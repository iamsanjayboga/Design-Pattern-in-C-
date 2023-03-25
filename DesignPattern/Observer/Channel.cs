using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer
{
    public class Channel : YoutubeChannel
    {
        private List<Subscriber> subsList = new List<Subscriber>();
        private string title;

        

        public void Subscribe(Subscriber subs)
        {
            subsList.Add(subs);
        }

        public void UnSubscribe(Subscriber subs)
        {            
            subsList.Remove(subs);
        }

        public void NotifySubscriber(string title)
        {
            foreach (Subscriber s in subsList)
            {
                s.Update(title);
            }
            
        }

        public void Upload(string title)
        {
            this.title = title;
            NotifySubscriber(title);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer
{
    public class Subscriber : YoutubeSubscribers
    {
        private string name;
        private Channel ch = new Channel();

        public Subscriber(string name)
        {
            this.name = name;
        }

        public void Update(string title)
        {
            Console.WriteLine(name + " Video name : " + title + " Uploaded...");
        }

        public void SubscribeChannel(Channel ch)
        {
            this.ch = ch;
        }
    }
}

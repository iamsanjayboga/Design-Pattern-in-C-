using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer
{
    public interface YoutubeChannel
    {
        
        void Subscribe(Subscriber subs);

        void UnSubscribe(Subscriber subs);

        void NotifySubscriber(string title);
    }
}

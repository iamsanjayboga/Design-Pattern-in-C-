using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer
{
    public interface YoutubeSubscribers
    {
        void Update(string title);

        void SubscribeChannel(Channel ch);
    }
}

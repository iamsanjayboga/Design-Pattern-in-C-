using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Observer
{
    public class Youtube
    {
        /*
         * 
         * The Observer design pattern defines a one-to-many dependency between objects 
         * so that when one object changes state, all its dependents are notified and updated automatically.
         * 
         * 
         * SUBJECT(Youtube.cs) ------------------------> INTERFACE OBSERVER(YoutubeChannel.cs & YoutubeSubsriber.cs)
         *    ^                                                 ^                         
         *    |                                                 |
         *    |                                                 |  
         *    |                                                 | 
         * Concrete SUBJECT() <----------------- Concrete Observer (Channel & Subscriber)
         * 
         */
        public static void Main(string[] args)
        {
            Channel beyond = new Channel();

            Subscriber s1 = new Subscriber("Sanjay");
            Subscriber s2 = new Subscriber("Urjitha");
            Subscriber s3 = new Subscriber("Sravan");

            s1.SubscribeChannel(beyond);
            s2.SubscribeChannel(beyond);
            s3.SubscribeChannel(beyond);

            beyond.Subscribe(s1);
            beyond.Subscribe(s2);
            beyond.Subscribe(s3);

            beyond.UnSubscribe(s1);


            beyond.Upload("How to learn programming");

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Proxy
{
    public class RealImage : IImage
    {
        string URL = string.Empty;
        public RealImage(string URL)
        {
            this.URL = URL;
            LoadImage(URL);
        }
        public void ShowImage()
        {
            Console.WriteLine("Displaying Real Image -- > " + this.URL);
        }

        public void LoadImage(string URL)
        {
            //Complex Logic to load image on client machine
            Console.WriteLine("Loading Image...");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Proxy
{
    public class ProxyImage : IImage
    {
        string URL = string.Empty;
        public ProxyImage(string URL)
        {
            this.URL = URL;
        }
        public void ShowImage()
        {
            RealImage real = new RealImage(URL);
            real.ShowImage();
        }
    }
}

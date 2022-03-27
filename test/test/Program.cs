using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://api.openweathermap.org/data/2.5/weather?q=London&unit=metric&appid=b5540070ac4ee230932c18ee8bfc7b27";

            HttpWebRequest httpReq = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpResp = (HttpWebResponse)httpReq.GetResponse();

            string response;

            using (StreamReader streamReader = new StreamReader(httpResp.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }
        }
    }
}
//https://www.youtube.com/watch?v=k91jTTdr0GM
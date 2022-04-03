using Newtonsoft.Json;
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
            Console.WriteLine("Enter town");
            string url = $"https://api.openweathermap.org/data/2.5/weather?q={Console.ReadLine()}&units=metric&appid=b5540070ac4ee230932c18ee8bfc7b27";

            HttpWebRequest httpReq = (HttpWebRequest)WebRequest.Create(url);
            HttpWebResponse httpResp = (HttpWebResponse)httpReq.GetResponse();

            string response;

            using (StreamReader streamReader = new StreamReader(httpResp.GetResponseStream()))
            {
                response = streamReader.ReadToEnd();
            }
            
            weatherInfo weatherInfo  = JsonConvert.DeserializeObject<weatherInfo>(response);
            Console.WriteLine($"Town {weatherInfo.name} temperature {weatherInfo.main.temp} wind speed {weatherInfo.wind.speed}");
            Console.ReadKey();
        }
    }
}
//https://www.youtube.com/watch?v=k91jTTdr0GM
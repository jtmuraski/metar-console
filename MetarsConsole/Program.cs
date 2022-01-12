using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace MetarsConsole
{
    class Program
    {
        private static readonly HttpClient client = new HttpClient();
        static async Task Main(string[] args)
        {
            client.DefaultRequestHeaders.Accept.Clear();
            string baseUrl = "https://www.aviationweather.gov/adds/dataserver_current/httpparam?dataSource=metars&requestType=retrieve&format=xml&stationString=KMSP&hoursBeforeNow=2";
            client.BaseAddress = new Uri(baseUrl);

            // Attempt to due a manual data parsing of the XML
            HttpResponseMessage message = client.GetAsync(baseUrl).Result;
            string xml = "";
            if (message.IsSuccessStatusCode)
                xml = message.Content.ReadAsStringAsync().Result;

            Response response;
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Response));
            using (StringReader reader = new StringReader(xml))
            {
                response = (Response)xmlSerializer.Deserialize(reader);
            }

            foreach(var metar in response.Data.METAR)
            {
                Console.WriteLine(metar.RawText);
            }
            Console.ReadLine();
        }
    }
}

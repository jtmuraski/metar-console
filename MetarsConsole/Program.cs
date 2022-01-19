using MetarsConsole.Contexts;
using MetarsConsole.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            // Setup the Http call
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

            // Parse the data from teh XML models into the DbContext models
            List<MetarsConsole.Models.Metar> MetarCollection = DataWork.ParseMetarToModel(response);
            foreach(var report in MetarCollection)
            {
                Console.WriteLine(report.RawText);
            }
            Console.ReadLine();

            // ---Database Update---
            // Update the database with teh new METARS data
            Console.WriteLine("Adding new data to the database now...");
            Console.WriteLine();

            var updateContext = new MetarContext();
            var currentContext = new MetarContext();
            foreach(var metar in MetarCollection)
            {
                var checkValue = currentContext.Metars.SingleOrDefault(record => record.RawText == metar.RawText);
                if (checkValue == null)
                    updateContext.Add(metar);
            }
            updateContext.SaveChanges();
            Console.WriteLine("Database updated");
            Console.ReadLine();
            
        }
    }
}

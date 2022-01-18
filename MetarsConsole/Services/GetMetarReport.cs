using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MetarsConsole.Services
{
    public class GetMetarReport
    {
        private HttpClient _httpClient = new HttpClient();
        public GetMetarReport()
        {
            _httpClient.BaseAddress = new Uri("https://www.aviationweather.gov/adds/dataserver_current/httpparam?dataSource=metars&requestType=retrieve&format=xml&stationString=KMSP&hoursBeforeNow=2");
        }
        
        static async Task GetMetar()
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MetarsConsole
{
    [XmlRoot("response")]
    [XmlType("METAR")]
    public class MetarReport
    {
        [XmlElement("raw_text")]
        public string rawText { get; set; }
        [XmlElement("station_id")]
        public string stationId { get; set; }
        [XmlElement("latitude")]
        public double latitiude { get; set; }
        [XmlElement("longitude")]
        public double longitude { get; set; }
        [XmlElement("temp_c")]
        public double tempCelsius { get; set; }
        [XmlElement("dewpoint_c")]
        public double dewpoint { get; set; }
        [XmlElement("wind_dir_degree")]
        public int windDirection { get; set; }
        [XmlElement("wind_speed_kt")]
        public double windspeed { get; set; }
        [XmlElement("visibility_statute_mi")]
        public double visbilityMiles { get; set; }
        [XmlElement("altim_in_hg")]
        public double altimeter { get; set; }
        //[XmlElement("sky_condition")]
        //public List<SkyCondition> skyConditions {get; set;}
        [XmlElement("flight_category")]
        public string flightCategory { get; set; }
        [XmlElement("metar_type")]
        public string metarType { get; set; }
        [XmlElement("elevation_m")]
        public double elevationMeters { get; set; }

    }
}

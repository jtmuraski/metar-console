using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MetarsConsole
{
    [XmlRoot(ElementName = "response")]
    public class Response
    {

        [XmlElement(ElementName = "request_index")]
        public int RequestIndex { get; set; }

        [XmlElement(ElementName = "data_source")]
        public DataSource DataSource { get; set; }

        [XmlElement(ElementName = "request")]
        public Request Request { get; set; }

        [XmlElement(ElementName = "errors")]
        public object Errors { get; set; }

        [XmlElement(ElementName = "warnings")]
        public object Warnings { get; set; }

        [XmlElement(ElementName = "time_taken_ms")]
        public int TimeTakenMs { get; set; }

        [XmlElement(ElementName = "data")]
        public Data Data { get; set; }

        [XmlAttribute(AttributeName = "xsd")]
        public string Xsd { get; set; }

        [XmlAttribute(AttributeName = "xsi")]
        public string Xsi { get; set; }

        [XmlAttribute(AttributeName = "version")]
        public string Version { get; set; }

        [XmlAttribute(AttributeName = "noNamespaceSchemaLocation")]
        public string NoNamespaceSchemaLocation { get; set; }

        [XmlText]
        public string Text { get; set; }
    }
    [XmlRoot(ElementName = "quality_control_flags")]
    public class QualityControlFlags
    {

        [XmlElement(ElementName = "auto_station")]
        public string AutoStation { get; set; }
    }

    [XmlRoot(ElementName = "sky_condition")]
    public class SkyCondition
    {

        [XmlAttribute(AttributeName = "sky_cover")]
        public string SkyCover { get; set; }

        [XmlAttribute(AttributeName = "cloud_base_ft_agl")]
        public int CloudBaseFtAgl { get; set; }
    }

    [XmlRoot(ElementName = "METAR")]
    public class METAR
    {

        [XmlElement(ElementName = "sky_condition")]
        public List<SkyCondition> SkyCondition { get; set; }

        [XmlElement(ElementName = "flight_category")]
        public string FlightCategory { get; set; }

        [XmlElement(ElementName = "three_hr_pressure_tendency_mb")]
        public double ThreeHrPressureTendencyMb { get; set; }

        [XmlElement(ElementName = "maxT_c")]
        public decimal MaxTC { get; set; }

        [XmlElement(ElementName = "minT_c")]
        public decimal MinTC { get; set; }

        [XmlElement(ElementName = "precip_in")]
        public double PrecipIn { get; set; }

        [XmlElement(ElementName = "pcp6hr_in")]
        public double Pcp6hrIn { get; set; }

        [XmlElement(ElementName = "metar_type")]
        public string MetarType { get; set; }

        [XmlElement(ElementName = "elevation_m")]
        public double ElevationM { get; set; }

        [XmlElement(ElementName = "raw_text")]
        public string RawText { get; set; }

        [XmlElement(ElementName = "station_id")]
        public string StationId { get; set; }

        [XmlElement(ElementName = "observation_time")]
        public DateTime ObservationTime { get; set; }

        [XmlElement(ElementName = "latitude")]
        public double Latitude { get; set; }

        [XmlElement(ElementName = "longitude")]
        public double Longitude { get; set; }

        [XmlElement(ElementName = "temp_c")]
        public double TempC { get; set; }

        [XmlElement(ElementName = "dewpoint_c")]
        public double DewpointC { get; set; }

        [XmlElement(ElementName = "wind_dir_degrees")]
        public int WindDirDegrees { get; set; }

        [XmlElement(ElementName = "wind_speed_kt")]
        public int WindSpeedKt { get; set; }

        [XmlElement(ElementName = "visibility_statute_mi")]
        public double VisibilityStatuteMi { get; set; }

        [XmlElement(ElementName = "altim_in_hg")]
        public double AltimInHg { get; set; }

        [XmlElement(ElementName = "sea_level_pressure_mb")]
        public decimal SeaLevelPressureMb { get; set; }

        [XmlElement(ElementName = "quality_control_flags")]
        public QualityControlFlags QualityControlFlags { get; set; }
    }

    [XmlRoot(ElementName = "data")]
    public class Data
    {

        [XmlElement(ElementName = "METAR")]
        public List<METAR> METAR { get; set; }

        [XmlAttribute(AttributeName = "num_results")]
        public int NumResults { get; set; }

        [XmlText]
        public string Text { get; set; }
    }

    [XmlRoot(ElementName = "data_source")]
    public class DataSource
    {

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }
    }

    [XmlRoot(ElementName = "request")]
    public class Request
    {

        [XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
    }
}

using MetarsConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetarsConsole.Services
{
    public static class DataWork
    {
        public static List<Metar> ParseMetarToModel(Response response)
        {
            List<Metar> MetarCollection = new List<Metar>();
            foreach(var data in response.Data.METAR)
            {
                List<MetarsConsole.Models.SkyCondition> skyConditions = new List<MetarsConsole.Models.SkyCondition>();
                foreach(var sky in data.SkyCondition)
                {
                    skyConditions.Add(new MetarsConsole.Models.SkyCondition()
                    {
                        CloudBaseFtAng = sky.CloudBaseFtAgl,
                        SkyCover = sky.SkyCover
                    });
                }
                List<MetarsConsole.Models.QualityControlFlags> qualityControl = new List<MetarsConsole.Models.QualityControlFlags>();
                foreach(var qual in data.QualityControlFlags)
                {
                    qualityControl.Add(new MetarsConsole.Models.QualityControlFlags()
                    {
                        AutoStation = qual.AutoStation
                    });
                }

                MetarCollection.Add(new Metar()
                {
                    RawText = data.RawText,
                    StationId = data.StationId,
                    ObservationTime = data.ObservationTime,
                    Latitude = data.Latitude,
                    Longtitude = data.Longitude,
                    TempC = data.TempC,
                    DewPointC = data.DewpointC,
                    WindDirDegree = data.WindDirDegrees,
                    WindSpeedKnots = data.WindSpeedKt,
                    VisibilityStatuteMi = data.VisibilityStatuteMi,
                    AltimeterInHg = data.AltimInHg,
                    SeaLevelPressureMb = data.SeaLevelPressureMb,
                    QualityControlFlag = qualityControl,
                    SkyConditions = skyConditions,
                    FlightCategory = data.FlightCategory,
                    ThreeHrPressureTEndencyMb = data.ThreeHrPressureTendencyMb,
                    MaxTC = data.MaxTC,
                    MinTC = data.MinTC,
                    PrecipIn = data.PrecipIn,
                    Pcp6hrIn = data.Pcp6hrIn,
                    MetarType = data.MetarType,
                    ElevationM = data.ElevationM
                });
            }

            return MetarCollection; 
        }
    }
}

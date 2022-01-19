using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetarsConsole.Models
{
    public class SkyCondition
    {
        public int Id { get; set; }
        public string SkyCover { get; set; }
        public int CloudBaseFtAng { get; set; }
    }
}

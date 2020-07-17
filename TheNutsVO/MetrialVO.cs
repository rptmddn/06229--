using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNutsVO
{
    public class MetrialVO
    {
        public string Metrial_ID { get; set; }
        public string Metrial_name { get; set; }
        public string Metrial_category { get; set; }
        public string Metrial_unit { get; set; }
        public string Metrial_Image { get; set; }
        public int? emergency_stock { get; set; }
        public int? safe_stock { get; set; }
    }
}

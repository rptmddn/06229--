using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheNutsVO;
using TheNutsDAC;

namespace The_Nuts.Service
{
    public class MerialService
    {
        public List<MetrialVO> GetMetrialinfo()
        {
            MetrialDAC dAC = new MetrialDAC();

             return dAC.GetMetrialinfo();
        }
    }
}

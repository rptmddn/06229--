using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheNutsVO;
using TheNutsDAC;
namespace The_Nuts.Service
{
    public class CommonService
    {
        public List<CommonVO> GetCodeInfo()
        {
            CommonDAC dac = new CommonDAC();
            return dac.GetCodeInfo();
        }
    }
}

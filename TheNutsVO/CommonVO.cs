using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNutsVO
{
   public class CommonVO
    {
        public string Code { get; set; }
        public string CodeType { get; set; }
        public string CodeNm { get; set; }

        public CommonVO() { }
        public CommonVO(string blankText)
        {
            Code = "";
            CodeNm = blankText;
        }
    }
}

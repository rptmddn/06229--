using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheNutsVO;
using System.Data;

namespace TheNutsDAC
{
  public  class CommonDAC : ConnectionAccess
    {
        public List<CommonVO> GetCodeInfo()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                DataTable dt = new DataTable();
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "select Code, CodeType, CodeNm from CommonCode";
                cmd.Connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                List<CommonVO> list = Helper.ConvertDataTableToList<CommonVO>(dt);
                cmd.Connection.Close();

                return list;
            }
        }
    }
}

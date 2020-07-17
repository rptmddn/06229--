using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheNutsVO;


namespace TheNutsDAC
{
    public class MetrialDAC : ConnectionAccess
    {
        public List<MetrialVO> GetMetrialinfo()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                DataTable dt = new DataTable();
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "select Metrial_ID, Metrial_name, Metrial_category, Metrial_unit, Metrial_Image, emergency_stock, safe_stock from Metrial";
                 cmd.Connection.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
               
                List<MetrialVO> list = Helper.ConvertDataTableToList<MetrialVO>(dt);
                cmd.Connection.Close();

                return list;
            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheNutsVO;

namespace TheNutsDAC
{
    public class BOMDAC : ConnectionAccess
    {
        public List<ComboItemVO> GetAllProduct()
        {
            try
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = new SqlConnection(this.ConnectionString);
                    cmd.CommandText = @"select Pro_Code as Code,Pro_Name as CodeNm, '제품' CodeType
                                                         from Product
                                                        union all
                                                        select Metrial_ID as Code,Metrial_name as CodeNm, '원재료' CodeType
                                                         from Metrial";



                    cmd.Connection.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    List<ComboItemVO> list = Helper.DataReaderMapToList<ComboItemVO>(reader);
                    cmd.Connection.Close();

                    return list;
                }
            }
            catch (Exception err)
            {
                throw err;
            }
        }
    }
}

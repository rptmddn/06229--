using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheNutsVO;

namespace TheNutsDAC
{
    public class ProductOrderDAC : ConnectionAccess
    {
        /// <summary>
        /// 특정 카테고리ID에 해당하는 제품목록 조회
        /// </summary>
        /// <param name="categoryID">카테고리ID</param>
        /// <returns>카테고리ID에 해당하는 제품목록 조회</returns>
        public bool RegisterProduct(ProductInfoVO pro)
        {
            int iRowAffect = 0;
            try
            {

                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = new SqlConnection(this.ConnectionString);
                    cmd.CommandText = "SP_ProductInsert";
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Pro_Name", pro.Pro_Name);
                    cmd.Parameters.AddWithValue("@Pro_Code", pro.Pro_Code);
                    cmd.Parameters.AddWithValue("@Pro_Price", pro.Pro_Price);
                    cmd.Parameters.AddWithValue("@Pro_Date", (object)pro.Pro_Date ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Pro_DateEnd", (object)pro.Pro_DateEnd ?? DBNull.Value);
                    cmd.Parameters.AddWithValue("@Pro_Count", pro.Pro_Count);
                    cmd.Parameters.AddWithValue("@Pro_Image", pro.Pro_Image);
                    cmd.Parameters.AddWithValue("@Pro_Note", pro.Pro_Note);

                    cmd.Connection.Open();
                    iRowAffect = cmd.ExecuteNonQuery();
                    cmd.Connection.Close();
               
                }
            }
            catch (SqlException e)
            {
                throw;
            }
            return iRowAffect > 0;
        }
        public List<ProductInfoVO> GetAllProData()
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "select Pro_Name,Pro_Code,Pro_Price,convert(varchar(10),Pro_Date,23)Pro_Date,convert(varchar(10),Pro_DateEnd,23)Pro_DateEnd,Pro_Count,null Pro_Image,Pro_Note from Product";


                cmd.Connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                List<ProductInfoVO> list = Helper.DataReaderMapToList<ProductInfoVO>(reader);
                cmd.Connection.Close();

                return list;
            }
        }

        public bool UpdateProduct(ProductInfoVO pro)
        {
            using (SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = new SqlConnection(this.ConnectionString);
                cmd.CommandText = "SP_ProductUpdate";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Pro_Name", pro.Pro_Name);
                cmd.Parameters.AddWithValue("@Pro_Code", pro.Pro_Code);
                cmd.Parameters.AddWithValue("@Pro_Price", pro.Pro_Price);
                cmd.Parameters.AddWithValue("@Pro_Date", (object)pro.Pro_Date ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Pro_DateEnd", (object)pro.Pro_DateEnd ?? DBNull.Value);
                cmd.Parameters.AddWithValue("@Pro_Count", pro.Pro_Count);
                cmd.Parameters.AddWithValue("@Pro_Image", pro.Pro_Image);
                cmd.Parameters.AddWithValue("@Pro_Note", pro.Pro_Note);


                cmd.Connection.Open();
                var rowsAffected = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return rowsAffected > 0;
            }
        }
        //public bool DeleteProduct(int employeeID)
        //{
        //    using (SqlCommand cmd = new SqlCommand())
        //    {
        //        cmd.Connection = new SqlConnection(this.ConnectionString);
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        cmd.CommandText = @"delete from Employees
        //                                WHERE EmployeeID = @P_EmployeeID";

        //        cmd.Parameters.AddWithValue("@P_EmployeeID", employeeID);

        //        cmd.Connection.Open();
        //        var rowsAffected = cmd.ExecuteNonQuery();
        //        cmd.Connection.Close();

        //        return rowsAffected > 0;
        //    }
        //}
    }
}

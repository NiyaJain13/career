using System.Data;
using System.Data.SqlClient;

namespace career.Models
{

    public class StudentDB
    {
        SqlConnection con = new SqlConnection(@"server=DESKTOP-IA0SOGT\SQLEXPRESS;database=CareerCounselling;Integrated security=true");
        public string InsertDB(Student objcls)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("sp_studentinsert", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@stname", objcls.name);
                cmd.Parameters.AddWithValue("@stemail", objcls.email);
                cmd.Parameters.AddWithValue("@stphone", objcls.phone);
                cmd.Parameters.AddWithValue("@stpassword", objcls.pass);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                return ("Inserted successfully");
            }
            catch (Exception ex)
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
                return ex.Message.ToString();
            }


        }
    }
 
}

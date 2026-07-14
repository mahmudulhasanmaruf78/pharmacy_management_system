using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace pharmacy_management_system
{


    internal class users
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HB9J2MTK;Initial Catalog=pharmacy_management_system;Integrated Security=True;");

        public int id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string role { get; set; }
        public string status { get; set; }
        public string dateRegister { get; set; }

        public List<users> Listusers()
        {
            List<users> listData = new List<users>();

            using (SqlConnection connection = new SqlConnection(con.ConnectionString))
            {
                connection.Open();

                string query = "SELECT * FROM users";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        users Data = new users();
                        Data.id = (int)reader["id"];
                        Data.Username = reader["username"].ToString();
                        Data.Password = reader["password"].ToString();
                        Data.role = reader["role"].ToString();
                        Data.status = reader["status"].ToString();
                        if (reader["dateRegister"] != null)
                        {
                            Data.dateRegister = ((DateTime)reader["dateRegister"]).ToString("dd-MM-yy");
                        }


                        listData.Add(Data);

                    }
                }
            }
            return listData;


        }

        public bool InsertUser(string username, string password, string role, string status, string dateRegister)
        {
            

            string insert_query = "insert into users values('" + username + "','" + password + "','" + role + "','" + status + "','" + dateRegister + "')";

            SqlCommand cmd = new SqlCommand(insert_query, con);

            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            int result = cmd.ExecuteNonQuery();
            return result > 0;
        }

        public DataTable AuthenticateUser(string username, string password)
        {
            string query = "SELECT * FROM users WHERE username COLLATE Latin1_General_CS_AS ='" + username + "' and password COLLATE Latin1_General_CS_AS ='" + password + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, con);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            return dt;
        }
    }
}
        

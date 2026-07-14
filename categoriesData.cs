using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace pharmacy_management_system
{
    internal class categoriesData
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HB9J2MTK;Initial Catalog=pharmacy_management_system;Integrated Security=True;");
        public int id { get; set; }
        public string category { get; set; }
        public string status { get; set; }
        public string insertDate { get; set; }

        public List<categoriesData> ListcategoriesData()
        {
            List<categoriesData> listData = new List<categoriesData>();
            using (SqlConnection connection = new SqlConnection(con.ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM categories";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        categoriesData Data = new categoriesData();
                        Data.id = (int)reader["id"];
                        Data.category = reader["category"].ToString();
                        Data.status = reader["status"].ToString();
                        if (reader["insertDate"] != null)
                        {
                            Data.insertDate = ((DateTime)reader["insertDate"]).ToString("dd-MM-yy");
                        }




                        listData.Add(Data);



                    }
                    return listData;
                }



            }


        }
    }
}

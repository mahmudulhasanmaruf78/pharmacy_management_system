using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace pharmacy_management_system
{
    internal class productData
    {

        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HB9J2MTK;Initial Catalog=pharmacy_management_system;Integrated Security=True;");

        public int id { get; set; }
        public string productID { get; set; }
        public string productname { get; set; }
        public int price { get; set; }
        public string stock { get; set; }
        public string catagory { get; set; }
        public string status { get; set; }
        public string image { get; set; }
        public string expaireDate { get; set; }

        public List<productData> ListproductData()
        {
            List<productData> listData = new List<productData>();
            using (SqlConnection connection = new SqlConnection(con.ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM products";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        productData Data = new productData();
                        Data.id = (int)reader["id"];
                        Data.productID = reader["productID"].ToString();
                        Data.productname = reader["productName"].ToString();
                        Data.price = (int)reader["price"];
                        Data.stock = reader["stock"].ToString();
                        Data.catagory = reader["catagory"].ToString();
                        Data.status = reader["status"].ToString();
                        Data.image = reader["image"].ToString();
                        if (reader["expaireDate"] != null)
                        {
                            Data.expaireDate = ((DateTime)reader["expaireDate"]).ToString("dd-MM-yy");
                        }
                        listData.Add(Data);
                    }
                    return listData;
                }






            }


        }










    }
}

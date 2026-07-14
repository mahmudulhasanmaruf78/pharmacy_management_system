using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace pharmacy_management_system
{
    internal class transectionData
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HB9J2MTK;Initial Catalog=pharmacy_management_system;Integrated Security=True;");
        public int id { get; set; }
        public int customerID { get; set; }
        public string productID { get; set; } 
        public float price { get; set; }
        public string status { get; set; }
        public string transactionDate { get; set; }
   
        
        public List<transectionData> Listtransection()
        {
            List<transectionData> listData = new List<transectionData>();
            using (SqlConnection connection = new SqlConnection(con.ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM transection";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        transectionData Data = new transectionData();
                        Data.id = (int)reader["id"];
                        Data.customerID = (int)reader["customerID"];
                        Data.productID = reader["productID"].ToString();
                        Data.price = (float)reader["price"];
                        Data.status = reader["status"].ToString();
                        Data.transactionDate = reader["transactionDate"].ToString();
                        listData.Add(Data);
                    }
                }
            }
            return listData;
        }
    }
}

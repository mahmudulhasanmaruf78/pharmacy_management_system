using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace pharmacy_management_system
{
    internal class ordersData
    {
        SqlConnection con = new SqlConnection(@"Data Source=LAPTOP-HB9J2MTK;Initial Catalog=pharmacy_management_system;Integrated Security=True;");

        public int id { get; set; }
        public int customerID { get; set; }
        public string productname { get; set; }
        public string productID { get; set; }
        public string catagory { get; set; }
        public int quantity { get; set; }
        public float price { get; set; }
        public float totalprice { get; set; }
        public string status { get; set; }
        public string orderdate { get; set; }
        public string stock { get; set; }
        public string billstutas { get; set; }

        public List<ordersData> ListOrders()
        {
            List<ordersData> listData = new List<ordersData>();
            using (SqlConnection connection = new SqlConnection(con.ConnectionString))
            {
                connection.Open();
                string query = "SELECT * FROM orders";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ordersData Data = new ordersData();
                        Data.id = (int)reader["id"];
                        Data.customerID = (int)reader["customerID"];
                        Data.productname = reader["productname"].ToString();
                        Data.productID = reader["productID"].ToString();
                        Data.catagory = reader["catagory"].ToString();
                        Data.quantity = (int)reader["quantity"];
                        Data.price = (float)reader["price"];
                        Data.totalprice = (float)reader["totalprice"];
                        Data.status = reader["status"].ToString();
                        Data.orderdate = reader["orderdate"].ToString();
                        Data.stock = reader["stock"].ToString();
                        Data.billstutas = reader["billstutas"].ToString();
                        listData.Add(Data);
                    }
                }
            }
            return listData;
        }

    }
}

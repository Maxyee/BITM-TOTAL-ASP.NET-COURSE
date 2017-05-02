using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using ExamTest.Models;

namespace ExamTest.DAL
{
    public class ProductGateway
    {
        private string connectionString = WebConfigurationManager.ConnectionStrings["ProductInfoConnectionString"].ConnectionString;

        public int Insert(Product pro)
        {
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "INSERT INTO Product(productCode,description,quantity)VALUES(@productCode,@description,@quantity)";
            SqlCommand command = new SqlCommand(query,connection);
            command.Parameters.Clear();
            command.Parameters.Add("productCode", SqlDbType.NVarChar);
            command.Parameters["productCode"].Value = pro.productCode;
            command.Parameters.Add("description", SqlDbType.NVarChar);
            command.Parameters["description"].Value = pro.description;
            command.Parameters.Add("quantity", SqlDbType.Int);
            command.Parameters["quantity"].Value = pro.quantity;
            connection.Open();
            int rowAffected = command.ExecuteNonQuery();
            connection.Close();
            return rowAffected;
        }

        public List<Product> GetAllProducts()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            //connection.ConnectionString = connectionString;
            //2. Qeury
            string query = "SELECT * FROM Product";
            connection.Open();

            //3. query execution
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Product> pruList = new List<Product>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Product pro = new Product();
                    pro.productCode = reader["productCode"].ToString();
                    pro.description = reader["description"].ToString();
                    pro.quantity = (int) reader["quantity"];

                    pruList.Add(pro);
                }
                reader.Close();
            }
            connection.Close();
            return pruList;
        }
    }
}
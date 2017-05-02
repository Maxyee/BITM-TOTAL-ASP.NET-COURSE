using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace InventoryManagementApp
{
    public partial class Index : System.Web.UI.Page
    {
        string connectionString = @"Server=PC-301-16\SQLEXPRESS;DataBase=inventory;Integrated Security=true;";
        
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSave_Click(object sender, EventArgs e)
        {
            //connection

            SqlConnection connection = new SqlConnection(connectionString);

            Product aProduct = new Product();
            aProduct.Code = txtCode.Text;
            aProduct.Name = txtName.Text;
            aProduct.Price = Convert.ToDouble(txtUnit.Text);
            aProduct.Quantity = Convert.ToInt32(txtQuantity.Text);


            //query
            string query = "INSERT INTO inventory3 (code,name,price,quantity)VALUES('" + aProduct.Code + "','" + aProduct.Name + "','"+aProduct.Price+"','"+aProduct.Quantity+"')";
            
            //execute
            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();

            bool isCodeExist = IsCodeIsExist(aProduct.Code);
            if (isCodeExist)
            {
                txtMeg.Text = "Save Successfully";
            }
            else
            {
                int rowAffected = command.ExecuteNonQuery();
                //result show
                if (rowAffected > 0)
                {
                    txtMeg.Text = "Save Successfully";
                }
                else
                {
                    txtMeg.Text = "Not Saved";
                }
            }
        }

        protected void btnShow_Click(object sender, EventArgs e)
        {
            List<Product> productList = new List<Product>();
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM inventory3";

            SqlCommand command = new SqlCommand(query, connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Product product = new Product();
                    product.Code = reader["code"].ToString();
                    product.Name = reader["name"].ToString();
                    product.Price = Convert.ToDouble(reader["price"]);
                    product.Quantity = Convert.ToInt32(reader["quantity"]);
                    
                    productList.Add(product);
                }
                reader.Close();
            }
            connection.Close();
            productView.DataSource = productList;
            productView.DataBind();
        }


        private Product GetProductByCode(string code)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            string query = "SELECT * FROM inventory3 where code='" + code + "'";
            SqlCommand command = new SqlCommand(query,connection);
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            
            Product product = new Product();
            if (reader.HasRows)
            {
                reader.Read();
                product.Code = reader["code"].ToString();
                product.Name = reader["name"].ToString();
                product.Price = Convert.ToDouble(reader["price"]);
                product.Quantity = Convert.ToInt32(reader["quantity"]);   
            }
            reader.Close();
            connection.Close();
            return product;
        }

        private bool IsCodeIsExist(string code)
        {
            bool isCodeExist = false;
            Product aProduct =GetProductByCode(code);
            if (aProduct != null)
            {
                isCodeExist = true;
            }
            return isCodeExist;
        }
    }
}
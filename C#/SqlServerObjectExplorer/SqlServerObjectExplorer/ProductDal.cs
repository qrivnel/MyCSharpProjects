using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlServerObjectExplorer
{
    public class ProductDal
    {
        static SqlConnection _connection = new SqlConnection(@"server=(localdb)\mssqllocaldb; initial catalog = ETrade; integrated security = true");

        public List<Product> GetAll()
        {
            ConnectionOpen();

            SqlCommand command = new SqlCommand("Select * from Products", _connection);
            SqlDataReader reader = command.ExecuteReader();

            List<Product> products = new List<Product>();

            
            while (reader.Read())
            {
                Product product = new Product()
                {
                    Id = Convert.ToInt32(reader["ID"]),
                    Name = Convert.ToString(reader["Name"]),
                    UnitPrice = Convert.ToDecimal(reader["UnitPrice"]),
                    StockAmount = Convert.ToInt32(reader["StockAmount"])
                };
                Console.WriteLine(Convert.ToInt32(Convert.ToString(reader.GetSqlValue(0))));
                products.Add(product);
            }

            

            reader.Close();
            _connection.Close();

            return products;
        }

        public static void ConnectionOpen()
        {
            if (_connection.State == ConnectionState.Closed)
                _connection.Open();
        }

        public DataTable GetAll2()
        {
            if (_connection.State == ConnectionState.Closed)
                _connection.Open();

            SqlCommand command = new SqlCommand("Select * from Products", _connection);
            SqlDataReader reader = command.ExecuteReader();

            DataTable dataTable = new DataTable();
            dataTable.Load(reader);

            reader.Close();
            _connection.Close();

            return dataTable;
        }

        
        public void AddProduct(Product product)
        {
            ConnectionOpen();
            SqlCommand command = new SqlCommand("insert into products values(@name, @unitprice,  @stockamount)",_connection);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitprice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockamount", product.StockAmount);
            command.ExecuteNonQuery();

            _connection.Close();

        }

        public void UpdateProduct(Product product)
        {
            ConnectionOpen();
            SqlCommand command = new SqlCommand("update products set name=@name, unitprice=@unitprice, stockamount=@stockamount where id=@id", _connection);
            command.Parameters.AddWithValue("@id", product.Id);
            command.Parameters.AddWithValue("@name", product.Name);
            command.Parameters.AddWithValue("@unitprice", product.UnitPrice);
            command.Parameters.AddWithValue("@stockamount", product.StockAmount);
            command.ExecuteNonQuery();

            _connection.Close();

        }
        public void DeleteProduct(int id)
        {
            ConnectionOpen();
            SqlCommand command = new SqlCommand("delete from products where id=@id", _connection);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();

            _connection.Close();
        }

    }
}

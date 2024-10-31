using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_DatabaseCrud
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("***Menü Sipariş İşlem Paneli****");
            Console.WriteLine();
            Console.WriteLine("---------------------------");

            #region Kategori ekleme işlemi

            //Console.Write("Eklemek istediğiniz kategori adı: ");
            //string categoryName=Console.ReadLine();

            //SqlConnection connection = new
            //    SqlConnection("Data Source=DESKTOP-I6R5PF8\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");

            //connection.Open();
            //SqlCommand command= new SqlCommand("insert into TblCategory (CategoryName) values (@p1)", connection);
            //command.Parameters.AddWithValue("@p1", categoryName);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Kategori başarı ile eklendi");

            #endregion

            #region Ürün ekleme işlemi

            //string productName;
            //decimal productPrice;

            //Console.Write("Ürün adı: ");
            //productName = Console.ReadLine();
            //Console.Write("Ürün fiyatı: ");
            //productPrice=decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new SqlConnection("Data Source=DESKTOP-I6R5PF8\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("insert into TblProduct  (ProductName,ProductPrice,ProductStatus) " +
            //    "values (@productName,@productPrice,@productStatus)", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productStatus", true);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.Write("Ürün eklemesi başarılı");

            #endregion

            #region Ürün listeleme işlemi

            //SqlConnection connection = new
            //   SqlConnection("Data Source=DESKTOP-I6R5PF8\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Select * From TblProduct", connection);
            //SqlDataAdapter adapter = new SqlDataAdapter(command);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);

            //foreach (DataRow row in dataTable.Rows) 
            //{
            //  foreach (var item in row.ItemArray) 
            //    {
            //      Console.WriteLine(item.ToString() + " ");
            //    }
            //  Console.WriteLine();
            //}

            #endregion

            #region Ürün silme işlemi

            //Console.Write("Ürün silinecek id: ");
            //int productId=int.Parse(Console.ReadLine());

            //SqlConnection connection = new
            //    SqlConnection("Data Source=DESKTOP-I6R5PF8\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Delete From TblProduct Where ProductId=@productId", connection);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
            //connection.Close();

            //Console.WriteLine("Silme işlemi yapıldı");

            #endregion

            #region Ürün güncelleme işlemi

            //Console.Write("Güncellenecek ürün id: ");
            //int productId=int.Parse(Console.ReadLine());

            //Console.Write("Güncellenecek ürün adı: ");
            //string productName = Console.ReadLine();

            //Console.Write("Güncellenecek ürün fiyatı: ");
            //decimal productPrice=decimal.Parse(Console.ReadLine());

            //SqlConnection connection = new
            //    SqlConnection("Data Source=DESKTOP-I6R5PF8\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            //connection.Open();
            //SqlCommand command = new SqlCommand("Update TblProduct Set ProductName=@productName,ProductPrice=@productPrice" +
            //    " where ProductId=@productId ", connection);
            //command.Parameters.AddWithValue("@productName", productName);
            //command.Parameters.AddWithValue("@productPrice", productPrice);
            //command.Parameters.AddWithValue("@productId", productId);
            //command.ExecuteNonQuery();
             
            //connection.Close();
            //Console.WriteLine("Güncelleme başarılı");

            #endregion

            Console.Read();
        }
    }
}

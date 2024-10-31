using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ado.net

            Console.WriteLine("****C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi****");
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("---------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("2-Ürünler");
            Console.WriteLine("3-Siparişler");
            Console.WriteLine("4-Çıkış Yap");
            Console.WriteLine("Lütfen getirmek istediğiniz tablo numarasını giriniz: ");
            Console.WriteLine("---------------------");

            SqlConnection connection=new 
                SqlConnection("Data Source=DESKTOP-I6R5PF8\\SQLEXPRESS;initial Catalog=EgitimKampiDb;integrated security=true");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * From TblCategory ", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connection.Close();

            foreach (DataRow Row in dt.Rows) 
            { 
               foreach (var item in Row.ItemArray) 
                { 
                Console.Write(item.ToString());
                }
               Console.WriteLine();
            }


            Console.Read();
        }
    }
}

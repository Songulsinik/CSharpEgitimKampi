using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            //double number;
            //number = 4.85;

            //Console.WriteLine(number);

            //Console.Read();


            //Console.WriteLine("****Fiyat Listesi****");
            //Console.WriteLine();

            //double orangePrice, applePrice, strawberryPrice, potatoPrice, tomatoPrice;

            //orangePrice = 5.50;
            //applePrice = 8.65;
            //strawberryPrice = 45;
            //potatoPrice = 10.56;
            //tomatoPrice = 24.67;


            //Console.WriteLine("---Portakal Birim Fiyatı:" + orangePrice + "TL");
            //Console.WriteLine("---Elma Birim Fiyatı:" + applePrice + "TL");
            //Console.WriteLine("---Çilek Birim Fiyatı:" + strawberryPrice + "TL");
            //Console.WriteLine("---Patates Birim Fiyatı:" + potatoPrice + "TL");
            //Console.WriteLine("---Domates Birim Fiyatı:" + tomatoPrice + "TL");

            //Console.WriteLine();
            //Console.WriteLine();

            //double orangeGram, appleGram, strawberryGram, potatoGram, tomatoGram;

            //orangeGram = 2.650;
            //appleGram = 1.245;          
            //strawberryGram = 0.750;
            //potatoGram = 4.859;
            //tomatoGram = 3.745;

            //double orangeTotalPrice = orangeGram * orangePrice;
            //double appleTotalPrice = appleGram * applePrice;
            //double strawberryTotalPrice = strawberryGram * strawberryPrice;
            //double potatoTotalPrice = potatoGram * potatoPrice;
            //double tomatoTotalPrice = tomatoGram * tomatoPrice;

            //Console.WriteLine("Alınan Ürün: Portakal-" + "Birim Fiyat: " + orangePrice + "-Gramaj: " + orangeGram + "-Toplam Tutar: " + orangeTotalPrice);
            //Console.WriteLine("Alınan Ürün: Elma-" + "Birim Fiyat: " + applePrice + "-Gramaj: " + appleGram + "-Toplam Tutar: " + appleTotalPrice);
            //Console.WriteLine("Alınan Ürün: Çilek-" + "Birim Fiyat: " + strawberryPrice + "-Gramaj: " + strawberryGram + "-Toplam Tutar: " + strawberryTotalPrice);
            //Console.WriteLine("Alınan Ürün: Patates-" + "Birim Fiyat: " + potatoPrice + "-Gramaj: " + potatoGram + "-Toplam Tutar: " + potatoTotalPrice);
            //Console.WriteLine("Alınan Ürün: Domates-" + "Birim Fiyat: " + tomatoPrice + "-Gramaj: " + tomatoGram + "-Toplam Tutar: " + tomatoTotalPrice);

            //double shoppingTotalPrice = orangeTotalPrice + appleTotalPrice + strawberryTotalPrice + potatoTotalPrice + tomatoTotalPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alışveriş Toplam Tutar:" + shoppingTotalPrice + "TL");


            #endregion

            #region Char Değişkenler

            //char symbol;
            //symbol = 'a';
            //Console.WriteLine(symbol);

            #endregion

            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("****CSharp Hava Yolları Yolcu Bilgileri****");
            //Console.WriteLine();

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();

            //Console.Write("Yolcu Soyadı: ");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi: ");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yolcu Yaş: ");
            //passengerAge = Console.ReadLine();


            //Console.Write("Yolcu TC Kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();

            //Console.WriteLine("--------------");

            //Console.WriteLine("Yolcu TC Kimlik No: " + passengerIdentityNumber +"-Yolcu Ad Soyad:" + 
            //    passengerName +" "+ passengerSurname + " " + passengerDistrict + "/" + passengerCity + " " + passengerAge);

            //Console.Read();

            #endregion

            #region Klavyeden Tam Sayı Girişleri ve Dönüşümler

            //int shoesPrice, computerPrice, chairPrice, tvPrice;

            //shoesPrice = 1000;
            //computerPrice = 20000;
            //chairPrice = 8000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvCount;

            //Console.Write("Lütfen Aldığınız Ayakkabı Sayısını Giriniz:");
            //shoesCount= int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Bilgisayar Sayısını Giriniz:");
            //computerCount= int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız Sandalye Sayısını Giriniz:");
            //chairCount= int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Aldığınız TV Sayısını Giriniz:");
            //tvCount= int.Parse(Console.ReadLine());

            //int totalPrice = shoesCount *shoesPrice + computerCount * computerPrice + chairCount * chairPrice  + tvCount * tvPrice ;

            //Console.WriteLine();

            //Console.WriteLine("Toplam Ödemeniz Gereken Tutar: " + totalPrice);

            //Console.Read();


            #endregion

            #region  Klavyeden Ondalıklı Sayı İşlemleri

            //double exam1, exam2, exam3, result;

            //Console.Write("Lütfen 1.Sınav Notunu Giriniz:");
            //exam1=double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2.Sınav Notunu Giriniz:");
            //exam2 = double.Parse(Console.ReadLine());

            //Console.Write("Lütfen 3.Sınav Notunu Giriniz:");
            //exam3 = double.Parse(Console.ReadLine());

            //result= (exam1 + exam2 + exam3) / 3;

            //Console.WriteLine();
            //Console.WriteLine("Sınav Ortalamanız: " + result);

            //Console.Read();
            #endregion

            #region Klavyeden Karakter Girişleri

            //char gender;
            //Console.Write("lütfen Cinsiyet Giriniz:");
            //gender=char.Parse(Console.ReadLine());
            //Console.WriteLine("Seçtiğiniz Cinsiyet: " + gender);

            //Console.Read();
            #endregion
        }
    }
}

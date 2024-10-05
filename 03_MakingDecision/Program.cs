using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region IF ELSE
            //Console.Write("Lütfen Şifre Giriniz:");
            //string password;
            //password = Console.ReadLine();
            //if(password == "abcd") 
            //{
            //    Console.WriteLine("Şifre Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}

            //string capital, country;
            //Console.Write("Başkenti Görünüz: ");
            //capital = Console.ReadLine();

            //Console.Write("Ülkeyi Giriniz: ");
            //country = Console.ReadLine();

            //if(capital == "izmir" & country == "türkiye")
            //{
            //    Console.Write("Veriler Doğrulandı.");
            //}
            //else
            //{
            //    Console.Write("Hatalı Bilgi");
            //}

            //int number;
            //Console.Write("Sayı Giriniz: ");
            //number= int.Parse(Console.ReadLine());
            //if(number == 8 )
            //{
            //    Console.WriteLine("Sayı Doğru");
            //}
            //else
            //{
            //    Console.WriteLine("Sayı Hatalı");
            //}

            //int exam1, exam2, exam3, average;
            //string result ="Hata!";

            //Console.Write("Sınav1: ");
            //exam1=int.Parse(Console.ReadLine());
            //Console.Write("Sınav2: ");
            //exam2 =int.Parse(Console.ReadLine());
            //Console.Write("Sınav3: ");
            //exam3 =int.Parse(Console.ReadLine());

            //average= (exam1+ exam2 + exam3)/ 3;
            //Console.WriteLine("Sınavların ortalaması: " + average);
            //if(average > 0 & average<=50)
            //{
            //    result = "Sonuç Vasat";
            //}
            //if(average>50 & average <= 70)
            //{
            //    result = "Sonuç Orta";
            //}
            //if(average>70 & average<=84)
            //{
            //    result = "Sonuç İyi";
            //}
            //if(average>84 & average<=100)
            //{
            //    result = "Sonuç Çok İyi";
            //}

            //Console.WriteLine(result); 

            //string city;
            //Console.Write("Lütfen Şehir Girişi Yapınız: ");
            //city = Console.ReadLine();

            //if(city=="İzmir" | city=="Adana" | city=="İstanbul" | city=="Muğla")
            //{
            //    Console.WriteLine("Şehir Mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("Şehir Mevcut Değil");
            //}

            //Console.Write("Lütfen Kullanıcı Adı Giriniz: ");
            //string username=Console.ReadLine();
            //if(username!="Admin")
            //{
            //    Console.Write("Bu Kullanıcı Adı Kabul Edilemez.");
            //}
            //else
            //{
            //    Console.Write("Hoş Geldiniz");
            //}

            //Console.Read();
            #endregion

            #region MOD İŞLEMLERİ

            //int number;
            //number = 26;
            //int result = number % 5;
            //Console.WriteLine(result);

            //Console.Write("Lütfen 1. Sayıyı Giriniz:");
            //int number1=int.Parse(Console.ReadLine());

            //Console.Write("Lütfen 2. Sayıyı Giriniz:");
            //int number2 = int.Parse(Console.ReadLine());

            // int result=number1 % number2;
            //Console.Write("1. sayını 2. sayıya bölümünden kalan: " +  result);

            //Console.Write("Lütfen Bir Sayı Giriniz: ");
            //int number=int.Parse(Console.ReadLine());
            //if(number % 2 == 0) 
            //{
            //    Console.Write("Sayı çifttir");
            //}
            //else
            //{
            //    Console.Write("Sayı Tektir");
            //}

            //char team;
            //Console.Write("Lütfen Takım Sembolünü Giriniz: ");
            //team=char.Parse(Console.ReadLine());

            //if(team =='g' | team=='G')
            //{
            //    Console.Write("GALATASARAY");
            //}

            //if (team == 'f' | team == 'F')
            //{
            //    Console.Write("FENERBAHÇE");
            //}

            //if (team == 'b' | team == 'B')
            //{
            //    Console.Write("BEŞİKTAŞ");
            //}
            #endregion

            #region ÖRNEK PROJE UYGULAMASI

            //Console.WriteLine("*****C# EĞİTİM KAMPI RESTAURANT*****");
            //Console.WriteLine();
            //Console.WriteLine("--------------------");
            //Console.WriteLine("1-Ana Yemekler");
            //Console.WriteLine("2-Çorbalar");
            //Console.WriteLine("3-Pizzalar");
            //Console.WriteLine("4-İçecekler");
            //Console.WriteLine("5-Tatlılar");
            //Console.WriteLine("--------------------");
            //Console.WriteLine();

            //string menuItem;

            //Console.Write("Detayını Görmek İstediğiniz Menü  Seçimi: ");
            //menuItem = Console.ReadLine();

            //if(menuItem=="1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Ana Yemekler----------");
            //    Console.WriteLine("1-Döner");
            //    Console.WriteLine("2-Köri Soslu Tavuk");
            //    Console.WriteLine("3-Fırında Somon");
            //    Console.WriteLine("4-Patlıcan Musakka");
            //    Console.WriteLine("5-Fasulye Pilav");
            //    Console.WriteLine("----------Ana Yemekler----------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Çorbalar----------");
            //    Console.WriteLine("1-Mercimek Çorbası");
            //    Console.WriteLine("2-Ezo Gelin Çorba");
            //    Console.WriteLine("3-Tarhana");
            //    Console.WriteLine("4-Paça");
            //    Console.WriteLine("5-Sebze Çorbası");
            //    Console.WriteLine("----------Çorbalar----------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Pizzalar----------");             
            //    Console.WriteLine("1-Vegan Pizza");
            //    Console.WriteLine("2-Mantarlı Pizza");
            //    Console.WriteLine("3-Ispanaklı Pizza");
            //    Console.WriteLine("4-Karışık Pizza");
            //    Console.WriteLine("5-Zeytinli Pizza");
            //    Console.WriteLine("----------Pizzalar----------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------İçecekler----------");
            //    Console.WriteLine("1-Su");
            //    Console.WriteLine("2-Ayran");
            //    Console.WriteLine("3-Şalgam");
            //    Console.WriteLine("----------İçecekler----------");
            //    Console.WriteLine();
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("----------Tatlılar----------");
            //    Console.WriteLine("1-Cheescake");
            //    Console.WriteLine("2-Tiramisu");
            //    Console.WriteLine("3-Tiriliçe");
            //    Console.WriteLine("4-Sütlaç");
            //    Console.WriteLine("5-Muhallebi");
            //    Console.WriteLine("----------Tatlılar----------");
            //    Console.WriteLine();
            //}

            //Console.Read();
            #endregion

            #region SWITCH CASE

            //Console.Write("lütfen Ay Girişi Yapın: ");
            //int montNumber=int.Parse(Console.ReadLine());

            //switch (montNumber) 
            //{
            //    case 1: Console.Write("Ocak"); break;
            //    case 2: Console.Write("Şubat"); break;
            //    case 3: Console.Write("Mart"); break;
            //    case 4: Console.Write("Nisan"); break;
            //    case 5: Console.Write("Mayıs"); break;
            //    case 6: Console.Write("Haziran"); break;
            //    case 7: Console.Write("Temmuz"); break;
            //    case 8: Console.Write("Ağustos"); break;
            //    case 9: Console.Write("Eylül"); break;
            //    case 10: Console.Write("Ekim"); break;
            //    case 11: Console.Write("Kasım"); break;
            //    case 12: Console.Write("Aralık"); break;
            //    default: Console.Write("Hatalı Veri Girişi"); break;
            //}

            //Console.Read();
            #endregion

            #region SWİTCH CASE HESAP MAKİNESİ

            //int number1, number2, result;
            //char symbol;

            //Console.Write("1. Sayıyı Griniz: ");
            //number1=int.Parse(Console.ReadLine());

            //Console.Write("2. Sayıyı Griniz: ");
            //number2 =int.Parse(Console.ReadLine());

            //Console.Write("Lütfen Yapmak İstediğiniz İşlemi Griniz: ");
            //symbol=char.Parse(Console.ReadLine());

            //switch (symbol) 
            //{
            //    case '+':
            //        result=number1 + number2; 
            //        Console.WriteLine("Toplam: " + result);
            //        break;

            //    case '-':
            //        result = number1 - number2;
            //        Console.WriteLine("Fark: " + result);
            //        break;

            //    case '/':
            //        result = number1 / number2;
            //        Console.WriteLine("Bölüm: " + result);
            //        break;

            //    case '*':
            //        result = number1 *+ number2;
            //        Console.WriteLine("Çarpım: " + result);
            //        break;
            //}
            //Console.Read();
            #endregion

        }
    }
}

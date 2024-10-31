﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Metotlar
            //void CustomerList()
            //{
            //    Console.WriteLine("Songül Şinik");
            //    Console.WriteLine("Songül Şinik");
            //    Console.WriteLine("Songül Şinik");
            //    Console.WriteLine("Songül Şinik");
            //}
            //CustomerList();
            //CustomerList();
            //CustomerList();
            //CustomerList();

            //void sum()
            //{
            //    int x =1; 
            //    int y = 2;
            //    int z = x + y;
            //    Console.WriteLine(z);
            //}
            //sum();

            #endregion

            #region Geriye Değer Döndürmeyen String Parametreli Metotlar

            //void WriteMethod(string customerName)
            //{
            //    Console.WriteLine(customerName);
            //}

            //WriteMethod("Songül Şinik");

            //void customerCard(string name, string surName)
            //{
            //    Console.WriteLine("Müşteri: " +  name + " " +  surName);
            //}

            //customerCard("Songül", "Şinik");
            //customerCard("Songül", "Şinik");


            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar

            //void sum(int number1, int number2, int number3)
            //{ 
            //int result=number1+number2+number3;
            //    Console.WriteLine(result);
            //}
            //sum(6, 10, 14);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string CustomerName()
            //{
            //    return "Songül Şinik";
            //}
            //CustomerName();

            //string StudentCard()
            //{
            //    string name = "Songül";
            //    string surname = "Şinik";

            //    return name + " " + surname;

            //}
            //Console.WriteLine(StudentCard());

            #endregion

            #region Geriye Değer  Döndüren String Parametreli Metotlar

            //string CountryCard(string countryName, string capital, string flagColor)
            //{
            //    string cardInfo = "Ülke: " + countryName + "- Başkent: " + capital + "- Bayrak Rengi: " + flagColor;
            //    return cardInfo;
            //}
            //string x, y, z;

            //Console.Write("Ülke adını giriniz:");
            //x= Console.ReadLine();

            //Console.Write("Başkenti giriniz:");
            //y = Console.ReadLine();

            //Console.Write("Bayrak Rengini giriniz:");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x,y,z));
            //Console.WriteLine(CountryCard("Türkiye","Ankara","Kırmızı-Beyaz"));

            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar

            //int Sum(int number1, int number2) 
            //{
            //int result=number1 + number2;
            //    return result;
            //}

            //Console.WriteLine(Sum(44, 57));
            //Console.WriteLine(Sum(90, 60));
            //Console.WriteLine(Sum(47, 23));
            //Console.WriteLine(Sum(845, 12));

            #endregion

            #region Örnek Uygulama

            string ExamResult(string student, int exam1, int exam2, int exam3)
            {
              int result=(exam1 + exam1 + exam2) / 3;
                if(result>=50)
                {
                    return student + " isimli öğrenci sınavı geçti" + " Ortalama: " + result;
                }
                else
                {
                    return student + "isimli öğrenci sınavı geçemedi" + "Ortalama: " + result;
                }
            }
            Console.WriteLine(ExamResult("Songül", 90, 98, 100));

            #endregion

            Console.Read();
        }
    }
}

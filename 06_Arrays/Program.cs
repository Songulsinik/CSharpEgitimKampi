using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Temel Dizi Örnekleri
            //string[] colors = new string[4];
            //colors[0] = "Beyaz";
            //colors[1] = "Siyah";
            //colors[2] = "Sarı";
            //colors[3] = "Kırmızı";

            //Console.WriteLine(colors[2]);

            //string[] cities = new string[5];
            //cities[0] = "İzmir";
            //cities[1] = "İstanbul";
            //cities[2] = "Muğla";
            //cities[3] = "Diyarbakır";
            //cities[4] = "Adana";

            //Console.WriteLine(cities[0]);

            //int[] numbers=new int[10];
            //numbers[0] = 143;
            //numbers[1] = 222;
            //numbers[2] = 33;
            //numbers[3] = 42;
            //numbers[7] = 675;

            //Console.WriteLine(numbers[7]);

            //string[] cities = { "İzmir", "İstanbul", "Muğla", "Diyarbakır", "Adana" };
            //Console.WriteLine(cities[4]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "Beyaz", "Siyah", "Pembe", "Sarı", "Kırmızı", "Mor", "Turuncu" };
            //for(int i = 0; i < colors.Length; i++) 
            //{
            //    Console.WriteLine(colors[i]);
            //}

            //int[] numbers = { 45, 890, 2354, 56, 4, 5, 90, 820, 1236, 900 };
            //for (int i = 0; i < numbers.Length; i++) 
            //{
            //    if (numbers[i]%3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            //char[] symbols = { 'a', 'b', 'c', '%','-' };
            //for(int i = 0; i < symbols.Length; i++) 
            //{
            //    Console.WriteLine(symbols[i]);
            //}

            //int[] myArray = { 55, 60, 70, 698, 12,897,1296,5,10 };
            //int maxNumber = myArray[0];
            //for(int i=0; i<myArray.Length; i++)
            //{
            //    if (myArray[i] > maxNumber)
            //    {
            //        maxNumber = myArray[i];
            //    }
            //}
            //Console.WriteLine(maxNumber);

            //string[] person = { "songül", "enes", "ada lina", "mori" };
            //Console.WriteLine(person.Length);

            //int[] numbers = { 56, 2, 890, 42, 550, 24 };
            //Array.Sort(numbers);
            //for(int i = 0; i < numbers.Length; i++) 
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            //int[] numbers = { 56, 2, 890, 42, 550, 24 };
            //Array.Reverse(numbers);
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.WriteLine(numbers[i]);
            //}
            #endregion

            #region Dizi Metotlar

            //string[] customers = { "enes", "suat", "serhat", "songül", "sibel", "ada lina" };
            //int index = Array.IndexOf(customers, "enes");
            //Console.WriteLine(index);

            //int[] numbers = { 23, 34, 45, 78, 90, 2 };
            //Console.WriteLine("Dizinin en büyük elemanı: " + numbers.Max() + "Dizinin en küçük elemanı: " + numbers.Min());

            #endregion

            #region Kullanıcıdan Değer Alma
            //string[] cities = new string[5];
            //for(int i = 0; i < cities.Length; i++) 
            //{
            //    Console.Write($"Lütfen{i+1}. şehri giriniz: ");
            //    cities[i] = Console.ReadLine();
            //}
            //Console.WriteLine();
            //Console.WriteLine("---------------------------");
            //for(int i = 0;i < cities.Length;i++) 
            //{
            //    Console.WriteLine(cities[i]);
            //}

            //int[] numbers = {10, 20, 30,40,50};
            //int sum = 0;
            //for(int i = 0; i < numbers.Length; i++) 
            //{
            //sum+= numbers[i];
            //}
            //Console.WriteLine(sum);

            //int[] numbers = { 45, 893, 2354, 56, 7, 5, 90, 820, 1236, 900,15,999 };
            //Console.WriteLine("Çift Sayılar");

            //for(int i = 0; i < numbers.Length; i++) 
            //{
            //    if (numbers[i]%2 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}
            //Console.WriteLine();
            //Console.WriteLine("Tek Sayılar");
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 1)
            //    {
            //        Console.WriteLine(numbers[i]);
            //    }
            //}

            #endregion
            Console.Read();
        }
    }
}

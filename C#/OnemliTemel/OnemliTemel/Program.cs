using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OnemliTemel
{
    internal class Program
    {
        enum Days
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }
        static void Main(string[] args)
        {
            Student erhan = new Student("21181617010", "Erhan", "Karataş", "Gazi University");
            erhan.showStudentInformation();
            erhan.bringUniversity();
            Console.WriteLine(erhan.CalculateTermAverage(50, 60, 100));
            ArrayList array = new ArrayList();
            array.Add(12);
            array.Add("erhan");
            Console.WriteLine(array[0]);
            Console.WriteLine(array[1]);
            array.RemoveAt(0);
            if (array.Contains(12))
                Console.WriteLine("There is!");
            else
                Console.WriteLine("There is not!");

            Console.WriteLine(array[0]);

            string isim = "erhan";
            //if (Days.erhan.ToString() == isim)
            //{
            //    Console.WriteLine("Equals");
            //}        


            var value = 12;
            value = 'X';
            Console.WriteLine(value.ToString() + " " + value.GetType());

            Console.WriteLine(value == 88 ? "Value is 88" : "Value isn't 88");

            int number1 = 20;
            int number2 = 100;
            Console.WriteLine($"{number1} {number2}");

            Console.WriteLine(Add(ref number1, number2));

            Console.WriteLine($"{number1} {number2}");

            //Property
            Console.WriteLine(erhan.Ttry);
            erhan.Ttry = "try2";
            Console.WriteLine(erhan.Ttry);

            //SOLID
            //Single Responsibility   ÖZET: Bir sınıf (nesne) yalnızca bir amaç uğruna değiştirilebilir,
            //                              o da o sınıfa yüklenen sorumluluktur, yani bir sınıfın(fonksiyona da indirgenebilir)
            //                              yapması gereken yalnızca bir işi olması gerekir.
            //
            //Open Closed             ÖZET: Bir sınıf ya da fonksiyon halihazırda var olan özellikleri korumalı ve değişikliğe izin
            //                              vermemelidir. Yani davranışını değiştirmiyor olmalı ve yeni özellikler kazanabiliyor olmalıdır.
            //
            //Liskov Substitution     ÖZET: Kodlarımızda herhangi bir değişiklik yapmaya gerek duymadan alt sınıfları, türedikleri(üst)
            //                              sınıfların yerine kullanabilmeliyiz.
            //
            //Interface Segregation   ÖZET: Sorumlulukların hepsini tek bir arayüze toplamak yerine daha özelleştirilmiş birden fazla
            //                              arayüz oluşturmalıyız.
            //
            //Dependency Inversion    ÖZET: Sınıflar arası bağımlılıklar olabildiğince az olmalıdır özellikle üst seviye sınıflar alt
            //                              seviye sınıflara bağımlı olmamalıdır.


            List<string> cities = new List<string> { "Bursa", "Ankara", "İstanbul"};
            cities.Add("Erzurum");

            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }

            MyList cities2 = new MyList("İzmir", "Antalya", "Çanakkale");
            Console.WriteLine(cities2.Show(2));
            cities2.Add("Muğla");
            cities2.Add("Hatay");
            for(int i = 0; i < cities2.Lenght(); i++)
            {
                Console.WriteLine(cities2.Show(i));
            }

            Console.ReadLine();
        }

        public static int Add(ref int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }

    }
}

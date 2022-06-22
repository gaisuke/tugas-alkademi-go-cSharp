using System;
using cSharpDasar.Model;

namespace cSharpDasar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!");

            var Count = 5;
            var number = 10;
            var totalDiscount = 20.56f;
            var h = 'h';
            var phoneNumber = "085236160581";
            var ishandsome = false;

            Console.WriteLine(Count);
            Console.WriteLine(number);
            Console.WriteLine(totalDiscount);
            Console.WriteLine(h);
            Console.WriteLine(phoneNumber);
            Console.WriteLine(ishandsome);

            Console.WriteLine("{0} dan {1}", Count, totalDiscount);

            const float Pi = 3.14f;
            Console.WriteLine("{0} ini adalah Pi", Pi);

            // byte a = 1;
            // int b = a;

            // int c = 1000;
            // byte d = (byte) c;

            // Console.WriteLine(d);

            string a = "20";
            int b = Convert.ToInt32(a);

            Console.WriteLine(b);

            string benar = "true";
            bool isTrue = Convert.ToBoolean(benar);

            Console.WriteLine(isTrue);

            var angka1 = 20;
            var angka2 = 9;
            var angka3 = 7;

            var angka4 = (angka1 + angka2) * angka3;

            // float angka3 = (float)20 / 9;

            Console.WriteLine(angka1 + angka2);
            Console.WriteLine(angka1 / angka2);
            // Console.WriteLine(angka3);
            Console.WriteLine(angka4);
            Console.WriteLine(angka1 > angka2);
            Console.WriteLine(angka1 == angka2);
            Console.WriteLine(angka1 != angka2);
            Console.WriteLine(!(angka1 != angka2));

            Console.WriteLine(angka3 > angka2 && angka3 > angka1);
            Console.WriteLine(angka1 > angka2 || angka3 == angka1);
            Console.WriteLine(angka1 > angka2 && angka1 > angka3);

            Person dani = new Person();
            dani.FirstName = "Dani";
            dani.LastName = "Munif";

            dani.Talk();
        }
    }
}
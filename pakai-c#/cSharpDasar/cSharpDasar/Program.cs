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

            int[] numbers = new int[3];
            var numbers2 = new int[4] {1, 3, 5, 7};
            
            numbers[0] = 1;
            numbers[1] = 3;
            numbers[2] = 5;

            Console.WriteLine(numbers[0]);
            Console.WriteLine(numbers[1]);
            Console.WriteLine(numbers[2]);

            // Console.WriteLine(numbers[4]);

            Console.WriteLine(numbers2[0]);
            Console.WriteLine(numbers2[1]);
            Console.WriteLine(numbers2[2]);

            string firstName = "Dani";
            var lastName = "Munif";

            var fullName = firstName + " " + lastName;

            var fullName2 = String.Format("{0} {1}", firstName, lastName);

            Console.WriteLine(fullName);
            Console.WriteLine(fullName2);

            var names = new string[3] {"Fetux", "Creative", "Labs"};
            var namesCombination = string.Join("-", names);

            Console.WriteLine(namesCombination);

            var text = "Hai Dani, \nYuk Pergi ke Jember\nUntuk pulang wakakak\n";
            Console.WriteLine(text);

            var text2 = @"WIDIHHH KEREN BROO
bisa gini lho ngeriii
asldkjasdh
line baru uhuy";
            Console.WriteLine(text2);

            var x = 10;
            var y = x;

            y++;

            Console.WriteLine(string.Format("x : {0}, y :{1}", x, y));

            var array1 = new int[3] { 1, 3, 5 };
            var array2 = array1;
            var array3 = new int[5] {1,2,3,4,5};
            var array4 = new int[] {};
            var array5 = new int[] {34,6,4,2,6,4,2,4,1,23,12,0};

            Console.WriteLine("Length : " + array3.Length);

            var index = Array.IndexOf(array3, 4);
            Console.WriteLine("Index dari 4 adalah : " + index);

            Array.Clear(array3, 0, 2);

            foreach ( var digit in array3)
            {
                Console.WriteLine(digit);
            }

            Array.Sort(array5);
            Console.WriteLine("Ini udah di sort gais : " + array5);

            array2[0] = 0;
            Console.WriteLine(string.Format("array1[0] : {0}, array2[0] :{1}", array1[0], array2[0]));

            var numbre = 5;
            Increment(5);
            Console.WriteLine(numbre);

            var person = new Person() { Age = 25 };
            MakeOld(person);
            Console.WriteLine(person.Age);

            int hour = 22;
            if (hour > 0 && hour < 12)
            {
                Console.WriteLine("It's Morning");
            }
            else if (hour >= 12 && hour < 18)
            {
                Console.WriteLine("It's Afternoon");
            }
            else 
            { 
                Console.WriteLine("It's Evening"); 
            }

            bool isPremiumCustomer = true;
            float price = (isPremiumCustomer) ? 20f : 10f;

            //if (isPremiumCustomer)
            //    float price = 20f;
            //else
            //    float price 10;

            Console.WriteLine(price);

            var currentSeason = Season.Summer;

            switch(currentSeason)
            {
                case Season.Fall:
                    Console.WriteLine("It's Fall and the leaves falls");
                    break;
                case Season.Summer:
                    Console.WriteLine("It's so hot in Summer, let's go to the beach!");
                    break;
                case Season.Winter:
                    Console.WriteLine("Life goes brrrrr, it's a damn cold Winter!");
                    break;
                default:
                    Console.WriteLine("What kind of season is that? huh?");
                    break;
            }

            for (int i = 1; i <= 10; i++)
            {
                if (i%2 == 0)
                {
                    //Console.WriteLine(i);
                }
            }

            for (int i = 10; i >= 1; i--)
            {
                if (i % 2 == 0)
                {
                    //Console.WriteLine(i);
                }
            }

            //var nama = "Dani Munif";

            //for (var i = 0; i < nama.Length; i++)
            //{
            //    Console.WriteLine(nama[i]);
            //}

            //foreach (var character in nama)
            //{
            //    Console.WriteLine(character);
            //}

            //var angkaygy = new int[] { 1, 2, 3, 4 };

            //foreach (var angka in angkaygy)
            //{
            //    Console.WriteLine(angka);
            //}

            int intejer = 0;
            while (intejer < 5)
            {
                Console.WriteLine("intejer : {0}", intejer);
                intejer++;
            }

            while (true)
            {
                Console.WriteLine("Input your name : ");
                var input = Console.ReadLine();

                if (String.IsNullOrWhiteSpace(input))
                    break;

                Console.WriteLine("Name is " + input);
            }
        }

        public static void Increment(int numbre)
        {
            numbre += 10;
        }

        public static void MakeOld(Person person)
        {
            person.Age += 10;
        }
    }

    public enum Season
    {
        Spring,
        Summer,
        Fall,
        Winter
    }
}
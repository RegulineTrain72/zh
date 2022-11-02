using System;
using System.Collections.Generic;
using System.Linq;

namespace zh
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. feladat
            int[] array = new int[] { 8, 37, 11, 98, 95, 43, 11, 98, 8, 8, 37 };
            //2. feladat
            var list = new List<string>() { "fa", "kép", "daru", "fa", "alma", "doboz", "kép", "doboz", "fa", "dalmata", "alpaka"};
            //3. feladat
            Console.WriteLine("Harmadik feladat: 20-nál nagyobb számok:");
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 20)
                    Console.WriteLine(array[i]);
            }
            Console.WriteLine();
            //4. feladat
            Console.WriteLine("4. feladat: ");
            var g = array.GroupBy(i => i);
            foreach (var grp in g)
            {
                Console.WriteLine("{0} {1}x fordul elő", grp.Key, grp.Count());
            }
            Console.WriteLine();
            //5. feladat
            Console.WriteLine("5. feladat: ");
            List<char> firstletters = new List<char>();
            foreach(string element in list)
            {
                firstletters.Add(element[0]);
            }
            var gb = firstletters.GroupBy(i => i);
            Dictionary<char, int> map = new Dictionary<char, int>();
            foreach (var grp in gb)
            {
                map.Add(grp.Key, grp.Count());
            }
            var max = map.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;
            Console.WriteLine("Leggyakoribb kezdőbetű: " + max);
            Console.WriteLine();
            //6. feladat
            Console.WriteLine("6. feladat: ");
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = 0; j < 1; j++)
                {
                    if (list[i][j] == max)
                    {
                        list.RemoveAt(i);
                    }
                }
            }
            foreach (string item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();
            //7. feladat
            Console.WriteLine("7. feladat:");
            int avg = Convert.ToInt32(array.Average());
            Console.WriteLine("Az átlag (" + avg + ")-nél kisebb számok a tömbben: ");
            foreach(int element in array)
            {
                if (element < avg)
                    Console.WriteLine(element);
            }
            Console.WriteLine();
            //8. feladat
            Console.WriteLine("8. feladat: ");
            int db = 0;
            int[] amount = new int[list.Count];
            for (int i = 0; i < list.Count; i++)
            {
                char ch = 'a';

                int freq = list[i].Count(f => (f == ch));
                amount[i] += freq;
            }
            int index = 0;
            for (int i = 0; i < amount.Length; i++)
            {
                if (amount[i] == amount.Max())
                {
                    index = i;
                }
            }
            Console.WriteLine("A legtöbb 'a'-t tartalmazó szó a listában: " + list.ElementAt(index));
            Console.WriteLine();
            //9. feladat
            Console.WriteLine("9. feladat:");
            Random rnd = new Random();
            int r = rnd.Next(0, 20);
            int entered = 0;
            Console.WriteLine("Adj meg egy számot 0 és 20 között.");
            entered = Convert.ToInt32(Console.ReadLine());
            if (entered < r)
                Console.WriteLine("Az általad megadott szám kisebb, mint a generált: " + r);
            else if(entered > r)
                Console.WriteLine("Az általad megadott szám nagyobb, mint a generált: " + r);
            else
                Console.WriteLine("Az általad szám megadott megegyezik generálttal: " + r);
            Console.ReadKey();
        }
    }
}

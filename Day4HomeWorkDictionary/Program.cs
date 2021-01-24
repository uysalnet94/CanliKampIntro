using System;
using System.Collections.Generic;

namespace Day4HomeWorkDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            MyDictionary<int, string> dictionary = new MyDictionary<int, string>();

            dictionary.Add(437, "Furkan");
            dictionary.Add(596, "Fatma");
            dictionary.Add(852, "Ali");
            dictionary.Add(796, "Gamze");
            dictionary.Add(793, "Büşra");
            dictionary.Add(798, "Seda");

            for (int i = 0; i < dictionary.Items1.Length; i++)
            {
                Console.WriteLine("Öğrenci No : " + dictionary.Items1[i] + "  Öğrenci Adı : " + dictionary.Items2[i]);
            }


        }
    }
}

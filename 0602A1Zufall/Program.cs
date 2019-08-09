using System;

namespace _0602A1Zufall
{
    class Program
    {
        static void Main(string[] args)
        {
            uint[] feld = new uint[100000];
            Random zuf = new Random();
            uint a;
            Boolean found = false;
            int index = 0;

            Console.WriteLine("Generating more random...");

            for (int i = 0; i < 100000; i++)
            {
                feld[i] = (uint)zuf.Next(1, 50001);
            }

            Console.WriteLine("Bitte geben Sie eine Zahl zwischen 1 und 50000 ein");
            a = uint.Parse(Console.ReadLine());

            if (a < 1 || a > 50000)
                Console.WriteLine("Fehleingabe!");
            else
            {
                for (int i = 0; i < 100000; i++)
                {
                    if (a == feld[i])
                    {
                        found = true;
                        index = i;
                        break;
                    }
                }
                if (found)
                    Console.WriteLine("Yippie! Gefunden an Position {0}!", index);
                else
                    Console.WriteLine("Verloren!");
            }
        }
    }
}

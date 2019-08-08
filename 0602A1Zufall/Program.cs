using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0602A1Zufall
{
    class Program
    {
        static void Main(string[] args)
        {
            uint[] feld = new uint[100000];
            Random zuf = new Random();
            uint a;

            for (int i = 0; i < 100000; i++)
            {
                feld[i] = (uint)zuf.Next(1, 50001);
            }

            Console.WriteLine("Bitte geben Sie eine Zahl zwischen 1 und 50000 ein");
            a = uint.Parse(Console.ReadLine());

        }
    }
}

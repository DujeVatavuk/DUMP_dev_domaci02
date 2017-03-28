using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUMP_zadatak03
{
    class zad03
    {
        static void Main(string[] args)
        {
            int ceda;
            Console.Write("Dobar dan direktore, koliko Cedevita pakiranja cemo danas proizvesti: ");
            ceda = int.Parse(Console.ReadLine());
            for (int i = 1; i <= ceda; i++)
            {
                if (0 == i % 3 && 0 != i % 7)
                {
                    Console.WriteLine("CEDE");
                }
                else if (0 != i % 3 && 0 == i % 7) 
                {
                    Console.WriteLine("VITA");
                }
                else if (0 == i % 3 && 0 == i % 7) 
                {
                    Console.WriteLine("CEDEVITA");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}

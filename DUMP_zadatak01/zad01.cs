using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUMP_zadatak01
{
    class zad01
    {
        static void Main(string[] args)
        {
            int galeon, srp, knut; //int jer predpostavljam da su kvantizirani inace bi bilo double ili float
            Console.WriteLine("Harry, how much monies did your parents leave you?");
            Console.Write("How many Galeons do you have: ");
            galeon = int.Parse(Console.ReadLine());
            Console.Write("How many Srps do you have: ");
            srp = int.Parse(Console.ReadLine());
            Console.Write("How many Knuts do you have: ");
            knut = int.Parse(Console.ReadLine());
            Console.WriteLine();
            if (Gringots(galeon, srp, knut) < 0)
            {
                Console.WriteLine("Harry, you have " + Gringots(galeon, srp, knut) + " Knuts, how did you manage to get in debt so young?\n");
            }
            else if (Gringots(galeon, srp, knut) >= 0 && Gringots(galeon, srp, knut) <= 1000)
            {
                Console.WriteLine("Harry, you have " + Gringots(galeon, srp, knut) + " Knuts, your parents didn't leave you much did they.\n");
            }
            else
            {
                Console.WriteLine("Harry, you have " + Gringots(galeon, srp, knut) + " Knuts, you're pretty rich\n");
            }
        }
        public static int Gringots(int galeon, int srp, int knut)
        {
            int monies;
            monies = galeon * 17 * 29 + srp * 20 + knut;
            return monies;
        }
    }
}

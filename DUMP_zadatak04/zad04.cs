using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUMP_zadatak04
{
    class zad04
    {
        static void Main(string[] args)
        {
            //string mentor1, mentor2, mentor3, mentor4, okrenutiMentor1, okrenutiMentor2, okrenutiMentor3, okrenutiMentor4;
            string[] mentor = new string[4];
            string[] okrenutiMentor = new string[4];
            int brojOkrenutihMentora;
            Console.WriteLine("Hajde kazi nam svoj poredak mentora, od najdrazeg prema najmanje dragog naravno");
            for (int i = 0; i < 4; i++)
            {
                Console.Write("Vas " + (i + 1) + ". mentor po redu je: ");
                mentor[i] = Console.ReadLine();
            }
            //Console.WriteLine("Hajde kazi nam svoj poredak mentora, od najdrazeg prema najmanje dragog naravno");
            //mentor1 = Console.ReadLine();
            //mentor2 = Console.ReadLine();
            //mentor3 = Console.ReadLine();
            //mentor4 = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Koliko ti se mentora okrenilo: ");
            brojOkrenutihMentora = int.Parse(Console.ReadLine());
            if (0==brojOkrenutihMentora)
            {
                Console.WriteLine("JAO");
            }
            else
            {
                Console.WriteLine("Koji su to bili mentori");
                for (int i = 0; i < brojOkrenutihMentora; i++)
                {
                    Console.Write((i + 1) + ". mentor koji ti se okrenuo je: ");
                    okrenutiMentor[i] = Console.ReadLine();
                }
                for (int i = 0; i < 4; i++)
                {
                    for (int j = 0; j < brojOkrenutihMentora; j++)
                    {
                        if (mentor[i]==okrenutiMentor[j])
                        {
                            Console.WriteLine();
                            Console.WriteLine("Predpostavljam da si onda odabrao " + mentor[i]);
                            i = 4;
                            break;
                        }
                    }
                }
            }

        }
    }
}

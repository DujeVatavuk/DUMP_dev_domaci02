using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUMP_zadatak05
{
    class zad05
    {
        static void Main(string[] args)
        {
            int dominik1, dominik2, matej1, matej2;
            Console.WriteLine("Ucenici: Ej, Dominik, Matej, kojih troje ce profesor pitati?\nDominik i Matej (skupa): Ne znamo, izgubili smo papiric\nUcenici: Pa jer se bar sicate ikojih brojeva?");
            Console.WriteLine("Dominik: Eeeem, sican se dva broja ");
            dominik1 = int.Parse(Console.ReadLine());
            dominik2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ucenici: Aj i to je nesto, Matej je li se ti sicas icega?");
            Console.WriteLine("Matej: Da, da, sican se i ja dva broja ");
            matej1 = int.Parse(Console.ReadLine());
            matej2 = int.Parse(Console.ReadLine());
            if ((dominik1==matej1 && dominik2==matej2) || (dominik2 == matej1 && dominik1 == matej2))
            {
                Console.WriteLine("Ucenici: Nemamo sva tri broja, bojim se da svi moramo uciti, Matej, Dominik iduci put vise pripazite na papiric");
            }
            else
            {
                if(matej1==dominik1 || matej1==dominik2)
                {
                    Console.WriteLine("Dominik i Matej (skupa s olaksanjem): Dobro da smo se sjetili, moraju uciti oni koji su pod brojem " + dominik1 + "., " + dominik2 + ". i " + matej2 + ". u dnevniku");
                }
                else
                {
                    Console.WriteLine("Dominik i Matej (skupa s olaksanjem): Dobro da smo se sjetili, moraju uciti oni koji su pod brojem " + dominik1 + "., " + dominik2 + ". i " + matej1 + ". u dnevniku");
                }
            }
        }
    }
}

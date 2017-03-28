using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUMP_zadatak02
{
    class zad02
    {
        static void Main(string[] args)
        {
            double darko, mirko, slavko;
            Console.WriteLine("Dame i gospodo, dobro dosli na prvo ovogodisnje svijetsko natjecanje u obaranju ruku\nNasi natjecatelji su redom: Darko, Mirko i Slavko");
            Console.Write("Darko, pokusaj ocjeniti svoju snagu od 1 do 10, ali iskreno: ");
            darko = double.Parse(Console.ReadLine());
            Console.Write("Mirko, sada ti iskreno pokusaj ocjeniti svoju snagu od 1 do 10: ");
            mirko = double.Parse(Console.ReadLine());
            Console.Write("I na kraju Slavko, tvoj je red da iskreno ocjenis svoju snagu od 1 do 10: ");
            slavko = double.Parse(Console.ReadLine());
            if (Math.Abs(darko-mirko) < Math.Abs(darko - slavko) && Math.Abs(darko - mirko) < Math.Abs(mirko - slavko))
            {
                Console.WriteLine();
                Console.WriteLine("U lijevom kutu terena imamo trenutnog svijetskog prvaka Darka sa 420 pobjeda i 69 gubitaka, a protiv njega u desnom kutu se bori nova mlada nada Mirko\nLets get ready to RUMBLEEEE");
            }
            else if (Math.Abs(darko - slavko) < Math.Abs(darko - mirko) && Math.Abs(darko - slavko) < Math.Abs(mirko - slavko))
            {
                Console.WriteLine();
                Console.WriteLine("U lijevom kutu terena imamo trenutnog svijetskog prvaka Darka sa 420 pobjeda i 69 gubitaka, a protiv njega u desnom kutu se bori nova mlada nada Slavko\nLets get ready to RUMBLEEEE");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("U lijevom kutu terena imamo mlau nadu Mirka, a protiv njega u desnom kurt se bori isto nova mlada nada Slavko\nLets get ready to RUMBLEEEE");
            }
        }
    }
}

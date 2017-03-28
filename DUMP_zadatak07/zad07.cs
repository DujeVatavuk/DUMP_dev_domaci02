using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUMP_zadatak07
{
    class zad07
    {
        static void Main(string[] args)
        {
            int brojKomadaHrane = int.Parse(Console.ReadLine());
            int[] kolicinaHrane = Enumerable.Repeat(0, brojKomadaHrane).ToArray();//trebam imat varijabli koliko i komada hrane jel u teoriji moze bit i dice koliko i hrane
            string[] imeDjeteta = new string[brojKomadaHrane];//-||-
            string ime;
            int brojac=0, brojPrasaca=0, pamcenje=0;
            bool postojiLiVecDijeteTogImena = false;
            for (int i = 0; i < brojKomadaHrane; i++)
            {
                ime = Console.ReadLine();
                if(i==0)
                {
                    imeDjeteta[0] = ime;
                    kolicinaHrane[0]++;
                    brojac++;
                    brojPrasaca--;
                }
                else
                {
                    for (int j = 0; j < brojac; j++)
                    {
                        if (imeDjeteta[j]==ime)
                        {
                            kolicinaHrane[j]++;
                            postojiLiVecDijeteTogImena = true;
                            pamcenje = j;
                            break;
                        }
                    }
                    if (!postojiLiVecDijeteTogImena)
                    {
                        imeDjeteta[brojac] = ime;
                        kolicinaHrane[brojac]++;
                        brojac++;
                    }
                }
                /*for (int j = 0; j < brojac; j++)
                {
                    if (kolicinaHrane[j]>((i+1)/2))
                    {
                        brojPrasaca++;
                    }
                }*/
                if (kolicinaHrane[pamcenje] > ((i + 1) / 2))
                {
                    brojPrasaca++;
                }
            }
            Console.WriteLine();
            Console.WriteLine(brojPrasaca);
        }
    }
}

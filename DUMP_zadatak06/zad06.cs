using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DUMP_zadatak06
{
    class zad06
    {
        static void Main(string[] args)
        {
            bool mogucnostUlova = false;
            string[] adreseAviona = new string[5];
            Console.WriteLine("USKOK: Dobar dan\nKontrolor leta: Dobar dan, što trebate?\nUSKOK: Znamo da imate trenutno 5 aviona parkiranih na aerodromu, kazite njihove registracije\nKontrolor leta (pomalo zbunjeno): Moze, samo na potvrdim sve podatke\nUSKOK: Moze, samo molim vas pozurite\nKontrolor leta: Evo, sve potvrdjeno, adrese su: ");
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Adresa " + (i + 1) + ". aviona je: ");
                adreseAviona[i] = Console.ReadLine();
                adreseAviona[i] = adreseAviona[i].ToUpper();
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < adreseAviona[i].Count()-2; j++)
                {
                    if(adreseAviona[i][j]=='F' && adreseAviona[i][j+1] == 'B' && adreseAviona[i][j+2] == 'I')
                    {
                        Console.WriteLine();
                        Console.WriteLine("Pobjeci ce sa " + (i + 1) + ". avionom, tablica tog aviona je: {0}", adreseAviona[i]);
                        i = 5;
                        mogucnostUlova = true;
                        break;
                    }
                }
            }
            if (!mogucnostUlova)
            {
                Console.WriteLine("UTEKO");
            }
        }
    }
}

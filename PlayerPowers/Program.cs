using System;
using System.Linq;

namespace PlayerPowers
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Quantos Jogadores? ");
            string jogadores = Console.ReadLine();
            int n = int.Parse(jogadores);

            Power [] pr = new Power[n];

            for (int i = 0; i < pr.Length; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write($"Jogador {i} diz me os teus poderes: ");
                    string escolhas = Console.ReadLine();

                    if(escolhas == "Fly")
                    {
                        pr[i] ^= Power.Fly;
                    }
                    else if (escolhas == "XRayVision")
                    {
                        pr[i] ^= Power.XRayVision;
                    }
                    else if( escolhas == "SuperStrength")
                    {
                        pr[i] ^= Power.SuperStrength;
                    }
                    else
                        continue;
                }

                if ((pr[i] & Power.Fly) == Power.Fly && ((pr[i] & Power.SuperStrength) == Power.SuperStrength))
                    {
                        Console.WriteLine("Flying Radiation");
                    }
            }
            
            

        }
    }
}

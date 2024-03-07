using System;

namespace HeroPerks
{
    class Program
    {
        static void Main(string[] args)
        {
            Perks playerPerks = Perks.None;

            foreach (char x in args[0])
            {
                switch(x)
                {
                    case 'w':
                        playerPerks ^= Perks.WaterBreathing;
                        break;
                    case 's':
                        playerPerks ^= Perks.Stealth;
                        break;
                    case 'a':
                        playerPerks ^= Perks.AutoHeal;
                        break;
                    case 'd':
                        playerPerks ^= Perks.DoubleJump;
                        break;
                    default:
                        Console.WriteLine("Unknown Perk!");
                        break;

                    
                }

            }

            if(playerPerks == Perks.None )
            {
                Console.WriteLine("No Perks at all!");
                return;
            }

            Console.WriteLine($"Player Perks: {playerPerks}");

            if((playerPerks & Perks.Stealth) == Perks.Stealth && (playerPerks & Perks.DoubleJump) == Perks.DoubleJump)
            {
                Console.WriteLine("Silent Jumper!");
            }
            if ((playerPerks & Perks.AutoHeal) != Perks.AutoHeal)
            {
                Console.WriteLine("Not gonna make it!");
            }

            
        }
    }
}

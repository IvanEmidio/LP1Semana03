using System;
using HeroPerks;

namespace HeroPerk
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Perks myPerks = Perks.None;

            foreach (char c in args[0])
            {
                switch(c)
                {
                    case 'w':
                        myPerks ^= Perks.WarpShift;
                        Console.Write("WarpShift ");
                        break;
                    case 's':
                        myPerks ^= Perks.Stealth;
                        Console.Write("Stealth ");
                        break;
                    case 'a':
                        myPerks ^= Perks.AutoHeal;
                        Console.Write("AutoHeal ");
                        break;
                    case 'd':
                        myPerks ^= Perks.DoubleJump;
                        Console.Write("DoubleJump ");
                        break;
                    default:
                        Console.WriteLine("!Unknown perk!");
                        break;
                }
            }

            if (myPerks == Perks.None)
            {
                Console.WriteLine("!No perks at all!");
                return;
            }  
            
            if((myPerks & Perks.Stealth) == Perks.Stealth && (myPerks & Perks.DoubleJump) == Perks.DoubleJump)
            {
                Console.WriteLine("\n!Silent Jumper!");
            }
            if((myPerks & Perks.AutoHeal) != Perks.AutoHeal)
            {
                Console.WriteLine("!Not gonna make it!");
            } 

        }
    }
}

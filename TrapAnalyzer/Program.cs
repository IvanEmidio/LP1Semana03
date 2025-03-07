using System;

namespace TrapAnalyzer
{
    public class Program
    {
        /// <summary>
        /// Main method. Do not change it!
        /// </summary>
        /// <param name="args">Command-line arguments.</param>
        private static void Main(string[] args)
        {
            // DO NOT CHANGE THIS METHOD!
            TrapType trap = Enum.Parse<TrapType>(args[0]);
            PlayerGear gear = ParseGear(args);
            bool survives = CanSurviveTrap(trap, gear);
            DisplayResult(trap, survives);
            // DO NOT CHANGE THIS METHOD!
        }

        /// <summary>
        /// Parse the command line arguments to get the player gear.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        /// <returns>The player gear.</returns>
        private static PlayerGear ParseGear(string[] args)
        {

            PlayerGear gear = PlayerGear.None;

            
            foreach (string item in args)
            {
                
                switch (item) 
                {
                    case "Helmet":
                        gear |= PlayerGear.Helmet;
                        break;
                    case "Shield":
                        gear |= PlayerGear.Shield;
                        break;
                    case "Boots":
                        gear |= PlayerGear.Boots;
                        break;
                    
                }
            }
            
            return gear;
        }

        /// <summary>
        /// Can the player survive the trap given the gear it has?
        /// </summary>
        /// <param name="trap">The trap the player falls into.</param>
        /// <param name="gear">The gear the player has.</param>
        /// <returns>Wether the player survived the trap or not.</returns>
        private static bool CanSurviveTrap(TrapType trap, PlayerGear gear)
        {
            if((gear & PlayerGear.Helmet) == PlayerGear.Helmet 
            && trap == TrapType.FallingRocks)
            {
                return true;
            }
            else if((gear & PlayerGear.Shield) == PlayerGear.Shield 
            && trap == TrapType.SpinningBlades)
            {
                return true;
            }
            else if((gear & PlayerGear.Helmet | PlayerGear.Shield) == (PlayerGear.Shield 
            | PlayerGear.Helmet) && trap == TrapType.PoisonGas)
            {
                return true;
            }
            else if((gear & PlayerGear.Boots) == PlayerGear.Boots 
            && trap == TrapType.LavaPit)
            {
                return true;
            }
            else return false;
            
        }

        /// <summary>
        /// Display information on wether the player survived the trap or not.
        /// </summary>
        /// <param name="trap">The trap the player has fallen into.</param>
        private static void DisplayResult(TrapType trap, bool survives)
        {
            if (survives)
            {
                Console.WriteLine($"Player survives {trap}");
            }
            else
            {
                Console.WriteLine($"Player dies due to {trap}");
            }
        }
    }
}

using System;

namespace PowTwoUntil
{
    class Program
    {
        private static void PowerOf2Until5()
                {
                    for (int i = 1; i <= (1<<5); i = i <<1)
                    {
                        Console.WriteLine(i);
                    }
                    
                    
                }
        static void Main(string[] args)
        {
            PowerOf2Until5();
            PowerOf2Until5();
        }
        
    }
}

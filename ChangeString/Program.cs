using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            char a = char.Parse(Console.ReadLine());
           

            foreach (char b in s)
            {
                if(b == a)
                {
                    Console.Write("X");
                }
                else
                {
                    Console.Write(b);
                }
                
            }
            
        }
    }
}

using System;

namespace ChangeString
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string sub = "";

            Console.WriteLine("String: ");
            string s = Console.ReadLine();
            Console.WriteLine("Character: ");
            char c = Console.ReadKey().KeyChar;
            Console.WriteLine();


            foreach (char a in s)
            {
                if(a == c)
                {
                    sub += "x";
                }
                else
                {
                    sub += a;
                }
            }
            Console.WriteLine(sub);
        }
    }
}

using System;
using System.Globalization;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
            CultureInfo culture = CultureInfo.InvariantCulture;

            float [,] array = new float [2,2];
            array[0,0] = float.Parse(args[0], culture);
            array[0,1] = float.Parse(args[1], culture);
            array[1,0] = float.Parse(args[2], culture);
            array[1,1] = float.Parse(args[3], culture);
            float [,] array1 = new float [2,1];
            array1[0,0] = float.Parse(args[4], culture);
            array1[1,0] = float.Parse(args[5], culture);

            float [,] result = new float [2,1];


            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 1; j++)
                {

                    result[i,j] = array[i,0] * array1[0,j]
                    + array[i,1] * array1[1,j];
                }    
            }
            
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"|{result[i,0],7}|");
            }

        }
    }
}

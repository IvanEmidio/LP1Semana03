using System;

namespace ArrayMult
{
    class Program
    {
        static void Main(string[] args)
        {
            float [,] matriz = new float [2,2];
            float [] vetor = new float [2];
            float [] resultado = new float [2];

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                  matriz[i, j] = float.Parse(args[i * 2 + j]);
                }
                
            }
            for (int i = 0; i < 2; i++)
            {
                vetor[i] = float.Parse(args[i + 4]);
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    resultado[i] += matriz[i, j] * vetor[j];
                }
            }

            Console.WriteLine(resultado[0]);
            Console.WriteLine(resultado[1]);
        }
    }
}

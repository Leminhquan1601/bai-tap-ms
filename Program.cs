using System;

namespace SumDiagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập kích thước ma trận vuông: ");
            int n = int.Parse(Console.ReadLine());

            double[,] matrix = new double[n, n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"matrix[{i},{j}] = ");
                    matrix[i, j] = double.Parse(Console.ReadLine());
                }
            }

            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum += matrix[i, i];
            }

            Console.WriteLine($"\nTổng các phần tử trên đường chéo chính = {sum}");
        }
    }
}

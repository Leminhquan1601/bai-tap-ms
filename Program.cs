using System;

namespace FindMaxIn2DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số hàng: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Nhập số cột: ");
            int cols = int.Parse(Console.ReadLine());

            double[,] matrix = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"matrix[{i},{j}] = ");
                    matrix[i, j] = double.Parse(Console.ReadLine());
                }
            }

            double maxValue = matrix[0, 0];
            int maxRow = 0, maxCol = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (matrix[i, j] > maxValue)
                    {
                        maxValue = matrix[i, j];
                        maxRow = i;
                        maxCol = j;
                    }
                }
            }

            Console.WriteLine($"\nPhần tử lớn nhất là: {maxValue}");
            Console.WriteLine($"Tọa độ: hàng {maxRow}, cột {maxCol}");
        }
    }
}

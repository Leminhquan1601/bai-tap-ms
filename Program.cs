using System;

namespace MinInArray
{
    class Program
    {
        static int MinValue(int[] a)
        {
            int idx = 0;
            for (int i = 1; i < a.Length; i++)
                if (a[i] < a[idx]) idx = i;
            return idx;
        }

        static void Main(string[] args)
        {
            Console.Write("Nhập số phần tử: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write($"a[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            int index = MinValue(arr);
            Console.WriteLine($"Vị trí nhỏ nhất: {index}");
            Console.WriteLine($"Giá trị nhỏ nhất: {arr[index]}");
        }
    }
}


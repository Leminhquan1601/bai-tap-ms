using System;

namespace DeleteElementFromArray
{
    class Program
    {
        static int[] DeleteElement(int[] arr, int x)
        {
            int indexDel = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    indexDel = i;
                    break;
                }
            }

            if (indexDel == -1) 
                return arr;

            int[] newArr = new int[arr.Length - 1];
            for (int i = 0; i < indexDel; i++)
                newArr[i] = arr[i];
            for (int i = indexDel; i < newArr.Length; i++)
                newArr[i] = arr[i + 1];

            return newArr;
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

            Console.Write("Nhập phần tử cần xoá: ");
            int x = int.Parse(Console.ReadLine());

            int[] result = DeleteElement(arr, x);

            Console.WriteLine("Mảng sau khi xoá:");
            foreach (int val in result)
                Console.Write(val + " ");
        }
    }
}




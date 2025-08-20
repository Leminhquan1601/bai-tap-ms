using System;

namespace StopWatchExample
{
    class StopWatch
    {
        private DateTime startTime;
        private DateTime endTime;

        public DateTime StartTime { get { return startTime; } }
        public DateTime EndTime { get { return endTime; } }

        public StopWatch()
        {
            startTime = DateTime.Now;
        }

        public void Start()
        {
            startTime = DateTime.Now;
        }

        public void Stop()
        {
            endTime = DateTime.Now;
        }

        public long GetElapsedTime()
        {
            return (long)(endTime - startTime).TotalMilliseconds;
        }
    }

    class Program
    {
        static void SelectionSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }

        static void Main(string[] args)
        {
            int n = 100000;
            int[] numbers = new int[n];
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                numbers[i] = rand.Next(1, 1000000);
            }

            StopWatch sw = new StopWatch();
            sw.Start();

            SelectionSort(numbers);

            sw.Stop();
            Console.WriteLine("Thời gian sắp xếp 100,000 số bằng Selection Sort: " + sw.GetElapsedTime() + " ms");
        }
    }
}


using System;

namespace FanClassExample
{
    class Fan
    {
        public const int SLOW = 1;
        public const int MEDIUM = 2;
        public const int FAST = 3;

        private int speed = SLOW;
        private bool on = false;
        private double radius = 5;
        private string color = "blue";

        public int Speed { get => speed; set => speed = value; }
        public bool On { get => on; set => on = value; }
        public double Radius { get => radius; set => radius = value; }
        public string Color { get => color; set => color = value; }

        public override string ToString()
        {
            if (on)
                return $"Fan is on: speed={speed}, color={color}, radius={radius}";
            else
                return $"Fan is off: color={color}, radius={radius}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Fan fan1 = new Fan();
            fan1.Speed = Fan.FAST;
            fan1.Radius = 10;
            fan1.Color = "yellow";
            fan1.On = true;

            Fan fan2 = new Fan();
            fan2.Speed = Fan.MEDIUM;
            fan2.Radius = 5;
            fan2.Color = "blue";
            fan2.On = false;

            Console.WriteLine(fan1.ToString());
            Console.WriteLine(fan2.ToString());
        }
    }
}

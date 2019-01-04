using System;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");
            Console.WriteLine("This application is for calculate the distance between two points and the angle between those points.");
            Console.Write("Enter first X value: ");
            float point1X = float.Parse(Console.ReadLine());

            Console.Write("Enter first Y value: ");
            float point1Y = float.Parse(Console.ReadLine());

            Console.Write("Enter second X value: ");
            float point2X = float.Parse(Console.ReadLine());

            Console.Write("Enter second Y value: ");
            float point2Y = float.Parse(Console.ReadLine());

            double deltaY = point2Y - point1Y;
            double deltaX = point2X - point1X;

            double distance = Math.Sqrt(Math.Pow(deltaX, 2)+Math.Pow(deltaY,2));

            Console.WriteLine("Distance between points:" + distance);

            double angle = Math.Atan2(deltaX, deltaY) * (180 / Math.PI);
            Console.WriteLine("Angle between points: "+angle+" degrees");

        }
    }
}

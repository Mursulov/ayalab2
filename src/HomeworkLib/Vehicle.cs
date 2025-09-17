using System;

namespace HomeworkLib
{
    public class Vehicle
    {
        public double X { get; }
        public double Y { get; }
        public decimal Price { get; }
        public double Speed { get; }
        public int Year { get; }

        public Vehicle(double x, double y, decimal price, double speed, int year)
        {
            X = x; Y = y; Price = price; Speed = speed; Year = year;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"{GetType().Name}: Coords=({X},{Y}) Price={Price} Speed={Speed} Year={Year}");
        }
    }

    public class Plane : Vehicle
    {
        public double Height { get; }
        public int Passengers { get; }
        public Plane(double x, double y, decimal price, double speed, int year, double height, int passengers)
            : base(x, y, price, speed, year)
        {
            Height = height; Passengers = passengers;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Height={Height} Passengers={Passengers}");
        }
    }

    public class Car : Vehicle
    {
        public Car(double x, double y, decimal price, double speed, int year)
            : base(x, y, price, speed, year) { }
    }

    public class Ship : Vehicle
    {
        public int Passengers { get; }
        public string Port { get; }
        public Ship(double x, double y, decimal price, double speed, int year, int passengers, string port)
            : base(x, y, price, speed, year)
        {
            Passengers = passengers; Port = port;
        }
        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"Passengers={Passengers} Port={Port}");
        }
    }
}

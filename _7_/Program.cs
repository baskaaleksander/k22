// See https://aka.ms/new-console-template for more information
using System;

namespace _7_
{
    class Program
    {
        public interface IVehicle
        {
            void Start();
            void Stop();
        }
        public interface IElectricVehicle : IVehicle
        {
            void Charge();
        }
        public abstract class Vehicle : IVehicle
        {
            public string Brand { get; set; }
            public string Model { get; set; }

            public Vehicle(string brand, string model)
            {
                Brand = brand;
                Model = model;
            }
            public virtual void Start()
            {
                Console.WriteLine("Vehicle started");
            }
            public virtual void Stop()
            {
                Console.WriteLine("Vehicle stopped");
            }
        }
        public class Car : Vehicle
        {
            public int NumberOfDoors { get; set; }
            public Car(string brand, string model, int numberOfDoors) : base(brand, model)
            {
                NumberOfDoors = numberOfDoors;
            }
            public override void Start()
            {
                Console.WriteLine("Vehicle started" + NumberOfDoors);
            }
            public virtual void Stop()
            {
                Console.WriteLine("Vehicle stopped" + NumberOfDoors);
            }

        }
        public class ElectricCar : Car, IElectricVehicle
        {
            public int BatteryLevel { get; set; }
            public ElectricCar(string brand, string model, int numberOfDoors, int batteryLevel) : base(brand, model, numberOfDoors)
            {
                BatteryLevel = batteryLevel;
            }
            public override void Start()
            {
                Console.WriteLine("Vehicle started" + NumberOfDoors + BatteryLevel);
            }
            public virtual void Stop()
            {
                Console.WriteLine("Vehicle stopped" + NumberOfDoors);
            }
            public void Charge()
            {
                Console.WriteLine("Vehicle charged");
            }

        }
        static void Main(string[] args)
        {
            List<IVehicle> vehicles = new List<IVehicle>();
            vehicles.Add(new Car("Toyota", "Corolla", 4));
            vehicles.Add(new ElectricCar("Tesla", "Model S", 4, 100));
            foreach (var vehicle in vehicles)
            {
                vehicle.Start();
                vehicle.Stop();
                if (vehicle is IElectricVehicle)
                {
                    ((IElectricVehicle)vehicle).Charge();
                }
            }
        }
    }
}

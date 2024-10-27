using System;

namespace OOP
{
    public enum Color
    {
        Black,
        Red,
        Green,
        Blue
    }
    public enum Type
    {
        Car,
        Motor,
        SUV,
        Truck,
        Bike
    }
    class Vehicle
    {
        public string Name { get; set; }
        public Color VehicleColor { get; set; }
        public double Speed { get; set; }
        public double Fuel { get; set; }
        public List<Type> Type { get; set; }
        public string Extra { get; set; }
        public double FuelConsumption { get; set; }

        public void ShowData()
        {
            string data = $"Name: {Name}\nColor: {VehicleColor}\nSpeed: {Speed}\nFuel: {Fuel}\nExtra: {Extra}";
            Console.WriteLine(data);
            double Range = CalculateRange();
            if (Range > 0)
            {
                Console.WriteLine($"Range: {Range}");
            }
            else
            {
                Console.WriteLine("Fuel consumption is 0");
            }

        }
        public double CalculateRange()
        {
            return this.Fuel / this.FuelConsumption * 100;
        }
    }
    class Garage
    {
        public List<Vehicle> vehicles = new List<Vehicle>();
        public byte Capacity { get; set; }

        public void AddVehicle(Vehicle vehicle)
        {
            if (vehicles.Count < Capacity)
            {
                vehicles.Add(vehicle);
                Console.WriteLine("Vehicle added to garage");
            }
            else
            {
                Console.WriteLine("Garage is full");
            }

        }
        public void RemoveVehicle(Vehicle vehicle)
        {
            vehicles.Remove(vehicle);
            Console.WriteLine("Vehicle removed from garage");
        }
        public void ShowAllVehicles()
        {
            foreach (var vehicle in vehicles)
            {
                vehicle.ShowData();
            }
        }
        public void ShowVehicle()
        {
            Dictionary<Type, int> vehiclesCount = new Dictionary<Type, int>();
            foreach (var vehicle in vehicles)
            {
                foreach (Type type in vehicle.Type)
                {
                    if (vehiclesCount.ContainsKey(type))
                    {
                        vehiclesCount[type]++;
                    }
                    else
                    {
                        vehiclesCount.Add(type, 1);
                    }
                }
            }
            foreach (var vehicle in vehiclesCount)
            {
                Console.WriteLine($"Type: {vehicle.Key.ToString()} Count: {vehicle.Value}");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // // 1 typ zapisywania obiektu
            // Vehicle bike1 = new Vehicle();
            // bike1.Name = "Yamaha";
            // bike1.VehicleColor = Color.Red;
            // bike1.Speed = 120;
            // bike1.Fuel = 10;
            // bike1.Type = new List<string> { "Two Wheeler", "Petrol" };
            // bike1.Extra = "Disc Brake";

            // // 2 typ zapisywania obiektu
            // Vehicle car1 = new Vehicle() { Name = "Audi", VehicleColor = Color.Black, Speed = 200, Fuel = 20, Type = new List<string> { "Four Wheeler", "Diesel" }, Extra = "Sunroof" };


            // bike1.ShowData();
            // Console.ReadKey();

            Vehicle bike1 = new Vehicle
            {
                Name = "Yamaha",
                VehicleColor = Color.Red,
                Speed = 30,
                Fuel = 0,
                Type = new List<Type> { Type.Bike },
                Extra = "Disc Brake",
                FuelConsumption = 0
            };

            Vehicle car1 = new Vehicle
            {
                Name = "Fiat",
                VehicleColor = Color.Blue,
                Speed = 115,
                Fuel = 50,
                Type = new List<Type> { Type.Car, Type.SUV },
                Extra = "126p",
                FuelConsumption = 6.5
            };

            Vehicle car2 = new Vehicle
            {
                Name = "Fiat",
                VehicleColor = Color.Blue,
                Speed = 115,
                Fuel = 50,
                Type = new List<Type> { Type.Car },
                Extra = "126p",
                FuelConsumption = 6.5
            };

            Garage garage = new Garage { Capacity = 10 };

            garage.AddVehicle(bike1);
            garage.AddVehicle(car1);
            garage.AddVehicle(car2);

            garage.ShowAllVehicles();
            garage.ShowVehicle();

            garage.RemoveVehicle(car1);

            garage.ShowVehicle();
            garage.ShowAllVehicles();
            Console.ReadKey();
        }
    }
}

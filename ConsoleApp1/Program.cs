using ConsoleApp1;

Car car = new Car("GTS", "Porsche", 300, "red", 2023);
Bus bus = new Bus(150, "blue", 2020);
Vehicle[] vehicles = new Vehicle[] { car, bus };


foreach (var vehicle in vehicles)
{
    Console.WriteLine(vehicle.ShowInfo());
}
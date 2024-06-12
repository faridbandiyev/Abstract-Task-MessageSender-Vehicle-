namespace ConsoleApp1
{
    public class Car : Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int MaxSpeed { get; set; }
        public Car(string model, string brand, int maxSpeed, string color, int year) : base(color, year)
        {
            Brand = brand;
            Model = model;
            MaxSpeed = maxSpeed;
        }

        public override string ShowInfo()
        => $"Car - Brand: {Brand}, Model: {Model}, Color: {Color}, Year: {Year}, Max Speed: {MaxSpeed}";
    }
}

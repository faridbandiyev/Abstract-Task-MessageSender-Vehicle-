namespace ConsoleApp1
{
    public class Bus : Vehicle
    {
        public int PassengerCount { get; set; }
        public Bus(int passengerCount, string color, int year) : base(color, year)
        {
            PassengerCount = passengerCount;
        }

        public override string ShowInfo()
        {
            
        }
    }
}

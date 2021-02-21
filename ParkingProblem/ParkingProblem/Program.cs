using System;

namespace ParkingProblem
{
    class Program
    {
        private readonly Random _random = new Random();
        public int RandomNumber(int min, int max)
        {
            return _random.Next(min, max);
        }
        static void Main(string[] args)
        {
            double total = 0;
            Console.Clear();
            Console.WriteLine("Enter number <= 0 to exit\n");
            while (true)
            {
                Console.Write(" Hours parked : ");
                string entry = Console.ReadLine();
                double hours;
                //hours = RandomNumber(0, 24); i tried to simulate input but it doesnt work
                double.TryParse(entry, out hours); // sets hours to 0 if entry is invalid
                if (hours <= 0) return;
                double charge = CalculateCharges(hours);
                total += charge;
                Console.WriteLine(" Charge is {0:C}, total today {1:C}\n", charge, total);
            }
        }
        static double CalculateCharges(double hours)
        {
            if (hours <= 3) return 2;
            double charge = 2 + 0.5 * Math.Ceiling(hours - 3);
            if (charge > 10) charge = 10;
            return charge;
        }
       
        
    }
}


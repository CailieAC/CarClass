using System;

namespace CarClass
{
    class Program
    {

        static void Main(string[] args)
        {
            Car car1 = new Car();
            Console.WriteLine($"The starting fuel amount is: {car1.GasLevel}");
            Console.Write("How much gas to add: ");
            car1.AddGas(float.Parse(Console.ReadLine()));
            Console.WriteLine($"The new gas amount is: {car1.GasLevel}");
            Console.Write("Fill up...");
            Console.ReadLine();
            float gasDifference = car1.FillUp();
            Console.WriteLine($"The gas difference is: {gasDifference}");
            Console.WriteLine($"The final filled up amount is: {car1.GasLevel}");
            Console.ReadLine();
        }
    }

    //Create a program with a Car class that has a gas level, 
    //a method to add gas that takes a single float value and adds this amount to the current gas level, 
    //a fill up method that fills the car up to its max value of 13.0 and returns how much gas was added. 
    //The class should have a constructor that fills the car with a random amount of gas to start up to 13.0.
    class Car
    {
        public float GasLevel { get; set; }

        public Car()
        {
            Random rdm = new Random();
            GasLevel = rdm.Next(14);
        }

        public void AddGas(float gasAmount)
        {
            if (GasLevel + gasAmount > 13)
                GasLevel = 13;
            else
                GasLevel += gasAmount;
        }

        public float FillUp()
        {
            float gasDifference = 13 - GasLevel;
            GasLevel = 13;
            return gasDifference;
        }
    }
}

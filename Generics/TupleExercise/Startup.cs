namespace TupleExercise
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var nameAddress = Console.ReadLine().Split();
            var fullName = $"{nameAddress[0]} {nameAddress[1]}";
            var address = nameAddress[2];
            var nameTuple = new Tuple<string, string>(fullName, address);
            Console.WriteLine(nameTuple);

            var nameBeer = Console.ReadLine().Split();
            var name = nameBeer[0];
            var beerAmount = int.Parse(nameBeer[1]);
            var beerTuple = new Tuple<string, int>(name, beerAmount);
            Console.WriteLine(beerTuple);

            var intDouble = Console.ReadLine().Split();
            var intValue = int.Parse(intDouble[0]);
            var doubleValue = double.Parse(intDouble[1]);
            var intDoubleTuple = new Tuple<int, double>(intValue, doubleValue);
            Console.WriteLine(intDoubleTuple);
        }
    }
}

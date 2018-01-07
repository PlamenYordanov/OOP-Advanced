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
            var town = nameAddress[3];
            var nameTuple = new Tuple<string, string, string>(fullName, address, town);
            Console.WriteLine(nameTuple);

            var nameBeer = Console.ReadLine().Split();
            var name = nameBeer[0];
            var beerAmount = int.Parse(nameBeer[1]);
            bool isDrunk = nameBeer[2] == "drunk" ? true : false;
            var beerTuple = new Tuple<string, int, bool>(name, beerAmount, isDrunk);
            Console.WriteLine(beerTuple);

            var nameBalanceBank = Console.ReadLine().Split();
            var accountHolder = nameBalanceBank[0];
            var balance = double.Parse(nameBalanceBank[1]);
            var bankName = nameBalanceBank[2];
            var bankInfo = new Tuple<string, double, string>(accountHolder, balance, bankName);
            Console.WriteLine(bankInfo);
        }
    }
}

namespace StupidExercise
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        
        public static void Main()
        {
            List<Citizen> citizens = new List<Citizen>();
            string input = string.Empty;
            while((input = Console.ReadLine()) != "End")
            {
                var tokens = input.Split();
                var name = tokens[0];
                var country = tokens[1];
                var age = int.Parse(tokens[2]);
                var person = new Citizen(name, age, country);
                citizens.Add(person);
            }
            foreach (var citizen in citizens)
            {
                var person = (IPerson)citizen;
                var resident = (IResident)citizen;
                Console.WriteLine(person.GetName());
                Console.WriteLine(resident.GetName());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace ComparingObjects
{
    public class Startup
    {
        public static void Main()
        {
            string input = string.Empty;
            var people = new List<Person>();
            while ((input = Console.ReadLine()) != "END")
            {
                var personData = input.Split();
                var name = personData[0];
                var age = int.Parse(personData[1]);
                var town = personData[2];
                var person = new Person(name, age, town);
                people.Add(person);
            }
            var personIndex = int.Parse(Console.ReadLine());
            var personToCompare = people[personIndex - 1];

            int equalPeople = people.Where(x => x.Equals(personToCompare)).Count();
            int notEqualPeople = people.Where(x => !x.Equals(personToCompare)).Count();
            string result = equalPeople == 1 ? "No matches" : FormatPeople(equalPeople, notEqualPeople);
            Console.WriteLine(result);
        }

        private static string FormatPeople(int equalPeople, int notEqualPeople)
        {
            int equalPeopleCount = equalPeople;
            int notEqualPeopleCount = notEqualPeople;
            int totalPeople = equalPeopleCount + notEqualPeopleCount;
            return $"{equalPeopleCount} {notEqualPeopleCount} {totalPeople}";
        }
    }
}

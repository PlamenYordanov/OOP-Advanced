using System;
using System.Collections.Generic;

namespace StrategyPattern
{
    public class Startup
    {
        public static void Main()
        {
            var uniquePeople = new HashSet<Person>();
            var sortedUniquePeople = new SortedSet<Person>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();
                string name = input[0];
                int age = int.Parse(input[1]);
                var person = new Person(name, age);
                uniquePeople.Add(person);
                sortedUniquePeople.Add(person);
            }
            Console.WriteLine(uniquePeople.Count);
            Console.WriteLine(sortedUniquePeople.Count);
        }

        

        private static void PrintPeople(ISet<Person> people)
        {
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }

       
    }
}

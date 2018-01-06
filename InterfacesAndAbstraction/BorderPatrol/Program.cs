namespace BorderPatrol
{
    using BorderPatrol.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {

            int numberOfPeople = int.Parse(Console.ReadLine());
            var entrants = new List<Citizen>();

            for (int i = 0; i < numberOfPeople; i++)
            {
                var input = Console.ReadLine().Split().ToArray();

                if (input.Length == 3)
                {
                    AddRebelsToList(entrants, input);
                }
                else
                {
                    AddHumanToList(entrants, input);
                }
            }
            string name = string.Empty;

            while ((name = Console.ReadLine()) != "End")
            {
                var buyer = entrants.SingleOrDefault(b => b.Name.Equals(name));

                if (buyer == null)
                {
                    continue;
                }

                buyer.BuyFood();
            }
            var totalFood = entrants.Sum(e => e.Food);
            Console.WriteLine(totalFood);
        }

        private static void AddRebelsToList(List<Citizen> entrants, string[] input)
        {
            string name = input[0];
            int age = int.Parse(input[1]);
            string group = input[2];
            var rebel = new Rebel(name, age, group);
            entrants.Add(rebel);
        }

        private static void PrintCitizensByBirthday(List<IBirthable> citizensAndPets, string yearToSelectFrom)
        {
            foreach (var citizen in citizensAndPets)
            {
                if (citizen.Birthday.EndsWith(yearToSelectFrom))
                {
                    Console.WriteLine(citizen.Birthday);
                }
            }
        }

        private static void AddPetToList(List<IBirthable> citizensAndPets, string[] tokens)
        {
            string name = tokens[1];
            string birthday = tokens[2];
            var pet = new Pet(name, birthday);
            citizensAndPets.Add(pet);
        }

        private static void PrintInvalidCitizens(List<IIdentifiable> citizens, string fakeId)
        {
            foreach (var citizen in citizens)
            {
                if (citizen.Id.EndsWith(fakeId))
                {
                    Console.WriteLine(citizen.Id);
                }
            }
        }

        private static void AddHumanToList(List<Citizen> citizens, string[] tokens)
        {
            string name = tokens[0];
            int age = int.Parse(tokens[1]);
            string id = tokens[2];
            string birthday = tokens[3];
            
            var human = new Human(id, name, age, birthday);
            citizens.Add(human);
        }

        private static void AddRobotToList(List<IIdentifiable> citizens, string[] tokens)
        {
            string model = tokens[1];
            string id = tokens[2];
            var citizen = new Robot(id, model);
            citizens.Add(citizen);
        }
    }
}

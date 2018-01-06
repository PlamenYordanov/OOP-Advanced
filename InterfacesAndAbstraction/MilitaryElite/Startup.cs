namespace MilitaryElite
{
    using MilitaryElite.AbstractSoldiers;
    using MilitaryElite.Interfaces;
    using MilitaryElite.MainFigures;
    using MilitaryElite.SecondaryClasses;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            string input = string.Empty;
            var soldiers = new List<Soldier>();

            while ((input= Console.ReadLine()) != "End")
            {
                var soldierData = input.Split(' ');
                string soldierType = soldierData[0];

                switch (soldierType)
                {
                    case "Private":
                        AddPrivateToList(soldiers, soldierData);
                        break;
                    case "LeutenantGeneral":
                        AddLeutenantGeneralToList(soldiers, soldierData);
                        break;
                    case "Engineer":
                        AddEngineerToList(soldiers, soldierData);
                        break;
                    case "Commando":
                        AddCommandoToList(soldiers, soldierData);
                        break;
                    case "Spy":
                        AddSpyToList(soldiers, soldierData);
                        break;
                    default:
                        break;
                }
            }
            foreach (var soldier in soldiers)
            {
                switch (soldier)
                {
                    case Commando c:
                        Console.WriteLine(c.ToString());
                        break;
                    case Engineer e:
                        Console.WriteLine(e.ToString());
                        break;
                    case LeutenantGeneral lg:
                        Console.WriteLine(lg.ToString());
                        break;
                    case Spy s:
                        Console.WriteLine(s.ToString());
                        break;
                    case Private p:
                        Console.WriteLine(p);
                        break;
                    default:
                        break;
                }
            }
            
        }

        private static void AddSpyToList(List<Soldier> soldiers, string[] soldierData)
        {
            int id = int.Parse(soldierData[1]);
            string firstName = soldierData[2];
            string lastName = soldierData[3];
            int codeNumber = int.Parse(soldierData[4]);
            var spy = new Spy(id, firstName, lastName, codeNumber);
            soldiers.Add(spy);
        }

        private static void AddCommandoToList(List<Soldier> soldiers, string[] soldierData)
        {
            GetIdNameAndSalary(soldierData, out int id, out string firstName, out string lastName, out double salary);
            string corps = soldierData[5];
            var missions = new List<Mission>();
            for (int i = 6; i < soldierData.Length; i += 2)
            {
                string codeName = soldierData[i];
                string state = soldierData[i + 1];
                if (!IsValidMission(state))
                {
                    continue;
                }
                var mission = new Mission(codeName, state);
                missions.Add(mission);
            }
            var commando = new Commando(id, firstName, lastName, salary, corps, missions);
            soldiers.Add(commando);
        }

        private static void AddEngineerToList(List<Soldier> soldiers, string[] soldierData)
        {
            GetIdNameAndSalary(soldierData, out int id, out string firstName, out string lastName, out double salary);
            string corps = soldierData[5];
            if(IsValidCorps(corps))
            {
                var repairs = new List<Repair>();
                for (int i = 6; i < soldierData.Length; i += 2)
                {
                    var partName = soldierData[i];
                    var hoursWorked = int.Parse(soldierData[i + 1]);
                    var repair = new Repair(partName, hoursWorked);
                    repairs.Add(repair);
                }
                var engineer = new Engineer(id, firstName, lastName, salary, corps, repairs);
                soldiers.Add(engineer);
            }
            
        }

        private static void AddLeutenantGeneralToList(List<Soldier> soldiers, string[] soldierData)
        {
            GetIdNameAndSalary(soldierData, out int id, out string firstName, out string lastName, out double salary);
            var privates = new List<Private>();
            for (int i = 5; i < soldierData.Length; i++)
            {

                int currentId = int.Parse(soldierData[i]);
                var currentPrivate = (Private)soldiers.SingleOrDefault(s => s.Id.Equals(currentId));
                privates.Add(currentPrivate);
            }
            var leutenantGeneral = new LeutenantGeneral(id, firstName, lastName, salary, privates);
            soldiers.Add(leutenantGeneral);
        }

        private static void AddPrivateToList(List<Soldier> soldiers, string[] soldierData)
        {
            GetIdNameAndSalary(soldierData, out int id, out string firstName, out string lastName, out double salary);
            var privateSoldier = new Private(id, firstName, lastName, salary);
            soldiers.Add(privateSoldier);
        }

        private static void GetIdNameAndSalary(string[] soldierData, out int id, out string firstName, out string lastName, out double salary)
        {
            id = int.Parse(soldierData[1]);
            firstName = soldierData[2];
            lastName = soldierData[3];
            salary = double.Parse(soldierData[4]);
        }

        private static bool IsValidCorps(string corps)
        {
            bool isValid = corps == "Airforces" || corps == "Marines";
            return isValid;
        }

        private static bool IsValidMission(string mission)
        {
            bool isValid = mission == "inProgress" || mission == "Finished";
            return isValid;
        }
    }
}

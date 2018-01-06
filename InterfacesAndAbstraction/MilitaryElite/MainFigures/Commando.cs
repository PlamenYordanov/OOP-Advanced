using System.Collections.Generic;
using MilitaryElite.AbstractSoldiers;
using MilitaryElite.Interfaces;
using MilitaryElite.SecondaryClasses;
using System;
using System.Text;

namespace MilitaryElite.MainFigures
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(int id, string firstName, string lastName, double salary, string corps, IList<Mission> missions)
            : base(id, firstName, lastName, salary, corps)
        {
            this.Missions = new List<Mission>();
            this.Missions.AddRange(missions);

        }

        public List<Mission> Missions { get; set; }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + PrintMissions();
        }

        private string PrintMissions()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Missions:");

            foreach (var mission in this.Missions)
            {
                sb.AppendLine($"  {mission.ToString()}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}

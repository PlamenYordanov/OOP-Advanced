using System.Collections.Generic;
using MilitaryElite.AbstractSoldiers;
using MilitaryElite.Interfaces;
using System;
using System.Text;
using MilitaryElite.SecondaryClasses;

namespace MilitaryElite.MainFigures
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(int id, string firstName, string lastName, double salary, string corps, IList<Repair> repairs)
            : base(id, firstName, lastName, salary, corps)
        {
            
            this.Repairs = new List<IRepair>();
            this.Repairs.AddRange(repairs);
        }
        

        public List<IRepair> Repairs { get; set; }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + PrintRepairs();
        }

        private string PrintRepairs()
        {
            var sb = new StringBuilder();

            sb.AppendLine($"Repairs:");

            foreach (var repair in this.Repairs)
            {
                sb.AppendLine($"  {repair.ToString()}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}

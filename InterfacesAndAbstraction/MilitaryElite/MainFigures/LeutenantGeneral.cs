using System.Collections.Generic;
using MilitaryElite.Interfaces;
using System;
using System.Text;

namespace MilitaryElite.MainFigures
{
    public class LeutenantGeneral : Private, ILeutenantGeneral
    {
        public LeutenantGeneral(int id, string firstName, string lastName, double salary, IList<Private> privates) 
            : base(id, firstName, lastName, salary)
        {
            this.Privates = new List<IPrivate>();

            this.Privates.AddRange(privates);
        }

        public List<IPrivate> Privates { get; set; }

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + PrintSoldiers();
        }

        private string PrintSoldiers()
        {
            var sb = new StringBuilder();

            sb.AppendLine("Privates:");

            foreach (var soldier in this.Privates)
            {
                sb.AppendLine($"  {soldier.ToString()}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}

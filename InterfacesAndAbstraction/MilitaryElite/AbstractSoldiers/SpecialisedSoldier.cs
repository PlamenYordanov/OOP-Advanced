using MilitaryElite.MainFigures;
using System;

namespace MilitaryElite.AbstractSoldiers
{
    public abstract class SpecialisedSoldier : Private
    {
        
        public SpecialisedSoldier(int id, string firstName, string lastName, double salary, string corps)
            : base(id, firstName, lastName, salary)
        {
            Corps = corps;
        }

        //private string corps;
        
        public string Corps { get; set; }
        //{
        //    set
        //    {
        //        if(value == "Airforces" || value == "Marines")
        //        {
        //            this.corps = value;
        //        }
                
        //    }
        //    get { return this.corps; }

        //}

        public override string ToString()
        {
            return base.ToString() + Environment.NewLine + $"Corps: {this.Corps}";
        }
    }
}

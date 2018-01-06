using MilitaryElite.Interfaces;

namespace MilitaryElite.SecondaryClasses
{
    public class Repair : IRepair
    {
        public Repair(string partName, int hoursWorked)
        {
            this.HoursWorked = hoursWorked;
            this.PartName = partName;
        }
        public string PartName { get; set; }
                               
        public int HoursWorked { get; set; }

        public override string ToString()
        {
            return $"Part Name: {this.PartName} Hours Worked: {this.HoursWorked}";
        }
    }
}

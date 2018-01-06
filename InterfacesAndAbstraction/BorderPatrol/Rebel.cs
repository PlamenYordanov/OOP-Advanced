
namespace BorderPatrol
{
    using BorderPatrol.Contracts;

    public class Rebel : Citizen, IBuyer, IGroupable
    {

        public Rebel(string name, int age, string group)
            :base(name, age)
        {
            
            this.Group = group;
        }

        public string Group { get; set; }

    }
}

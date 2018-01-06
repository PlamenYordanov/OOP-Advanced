namespace BorderPatrol.Contracts
{
    public abstract class Citizen : INamable, IAgable, IBuyer
    {
        public Citizen(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public string Name { get; set; }

        public int Age { get; set; }

        public int Food { get; set; } = 0;

        public virtual void BuyFood()
        {
            this.Food += 5;
        }
    }
}

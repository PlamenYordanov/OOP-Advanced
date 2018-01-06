namespace BorderPatrol
{
    using System;
    using BorderPatrol.Contracts;

    public class Human : Citizen, IIdentifiable, IBirthable, IBuyer
    {

        public Human(string id, string name, int age, string birthday)
            :base(name, age)
        {
            this.Id = id;
            this.Birthday = birthday;
        }

        public string Id { get; set; }

        public string Birthday { get; set; }

        public override void BuyFood()
        {
            this.Food += 10;
        }
    }
}

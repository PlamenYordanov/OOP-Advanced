using System;
using BorderPatrol.Contracts;

namespace BorderPatrol
{
    public class Pet : INamable, IBirthable
    {

        public Pet(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }
        public string Name { get; set; }

        public string Birthday { get; set; }
    }
}

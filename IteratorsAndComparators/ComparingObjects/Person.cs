
namespace ComparingObjects
{
    using System;

    public class Person : IComparable<Person>
    {
        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }
        public string Name { get; set; }

        public int Age { get; set; }

        public string Town { get; set; }

        public int CompareTo(Person other)
        {
            if (this.Name != other.Name)
            {
                return this.Name.CompareTo(other.Name);
            }
            if (this.Age != other.Age)
            {
                return this.Age.CompareTo(other.Age);
            }
            return this.Town.CompareTo(other.Town);

        }

        public bool Equals(Person other)
        {
            return this.Name == other.Name &&
                this.Age == other.Age &&
                    this.Town == other.Town;
        }

        

        public override string ToString()
        {
            return $"{this.Name} - {this.Age} - {this.Town}";
        }
    }
}

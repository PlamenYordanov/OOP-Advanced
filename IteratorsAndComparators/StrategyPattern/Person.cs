using System;

namespace StrategyPattern
{
    public class Person : IComparable<Person>
    {
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;

        }
        public string Name { get; set; }

        public int Age { get; set; }

        public override bool Equals(object obj)
        {
            var person = (Person)obj;
            
            return this.Name == person.Name &&
                this.Age == person.Age;
        }
        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }
        public override int GetHashCode()
        {
            return this.Name.GetHashCode() * 17 + this.Age.GetHashCode();
        }

        public int CompareTo(Person other)
        {
            if (this.Name != other.Name)
            {
                return this.Name.CompareTo(other.Name);

            }
            return this.Age.CompareTo(other.Age);
        }
    }
}

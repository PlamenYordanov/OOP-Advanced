using System;

namespace CardSuit
{
    [AttributeUsage(AttributeTargets.Enum, AllowMultiple = true)]
    public class TypeAttribute : Attribute
    {
        public TypeAttribute(string category)
        {
            this.Category = category;
        }
        public string Type { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }
    }
}

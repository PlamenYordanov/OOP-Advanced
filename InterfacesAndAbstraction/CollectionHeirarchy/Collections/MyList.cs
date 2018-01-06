using CollectionHeirarchy.Interfaces;
using System.Collections.Generic;

namespace CollectionHeirarchy.Collections
{
    public class MyList : AbstractCollection, IMyList
    {


        public int Add(string itemToAdd)
        {
            this.list.Insert(0, itemToAdd);
            return 0;
        }

        public string Remove()
        {
            var firstElement = this.list[0];
            this.list.RemoveAt(0);
            return firstElement;
        }

        public int Used()
        {
            return this.list.Count;
        }
    }
}

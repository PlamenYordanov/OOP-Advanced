using CollectionHeirarchy.Interfaces;

namespace CollectionHeirarchy.Collections
{
    using System.Collections.Generic;
    using System.Linq;

    public class AddRemoveCollection : AbstractCollection, IAddable, IRemovable
    {

        public int Add(string itemToAdd)
        {
            this.list.Insert(0, itemToAdd);
            return 0;
        }

        public string Remove()
        {
            var lastIndexOfList = this.list.Count - 1;
            var lastElement = this.list[lastIndexOfList];
            this.list.RemoveAt(lastIndexOfList);
            return lastElement;
        }
    }
}

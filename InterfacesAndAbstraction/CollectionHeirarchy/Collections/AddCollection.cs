using CollectionHeirarchy.Interfaces;

namespace CollectionHeirarchy.Collections
{
    using System.Collections.Generic;

    public class AddCollection : AbstractCollection, IAddable
    {

        public int Add(string itemToAdd)
        {
            this.list.Add(itemToAdd);
            var indexOfItem = list.LastIndexOf(itemToAdd);
            return indexOfItem;
        }
    }
}

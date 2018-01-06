namespace CollectionHeirarchy.Collections
{
    using System.Collections.Generic;

    public class AbstractCollection
    {
        const int listSize = 100;

        protected List<string> list = new List<string>(listSize);
    }
}

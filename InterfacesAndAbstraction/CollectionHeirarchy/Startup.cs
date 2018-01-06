namespace CollectionHeirarchy
{
    using CollectionHeirarchy.Collections;
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            var addCollection = new AddCollection();
            var addRemoveCollection = new AddRemoveCollection();
            var myList = new MyList();

            var input = Console.ReadLine().Split(' ');
            var removeCount = int.Parse(Console.ReadLine());

            foreach (var item in input)
            {
                Console.Write(addCollection.Add(item) + " " );
            }
            Console.WriteLine();
            foreach (var item in input)
            {
                Console.Write(addRemoveCollection.Add(item) + " ");
            }
            Console.WriteLine();
            foreach (var item in input)
            {
                Console.Write(myList.Add(item) + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < removeCount; i++)
            {
                Console.Write(addRemoveCollection.Remove() + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < removeCount; i++)
            {
                Console.Write(myList.Remove() + " ");
            }

        }
    }
}

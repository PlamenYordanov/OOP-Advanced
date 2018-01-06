namespace Telephony
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().ToList();
            var urls = Console.ReadLine().Split().ToList();
            var phone = new Smartphone(numbers, urls);

            Console.WriteLine(phone.CallNumbers);
            Console.WriteLine(phone.BrowseUrls);
        }
    }
}

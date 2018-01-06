namespace GenericBoxOfString
{
    using System;

    public class Startup
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string str = string.Empty;

            for (int i = 0; i < n; i++)
            {
                str = Console.ReadLine();
                var box = new Box<string>(str);
                Console.WriteLine(box);
            }
        }
    }
}

using System;

namespace FerrariExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string driver = Console.ReadLine();

            var ferrari = new Ferrari(driver);

            Console.WriteLine($"{ferrari.Model}/{ferrari.UseBrakes}/{ferrari.PushGasPedal}/{ferrari.Driver}");
        }
    }
}

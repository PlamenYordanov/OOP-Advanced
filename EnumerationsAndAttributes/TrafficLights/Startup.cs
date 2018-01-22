
using System;

namespace TrafficLights
{
    public class Startup
    {
        public static void Main()
        {
            var inputTokens = Console.ReadLine().Split();
            int n = int.Parse(Console.ReadLine());
            var numberOfTokens = inputTokens.Length;
            var lights = new State[numberOfTokens];
            PopulateLights(inputTokens, numberOfTokens, lights);
            for (int i = 0; i < n; i++)
            {
                UpdateState(lights);
                Console.WriteLine(string.Join(" ", lights));
            }

        }

        private static void PopulateLights(string[] inputTokens, int numberOfTokens, State[] lights)
        {
            for (int i = 0; i < numberOfTokens; i++)
            {
                var state = (State)Enum.Parse(typeof(State), inputTokens[i]);
                lights[i] = state;
            }
        }
        private static void UpdateState(State[] lights)
        {
            for (int i = 0; i < lights.Length ; i++)
            {
                int currentIndex = (int)++lights[i];
                currentIndex %= 3;
                State state = (State)currentIndex;
                lights[i] = state;
            }
        }
    }
}

namespace TrafficLights
{
    public class TrafficLight
    {
        public State PreviousState { get; set; }

        public State CurrentState { get; set; }

        public State NextState { get; set; }

        public TrafficLight(State previous, State current, State next)
        {
            this.PreviousState = previous;
            this.CurrentState = current;
            this.NextState = next;
        }
    }
}

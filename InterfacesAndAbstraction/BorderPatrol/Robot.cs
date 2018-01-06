namespace BorderPatrol
{
    using BorderPatrol.Contracts;

    public class Robot : IIdentifiable, IRobot
    {
        public Robot(string id, string model)
        {
            this.Id = id;
            this.Model = model; 
        }

        public string Id { get; set; }

        public string Model { get; set; }
    }
}

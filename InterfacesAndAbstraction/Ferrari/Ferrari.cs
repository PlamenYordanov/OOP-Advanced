namespace FerrariExercise
{
    public class Ferrari : ICar
    {
        public Ferrari(string driver)
        {
            this.Driver = driver;
        }
        public string Model => "488-Spider";

        public string Driver { get; set; }

        public string UseBrakes => "Brakes!";

        public string PushGasPedal => "Zadu6avam sA!";
        
    }
}

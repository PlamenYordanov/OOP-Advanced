namespace MilitaryElite.SecondaryClasses
{
    public class Mission
    {
        public Mission(string codeName, string state)
        {
            
            this.State = state;
            this.CodeName = codeName;
        }
       

        public string  CodeName { get; set; }
        //private string state;

        public string State { get; set; }
        //{
        //    get
        //    {
        //        return this.state;
        //    }
        //    set
        //    {
        //        if (value == "inProgress" || value == "Finished")
        //        {
        //            this.state = value;
        //        }
        //    }
        //}

        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.State}";
        }
    }
}

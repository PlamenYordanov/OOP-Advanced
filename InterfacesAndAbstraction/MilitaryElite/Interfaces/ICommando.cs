namespace MilitaryElite.Interfaces
{
    using MilitaryElite.SecondaryClasses;
    using System.Collections.Generic;

    public interface ICommando
    {
        List<Mission> Missions { get; }

    }
}

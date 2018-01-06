﻿namespace MilitaryElite.Interfaces
{
    using System.Collections.Generic;

    public interface IEngineer
    {
        List<IRepair> Repairs { get; }
    }
}

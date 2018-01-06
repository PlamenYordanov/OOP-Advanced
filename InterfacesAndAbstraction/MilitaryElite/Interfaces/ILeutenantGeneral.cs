namespace MilitaryElite.Interfaces
{
    using System.Collections.Generic;

    public interface ILeutenantGeneral
    {
        List<IPrivate> Privates { get; }
    }
}

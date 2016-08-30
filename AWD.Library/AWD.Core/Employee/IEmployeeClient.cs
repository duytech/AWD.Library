namespace AWD.Core.Employee
{
    using System.Collections.Generic;
    public interface IEmployeeClient
    {
        IList<AW.Library.Models.Employee> Get();
    }
}

namespace AWD.Library.Console
{
    using Core;
    class Program
    {
        static void Main(string[] args)
        {
            var config = new ApiConfig();
            config.BaseUrl = @"http://localhost/AW.WebAPI/odata";

            var emp = new EmployeeParser(config);
            var employee = emp.GetEmployee();
        }
    }
}

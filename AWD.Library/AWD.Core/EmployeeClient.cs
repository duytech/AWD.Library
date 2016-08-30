namespace AWD.Core
{
    using RestSharp;
    using AW.Library.Models;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System;
    using System.Xml;
    using Employee;

    public class EmployeeClient : IEmployeeClient
    {
        private ApiConfig config;

        public EmployeeClient(ApiConfig config)
        {
            this.config = config;
        }
        public IList<AW.Library.Models.Employee> Get()
        {
            var client = new RestClient(config.BaseUrl);

            var request = new RestRequest("Employees", Method.GET);

            // async with deserialization
            var payloadRes = client.Execute<OdataPayload>(request);

            var employee = JsonConvert.DeserializeObject<IList<AW.Library.Models.Employee>>(payloadRes.Data.Value);

            return employee;
        }
    }
}

namespace AWD.Core
{
    using RestSharp;
    using AW.Library.Models;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using System;
    using System.Xml;

    public class EmployeeParser
    {
        private ApiConfig config;

        public EmployeeParser(ApiConfig config)
        {
            this.config = config;
        }
        public IList<Employee> GetEmployee()
        {
            var client = new RestClient(config.BaseUrl);

            var request = new RestRequest("Employees", Method.GET);

            // async with deserialization
            var payloadRes = client.Execute<OdataPayload>(request);

            var employee = JsonConvert.DeserializeObject<IList<Employee>>(payloadRes.Data.Value);

            return employee;
        }
    }
}

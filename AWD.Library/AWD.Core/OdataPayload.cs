namespace AWD.Core
{
    using Newtonsoft.Json;
    public class OdataPayload
    {
        [JsonProperty("odata.metadata")]
        public string Metadata { get; set; }
        public string Value { get; set; }
    }
}

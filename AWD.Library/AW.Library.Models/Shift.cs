namespace AW.Library.Models
{
    using AWD.Core;
    using Newtonsoft.Json;
    using System;
    public class Shift
    {
        public byte ShiftID { get; set; }
        public string Name { get; set; }
        [JsonConverter(typeof(TimespanObjectConverter))]
        public TimeSpan StartTime { get; set; }
        [JsonConverter(typeof(TimespanObjectConverter))]
        public TimeSpan EndTime { get; set; }
    }
}

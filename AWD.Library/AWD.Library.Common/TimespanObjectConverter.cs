namespace AWD.Core
{
    using System;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using System.Xml;

    public class TimespanObjectConverter : JsonConverter
    {
        public override bool CanConvert(Type objectType)
        {
            return true;
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var value = JToken.Load(reader);
            TimeSpan ts = XmlConvert.ToTimeSpan(value.ToString());

            return ts;
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }
    }
}

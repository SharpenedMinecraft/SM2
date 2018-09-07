using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace SM2.CodeGenerator
{
    public partial class JsonBlocks
    {
        public static Dictionary<string, JsonBlock> FromJson(string json) => JsonConvert.DeserializeObject<Dictionary<string, JsonBlock>>(json, Converter.Settings);
    }

    public class JsonBlock
    {
        [JsonProperty("states")]
        public State[] States { get; set; }
        [JsonProperty("properties")]
        public Dictionary<string, string[]> Properties { get; set; }
    }

    public class State
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("properties")]
        public Dictionary<string, string> Properties { get; set; }
        [JsonProperty("default", NullValueHandling = NullValueHandling.Include)]
        public bool? Default { get; set; }
    }

    public static class Serialize
    {
        public static string ToJson(this Dictionary<string, JsonBlock> self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    internal static class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
            Converters = {
                new IsoDateTimeConverter { DateTimeStyles = DateTimeStyles.AssumeUniversal }
            },
        };
    }
}

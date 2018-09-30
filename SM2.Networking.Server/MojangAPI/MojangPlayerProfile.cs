namespace SM2.MojangAPI
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using J = Newtonsoft.Json.JsonPropertyAttribute;
    using R = Newtonsoft.Json.Required;
    using N = Newtonsoft.Json.NullValueHandling;

    public partial class MojangPlayerProfile
    {
        [J("id", NullValueHandling = N.Ignore)] public string Id { get; set; }
        [J("name", NullValueHandling = N.Ignore)] public string Name { get; set; }
        [J("properties", NullValueHandling = N.Ignore)] public List<Property> Properties { get; set; }
    }

    public partial class Property
    {
        [J("name", NullValueHandling = N.Ignore)] public string Name { get; set; }
        [J("value", NullValueHandling = N.Ignore)] public string Value { get; set; }
        [J("signature", NullValueHandling = N.Ignore)] public string Signature { get; set; }
    }

    public partial class MojangPlayerProfile
    {
        public static MojangPlayerProfile FromJson(string json) => JsonConvert.DeserializeObject<MojangPlayerProfile>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this MojangPlayerProfile self) => JsonConvert.SerializeObject(self, Converter.Settings);
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

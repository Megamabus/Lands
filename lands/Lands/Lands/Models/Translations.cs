namespace Lands.Models
{
    using Newtonsoft.Json;
    public class Translations
    {
        [JsonProperty(PropertyName = "germany")]
        public string Germany { get; set; }

        [JsonProperty(PropertyName = "spanish")]
        public string Spanish { get; set; }

        [JsonProperty(PropertyName = "french")]
        public string French { get; set; }

        [JsonProperty(PropertyName = "japanese")]
        public string Japanese { get; set; }

        [JsonProperty(PropertyName = "italian")]
        public string Italian { get; set; }

        [JsonProperty(PropertyName = "brazilian")]
        public string Brazilian { get; set; }

        [JsonProperty(PropertyName = "portuges")]
        public string Portuges { get; set; }

        [JsonProperty(PropertyName = "dutch")]
        public string Dutch { get; set; }

        [JsonProperty(PropertyName = "croatian")]
        public string Croatian { get; set; }

        [JsonProperty(PropertyName = "danish")]
        public string Danish { get; set; }
    }
}

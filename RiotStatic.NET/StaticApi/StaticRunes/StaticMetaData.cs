using Newtonsoft.Json;

namespace RiotStatic.StaticApi.StaticRunes
{
    public class StaticMetaData
    {
        [JsonProperty("tier")]
        public string Tier { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("isRune")]
        public bool IsRune { get; set; }
    }
}
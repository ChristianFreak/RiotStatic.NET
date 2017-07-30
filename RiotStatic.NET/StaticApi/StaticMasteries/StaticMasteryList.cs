using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotStatic.StaticApi.StaticMasteries
{
    public class StaticMasteryList
    {
        [JsonProperty("data")]
        public Dictionary<string, StaticMastery> Data { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("tree")]
        public StaticMasteryTree Tree { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

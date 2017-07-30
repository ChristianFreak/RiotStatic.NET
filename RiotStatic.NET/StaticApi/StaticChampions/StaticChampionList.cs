using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotStatic.StaticApi.StaticChampions
{
    public class StaticChampionList
    {
        [JsonProperty("keys")]
        public Dictionary<string, string> Keys { get; set; }

        [JsonProperty("data")]
        public Dictionary<string, StaticChampion> Data { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("format")]
        public string Format { get; set; }
    }
}

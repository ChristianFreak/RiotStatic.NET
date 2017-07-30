using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotStatic.StaticApi.StaticRunes
{
    public class StaticRuneList
    {
        [JsonProperty("data")]
        public Dictionary<string, StaticRune> Data { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

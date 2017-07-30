using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotStatic.StaticApi.StaticChampions
{
    public class StaticBlock
    {
        [JsonProperty("items")]
        public List<StaticBlockItem> Items { get; set; }

        [JsonProperty("recMath")]
        public bool RecMath { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
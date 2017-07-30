using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotStatic.StaticApi.StaticMasteries
{
    public class StaticMasteryTree
    {
        [JsonProperty("Resolve")]
        public List<StaticMasteryTreeList> Resolve { get; set; }

        [JsonProperty("Ferocity")]
        public List<StaticMasteryTreeList> Ferocity { get; set; }

        [JsonProperty("Cunning")]
        public List<StaticMasteryTreeList> Cunning { get; set; }
    }
}
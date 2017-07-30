using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotStatic.StaticApi.StaticMasteries
{
    public class StaticMasteryTreeList
    {
        [JsonProperty("masteryTreeItems")]
        public List<StaticMasteryTreeItem> MasteryTreeItems { get; set; }
    }
}
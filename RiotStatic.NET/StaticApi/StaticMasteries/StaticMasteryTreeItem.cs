using Newtonsoft.Json;

namespace RiotStatic.StaticApi.StaticMasteries
{
    public class StaticMasteryTreeItem
    {
        [JsonProperty("masteryId")]
        public int MasteryId { get; set; }

        [JsonProperty("prereq")]
        public string Prereq { get; set; }
    }
}
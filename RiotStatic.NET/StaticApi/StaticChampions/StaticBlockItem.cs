using Newtonsoft.Json;

namespace RiotStatic.StaticApi.StaticChampions
{
    public class StaticBlockItem
    {
        [JsonProperty("count")]
        public int Count { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
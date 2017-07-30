using Newtonsoft.Json;

namespace RiotStatic.StaticApi.StaticChampions
{
    public class StaticPassive
    {
        [JsonProperty("image")]
        public StaticImage Image { get; set; }

        [JsonProperty("sanitizedDescription")]
        public string SanitizedDescription { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
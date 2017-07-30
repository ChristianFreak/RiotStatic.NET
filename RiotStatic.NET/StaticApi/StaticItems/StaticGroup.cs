using Newtonsoft.Json;

namespace RiotStatic.StaticApi.StaticItems
{
    public class StaticGroup
    {
        [JsonProperty("MaxGroupOwnable")]
        public string MaxGroupOwnable { get; set; }

        [JsonProperty("key")]
        public string Key { get; set; }
    }
}
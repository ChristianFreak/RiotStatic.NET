using Newtonsoft.Json;

namespace RiotStatic.StaticApi.StaticItems
{
    public class StaticGold
    {
        [JsonProperty("sell")]
        public int Sell { get; set; }

        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("base")]
        public int Base { get; set; }

        [JsonProperty("purchaseable")]
        public bool Purchaseable { get; set; }
    }
}
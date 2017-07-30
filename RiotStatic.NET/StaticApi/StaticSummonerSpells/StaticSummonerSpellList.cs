using Newtonsoft.Json;
using System.Collections.Generic;

namespace RiotStatic.StaticApi.StaticSummonerSpells
{
    public class StaticSummonerSpellList
    {
        [JsonProperty("data")]
        public Dictionary<string, StaticSummonerSpell> Data { get; set; }

        [JsonProperty("version")]
        public string Version { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

﻿using Newtonsoft.Json;

namespace RiotStatic.StaticApi.StaticChampions
{
    public class StaticInfo
    {
        [JsonProperty("difficulty")]
        public int Difficulty { get; set; }

        [JsonProperty("attack")]
        public int attack { get; set; }

        [JsonProperty("defense")]
        public int defense { get; set; }

        [JsonProperty("magic")]
        public int magic { get; set; }
    }
}
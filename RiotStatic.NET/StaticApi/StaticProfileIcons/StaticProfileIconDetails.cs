using Newtonsoft.Json;

namespace RiotStatic.StaticApi.StaticProfileIcons
{
    public class StaticProfileIconDetails
    {
        [JsonProperty("image")]
        public StaticImage Image { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }
    }
}
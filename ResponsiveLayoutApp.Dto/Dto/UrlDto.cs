using Newtonsoft.Json;

namespace ResponsiveLayoutAppDto.Dto
{
    public class UrlDto
    {
        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }
}

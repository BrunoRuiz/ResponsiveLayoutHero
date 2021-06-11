using Newtonsoft.Json;

namespace ResponsiveLayoutAppDto.Dto
{
    public class ThumbnailDto
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("extension")]
        public string Extension { get; set; }

    }
}

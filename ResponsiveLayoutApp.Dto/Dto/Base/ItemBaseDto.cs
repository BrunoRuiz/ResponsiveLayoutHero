using Newtonsoft.Json;

namespace ResponsiveLayoutAppDto.Dto.Base
{
    public class ItemBaseDto
    {
        [JsonProperty("resourceURI")]
        public string ResourceURI { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}

using Newtonsoft.Json;
using ResponsiveLayoutAppDto.Dto.Base;

namespace ResponsiveLayoutAppDto.Dto
{
    public class ItemDto : ItemBaseDto
    {
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}

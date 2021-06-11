using System.Collections.Generic;
using Newtonsoft.Json;
using ResponsiveLayoutAppDto.Dto.Base;

namespace ResponsiveLayoutAppDto.Dto
{
    public class CommonDto
    {
        [JsonProperty("available")]
        public int Available { get; set; }

        [JsonProperty("collectionURI")]
        public string CollectionURI { get; set; }

        [JsonProperty("items")]
        public IList<ItemBaseDto> Items { get; set; }

        [JsonProperty("Returned")]
        public int Returned { get; set; }
    }
}

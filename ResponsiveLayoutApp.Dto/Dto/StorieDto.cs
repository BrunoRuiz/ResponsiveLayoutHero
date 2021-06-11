using System.Collections.Generic;
using Newtonsoft.Json;

namespace ResponsiveLayoutAppDto.Dto
{
    public class StorieDto
    {
        [JsonProperty("available")]
        public int Available { get; set; }

        [JsonProperty("collectionURI")]
        public string CollectionURI { get; set; }

        [JsonProperty("items")]
        public IList<ItemDto> Items { get; set; }

        [JsonProperty("Returned")]
        public int Returned { get; set; }

    }
}

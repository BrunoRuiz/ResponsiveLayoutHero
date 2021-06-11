using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace ResponsiveLayoutAppDto.Dto
{
    
    public class ResultDto
    {
        [JsonProperty("id")]
        public int ID { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("modified")]
        public string Modified { get; set; }

        [JsonProperty("thumbnail")]
        public ThumbnailDto Thumbnail { get; set; }

        [JsonProperty("resourceURI")]
        public string ResourceURI { get; set; }

        [JsonProperty("comics")]
        public CommonDto Comics { get; set; }

        [JsonProperty("series")]
        public CommonDto Series { get; set; }

        [JsonProperty("stories")]
        public StorieDto Stories { get; set; }

        [JsonProperty("events")]
        public CommonDto Events { get; set; }

        [JsonProperty("urls")]
        public IList<UrlDto> Urls { get; set; }
        
    }
}

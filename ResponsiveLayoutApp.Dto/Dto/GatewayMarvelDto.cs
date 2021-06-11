using Newtonsoft.Json;

namespace ResponsiveLayoutAppDto.Dto
{
    public class GatewayMarvelDto
    {
        [JsonProperty("code")]
        public int Code { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("copyright")]
        public string Copyright { get; set; }

        [JsonProperty("attributionText")]
        public string AttributionText { get; set; }

        [JsonProperty("attributionHTML")]
        public string AttributionHTML { get; set; }

        [JsonProperty("data")]
        public DataDto Data { get; set; }

        [JsonProperty("etag")]
        public string Etag { get; set; }
    }

}

using System;
using Refit;

namespace ResponsiveLayoutApp.Services
{
    public class ApiServiceParams
    {
       
        private string PrivateKey => "bc4acd9e9cad1e7755701775327a9592bff5c477";

        [AliasAs("apikey")]
        public string PublicKey => "8605b5601c71eeac0256f6d41f26e54a";

        [AliasAs("ts")]
        public string TimeStamp => new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds().ToString();

        [AliasAs("hash")]
        public string HashKey => ApiServiceSecurity.GetMd5Hash(TimeStamp + PrivateKey + PublicKey);
    
    }
}

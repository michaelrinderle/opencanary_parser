using Newtonsoft.Json;

namespace CanaryLogParser.Models.Credential
{
    public class CredentialLog
    {
       [JsonProperty("dst_host")]
        public string dst_host { get; set; }

        [JsonProperty("dst_port")]
        public int dst_port { get; set; }

        [JsonProperty("honeycred")]
        public bool honeycred { get; set; }

        [JsonProperty("local_time")]
        public string local_time { get; set; }

        [JsonProperty("logdata")]
        public Logdata logdata { get; set; }

        [JsonProperty("logtype")]
        public int logtype { get; set; }

        [JsonProperty("node_id")]
        public string node_id { get; set; }

        [JsonProperty("src_host")]
        public string src_host { get; set; }

        [JsonProperty("src_port")]
        public int src_port { get; set; }
    }
    public class Logdata
    {
        [JsonProperty("PASSWORD")]
        public string PASSWORD { get; set; }

        [JsonProperty("USERNAME")]
        public string USERNAME { get; set; }
    }
}

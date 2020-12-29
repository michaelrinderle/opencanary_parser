using Newtonsoft.Json;

namespace CanaryLogParser.Models.Port
{
    public class PortLog
    {
        [JsonProperty("dst_host")]
        public string dst_host { get; set; }

        [JsonProperty("dst_port")]
        public string dst_port { get; set; }

        [JsonProperty("local_time")]
        public string local_time { get; set; }

        [JsonProperty("logdata")]
        public Logdata logdata { get; set; }

        [JsonProperty("logtype")]
        public int? logtype { get; set; }

        [JsonProperty("node_id")]
        public string node_id { get; set; }

        [JsonProperty("src_host")]
        public string src_host { get; set; }

        [JsonProperty("src_port")]
        public string src_port { get; set; }
    }

    public class Logdata
    {
        [JsonProperty("DF")]
        public string DF { get; set; }

        [JsonProperty("ID")]
        public string ID { get; set; }

        [JsonProperty("IN")]
        public string IN { get; set; }

        [JsonProperty("LEN")]
        public string LEN { get; set; }

        [JsonProperty("MAC")]
        public string MAC { get; set; }

        [JsonProperty("OUT")]
        public string OUT { get; set; }

        [JsonProperty("PREC")]
        public string PREC { get; set; }

        [JsonProperty("PROTO")]
        public string PROTO { get; set; }

        [JsonProperty("RES")]
        public string RES { get; set; }

        [JsonProperty("SYN")]
        public string SYN { get; set; }

        [JsonProperty("TOS")]
        public string TOS { get; set; }

        [JsonProperty("TTL")]
        public string TTL { get; set; }

        [JsonProperty("URGP")]
        public string URGP { get; set; }

        [JsonProperty("WINDOW")]
        public string WINDOW { get; set; }
    }
}
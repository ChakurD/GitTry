using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DeserializeSquad
{
    public class Squad
    {
        [JsonPropertyName("squadName") ]
        public string SquadName { get; set; }
        [JsonPropertyName("homeTown")]
        public string HomeTown { get; set; }
        [JsonPropertyName("formed")]
        public int Formed { get; set; }
        [JsonPropertyName("secretBase")]
        public string SecretBase { get; set; }
        [JsonPropertyName("active")]
        public bool Active { get; set; }
        [JsonPropertyName("members")]
        public SquadMember[] Members { get; set; }
    }
}

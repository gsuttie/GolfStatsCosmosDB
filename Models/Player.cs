using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfStatsCosmosDB.Models
{
    public class Player
    {
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "FirstName")]
        public string Firstname { get; set; }
        
        [JsonProperty(PropertyName = "LastName")] 
        public string Lastname { get; set; }

        [JsonProperty(PropertyName = "Handicap")] 
        public decimal Handicap { get; set; }
    }
}

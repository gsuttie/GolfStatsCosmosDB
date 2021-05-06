using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GolfStatsCosmosDB.Models
{
    public class Course
    {
        [JsonProperty(PropertyName = "Id")] 
        public string Id { get; set; }
        
        [JsonProperty(PropertyName = "Hole1Par")] 
        public int Hole1Par { get; set; }

        [JsonProperty(PropertyName = "Hole2Par")] 
        public int Hole2Par { get; set; }

        [JsonProperty(PropertyName = "Hole3Par")] 
        public int Hole3Par { get; set; }

        [JsonProperty(PropertyName = "Hole4Par")]
        public int Hole4Par { get; set; }

        [JsonProperty(PropertyName = "Hole5Par")]
        public int Hole5Par { get; set; }

        [JsonProperty(PropertyName = "Hole6Par")]
        public int Hole6Par { get; set; }

        [JsonProperty(PropertyName = "Hole7Par")]
        public int Hole7Par { get; set; }

        [JsonProperty(PropertyName = "Hole8Par")] 
        public int Hole8Par { get; set; }

        [JsonProperty(PropertyName = "Hole9Par")]
        public int Hole9Par { get; set; }

        [JsonProperty(PropertyName = "Hole10Par")] 
        public int Hole10Par { get; set; }
        
        [JsonProperty(PropertyName = "Hole11Par")] 
        public int Hole11Par { get; set; }

        [JsonProperty(PropertyName = "Hole12Par")]
        public int Hole12Par { get; set; }

        [JsonProperty(PropertyName = "Hole13Par")]
        public int Hole13Par { get; set; }
        
        [JsonProperty(PropertyName = "Hole14Par")] 
        public int Hole14Par { get; set; }

        [JsonProperty(PropertyName = "Hole15Par")]
        public int Hole15Par { get; set; }

        [JsonProperty(PropertyName = "Hole16Par")]
        public int Hole16Par { get; set; }

        [JsonProperty(PropertyName = "Hole17Par")] 
        public int Hole17Par { get; set; }

        [JsonProperty(PropertyName = "Hole18Par")] 
        public int Hole18Par { get; set; }

    }
}

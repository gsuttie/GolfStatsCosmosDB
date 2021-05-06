using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GolfStatsCosmosDB.Models
{
    public class Score
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "Hole 1")]
        [DisplayName("Hole 1")]
        public int Hole1 { get; set; }

        [JsonProperty(PropertyName = "Hole 2")]
        [DisplayName("Hole 2")]
        public int Hole2 { get; set; }

        [JsonProperty(PropertyName = "Hole 3")]
        [DisplayName("Hole 3")]
        public int Hole3 { get; set; }

        [JsonProperty(PropertyName = "Hole 4")]
        [DisplayName("Hole 4")]
        public int Hole4 { get; set; }

        [JsonProperty(PropertyName = "Hole 5")]
        [DisplayName("Hole 5")]
        public int Hole5 { get; set; }

        [JsonProperty(PropertyName = "Hole 6")]
        [DisplayName("Hole 6")]
        public int Hole6 { get; set; }

        [JsonProperty(PropertyName = "Hole 7")]
        [DisplayName("Hole 7")]
        public int Hole7 { get; set; }

        [JsonProperty(PropertyName = "Hole 8")]
        [DisplayName("Hole 8")]
        public int Hole8 { get; set; }

        [JsonProperty(PropertyName = "Hole 9")]
        [DisplayName("Hole 9")]
        public int Hole9 { get; set; }

        [JsonProperty(PropertyName = "Hole 10")]
        [DisplayName("Hole 10")]
        public int Hole10 { get; set; }

        [JsonProperty(PropertyName = "Hole 11")]
        [DisplayName("Hole 11")]
        public int Hole11 { get; set; }

        [JsonProperty(PropertyName = "Hole 12")]
        [DisplayName("Hole 12")]
        public int Hole12 { get; set; }

        [JsonProperty(PropertyName = "Hole 13")]
        [DisplayName("Hole 13")]
        public int Hole13 { get; set; }

        [JsonProperty(PropertyName = "Hole 14")]
        [DisplayName("Hole 14")]
        public int Hole14 { get; set; }

        [JsonProperty(PropertyName = "Hole 15")]
        [DisplayName("Hole 15")]
        public int Hole15 { get; set; }

        [JsonProperty(PropertyName = "Hole 16")]
        [DisplayName("Hole 16")]
        public int Hole16 { get; set; }

        [JsonProperty(PropertyName = "Hole 17")]
        [DisplayName("Hole 17")]
        public int Hole17 { get; set; }

        [JsonProperty(PropertyName = "Hole 18")]
        [DisplayName("Hole 18")]
        public int Hole18 { get; set; }

        [JsonProperty(PropertyName = "Total")]
        public int Total { get; set; }

        [JsonProperty(PropertyName = "Created")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? Created { get; set; }
    }
}

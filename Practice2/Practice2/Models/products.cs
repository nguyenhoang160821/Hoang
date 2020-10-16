using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Pracetice2.Models
{
    public class Products
    {
        public string ID { get; set; }

        public string name { get; set; }

        [JsonPropertyName("img")]
        public string Image { get; set; }

        public string Price { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Products>(this);
    }
}

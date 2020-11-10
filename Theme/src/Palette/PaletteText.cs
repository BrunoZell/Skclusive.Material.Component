using System.Collections.Generic;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Skclusive.Material.Theme
{
    public partial class PaletteText
    {
        [JsonPropertyName("disabled")]
        public string Disabled { get; set; }

        [JsonPropertyName("hint")]
        public string Hint { get; set; }

        [JsonPropertyName("primary")]
        public string Primary { get; set; }

        [JsonPropertyName("secondary")]
        public string Secondary { get; set; }

        [JsonPropertyName("custom")]
        public IDictionary<string, string> Custom { get; set; }
    }
}
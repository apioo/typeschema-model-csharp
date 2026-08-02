using System.Text.Json.Serialization;

namespace TypeSchema.Model;

/// <summary>
/// Represents a property containing a key-value map where all values share the same schema.
/// </summary>
public class MapPropertyType : CollectionPropertyType
{
    [JsonPropertyName("type")]
    public new string? Type { get; set; } = "map";

}


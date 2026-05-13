using System.Text.Json.Serialization;

namespace TypeSchema.Model;

/// <summary>
/// A property containing a map of dynamic keys to a consistent value type.
/// </summary>
public class MapPropertyType : CollectionPropertyType
{
    [JsonPropertyName("type")]
    public new string? Type { get; set; } = "map";

}


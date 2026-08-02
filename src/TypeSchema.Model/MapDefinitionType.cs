using System.Text.Json.Serialization;

namespace TypeSchema.Model;

/// <summary>
/// Represents a key-value map with dynamic key names where all values conform to the same schema.
/// </summary>
public class MapDefinitionType : CollectionDefinitionType
{
    [JsonPropertyName("type")]
    public new string? Type { get; set; } = "map";

}


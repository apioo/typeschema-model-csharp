using System.Text.Json.Serialization;

namespace TypeSchema.Model;

/// <summary>
/// An object with a dynamic set of keys where every value conforms to the same schema.
/// </summary>
public class MapDefinitionType : CollectionDefinitionType
{
    [JsonPropertyName("type")]
    public new string? Type { get; set; } = "map";

}


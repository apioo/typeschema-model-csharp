using System.Text.Json.Serialization;

namespace TypeSchema.Model;

/// <summary>
/// Represents an ordered list of elements where every item conforms to the same schema.
/// </summary>
public class ArrayDefinitionType : CollectionDefinitionType
{
    [JsonPropertyName("type")]
    public new string? Type { get; set; } = "array";

}


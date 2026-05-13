using System.Text.Json.Serialization;

namespace TypeSchema.Model;

/// <summary>
/// An ordered list of values where every item conforms to the same schema.
/// </summary>
public class ArrayDefinitionType : CollectionDefinitionType
{
    [JsonPropertyName("type")]
    public new string? Type { get; set; } = "array";

}


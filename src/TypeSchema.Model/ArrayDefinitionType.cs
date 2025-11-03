using System.Text.Json.Serialization;

namespace TypeSchema.Model;

/// <summary>
/// Represents an array which contains a dynamic list of values of the same type
/// </summary>
public class ArrayDefinitionType : CollectionDefinitionType
{
    [JsonPropertyName("type")]
    public new string? Type { get; set; } = "array";

}


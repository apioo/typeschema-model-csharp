using System.Text.Json.Serialization;

namespace TypeSchema.Model;

/// <summary>
/// Represents a property containing a list of items that share the same schema.
/// </summary>
public class ArrayPropertyType : CollectionPropertyType
{
    [JsonPropertyName("type")]
    public new string? Type { get; set; } = "array";

}


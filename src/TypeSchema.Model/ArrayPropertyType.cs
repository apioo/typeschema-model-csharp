using System.Text.Json.Serialization;

namespace TypeSchema.Model;

/// <summary>
/// A property containing a list of items of a consistent type.
/// </summary>
public class ArrayPropertyType : CollectionPropertyType
{
    [JsonPropertyName("type")]
    public new string? Type { get; set; } = "array";

}


using System.Text.Json.Serialization;

namespace TypeSchema.Model;

/// <summary>
/// Represents a wildcard property that accepts any valid JSON value (object, array, string, number, boolean, or null).
/// </summary>
public class AnyPropertyType : PropertyType
{
    [JsonPropertyName("type")]
    public new string? Type { get; set; } = "any";

}


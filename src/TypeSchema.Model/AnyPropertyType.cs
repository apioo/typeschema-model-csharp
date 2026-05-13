using System.Text.Json.Serialization;

namespace TypeSchema.Model;

/// <summary>
/// A wildcard property that accepts any valid JSON value (object, array, string, etc.).
/// </summary>
public class AnyPropertyType : PropertyType
{
    [JsonPropertyName("type")]
    public new string? Type { get; set; } = "any";

}


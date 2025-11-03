using System.Text.Json.Serialization;

namespace TypeSchema.Model;

/// <summary>
/// Represents a boolean value
/// </summary>
public class BooleanPropertyType : ScalarPropertyType
{
    [JsonPropertyName("type")]
    public new string? Type { get; set; } = "boolean";

}


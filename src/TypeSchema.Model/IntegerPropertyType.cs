using System.Text.Json.Serialization;

namespace TypeSchema.Model;

/// <summary>
/// Represents a whole number.
/// </summary>
public class IntegerPropertyType : ScalarPropertyType
{
    [JsonPropertyName("type")]
    public new string? Type { get; set; } = "integer";

}


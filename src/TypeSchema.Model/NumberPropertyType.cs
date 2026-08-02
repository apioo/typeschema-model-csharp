using System.Text.Json.Serialization;

namespace TypeSchema.Model;

/// <summary>
/// Represents a numeric value, including floating-point and decimal numbers.
/// </summary>
public class NumberPropertyType : ScalarPropertyType
{
    [JsonPropertyName("type")]
    public new string? Type { get; set; } = "number";

}


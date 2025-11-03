using System.Text.Json.Serialization;

namespace TypeSchema.Model;

/// <summary>
/// Represents an integer value
/// </summary>
public class IntegerPropertyType : ScalarPropertyType
{
    [JsonPropertyName("type")]
    public new string? Type { get; set; } = "integer";

}


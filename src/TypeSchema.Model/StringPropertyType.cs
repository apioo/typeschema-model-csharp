using System.Text.Json.Serialization;

namespace TypeSchema.Model;

/// <summary>
/// Represents a string value
/// </summary>
public class StringPropertyType : ScalarPropertyType
{
    [JsonPropertyName("format")]
    public string? Format { get; set; }

}


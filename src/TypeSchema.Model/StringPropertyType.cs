using System.Text.Json.Serialization;

namespace TypeSchema.Model;

/// <summary>
/// Represents a sequence of characters, with optional formatting rules.
/// </summary>
public class StringPropertyType : ScalarPropertyType
{
    [JsonPropertyName("default")]
    public string? Default { get; set; }

    [JsonPropertyName("format")]
    public string? Format { get; set; }

    [JsonPropertyName("type")]
    public new string? Type { get; set; } = "string";

}


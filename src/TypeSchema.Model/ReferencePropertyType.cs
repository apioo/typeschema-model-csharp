using System.Text.Json.Serialization;

namespace TypeSchema.Model;

/// <summary>
/// Represents a reference to a type defined in the global definitions dictionary.
/// </summary>
public class ReferencePropertyType : PropertyType
{
    [JsonPropertyName("target")]
    public string? Target { get; set; }

    [JsonPropertyName("template")]
    public System.Collections.Generic.Dictionary<string, string>? Template { get; set; }

    [JsonPropertyName("type")]
    public new string? Type { get; set; } = "reference";

}


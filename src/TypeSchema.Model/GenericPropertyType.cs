using System.Text.Json.Serialization;

namespace TypeSchema.Model;

/// <summary>
/// A placeholder for a type that will be specified at runtime or through template arguments.
/// </summary>
public class GenericPropertyType : PropertyType
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public new string? Type { get; set; } = "generic";

}


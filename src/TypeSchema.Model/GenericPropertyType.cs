using System.Text.Json.Serialization;

namespace TypeSchema.Model;

/// <summary>
/// Represents a generic placeholder type that is resolved at runtime or via template arguments.
/// </summary>
public class GenericPropertyType : PropertyType
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

    [JsonPropertyName("type")]
    public new string? Type { get; set; } = "generic";

}


using System.Text.Json.Serialization;

namespace TypeSchema.Model;

/// <summary>
/// Represents a generic value which can be replaced with a concrete type
/// </summary>
public class GenericPropertyType : PropertyType
{
    [JsonPropertyName("name")]
    public string? Name { get; set; }

}


using System.Text.Json.Serialization;

namespace TypeSchema.Model;

/// <summary>
/// Represents an object with a fixed set of properties (such as a class or record). Supports inheritance and explicit property typing.
/// </summary>
public class StructDefinitionType : DefinitionType
{
    [JsonPropertyName("base")]
    public bool? Base { get; set; }

    [JsonPropertyName("discriminator")]
    public string? Discriminator { get; set; }

    [JsonPropertyName("mapping")]
    public System.Collections.Generic.Dictionary<string, string>? Mapping { get; set; }

    [JsonPropertyName("parent")]
    public ReferencePropertyType? Parent { get; set; }

    [JsonPropertyName("properties")]
    public System.Collections.Generic.Dictionary<string, PropertyType>? Properties { get; set; }

    [JsonPropertyName("type")]
    public new string? Type { get; set; } = "struct";

}


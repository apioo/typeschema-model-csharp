using System.Text.Json.Serialization;

namespace TypeSchema.Model;

/// <summary>
/// TypeSchema specification
/// </summary>
public class TypeSchema
{
    [JsonPropertyName("definitions")]
    public System.Collections.Generic.Dictionary<string, DefinitionType>? Definitions { get; set; }

    [JsonPropertyName("import")]
    public System.Collections.Generic.Dictionary<string, string>? Import { get; set; }

    [JsonPropertyName("root")]
    public string? Root { get; set; }

}


using System.Text.Json.Serialization;

namespace TypeSchema.Model;

/// <summary>
/// The root object of a TypeSchema document containing imports, definitions, and the entry point.
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


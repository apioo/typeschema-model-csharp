using System.Text.Json.Serialization;

namespace TypeSchema.Model;

/// <summary>
/// The abstract base type for all schema definitions. It provides common metadata such as descriptions and deprecation status.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "type")]
[JsonDerivedType(typeof(ArrayDefinitionType), typeDiscriminator: "array")]
[JsonDerivedType(typeof(MapDefinitionType), typeDiscriminator: "map")]
[JsonDerivedType(typeof(StructDefinitionType), typeDiscriminator: "struct")]
public abstract class DefinitionType
{
    [JsonPropertyName("deprecated")]
    public bool? Deprecated { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

}


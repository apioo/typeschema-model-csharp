using System.Text.Json.Serialization;

namespace TypeSchema.Model;

/// <summary>
/// The abstract base type for collection definitions that contain multiple elements of a uniform type.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "type")]
[JsonDerivedType(typeof(ArrayDefinitionType), typeDiscriminator: "array")]
[JsonDerivedType(typeof(MapDefinitionType), typeDiscriminator: "map")]
public abstract class CollectionDefinitionType : DefinitionType
{
    [JsonPropertyName("schema")]
    public PropertyType? Schema { get; set; }

}


using System.Text.Json.Serialization;

namespace TypeSchema.Model;

/// <summary>
/// Abstract base for definitions that hold multiple values of a single type, such as arrays or maps.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "type")]
[JsonDerivedType(typeof(ArrayDefinitionType), typeDiscriminator: "array")]
[JsonDerivedType(typeof(MapDefinitionType), typeDiscriminator: "map")]
public abstract class CollectionDefinitionType : DefinitionType
{
    [JsonPropertyName("schema")]
    public PropertyType? Schema { get; set; }

}


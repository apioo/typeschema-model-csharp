using System.Text.Json.Serialization;

namespace TypeSchema.Model;

/// <summary>
/// The abstract base type for properties that define inline collections (maps or arrays).
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "type")]
[JsonDerivedType(typeof(ArrayPropertyType), typeDiscriminator: "array")]
[JsonDerivedType(typeof(MapPropertyType), typeDiscriminator: "map")]
public abstract class CollectionPropertyType : PropertyType
{
    [JsonPropertyName("schema")]
    public PropertyType? Schema { get; set; }

}


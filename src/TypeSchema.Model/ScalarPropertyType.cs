using System.Text.Json.Serialization;

namespace TypeSchema.Model;

/// <summary>
/// Abstract base for simple value types like strings, numbers, and booleans.
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "type")]
[JsonDerivedType(typeof(BooleanPropertyType), typeDiscriminator: "boolean")]
[JsonDerivedType(typeof(IntegerPropertyType), typeDiscriminator: "integer")]
[JsonDerivedType(typeof(NumberPropertyType), typeDiscriminator: "number")]
[JsonDerivedType(typeof(StringPropertyType), typeDiscriminator: "string")]
public abstract class ScalarPropertyType : PropertyType
{
}


using System.Text.Json.Serialization;

namespace TypeSchema.Model;

/// <summary>
/// Base scalar property type
/// </summary>
[JsonPolymorphic(TypeDiscriminatorPropertyName = "type")]
[JsonDerivedType(typeof(BooleanPropertyType), typeDiscriminator: "boolean")]
[JsonDerivedType(typeof(IntegerPropertyType), typeDiscriminator: "integer")]
[JsonDerivedType(typeof(NumberPropertyType), typeDiscriminator: "number")]
[JsonDerivedType(typeof(StringPropertyType), typeDiscriminator: "string")]
public abstract class ScalarPropertyType : PropertyType
{
    [JsonPropertyName("type")]
    public string? Type { get; set; }

}


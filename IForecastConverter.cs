using System.Text.Json;
using System.Text.Json.Serialization;

namespace WebAPIWithInterface;

// Ideally if anyone wanted to use this, they'd want to turn it into a generic, 
// then simply use a JsonConverterFactory to instantiate a generic targetting the type that they're trying to deserialize.
// This is just a proof of concept of using an interface as the parameter type in WebAPIs.

// Instead of attaching a attribute to the interface, you could also use reflection to locate any concrete types that implement the interface 
// and have a parameterless constructor.
public class IForecastConverter : System.Text.Json.Serialization.JsonConverter<IForecast>
{
    public override bool CanConvert(Type typeToConvert)
    {
        return (typeToConvert == typeof(IForecast));
    }
    public override IForecast? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        var attr = (DefaultImplementationAttribute)typeof(IForecast).GetCustomAttributes(typeof(DefaultImplementationAttribute), false).First();
        
        return JsonSerializer.Deserialize(ref reader, attr.Implementation, options) as IForecast;
    }

    public override void Write(Utf8JsonWriter writer, IForecast value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}
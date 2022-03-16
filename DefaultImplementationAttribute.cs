namespace WebAPIWithInterface;

public class DefaultImplementationAttribute : Attribute
{
    public DefaultImplementationAttribute(Type imp)
    {
        Implementation = imp;
    }
    public Type Implementation { get; set; }
}

namespace UnrealEngine.Gvas.FProperties;

[OptionalGuid]
public class FIntProperty : FProperty
{
    public int Value { get; set; }

    internal override void Read(BinaryReader reader, string? propertyName, long fieldLength, bool bodyOnly = false)
    {
        Value = reader.ReadInt32();
    }

    internal override void Write(BinaryWriter writer, bool skipHeader)
    {
        writer.Write(Value);
    }

    protected override IEnumerable<object> SerializeContent()
    {
        yield return Value;
    }

    public override object AsPrimitive() => Value;
    
    public override void SetValue(object? val) => Value = (int) val;

    public override string ToString()
    {
        return Value.ToString();
    }
}
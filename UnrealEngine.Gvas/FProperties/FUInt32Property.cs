namespace UnrealEngine.Gvas.FProperties;

[OptionalGuid]
public class FUInt32Property : FProperty
{
    public UInt32 Value { get; set; }

    internal override void Read(BinaryReader reader, string? propertyName, long fieldLength, bool bodyOnly = false)
    {
        Value = reader.ReadUInt32();
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
    
    public override void SetValue(object? val) => Value = (UInt32) val;
}
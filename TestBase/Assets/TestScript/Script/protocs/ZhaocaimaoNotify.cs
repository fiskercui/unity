//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ZhaocaimaoNotify.proto
namespace Pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ZhaocaimaoNotify")]
  public partial class ZhaocaimaoNotify : global::ProtoBuf.IExtensible
  {
    public ZhaocaimaoNotify() {}
    
    private uint _end_cd;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"end_cd", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint end_cd
    {
      get { return _end_cd; }
      set { _end_cd = value; }
    }
    private uint _count;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint count
    {
      get { return _count; }
      set { _count = value; }
    }
    private uint _last_get;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"last_get", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint last_get
    {
      get { return _last_get; }
      set { _last_get = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
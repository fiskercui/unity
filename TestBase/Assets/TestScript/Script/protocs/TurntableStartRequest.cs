//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: TurntableStartRequest.proto
namespace Pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"TurntableStartRequest")]
  public partial class TurntableStartRequest : global::ProtoBuf.IExtensible
  {
    public TurntableStartRequest() {}
    
    private uint _all;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"all", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint all
    {
      get { return _all; }
      set { _all = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
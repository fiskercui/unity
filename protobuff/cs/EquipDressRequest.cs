//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: EquipDressRequest.proto
namespace Pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EquipDressRequest")]
  public partial class EquipDressRequest : global::ProtoBuf.IExtensible
  {
    public EquipDressRequest() {}
    
    private readonly global::System.Collections.Generic.List<uint> _pos = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(1, Name=@"pos", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> pos
    {
      get { return _pos; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _posZhengXing = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(2, Name=@"posZhengXing", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> posZhengXing
    {
      get { return _posZhengXing; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
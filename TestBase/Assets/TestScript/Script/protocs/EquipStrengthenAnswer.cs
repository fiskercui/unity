//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: EquipStrengthenAnswer.proto
namespace Pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EquipStrengthenAnswer")]
  public partial class EquipStrengthenAnswer : global::ProtoBuf.IExtensible
  {
    public EquipStrengthenAnswer() {}
    
    private uint _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint result
    {
      get { return _result; }
      set { _result = value; }
    }
    private uint _extra_level;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"extra_level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint extra_level
    {
      get { return _extra_level; }
      set { _extra_level = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
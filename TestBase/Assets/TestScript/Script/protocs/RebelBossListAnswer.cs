//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: RebelBossListAnswer.proto
namespace Pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RebelBossListAnswer")]
  public partial class RebelBossListAnswer : global::ProtoBuf.IExtensible
  {
    public RebelBossListAnswer() {}
    
    private uint _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint result
    {
      get { return _result; }
      set { _result = value; }
    }
    private uint _id;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }
    private uint _state;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"state", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint state
    {
      get { return _state; }
      set { _state = value; }
    }
    private uint _maxhp;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"maxhp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint maxhp
    {
      get { return _maxhp; }
      set { _maxhp = value; }
    }
    private uint _curhp;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"curhp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint curhp
    {
      get { return _curhp; }
      set { _curhp = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: RaidResetAnswer.proto
namespace Pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RaidResetAnswer")]
  public partial class RaidResetAnswer : global::ProtoBuf.IExtensible
  {
    public RaidResetAnswer() {}
    
    private uint _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint result
    {
      get { return _result; }
      set { _result = value; }
    }
    private uint _raid_id;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"raid_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint raid_id
    {
      get { return _raid_id; }
      set { _raid_id = value; }
    }
    private uint _type;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint type
    {
      get { return _type; }
      set { _type = value; }
    }
    private uint _count;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint count
    {
      get { return _count; }
      set { _count = value; }
    }
    private uint _rstcnt;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"rstcnt", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint rstcnt
    {
      get { return _rstcnt; }
      set { _rstcnt = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ShopPlayInfoAnswer.proto
namespace Pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ShopPlayInfoAnswer")]
  public partial class ShopPlayInfoAnswer : global::ProtoBuf.IExtensible
  {
    public ShopPlayInfoAnswer() {}
    
    private uint _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint result
    {
      get { return _result; }
      set { _result = value; }
    }
    private uint _type;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint type
    {
      get { return _type; }
      set { _type = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _id = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(3, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> id
    {
      get { return _id; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _buy_times = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(4, Name=@"buy_times", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> buy_times
    {
      get { return _buy_times; }
    }
  
    private uint _arena_rank;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"arena_rank", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint arena_rank
    {
      get { return _arena_rank; }
      set { _arena_rank = value; }
    }
    private uint _ladder_history_star;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"ladder_history_star", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint ladder_history_star
    {
      get { return _ladder_history_star; }
      set { _ladder_history_star = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
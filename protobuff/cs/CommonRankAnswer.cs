//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: CommonRankAnswer.proto
// Note: requires additional types generated from: U64Type.proto
namespace Pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CommonRankAnswer")]
  public partial class CommonRankAnswer : global::ProtoBuf.IExtensible
  {
    public CommonRankAnswer() {}
    
    private uint _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint result
    {
      get { return _result; }
      set { _result = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _likes = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(10, Name=@"likes", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> likes
    {
      get { return _likes; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _viplv = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(11, Name=@"viplv", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> viplv
    {
      get { return _viplv; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _fashion_id = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(12, Name=@"fashion_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> fashion_id
    {
      get { return _fashion_id; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _pet_id = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(13, Name=@"pet_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> pet_id
    {
      get { return _pet_id; }
    }
  
    private readonly global::System.Collections.Generic.List<U64Type> _legion_id = new global::System.Collections.Generic.List<U64Type>();
    [global::ProtoBuf.ProtoMember(14, Name=@"legion_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<U64Type> legion_id
    {
      get { return _legion_id; }
    }
  
    private readonly global::System.Collections.Generic.List<string> _legion_name = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(15, Name=@"legion_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> legion_name
    {
      get { return _legion_name; }
    }
  
    private uint _type;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint type
    {
      get { return _type; }
      set { _type = value; }
    }
    private uint _left_like_count;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"left_like_count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint left_like_count
    {
      get { return _left_like_count; }
      set { _left_like_count = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _rank = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(4, Name=@"rank", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> rank
    {
      get { return _rank; }
    }
  
    private readonly global::System.Collections.Generic.List<U64Type> _player_id = new global::System.Collections.Generic.List<U64Type>();
    [global::ProtoBuf.ProtoMember(5, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<U64Type> player_id
    {
      get { return _player_id; }
    }
  
    private readonly global::System.Collections.Generic.List<string> _name = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(6, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> name
    {
      get { return _name; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _main_card_id = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(7, Name=@"main_card_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> main_card_id
    {
      get { return _main_card_id; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _level = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(8, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> level
    {
      get { return _level; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _fight_power = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(9, Name=@"fight_power", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> fight_power
    {
      get { return _fight_power; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: WudiPreselectRankAnswer.proto
// Note: requires additional types generated from: U64Type.proto
namespace Pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"WudiPreselectRankAnswer")]
  public partial class WudiPreselectRankAnswer : global::ProtoBuf.IExtensible
  {
    public WudiPreselectRankAnswer() {}
    
    private uint _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint result
    {
      get { return _result; }
      set { _result = value; }
    }
    private uint _self_rank;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"self_rank", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint self_rank
    {
      get { return _self_rank; }
      set { _self_rank = value; }
    }
    private uint _self_occupy_time;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"self_occupy_time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint self_occupy_time
    {
      get { return _self_occupy_time; }
      set { _self_occupy_time = value; }
    }
    private readonly global::System.Collections.Generic.List<U64Type> _player_id = new global::System.Collections.Generic.List<U64Type>();
    [global::ProtoBuf.ProtoMember(4, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<U64Type> player_id
    {
      get { return _player_id; }
    }
  
    private readonly global::System.Collections.Generic.List<string> _player_name = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(5, Name=@"player_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> player_name
    {
      get { return _player_name; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _occupy_time = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(6, Name=@"occupy_time", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> occupy_time
    {
      get { return _occupy_time; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _level = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(7, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> level
    {
      get { return _level; }
    }
  

    private uint _begin_ts = default(uint);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"begin_ts", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint begin_ts
    {
      get { return _begin_ts; }
      set { _begin_ts = value; }
    }

    private uint _end_ts = default(uint);
    [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"end_ts", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint end_ts
    {
      get { return _end_ts; }
      set { _end_ts = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
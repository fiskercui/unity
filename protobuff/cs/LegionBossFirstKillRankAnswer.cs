//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: LegionBossFirstKillRankAnswer.proto
namespace Pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LegionBossFirstKillRankAnswer")]
  public partial class LegionBossFirstKillRankAnswer : global::ProtoBuf.IExtensible
  {
    public LegionBossFirstKillRankAnswer() {}
    
    private uint _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint result
    {
      get { return _result; }
      set { _result = value; }
    }
    private uint _self_rank;
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"self_rank", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint self_rank
    {
      get { return _self_rank; }
      set { _self_rank = value; }
    }
    private uint _self_first_kill_ts;
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"self_first_kill_ts", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint self_first_kill_ts
    {
      get { return _self_first_kill_ts; }
      set { _self_first_kill_ts = value; }
    }
    private uint _stage;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"stage", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint stage
    {
      get { return _stage; }
      set { _stage = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _rank = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(4, Name=@"rank", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> rank
    {
      get { return _rank; }
    }
  
    private readonly global::System.Collections.Generic.List<string> _name = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(5, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> name
    {
      get { return _name; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _level = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(6, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> level
    {
      get { return _level; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _logo_id = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(7, Name=@"logo_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> logo_id
    {
      get { return _logo_id; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _frame_id = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(8, Name=@"frame_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> frame_id
    {
      get { return _frame_id; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _first_kill_ts = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(9, Name=@"first_kill_ts", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> first_kill_ts
    {
      get { return _first_kill_ts; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
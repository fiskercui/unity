//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: CsRiverLanternInfoAnswer.proto
namespace Pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CsRiverLanternInfoAnswer")]
  public partial class CsRiverLanternInfoAnswer : global::ProtoBuf.IExtensible
  {
    public CsRiverLanternInfoAnswer() {}
    
    private uint _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint result
    {
      get { return _result; }
      set { _result = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _id = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(15, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> id
    {
      get { return _id; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _ts = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(16, Name=@"ts", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> ts
    {
      get { return _ts; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _num = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(17, Name=@"num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> num
    {
      get { return _num; }
    }
  
    private uint _end_ts;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"end_ts", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint end_ts
    {
      get { return _end_ts; }
      set { _end_ts = value; }
    }
    private uint _level_max;
    [global::ProtoBuf.ProtoMember(20, IsRequired = true, Name=@"level_max", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint level_max
    {
      get { return _level_max; }
      set { _level_max = value; }
    }
    private uint _level_min;
    [global::ProtoBuf.ProtoMember(21, IsRequired = true, Name=@"level_min", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint level_min
    {
      get { return _level_min; }
      set { _level_min = value; }
    }

    private uint _activity_id = default(uint);
    [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"activity_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint activity_id
    {
      get { return _activity_id; }
      set { _activity_id = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _rank = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(3, Name=@"rank", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> rank
    {
      get { return _rank; }
    }
  
    private readonly global::System.Collections.Generic.List<string> _name = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(4, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> name
    {
      get { return _name; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _count = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(5, Name=@"count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> count
    {
      get { return _count; }
    }
  
    private uint _self_rank;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"self_rank", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint self_rank
    {
      get { return _self_rank; }
      set { _self_rank = value; }
    }
    private uint _self_count;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"self_count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint self_count
    {
      get { return _self_count; }
      set { _self_count = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
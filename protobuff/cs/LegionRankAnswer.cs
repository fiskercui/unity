//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: LegionRankAnswer.proto
// Note: requires additional types generated from: U64Type.proto
namespace Pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LegionRankAnswer")]
  public partial class LegionRankAnswer : global::ProtoBuf.IExtensible
  {
    public LegionRankAnswer() {}
    
    private uint _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint result
    {
      get { return _result; }
      set { _result = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _raid = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(10, Name=@"raid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> raid
    {
      get { return _raid; }
    }
  
    private uint _self_rank;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"self_rank", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint self_rank
    {
      get { return _self_rank; }
      set { _self_rank = value; }
    }
    private readonly global::System.Collections.Generic.List<U64Type> _legion_id = new global::System.Collections.Generic.List<U64Type>();
    [global::ProtoBuf.ProtoMember(3, Name=@"legion_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<U64Type> legion_id
    {
      get { return _legion_id; }
    }
  
    private readonly global::System.Collections.Generic.List<string> _name = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(4, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> name
    {
      get { return _name; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _logo_id = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(5, Name=@"logo_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> logo_id
    {
      get { return _logo_id; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _frame_id = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(6, Name=@"frame_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> frame_id
    {
      get { return _frame_id; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _level = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(7, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> level
    {
      get { return _level; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _member_num = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(8, Name=@"member_num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> member_num
    {
      get { return _member_num; }
    }
  
    private readonly global::System.Collections.Generic.List<string> _head_name = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(9, Name=@"head_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> head_name
    {
      get { return _head_name; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
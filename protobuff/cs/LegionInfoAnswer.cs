//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: LegionInfoAnswer.proto
namespace Pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LegionInfoAnswer")]
  public partial class LegionInfoAnswer : global::ProtoBuf.IExtensible
  {
    public LegionInfoAnswer() {}
    
    private uint _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint result
    {
      get { return _result; }
      set { _result = value; }
    }
    private string _declaration;
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"declaration", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string declaration
    {
      get { return _declaration; }
      set { _declaration = value; }
    }
    private uint _position;
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"position", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint position
    {
      get { return _position; }
      set { _position = value; }
    }
    private uint _worship_value;
    [global::ProtoBuf.ProtoMember(12, IsRequired = true, Name=@"worship_value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint worship_value
    {
      get { return _worship_value; }
      set { _worship_value = value; }
    }
    private uint _worship_count;
    [global::ProtoBuf.ProtoMember(13, IsRequired = true, Name=@"worship_count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint worship_count
    {
      get { return _worship_count; }
      set { _worship_count = value; }
    }
    private string _impeach_name;
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"impeach_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string impeach_name
    {
      get { return _impeach_name; }
      set { _impeach_name = value; }
    }
    private uint _impeach_ts;
    [global::ProtoBuf.ProtoMember(15, IsRequired = true, Name=@"impeach_ts", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint impeach_ts
    {
      get { return _impeach_ts; }
      set { _impeach_ts = value; }
    }
    private uint _auto_del_ts;
    [global::ProtoBuf.ProtoMember(16, IsRequired = true, Name=@"auto_del_ts", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint auto_del_ts
    {
      get { return _auto_del_ts; }
      set { _auto_del_ts = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _accept_type = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(17, Name=@"accept_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> accept_type
    {
      get { return _accept_type; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _accept_value = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(18, Name=@"accept_value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> accept_value
    {
      get { return _accept_value; }
    }
  
    private uint _accept;
    [global::ProtoBuf.ProtoMember(19, IsRequired = true, Name=@"accept", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint accept
    {
      get { return _accept; }
      set { _accept = value; }
    }
    private string _name;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }
    private uint _logo_id;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"logo_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint logo_id
    {
      get { return _logo_id; }
      set { _logo_id = value; }
    }
    private uint _frame_id;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"frame_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint frame_id
    {
      get { return _frame_id; }
      set { _frame_id = value; }
    }
    private uint _level;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint level
    {
      get { return _level; }
      set { _level = value; }
    }
    private uint _exp;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"exp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint exp
    {
      get { return _exp; }
      set { _exp = value; }
    }
    private uint _member_num;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"member_num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint member_num
    {
      get { return _member_num; }
      set { _member_num = value; }
    }
    private string _head_name;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"head_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string head_name
    {
      get { return _head_name; }
      set { _head_name = value; }
    }
    private string _bulletin;
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"bulletin", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string bulletin
    {
      get { return _bulletin; }
      set { _bulletin = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
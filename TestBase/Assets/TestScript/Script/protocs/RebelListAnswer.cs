//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: RebelListAnswer.proto
// Note: requires additional types generated from: U64Type.proto
// Note: requires additional types generated from: RebelExtInfo.proto
namespace Pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RebelListAnswer")]
  public partial class RebelListAnswer : global::ProtoBuf.IExtensible
  {
    public RebelListAnswer() {}
    
    private uint _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint result
    {
      get { return _result; }
      set { _result = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _honortype = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(10, Name=@"honortype", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> honortype
    {
      get { return _honortype; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _lv = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(11, Name=@"lv", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> lv
    {
      get { return _lv; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _role = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(12, Name=@"role", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> role
    {
      get { return _role; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _state = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(13, Name=@"state", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> state
    {
      get { return _state; }
    }
  
    private readonly global::System.Collections.Generic.List<U64Type> _hurt = new global::System.Collections.Generic.List<U64Type>();
    [global::ProtoBuf.ProtoMember(14, Name=@"hurt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<U64Type> hurt
    {
      get { return _hurt; }
    }
  
    private readonly global::System.Collections.Generic.List<string> _hurtname = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(15, Name=@"hurtname", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> hurtname
    {
      get { return _hurtname; }
    }
  
    private readonly global::System.Collections.Generic.List<U64Type> _selfhurt = new global::System.Collections.Generic.List<U64Type>();
    [global::ProtoBuf.ProtoMember(16, Name=@"selfhurt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<U64Type> selfhurt
    {
      get { return _selfhurt; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _share_state = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(17, Name=@"share_state", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> share_state
    {
      get { return _share_state; }
    }
  
    private U64Type _credit;
    [global::ProtoBuf.ProtoMember(18, IsRequired = true, Name=@"credit", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public U64Type credit
    {
      get { return _credit; }
      set { _credit = value; }
    }
    private U64Type _totalhurt;
    [global::ProtoBuf.ProtoMember(19, IsRequired = true, Name=@"totalhurt", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public U64Type totalhurt
    {
      get { return _totalhurt; }
      set { _totalhurt = value; }
    }
    private readonly global::System.Collections.Generic.List<U64Type> _serial_id = new global::System.Collections.Generic.List<U64Type>();
    [global::ProtoBuf.ProtoMember(2, Name=@"serial_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<U64Type> serial_id
    {
      get { return _serial_id; }
    }
  
    private readonly global::System.Collections.Generic.List<RebelExtInfo> _extinfo = new global::System.Collections.Generic.List<RebelExtInfo>();
    [global::ProtoBuf.ProtoMember(20, Name=@"extinfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<RebelExtInfo> extinfo
    {
      get { return _extinfo; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _id = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(3, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> id
    {
      get { return _id; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _ts = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(4, Name=@"ts", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> ts
    {
      get { return _ts; }
    }
  
    private readonly global::System.Collections.Generic.List<string> _name = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(5, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> name
    {
      get { return _name; }
    }
  
    private readonly global::System.Collections.Generic.List<U64Type> _max_hp = new global::System.Collections.Generic.List<U64Type>();
    [global::ProtoBuf.ProtoMember(6, Name=@"max_hp", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<U64Type> max_hp
    {
      get { return _max_hp; }
    }
  
    private readonly global::System.Collections.Generic.List<U64Type> _cur_hp = new global::System.Collections.Generic.List<U64Type>();
    [global::ProtoBuf.ProtoMember(7, Name=@"cur_hp", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<U64Type> cur_hp
    {
      get { return _cur_hp; }
    }
  
    private readonly global::System.Collections.Generic.List<string> _killname = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(8, Name=@"killname", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> killname
    {
      get { return _killname; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _exploit_type = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(9, Name=@"exploit_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> exploit_type
    {
      get { return _exploit_type; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
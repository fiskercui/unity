//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: DrawLuckPackageAnswer.proto
namespace Pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DrawLuckPackageAnswer")]
  public partial class DrawLuckPackageAnswer : global::ProtoBuf.IExtensible
  {
    public DrawLuckPackageAnswer() {}
    
    private uint _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint result
    {
      get { return _result; }
      set { _result = value; }
    }
    private uint _isdef;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"isdef", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint isdef
    {
      get { return _isdef; }
      set { _isdef = value; }
    }
    private uint _act_id;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"act_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint act_id
    {
      get { return _act_id; }
      set { _act_id = value; }
    }
    private uint _cfg_id;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"cfg_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint cfg_id
    {
      get { return _cfg_id; }
      set { _cfg_id = value; }
    }
    private uint _luck;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"luck", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint luck
    {
      get { return _luck; }
      set { _luck = value; }
    }
    private uint _draw_luck_package;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"draw_luck_package", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint draw_luck_package
    {
      get { return _draw_luck_package; }
      set { _draw_luck_package = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _item_type = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(7, Name=@"item_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> item_type
    {
      get { return _item_type; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _item_id = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(8, Name=@"item_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> item_id
    {
      get { return _item_id; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _item_count = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(9, Name=@"item_count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> item_count
    {
      get { return _item_count; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: DrawVipDailyWelfareAnswer.proto
namespace Pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DrawVipDailyWelfareAnswer")]
  public partial class DrawVipDailyWelfareAnswer : global::ProtoBuf.IExtensible
  {
    public DrawVipDailyWelfareAnswer() {}
    
    private uint _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint result
    {
      get { return _result; }
      set { _result = value; }
    }
    private uint _id;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }
    private uint _vip_lv;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"vip_lv", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint vip_lv
    {
      get { return _vip_lv; }
      set { _vip_lv = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _item_type = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(4, Name=@"item_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> item_type
    {
      get { return _item_type; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _item_id = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(5, Name=@"item_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> item_id
    {
      get { return _item_id; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _item_num = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(6, Name=@"item_num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> item_num
    {
      get { return _item_num; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
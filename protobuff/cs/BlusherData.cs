//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: BlusherData.proto
namespace Pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BlusherData")]
  public partial class BlusherData : global::ProtoBuf.IExtensible
  {
    public BlusherData() {}
    
    private uint _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _user_data = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(10, Name=@"user_data", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> user_data
    {
      get { return _user_data; }
    }
  
    private uint _quyue_times;
    [global::ProtoBuf.ProtoMember(11, IsRequired = true, Name=@"quyue_times", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint quyue_times
    {
      get { return _quyue_times; }
      set { _quyue_times = value; }
    }
    private uint _lv;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"lv", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint lv
    {
      get { return _lv; }
      set { _lv = value; }
    }
    private uint _exp;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"exp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint exp
    {
      get { return _exp; }
      set { _exp = value; }
    }
    private uint _luck_id;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"luck_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint luck_id
    {
      get { return _luck_id; }
      set { _luck_id = value; }
    }
    private uint _admire;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"admire", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint admire
    {
      get { return _admire; }
      set { _admire = value; }
    }
    private uint _all_admire;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"all_admire", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint all_admire
    {
      get { return _all_admire; }
      set { _all_admire = value; }
    }
    private uint _lv_reward;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"lv_reward", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint lv_reward
    {
      get { return _lv_reward; }
      set { _lv_reward = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _attr_id = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(8, Name=@"attr_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> attr_id
    {
      get { return _attr_id; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _attr_value = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(9, Name=@"attr_value", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> attr_value
    {
      get { return _attr_value; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
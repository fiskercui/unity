//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: KingFightAnswer.proto
namespace Pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"KingFightAnswer")]
  public partial class KingFightAnswer : global::ProtoBuf.IExtensible
  {
    public KingFightAnswer() {}
    
    private uint _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint result
    {
      get { return _result; }
      set { _result = value; }
    }

    private uint _income_fortress_id = default(uint);
    [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"income_fortress_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint income_fortress_id
    {
      get { return _income_fortress_id; }
      set { _income_fortress_id = value; }
    }
    private uint _id;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint id
    {
      get { return _id; }
      set { _id = value; }
    }
    private uint _refresh;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"refresh", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint refresh
    {
      get { return _refresh; }
      set { _refresh = value; }
    }
    private uint _total_star;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"total_star", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint total_star
    {
      get { return _total_star; }
      set { _total_star = value; }
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
  
    private readonly global::System.Collections.Generic.List<uint> _item_use_num = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(7, Name=@"item_use_num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> item_use_num
    {
      get { return _item_use_num; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _com_id = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(8, Name=@"com_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> com_id
    {
      get { return _com_id; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _com_star = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(9, Name=@"com_star", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> com_star
    {
      get { return _com_star; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: HuangtingAnswer.proto
namespace Pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"HuangtingAnswer")]
  public partial class HuangtingAnswer : global::ProtoBuf.IExtensible
  {
    public HuangtingAnswer() {}
    
    private uint _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint result
    {
      get { return _result; }
      set { _result = value; }
    }
    private uint _next_step;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"next_step", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint next_step
    {
      get { return _next_step; }
      set { _next_step = value; }
    }
    private uint _item_choose;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"item_choose", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint item_choose
    {
      get { return _item_choose; }
      set { _item_choose = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
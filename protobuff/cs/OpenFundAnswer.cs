//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: OpenFundAnswer.proto
namespace Pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OpenFundAnswer")]
  public partial class OpenFundAnswer : global::ProtoBuf.IExtensible
  {
    public OpenFundAnswer() {}
    
    private uint _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint result
    {
      get { return _result; }
      set { _result = value; }
    }
    private uint _has_bought;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"has_bought", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint has_bought
    {
      get { return _has_bought; }
      set { _has_bought = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _fund_id = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(3, Name=@"fund_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> fund_id
    {
      get { return _fund_id; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _fund_get = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(4, Name=@"fund_get", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> fund_get
    {
      get { return _fund_get; }
    }
  
    private uint _buy_num;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"buy_num", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint buy_num
    {
      get { return _buy_num; }
      set { _buy_num = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _welfare_id = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(6, Name=@"welfare_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> welfare_id
    {
      get { return _welfare_id; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _welfare_get = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(7, Name=@"welfare_get", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> welfare_get
    {
      get { return _welfare_get; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
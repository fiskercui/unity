//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: BuyWudiBossBuffRequest.proto
namespace Pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"BuyWudiBossBuffRequest")]
  public partial class BuyWudiBossBuffRequest : global::ProtoBuf.IExtensible
  {
    public BuyWudiBossBuffRequest() {}
    
    private uint _index;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint index
    {
      get { return _index; }
      set { _index = value; }
    }
    private uint _boss_ts;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"boss_ts", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint boss_ts
    {
      get { return _boss_ts; }
      set { _boss_ts = value; }
    }
    private uint _buff_type;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"buff_type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint buff_type
    {
      get { return _buff_type; }
      set { _buff_type = value; }
    }
    private uint _buff_index;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"buff_index", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint buff_index
    {
      get { return _buff_index; }
      set { _buff_index = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
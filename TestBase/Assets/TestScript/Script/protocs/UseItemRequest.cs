//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: UseItemRequest.proto
namespace Pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UseItemRequest")]
  public partial class UseItemRequest : global::ProtoBuf.IExtensible
  {
    public UseItemRequest() {}
    
    private uint _bagType;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"bagType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint bagType
    {
      get { return _bagType; }
      set { _bagType = value; }
    }
    private uint _bagIdx;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"bagIdx", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint bagIdx
    {
      get { return _bagIdx; }
      set { _bagIdx = value; }
    }
    private uint _itemid;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"itemid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint itemid
    {
      get { return _itemid; }
      set { _itemid = value; }
    }
    private uint _count;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint count
    {
      get { return _count; }
      set { _count = value; }
    }
    private uint _param;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"param", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint param
    {
      get { return _param; }
      set { _param = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
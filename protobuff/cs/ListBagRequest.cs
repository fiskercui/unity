//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ListBagRequest.proto
namespace Pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ListBagRequest")]
  public partial class ListBagRequest : global::ProtoBuf.IExtensible
  {
    public ListBagRequest() {}
    
    private uint _bagType;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"bagType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint bagType
    {
      get { return _bagType; }
      set { _bagType = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: SellChipRequest.proto
namespace Pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SellChipRequest")]
  public partial class SellChipRequest : global::ProtoBuf.IExtensible
  {
    public SellChipRequest() {}
    
    private readonly global::System.Collections.Generic.List<uint> _pos = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(1, Name=@"pos", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> pos
    {
      get { return _pos; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
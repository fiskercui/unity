//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: LegionSendMessageRequest.proto
namespace Pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"LegionSendMessageRequest")]
  public partial class LegionSendMessageRequest : global::ProtoBuf.IExtensible
  {
    public LegionSendMessageRequest() {}
    
    private string _content;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"content", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string content
    {
      get { return _content; }
      set { _content = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
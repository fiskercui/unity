//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: QiecuoStartRequest.proto
// Note: requires additional types generated from: U64Type.proto
namespace Pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"QiecuoStartRequest")]
  public partial class QiecuoStartRequest : global::ProtoBuf.IExtensible
  {
    public QiecuoStartRequest() {}
    
    private U64Type _player_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public U64Type player_id
    {
      get { return _player_id; }
      set { _player_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
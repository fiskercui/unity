//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ZhuZhenLst.proto
// Note: requires additional types generated from: ZhuZhenItem.proto
namespace Pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ZhuZhenLst")]
  public partial class ZhuZhenLst : global::ProtoBuf.IExtensible
  {
    public ZhuZhenLst() {}
    
    private readonly global::System.Collections.Generic.List<ZhuZhenItem> _allZhuZhen = new global::System.Collections.Generic.List<ZhuZhenItem>();
    [global::ProtoBuf.ProtoMember(1, Name=@"allZhuZhen", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<ZhuZhenItem> allZhuZhen
    {
      get { return _allZhuZhen; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: FriendArray.proto
namespace Pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FriendArray")]
  public partial class FriendArray : global::ProtoBuf.IExtensible
  {
    public FriendArray() {}
    
    private readonly global::System.Collections.Generic.List<ulong> _playerlist = new global::System.Collections.Generic.List<ulong>();
    [global::ProtoBuf.ProtoMember(1, Name=@"playerlist", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<ulong> playerlist
    {
      get { return _playerlist; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _times = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(2, Name=@"times", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> times
    {
      get { return _times; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
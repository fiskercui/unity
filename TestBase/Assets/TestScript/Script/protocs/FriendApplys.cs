//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: FriendApplys.proto
namespace Pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FriendApplys")]
  public partial class FriendApplys : global::ProtoBuf.IExtensible
  {
    public FriendApplys() {}
    
    private readonly global::System.Collections.Generic.List<ulong> _playerids = new global::System.Collections.Generic.List<ulong>();
    [global::ProtoBuf.ProtoMember(1, Name=@"playerids", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<ulong> playerids
    {
      get { return _playerids; }
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
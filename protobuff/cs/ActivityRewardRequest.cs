//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ActivityRewardRequest.proto
namespace Pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ActivityRewardRequest")]
  public partial class ActivityRewardRequest : global::ProtoBuf.IExtensible
  {
    public ActivityRewardRequest() {}
    
    private uint _act_id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"act_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint act_id
    {
      get { return _act_id; }
      set { _act_id = value; }
    }
    private uint _task_id;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"task_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint task_id
    {
      get { return _task_id; }
      set { _task_id = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
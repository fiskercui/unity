//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: AchievementTaskListAnswer.proto
namespace Pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AchievementTaskListAnswer")]
  public partial class AchievementTaskListAnswer : global::ProtoBuf.IExtensible
  {
    public AchievementTaskListAnswer() {}
    
    private uint _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint result
    {
      get { return _result; }
      set { _result = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _entry_id = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(10, Name=@"entry_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> entry_id
    {
      get { return _entry_id; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _entry_progress = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(11, Name=@"entry_progress", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> entry_progress
    {
      get { return _entry_progress; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _entry_state = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(12, Name=@"entry_state", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> entry_state
    {
      get { return _entry_state; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _entry_count = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(13, Name=@"entry_count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> entry_count
    {
      get { return _entry_count; }
    }
  
    private uint _point;
    [global::ProtoBuf.ProtoMember(14, IsRequired = true, Name=@"point", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint point
    {
      get { return _point; }
      set { _point = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _target_id = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(2, Name=@"target_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> target_id
    {
      get { return _target_id; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _target_progress = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(3, Name=@"target_progress", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> target_progress
    {
      get { return _target_progress; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _target_state = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(4, Name=@"target_state", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> target_state
    {
      get { return _target_state; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _target_count = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(5, Name=@"target_count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> target_count
    {
      get { return _target_count; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _section_id = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(6, Name=@"section_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> section_id
    {
      get { return _section_id; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _section_progress = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(7, Name=@"section_progress", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> section_progress
    {
      get { return _section_progress; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _section_state = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(8, Name=@"section_state", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> section_state
    {
      get { return _section_state; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _section_count = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(9, Name=@"section_count", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> section_count
    {
      get { return _section_count; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
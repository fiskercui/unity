//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: ArenaGetPlayerAnswer.proto
// Note: requires additional types generated from: U64Type.proto
namespace Pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ArenaGetPlayerAnswer")]
  public partial class ArenaGetPlayerAnswer : global::ProtoBuf.IExtensible
  {
    public ArenaGetPlayerAnswer() {}
    
    private uint _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint result
    {
      get { return _result; }
      set { _result = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _pet_id = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(10, Name=@"pet_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> pet_id
    {
      get { return _pet_id; }
    }
  
    private uint _self_rank;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"self_rank", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint self_rank
    {
      get { return _self_rank; }
      set { _self_rank = value; }
    }
    private readonly global::System.Collections.Generic.List<U64Type> _player_id = new global::System.Collections.Generic.List<U64Type>();
    [global::ProtoBuf.ProtoMember(3, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<U64Type> player_id
    {
      get { return _player_id; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _rank = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(4, Name=@"rank", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> rank
    {
      get { return _rank; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _fc = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(5, Name=@"fc", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> fc
    {
      get { return _fc; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _main_id = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(6, Name=@"main_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> main_id
    {
      get { return _main_id; }
    }
  
    private readonly global::System.Collections.Generic.List<string> _name = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(7, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> name
    {
      get { return _name; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _level = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(8, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> level
    {
      get { return _level; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _fashion_id = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(9, Name=@"fashion_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> fashion_id
    {
      get { return _fashion_id; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: EnterGameAnswer.proto
// Note: requires additional types generated from: U64Type.proto
namespace Pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"EnterGameAnswer")]
  public partial class EnterGameAnswer : global::ProtoBuf.IExtensible
  {
    public EnterGameAnswer() {}
    
    private uint _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint result
    {
      get { return _result; }
      set { _result = value; }
    }
    private U64Type _player_id;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"player_id", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public U64Type player_id
    {
      get { return _player_id; }
      set { _player_id = value; }
    }
    private string _player_name;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"player_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string player_name
    {
      get { return _player_name; }
      set { _player_name = value; }
    }
    private uint _timestamp;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"timestamp", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint timestamp
    {
      get { return _timestamp; }
      set { _timestamp = value; }
    }
    private int _timezone;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"timezone", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int timezone
    {
      get { return _timezone; }
      set { _timezone = value; }
    }

    private uint _opensrvact = default(uint);
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"opensrvact", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint opensrvact
    {
      get { return _opensrvact; }
      set { _opensrvact = value; }
    }

    private uint _create_ts = default(uint);
    [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"create_ts", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint create_ts
    {
      get { return _create_ts; }
      set { _create_ts = value; }
    }

    private uint _cross_server = default(uint);
    [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"cross_server", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint cross_server
    {
      get { return _cross_server; }
      set { _cross_server = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
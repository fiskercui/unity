//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: CSPointsRaceGetInfoAnswer.proto
namespace Pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CSPointsRaceGetInfoAnswer")]
  public partial class CSPointsRaceGetInfoAnswer : global::ProtoBuf.IExtensible
  {
    public CSPointsRaceGetInfoAnswer() {}
    
    private uint _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint result
    {
      get { return _result; }
      set { _result = value; }
    }
    private uint _duration;
    [global::ProtoBuf.ProtoMember(10, IsRequired = true, Name=@"duration", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint duration
    {
      get { return _duration; }
      set { _duration = value; }
    }
    private uint _end_cd;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"end_cd", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint end_cd
    {
      get { return _end_cd; }
      set { _end_cd = value; }
    }
    private uint _points;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"points", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint points
    {
      get { return _points; }
      set { _points = value; }
    }
    private uint _last_points;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"last_points", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint last_points
    {
      get { return _last_points; }
      set { _last_points = value; }
    }
    private uint _history_points;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"history_points", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint history_points
    {
      get { return _history_points; }
      set { _history_points = value; }
    }
    private uint _rank;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"rank", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint rank
    {
      get { return _rank; }
      set { _rank = value; }
    }
    private uint _fight_times;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"fight_times", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint fight_times
    {
      get { return _fight_times; }
      set { _fight_times = value; }
    }
    private uint _win_times;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"win_times", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint win_times
    {
      get { return _win_times; }
      set { _win_times = value; }
    }
    private uint _continuous_wins;
    [global::ProtoBuf.ProtoMember(9, IsRequired = true, Name=@"continuous_wins", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint continuous_wins
    {
      get { return _continuous_wins; }
      set { _continuous_wins = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
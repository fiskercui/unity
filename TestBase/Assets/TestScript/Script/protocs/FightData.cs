//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: FightData.proto
// Note: requires additional types generated from: FightArray.proto
// Note: requires additional types generated from: FighterStatu.proto
// Note: requires additional types generated from: FightRound.proto
namespace Pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FightData")]
  public partial class FightData : global::ProtoBuf.IExtensible
  {
    public FightData() {}
    
    private FightArray _FightsArray;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"FightsArray", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public FightArray FightsArray
    {
      get { return _FightsArray; }
      set { _FightsArray = value; }
    }
    private readonly global::System.Collections.Generic.List<FighterStatu> _fightersstatu = new global::System.Collections.Generic.List<FighterStatu>();
    [global::ProtoBuf.ProtoMember(2, Name=@"fightersstatu", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<FighterStatu> fightersstatu
    {
      get { return _fightersstatu; }
    }
  
    private readonly global::System.Collections.Generic.List<FightRound> _round = new global::System.Collections.Generic.List<FightRound>();
    [global::ProtoBuf.ProtoMember(3, Name=@"round", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<FightRound> round
    {
      get { return _round; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _cheerlist = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(4, Name=@"cheerlist", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> cheerlist
    {
      get { return _cheerlist; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _opening_buff = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(5, Name=@"opening_buff", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> opening_buff
    {
      get { return _opening_buff; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
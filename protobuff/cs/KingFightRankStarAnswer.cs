//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: KingFightRankStarAnswer.proto
namespace Pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"KingFightRankStarAnswer")]
  public partial class KingFightRankStarAnswer : global::ProtoBuf.IExtensible
  {
    public KingFightRankStarAnswer() {}
    
    private uint _result;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"result", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint result
    {
      get { return _result; }
      set { _result = value; }
    }
    private uint _selfrank;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"selfrank", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint selfrank
    {
      get { return _selfrank; }
      set { _selfrank = value; }
    }
    private uint _selfstar;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"selfstar", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint selfstar
    {
      get { return _selfstar; }
      set { _selfstar = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _ranklist = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(4, Name=@"ranklist", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> ranklist
    {
      get { return _ranklist; }
    }
  
    private readonly global::System.Collections.Generic.List<string> _namelist = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(5, Name=@"namelist", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> namelist
    {
      get { return _namelist; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _starlist = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(6, Name=@"starlist", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> starlist
    {
      get { return _starlist; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: FightArray.proto
namespace Pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"FightArray")]
  public partial class FightArray : global::ProtoBuf.IExtensible
  {
    public FightArray() {}
    
    private readonly global::System.Collections.Generic.List<uint> _positions = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(1, Name=@"positions", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> positions
    {
      get { return _positions; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _pet_refine_lv = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(10, Name=@"pet_refine_lv", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> pet_refine_lv
    {
      get { return _pet_refine_lv; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _roleids = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(2, Name=@"roleids", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> roleids
    {
      get { return _roleids; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _color = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(3, Name=@"color", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> color
    {
      get { return _color; }
    }
  

    private string _name = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string name
    {
      get { return _name; }
      set { _name = value; }
    }

    private string _attack_name = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"attack_name", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string attack_name
    {
      get { return _attack_name; }
      set { _attack_name = value; }
    }
    private readonly global::System.Collections.Generic.List<uint> _roletype = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(6, Name=@"roletype", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> roletype
    {
      get { return _roletype; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _rolefashion = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(7, Name=@"rolefashion", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> rolefashion
    {
      get { return _rolefashion; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _pet_pos = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(8, Name=@"pet_pos", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> pet_pos
    {
      get { return _pet_pos; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _pet_id = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(9, Name=@"pet_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> pet_id
    {
      get { return _pet_id; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
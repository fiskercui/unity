//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: MailInsertRequest.proto
// Note: requires additional types generated from: MailData.proto
namespace Pb
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MailInsertRequest")]
  public partial class MailInsertRequest : global::ProtoBuf.IExtensible
  {
    public MailInsertRequest() {}
    
    private uint _ts;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"ts", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint ts
    {
      get { return _ts; }
      set { _ts = value; }
    }
    private uint _need_res;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"need_res", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint need_res
    {
      get { return _need_res; }
      set { _need_res = value; }
    }
    private uint _templete_id;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"templete_id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint templete_id
    {
      get { return _templete_id; }
      set { _templete_id = value; }
    }
    private string _sender;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"sender", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string sender
    {
      get { return _sender; }
      set { _sender = value; }
    }
    private string _title;
    [global::ProtoBuf.ProtoMember(5, IsRequired = true, Name=@"title", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string title
    {
      get { return _title; }
      set { _title = value; }
    }
    private string _context;
    [global::ProtoBuf.ProtoMember(6, IsRequired = true, Name=@"context", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string context
    {
      get { return _context; }
      set { _context = value; }
    }
    private MailData _data;
    [global::ProtoBuf.ProtoMember(7, IsRequired = true, Name=@"data", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public MailData data
    {
      get { return _data; }
      set { _data = value; }
    }
    private uint _type;
    [global::ProtoBuf.ProtoMember(8, IsRequired = true, Name=@"type", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public uint type
    {
      get { return _type; }
      set { _type = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}
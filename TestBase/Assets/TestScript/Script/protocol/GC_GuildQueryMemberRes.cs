﻿namespace com.kodgames.corgi.protocol
{
    using ProtoBuf;
    using System;
    using System.Collections.Generic;

    [ProtoContract(Name="GC_GuildQueryMemberRes")]
    public class GC_GuildQueryMemberRes : IExtensible
    {
        private int _callback;
        private readonly List<GuildMemberInfo> _guildMemberInfos = new List<GuildMemberInfo>();
        private int _result;
        private IExtension extensionObject;

        IExtension IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
        }

        [ProtoMember(1, IsRequired=true, Name="callback", DataFormat=DataFormat.TwosComplement)]
        public int callback
        {
            get
            {
                return this._callback;
            }
            set
            {
                this._callback = value;
            }
        }

        [ProtoMember(3, Name="guildMemberInfos", DataFormat=DataFormat.Default)]
        public List<GuildMemberInfo> guildMemberInfos
        {
            get
            {
                return this._guildMemberInfos;
            }
        }

        [ProtoMember(2, IsRequired=true, Name="result", DataFormat=DataFormat.TwosComplement)]
        public int result
        {
            get
            {
                return this._result;
            }
            set
            {
                this._result = value;
            }
        }
    }
}


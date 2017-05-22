﻿namespace com.kodgames.corgi.protocol
{
    using ProtoBuf;
    using System;
    using System.ComponentModel;

    [ProtoContract(Name="CG_SetDungeonDialogStateReq")]
    public class CG_SetDungeonDialogStateReq : IExtensible
    {
        private int _callback;
        private int _dialogState;
        private int _dungeonId;
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

        [ProtoMember(3, IsRequired=false, Name="dialogState", DataFormat=DataFormat.TwosComplement), DefaultValue(0)]
        public int dialogState
        {
            get
            {
                return this._dialogState;
            }
            set
            {
                this._dialogState = value;
            }
        }

        [ProtoMember(2, IsRequired=false, Name="dungeonId", DataFormat=DataFormat.TwosComplement), DefaultValue(0)]
        public int dungeonId
        {
            get
            {
                return this._dungeonId;
            }
            set
            {
                this._dungeonId = value;
            }
        }
    }
}


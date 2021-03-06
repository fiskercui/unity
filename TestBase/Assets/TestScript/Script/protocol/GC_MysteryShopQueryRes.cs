﻿namespace com.kodgames.corgi.protocol
{
    using ProtoBuf;
    using System;
    using System.ComponentModel;

    [ProtoContract(Name="GC_MysteryShopQueryRes")]
    public class GC_MysteryShopQueryRes : IExtensible
    {
        private int _callback;
        private int _result;
        private MysteryShopInfo _shopInfo;
        private int _shopType;
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

        [DefaultValue((string) null), ProtoMember(4, IsRequired=false, Name="shopInfo", DataFormat=DataFormat.Default)]
        public MysteryShopInfo shopInfo
        {
            get
            {
                return this._shopInfo;
            }
            set
            {
                this._shopInfo = value;
            }
        }

        [DefaultValue(0), ProtoMember(3, IsRequired=false, Name="shopType", DataFormat=DataFormat.TwosComplement)]
        public int shopType
        {
            get
            {
                return this._shopType;
            }
            set
            {
                this._shopType = value;
            }
        }
    }
}


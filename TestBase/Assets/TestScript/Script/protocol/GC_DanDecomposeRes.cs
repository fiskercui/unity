﻿namespace com.kodgames.corgi.protocol
{
    using ProtoBuf;
    using System;
    using System.ComponentModel;

    [ProtoContract(Name="GC_DanDecomposeRes")]
    public class GC_DanDecomposeRes : IExtensible
    {
        private int _callback;
        private CostAndRewardAndSync _costAndRewardAndSync;
        private DecomposeInfo _decomposeInfo;
        private bool _isNeedRefresh;
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

        [ProtoMember(3, IsRequired=false, Name="costAndRewardAndSync", DataFormat=DataFormat.Default), DefaultValue((string) null)]
        public CostAndRewardAndSync costAndRewardAndSync
        {
            get
            {
                return this._costAndRewardAndSync;
            }
            set
            {
                this._costAndRewardAndSync = value;
            }
        }

        [ProtoMember(5, IsRequired=false, Name="decomposeInfo", DataFormat=DataFormat.Default), DefaultValue((string) null)]
        public DecomposeInfo decomposeInfo
        {
            get
            {
                return this._decomposeInfo;
            }
            set
            {
                this._decomposeInfo = value;
            }
        }

        [DefaultValue(false), ProtoMember(4, IsRequired=false, Name="isNeedRefresh", DataFormat=DataFormat.Default)]
        public bool isNeedRefresh
        {
            get
            {
                return this._isNeedRefresh;
            }
            set
            {
                this._isNeedRefresh = value;
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


﻿// Copyright 2015 - 2019 Andreas Jakl, Chris Tacke and Contributors. All rights reserved. 
// https://github.com/andijakl/universal-beacon 
// 
// This code is licensed under the MIT License.
// See the LICENSE file in the project root for more information.

namespace UniversalBeacon.Library.Core.Interop
{
    public sealed class BLEGenericRecord : BLERecord
    {
        public byte[] RawData { get; private set; }

        public BLEGenericRecord(BLEPacketType packetType, byte[] data)
            : base(packetType)
        {
            RawData = data;
        }
    }
}

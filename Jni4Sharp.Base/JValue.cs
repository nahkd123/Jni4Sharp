using System;
using System.Runtime.InteropServices;

namespace Jni4Sharp.Base
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe struct JValue
    {
        [FieldOffset(0)] public byte Z;
        [FieldOffset(0)] public sbyte B;
        [FieldOffset(0)] public ushort C;
        [FieldOffset(0)] public short S;
        [FieldOffset(0)] public int I;
        [FieldOffset(0)] public long J;
        [FieldOffset(0)] public float F;
        [FieldOffset(0)] public double D;
        [FieldOffset(0)] public JObject* L;
    }
}

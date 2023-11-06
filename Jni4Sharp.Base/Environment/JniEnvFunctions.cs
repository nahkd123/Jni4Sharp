using System;
using System.Runtime.InteropServices;

namespace Jni4Sharp.Base.Environment
{
    [StructLayout(LayoutKind.Sequential)]
    public unsafe struct JniEnvFunctions
    {
        // From https://docs.oracle.com/javase/8/docs/technotes/guides/jni/spec/functions.html#interface_function_table
        /*
         * "Note that the first three entries are reserved for future compatibility with COM.
         * In addition, we reserve a number of additional NULL entries near the beginning of the function
         * table, so that, for example, a future class-related JNI operation can be added after FindClass,
         * rather than at the end of the table."
         */
        public nint Reserved0;
        public nint Reserved1;
        public nint Reserved2;
        public nint Reserved3;
        public delegate* unmanaged[Stdcall]<JniEnvFunctions**, int> GetVersion;

        public nint DefineClass;
        public delegate* unmanaged[Stdcall]<JniEnvFunctions**, string, void*> FindClass;

        // Reflective stuffs
        public nint FromReflectedMethod;
        public nint FromReflectedField;
        public nint ToReflectedMethod;
        public nint GetSuperclass;
        public nint IsAssignableFrom;
        public nint ToReflectedField;

        // Throwables
        public nint Throw;
        public nint ThrowNew;
        public nint ExceptionOccurred;
        public nint ExceptionDescribe;
        public nint ExceptionClear;
        public nint FatalError;

        // Frames
        public nint PushLocalFrame;
        public nint PopLocalFrame;

        // Refs
        public nint NewGlobalRef;
        public nint DeleteGlobalRef;
        public nint DeleteLocalRef;
        public nint IsSameObject;
        public nint NewLocalRef;
        public nint EnsureLocalCapacity;

        // Instantiation
        public nint AllocObject;
        public nint NewObject;
        public nint NewObjectV;
        public nint NewObjectA;

        // ???
        public delegate* unmanaged[Stdcall]<JniEnvFunctions**, void*, void*> GetObjectClass;
        public nint IsInstanceOf;

        // Methods
        public delegate* unmanaged[Stdcall]<JniEnvFunctions**, void*, string, string, void*> GetMethodId;

        public nint CallObjectMethod;
        public nint CallObjectMethodV;
        public nint CallObjectMethodA;
        public nint CallBooleanMethod;
        public nint CallBooleanMethodV;
        public delegate* unmanaged[Stdcall]<JniEnvFunctions**, void*, void*, JValue[], bool> CallBooleanMethodA;
        public nint CallByteMethod;
        public nint CallByteMethodV;
        public delegate* unmanaged[Stdcall]<JniEnvFunctions**, void*, void*, JValue[], sbyte> CallByteMethodA;
        public nint CallCharMethod;
        public nint CallCharMethodV;
        public delegate* unmanaged[Stdcall]<JniEnvFunctions**, void*, void*, JValue[], ushort> CallCharMethodA;
        public nint CallShortMethod;
        public nint CallShortMethodV;
        public delegate* unmanaged[Stdcall]<JniEnvFunctions**, void*, void*, JValue[], short> CallShortMethodA;
        public nint CallIntMethod;
        public nint CallIntMethodV;
        public delegate* unmanaged[Stdcall]<JniEnvFunctions**, void*, void*, JValue[], int> CallIntMethodA;
        public nint CallLongMethod;
        public nint CallLongMethodV;
        public delegate* unmanaged[Stdcall]<JniEnvFunctions**, void*, void*, JValue[], long> CallLongMethodA;
        public nint CallFloatMethod;
        public nint CallFloatMethodV;
        public delegate* unmanaged[Stdcall]<JniEnvFunctions**, void*, void*, JValue[], float> CallFloatMethodA;
        public nint CallDoubleMethod;
        public nint CallDoubleMethodV;
        public delegate* unmanaged[Stdcall]<JniEnvFunctions**, void*, void*, JValue[], double> CallDoubleMethodA;
        public nint CallVoidMethod;
        public nint CallVoidMethodV;
        public delegate* unmanaged[Stdcall]<JniEnvFunctions**, void*, void*, JValue[], void> CallVoidMethodA;

        public nint CallNonvirtualObjectMethod;
        public nint CallNonvirtualObjectMethodV;
        public nint CallNonvirtualObjectMethodA;
        public nint CallNonvirtualBooleanMethod;
        public nint CallNonvirtualBooleanMethodV;
        public nint CallNonvirtualBooleanMethodA;
        public nint CallNonvirtualByteMethod;
        public nint CallNonvirtualByteMethodV;
        public nint CallNonvirtualByteMethodA;
        public nint CallNonvirtualCharMethod;
        public nint CallNonvirtualCharMethodV;
        public nint CallNonvirtualCharMethodA;
        public nint CallNonvirtualShortMethod;
        public nint CallNonvirtualShortMethodV;
        public nint CallNonvirtualShortMethodA;
        public nint CallNonvirtualIntMethod;
        public nint CallNonvirtualIntMethodV;
        public nint CallNonvirtualIntMethodA;
        public nint CallNonvirtualLongMethod;
        public nint CallNonvirtualLongMethodV;
        public nint CallNonvirtualLongMethodA;
        public nint CallNonvirtualFloatMethod;
        public nint CallNonvirtualFloatMethodV;
        public nint CallNonvirtualFloatMethodA;
        public nint CallNonvirtualDoubleMethod;
        public nint CallNonvirtualDoubleMethodV;
        public nint CallNonvirtualDoubleMethodA;
        public nint CallNonvirtualVoidMethod;
        public nint CallNonvirtualVoidMethodV;
        public nint CallNonvirtualVoidMethodA;
        public nint GetFieldId;
        public nint GetObjectField;
        public nint GetBooleanField;
        public nint GetByteField;
        public nint GetCharField;
        public nint GetShortField;
        public nint GetIntField;
        public nint GetLongField;
        public nint GetFloatField;
        public nint GetDoubleField;
        public nint SetFieldId;
        public nint SetObjectField;
        public nint SetBooleanField;
        public nint SetByteField;
        public nint SetCharField;
        public nint SetShortField;
        public nint SetIntField;
        public nint SetLongField;
        public nint SetFloatField;
        public nint SetDoubleField;

        // More pointers will be added at a later date!
    }
}

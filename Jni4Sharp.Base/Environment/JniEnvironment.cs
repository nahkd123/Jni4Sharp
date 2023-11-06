using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Jni4Sharp.Base.Environment
{
    public unsafe struct JniEnvironment
    {
        /// <summary>
        /// A table of JNI function pointers. See JNINativeInterface struct in "jni.h" for a
        /// complete list of functions. If you really need to access the pointers for some
        /// reason, you can use this.
        /// </summary>
        public JniEnvFunctions** FunctionPointers;

        /// <summary>
        /// Get both major and minor version number.
        /// </summary>
        /// <returns>A tuple with the first element as major version and second element
        /// as minor version.</returns>
        public (int, int) GetVersion()
        {
            int combined = (*FunctionPointers)->GetVersion(FunctionPointers);
            return (combined >> 16, combined & 0xFFFF);
        }

        /// <summary>
        /// Find the class with given path to class, with the name follows the "path/to/Class"
        /// format instead of the usual "path.to.Class".
        /// </summary>
        /// <param name="name">Path to class. Each package level is separated by foreward
        /// slash ("/") instead of the usual dot (".") character, like "java/lang/String"
        /// for example.</param>
        /// <returns>(Currently) A void* pointer to the class.</returns>
        public JObject? FindClass(string name)
        {
            void* ptr = (*FunctionPointers)->FindClass(FunctionPointers, name);
            return ptr == null ? null : new JObject() { Pointer = ptr };
        }

        public JObject? GetObjectClass(JObject jobj)
        {
            void* ptr = (*FunctionPointers)->GetObjectClass(FunctionPointers, jobj.Pointer);
            return ptr == null ? null : new JObject() { Pointer = ptr };
        }

        public JMethodId? GetMethodId(JObject clazz, string methodName, string signature)
        {
            void* ptr = (*FunctionPointers)->GetMethodId(FunctionPointers, clazz.Pointer, methodName, signature);
            return ptr == null ? null : new JMethodId() { Pointer = ptr };
        }

        public bool CallBooleanMethod(JObject jobj, JMethodId methodId, params JValue[] args)
        {
            return (*FunctionPointers)->CallBooleanMethodA(FunctionPointers, jobj.Pointer, methodId.Pointer, args);
        }

        public sbyte CallByteMethod(JObject jobj, JMethodId methodId, params JValue[] args)
        {
            return (*FunctionPointers)->CallByteMethodA(FunctionPointers, jobj.Pointer, methodId.Pointer, args);
        }

        public ushort CallCharMethod(JObject jobj, JMethodId methodId, params JValue[] args)
        {
            return (*FunctionPointers)->CallCharMethodA(FunctionPointers, jobj.Pointer, methodId.Pointer, args);
        }

        public short CallShortMethod(JObject jobj, JMethodId methodId, params JValue[] args)
        {
            return (*FunctionPointers)->CallShortMethodA(FunctionPointers, jobj.Pointer, methodId.Pointer, args);
        }

        public int CallIntMethod(JObject jobj, JMethodId methodId, params JValue[] args)
        {
            return (*FunctionPointers)->CallIntMethodA(FunctionPointers, jobj.Pointer, methodId.Pointer, args);
        }

        public long CallLongMethod(JObject jobj, JMethodId methodId, params JValue[] args)
        {
            return (*FunctionPointers)->CallLongMethodA(FunctionPointers, jobj.Pointer, methodId.Pointer, args);
        }

        public float CallFloatMethod(JObject jobj, JMethodId methodId, params JValue[] args)
        {
            return (*FunctionPointers)->CallFloatMethodA(FunctionPointers, jobj.Pointer, methodId.Pointer, args);
        }

        public double CallDoubleMethod(JObject jobj, JMethodId methodId, params JValue[] args)
        {
            return (*FunctionPointers)->CallDoubleMethodA(FunctionPointers, jobj.Pointer, methodId.Pointer, args);
        }

        public void CallVoidMethod(JObject jobj, JMethodId methodId, params JValue[] args)
        {
            (*FunctionPointers)->CallVoidMethodA(FunctionPointers, jobj.Pointer, methodId.Pointer, args);
        }
    }
}

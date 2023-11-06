using Jni4Sharp.Base;
using Jni4Sharp.Base.Environment;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Jni4Sharp.SampleLibrary
{
    public class MyLibrary
    {
        [UnmanagedCallersOnly(EntryPoint = "Java_io_github_nahkd123_jni4sharp_sample_SampleLibrary_staticMethod")]
        public static void StaticMethod(JniEnvironment jniEnv, JObject clazz, int answer)
        {
            Console.WriteLine($"Current version: {jniEnv.GetVersion()}");
            Console.WriteLine($"java.lang.String is {jniEnv.FindClass("java/lang/String")}");
        }

        [UnmanagedCallersOnly(EntryPoint = "Java_io_github_nahkd123_jni4sharp_sample_SampleLibrary_doTheCallback")]
        public static void DoTheCallback(JniEnvironment jniEnv, JObject clazz, JObject callback)
        {
            Console.WriteLine($"C# Universe: Calling the callback...");
            JObject? callbackClass = jniEnv.GetObjectClass(callback);
            JMethodId? method = jniEnv.GetMethodId(callbackClass!.Value, "invoke", "(I)V");

            if (method.HasValue)
            {
                jniEnv.CallVoidMethod(callback, method.Value, new JValue() { I = 69 });
            }
            else
            {
                Console.Error.WriteLine("Method 'invoke' not found in callback!");
            }
        }
    }
}
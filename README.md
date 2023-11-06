# Jni4Sharp
_An attempt to allow me to write JNI native libraries in C# a little bit easier._

## Why was C# chosen?
You see, people have been joking about C# for a while. They said this is Microsoft's Java, and well, it _does_ feels like Java, except it isn't in some cases.

Ok I gotta admit, the initial goal of making this is to help me gain access to Windows Ink API from within Java process. Ink API is needed for me to add pen/stylus pressure tracking to one of my Fabric mod (it is about sculpting!).

## Using Jni4Sharp
### Prerequisites (for C# projects only)
- .NET 7.0
- Ahead-of-time (AOT) complication is enabled in your C# project (add `<PublishAot>true</PublishAot>` to your `.csproj`).
- You may need to enable `unsafe` if you are into the world of unsafes.

### Adding native method in Javaland (or Java universe, idk tbh)
Simply add `native` modifier!

```java
package com.example; // Take note of package; it is important!

class MyLibrary {
    public static native void myStaticNativeMethod(int a);
    public native void myInstanceNativeMethod(int a);
}
```

### Binding to those native methods in Javaland with methods in C# universe
```csharp
class MyLibrary
{
    // I think you can't have dots or slashes in entry point names, so you'll
    // have to use underscores to separate package levels.
    // Oh and the entry point name must starts with "Java_". This is important!!!
    [UnmanagedCallersOnly(EntryPoint = "Java_com_example_MyLibrary_myStaticNativeMethod")]
    public static void MyStaticNativeMethod(JniEnvironment jniEnv, JObject clazz, int a)
    {
        Console.WriteLine(a);
    }
    
    [UnmanagedCallersOnly(EntryPoint = "Java_com_example_MyLibrary_myInstanceNativeMethod")]
    public static void MyInstanceNativeMethod(JniEnvironment jniEnv, JObject thiz, int a)
    {
        Console.WriteLine($"Instance; {a}");
    }
}
```

## Copyright and License
(c) nahkd 2023. Licensed under MIT because I'm cool :sunglasses:.
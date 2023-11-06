package io.github.nahkd123.jni4sharp.sample;

public class SampleLibrary {
	@FunctionalInterface
	public static interface MyCallbackType {
		public void invoke(int number);
	}

	public static native void staticMethod(int answer);
	public static native void doTheCallback(MyCallbackType callback);
}

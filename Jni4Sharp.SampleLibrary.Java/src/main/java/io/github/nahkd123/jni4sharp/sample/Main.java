package io.github.nahkd123.jni4sharp.sample;

import java.io.IOException;
import java.nio.file.Path;

public class Main {
	public static void main(String[] args) throws IOException {
		System.out.println("Loading native library...");
		String pathToLib = Path.of("..", "Jni4Sharp.SampleLibrary", "bin", "Release", "net7.0", "publish", "win-x64", "Jni4Sharp.SampleLibrary.dll").toAbsolutePath().normalize().toString();

		System.load(pathToLib);
		SampleLibrary.staticMethod(42);
		SampleLibrary.doTheCallback(number -> {
			System.out.println("Java Universe: Java callback received a number! It is " + number);
		});
	}
}

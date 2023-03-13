using System;
using System.Threading;

public class MyClass
{

	static void Main(string[] args) {
		Console.WriteLine("MyClass: Hello World!");
		Console.WriteLine("Current Thread State = " + Thread.CurrentThread.ThreadState);
        Console.WriteLine("Current Thread Name = " + Thread.CurrentThread.Name);

		MyClass myClass = new MyClass();

		Thread thread1 = new Thread(new ThreadStart(myClass.threadMethod));
		thread1.Start();
    }


	public void threadMethod()
	{
		for (var i = 0; i < 10; i++) {

			Console.WriteLine(i);
		}

	}
}

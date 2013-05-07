using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JenkinsTestProject
{
	class Program
	{
		static void Main(string[] args)
		{
			WriteHelloWorldToConsole();
			WriteSecondaryGreetingToConsole();
			AwaitUserResponse();
		}

		private static void WriteSecondaryGreetingToConsole()
		{
			Console.WriteLine("You're my homie!");
		}

		private static void AwaitUserResponse()
		{
			Console.Write("Yo, press a key, dude ...");
			Console.ReadLine();
		}

		private static void WriteHelloWorldToConsole()
		{
			Console.WriteLine("Hello, World!");
		}
	}
}

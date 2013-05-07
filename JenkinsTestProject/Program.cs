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
			TalkBacktoUser();
		}

		private static void TalkBacktoUser()
		{
			Console.WriteLine("Really? That's the one you're going to press? Couldn't you be a little more imaginative?");
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

using System;
using Nancy.Hosting.Self;
using System.Linq;
using System.Threading;

namespace NancyExample
{
	class Program
	{
		static void Main(string[] args)
		{
			var uri = "http://localhost:8888";
			Console.WriteLine(uri);
			// initialize an instance of NancyHost (found in the Nancy.Hosting.Self package)
			var host = new NancyHost(new Uri(uri));
			host.Start();  // start hosting

			//Under mono if you deamonize a process a Console.ReadLine with cause an EOF 
			//so we need to block another way
			if (args.Any(s => s.Equals("-d", StringComparison.CurrentCultureIgnoreCase)))
			{
				Thread.Sleep(Timeout.Infinite);
			}
			else
			{
				Console.ReadKey();
			}

			host.Stop();  // stop hosting
		}
	}
}

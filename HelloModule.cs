﻿using System;
using Nancy;

namespace NancyExample
{
	public class HelloModule : NancyModule
	{
		public HelloModule()
		{
			Get["/"] = parameters => "Hello World";
		}
	}
}


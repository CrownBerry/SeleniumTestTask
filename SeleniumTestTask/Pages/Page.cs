using System;

namespace SeleniumTestTask.Pages
{
	[AttributeUsage(AttributeTargets.Class)]
	public class Page : Attribute
	{
		public string Name { get; }

		public Page(string name)
		{
			Name = name;
		}

		public override string ToString()
		{
			return Name;
		}
	}
}
using System;

public interface IName
{
	string GetName();
}

public class Person : IName
{
	public string GetName()
	{
		return "Person"
	}
}

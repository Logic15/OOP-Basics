using System;

public class Person
{
	private string _firstName { get; set; }

	private string _lastName { get; set; }

	private int _age { get; set; }

	public Person(string firstName, string lastName, int age)
	{
		this._firstName = firstName;
		this._lastName = lastName;
		this._age = age;
	}

	public void Info()
	{
		if (this._firstName == null || this._lastName == null || this._age == null)
		{
			Console.WriteLine("I love you, you do not init me <3");
		}
		else
		{
			Console.WriteLine("Ahoj, jmenuji se {0} {1} a je mi {2} let.", this._firstName, this._lastName, this._age);
		}
	}
}

public class Program
{
	public static void Main()
	{
		// Person badPerson = new Person(null, null, 0);
		Person personSimpsons = new Person("Homer", "Simpson", 47);
		personSimpsons.Info();
	}
}
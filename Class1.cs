using System;

public class Person
{
    public string Name = "姓氏";
	public Person(string n)
	{
        Name = n;
	}
}
public class Student : Person
{
    public string stdname = "名字";
    public Student(string n) : base("陳")
    {
        stdname = Name + n;
    }
}

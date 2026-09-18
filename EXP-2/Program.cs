using System;
class Person
{
    protected string name;
    protected int age;
    public void GetPersonDetails()
    {
        Console.Write("Enter Name: ");
        name = Console.ReadLine();
        Console.Write("Enter Age: ");
        age = Convert.ToInt32(Console.ReadLine());
    }
}
class Student : Person
{
    private int rollNo;
    public void GetStudentDetails()
    {
        GetPersonDetails();
        Console.Write("Enter Roll Number: ");
        rollNo = Convert.ToInt32(Console.ReadLine());
    }
    public void DisplayDetails()
    {
        Console.WriteLine("\n--- Student Details ---");
        Console.WriteLine("Name        : " + name);
        Console.WriteLine("Age         : " + age);
        Console.WriteLine("Roll Number : " + rollNo);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student s = new Student();
        s.GetStudentDetails();
        s.DisplayDetails();
        Console.ReadKey();
    }
}


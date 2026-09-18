
using System;
class Student
{
    string Name;
    int RollNo;
    string Department;
    public void GetDetails()
    {
        Name = "Rithika";
        RollNo = 101;
        Department = "Information Technology";
    }
    public void DisplayDetails()
    {
        Console.WriteLine("Student Details");
        Console.WriteLine("---------------------");
        Console.WriteLine("Name       : " + Name);
        Console.WriteLine("Roll No    : " + RollNo);
        Console.WriteLine("Department : " + Department);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.GetDetails();
        s1.DisplayDetails();

        Console.ReadLine();
    }
}




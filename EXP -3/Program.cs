using System;
class Complex
{
    int real, imag;
    public Complex(int r, int i)
    {
        real = r;
        imag = i;
    }
    // Operator Overloading
    public static Complex operator +(Complex c1, Complex c2)
    {
        return new Complex(c1.real + c2.real, c1.imag + c2.imag);
    }
    public void Display()
    {
        Console.WriteLine(real + " + " + imag + "i");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Complex c1 = new Complex(4, 5);
        Complex c2 = new Complex(2, 3);
        Complex c3 = c1 + c2;

        Console.Write("First Complex Number  : ");
        c1.Display();
        Console.Write("Second Complex Number : ");
        c2.Display();
        Console.Write("Sum   : ");
        c3.Display();
        Console.ReadKey();
    }
}


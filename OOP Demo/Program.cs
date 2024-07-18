using OOP_Demo.Inheritance;

namespace OOP_Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Inheritance 
            Child child = new Child(x: 1, y: 2);
            Console.WriteLine(child.X);
            Console.WriteLine(child.Y);


            child.X = 10;
            child.Y = 20;

            child.Fun1();
            child.Fun2();


          
        }
    }
}

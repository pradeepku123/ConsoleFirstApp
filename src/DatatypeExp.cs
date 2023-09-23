namespace ConsoleFirstApp;

class DatatypeExp
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to C# Datatype Exploration");
        //Data type int, double, float,
        // variable declaration
        int num1;
        //Assign value to a variable
        num1 = 10;
        Console.WriteLine($"variable num1={num1}");
        int num2 = 10;
        Console.WriteLine("variable num2= {0}", num2);

        double d1 = 2348765463532445469;
        float f1 = 2348765463532445469f;
        Console.WriteLine($"Double d1={d1}");
        Console.WriteLine($"Float f1 ={f1 / 7899234560}");

    }
}
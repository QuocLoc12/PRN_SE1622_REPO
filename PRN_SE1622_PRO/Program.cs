namespace fptedu.se1622;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"Hello, World....");

        int x = 10, y = 20;

        Console.WriteLine($"Total of a = {x} and b = {y} is: {Sum(x,y)}");
        Console.ReadLine();
    }

    public static int Sum(int a, int b)
    {
        return a + b;
    }
}

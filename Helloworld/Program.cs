namespace Helloworld;
public class Program
{
    public static string GetGreeting()
    {
        return "Ola, mundo!" ; 
    }    

    static void Main(string[] args)
    {
        Console.WriteLine(GetGreeting());
    }
}
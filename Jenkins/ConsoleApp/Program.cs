internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(Lib.Saudacao.Cumprimentar(args[0], DateTime.Now));
    }
}
internal class Program
{
    private static void Main(string[] args)
    {
        if (args != null)
        {
            Console.WriteLine(Lib.Saudacao.Cumprimentar(args[0], DateTime.Now));
        }
        else
        {
            Console.WriteLine("Tem que indicar um argumento");
        }

    }
}
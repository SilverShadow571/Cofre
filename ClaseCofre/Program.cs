namespace ClaseCofre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CofreMadera cofreMadera = new CofreMadera();
            cofreMadera.Abrir();
            Console.ReadKey();
            cofreMadera.Abrir();
            Console.ReadKey();
        }
    }
}

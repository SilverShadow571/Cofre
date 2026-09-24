namespace ClaseCofre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CofreMadera cofreMadera = new CofreMadera();
            //Se abre el cofre por primera vez.
            cofreMadera.Abrir();
            Console.ReadKey();
            //La segunda vez el cofre ya esta vacio.
            cofreMadera.Abrir();
            Console.ReadKey();
        }
    }
}

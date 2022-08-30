namespace MinhaCalculadoraDeSignos
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Que dia você nasceu? ");
            int dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Que mes você nasceu? ");
            int mes = int.Parse(Console.ReadLine());

            InterpretadorSigno interpretador = new InterpretadorSigno();
            Signo signo = interpretador.Interpretar(dia, mes);

            Console.WriteLine($"Seu signo é {signo.nome}, a característica do seu signo é {signo.caracteristicas}");
        }
    }
}
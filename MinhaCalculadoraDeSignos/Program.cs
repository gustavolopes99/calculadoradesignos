namespace MinhaCalculadoraDeSignos
{
    class Program
    {
        static void Main()
        {
            int dia = 0;
            int mes = 0;

            try
            {
                Console.WriteLine("Que dia você nasceu? ");
                dia = int.Parse(Console.ReadLine());
                Console.WriteLine("Que mes você nasceu? ");
                mes = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Não é permitido letras, digite apenas números!");
                Main();
            }

            InterpretadorSigno interpretador = new InterpretadorSigno();
            Signo signo = interpretador.Interpretar(dia, mes);

            if (signo != null)
            {
                Console.WriteLine($"Seu signo é {signo.nome}, a característica do seu signo é {signo.caracteristicas}");
            }
            else
            {
                Console.WriteLine("Data incorreta! Tente novamente.");
            }
        }
    }
}
public class Program()
{
    public static async Task Main(string[] args)
    {
        Console.WriteLine("Tecle algo para iniciar...\n");
        Console.ReadKey();
        await Aguardar(5);
        Console.WriteLine("Já passou 5 segundos ...\n");
        Console.WriteLine("fim");
        Console.ReadLine();
    }

    static async Task Aguardar(int tempo)
    {
        Console.WriteLine("Iniciando espera ....\n ");
        await Task.Delay(TimeSpan.FromSeconds(tempo));
        Console.WriteLine("Fim da espera...\n");


    }
}




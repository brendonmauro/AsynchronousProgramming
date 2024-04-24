using System.Diagnostics;
using System.Net.NetworkInformation;

public class Program()
{
    public static async Task Main(string[] args)
    {
        //await ExecutaTarefasAsync();
        await ExecutaTarefasAsyncWhenAll();
    }

    private static async Task ExecutaTarefasAsync()
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();

        var dados = await ExtrairDadosAsync();
        Console.WriteLine("Tempo para extrar dados ...." + stopwatch.Elapsed);

        var resultado = await InserirDadosAsync();
        Console.WriteLine("Tempo gasto para inserir dados ..." + stopwatch.Elapsed + "\n");
    }

    private static async Task ExecutaTarefasAsyncWhenAll()
    {
        var stopwatch = new Stopwatch();
        stopwatch.Start();

        var dadosTask = ExtrairDadosAsync();
        var resultadoTask = InserirDadosAsync();

        await Task.WhenAll(dadosTask, resultadoTask);

        Console.WriteLine("Tempo gasto para extrar e inserir dados..." + stopwatch.Elapsed);

        Console.WriteLine("Resultado de Extrair Dados = " + dadosTask.Result);
        Console.WriteLine("Resultado de Inserir Dados = " + resultadoTask.Result);
    }

    private static async Task<string> ExtrairDadosAsync()
    {
        Console.WriteLine("Extrair dados executou");
        string dados = "Dados";
        await Task.Delay(TimeSpan.FromMilliseconds(1500));
        return dados;
    }

    private static async Task<bool> InserirDadosAsync()
    {
        Console.WriteLine("\nInserir dados executou");
        var resultado = true;
        await Task.Delay(TimeSpan.FromMilliseconds(2500));
        return resultado;
    }
}




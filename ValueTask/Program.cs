public class Program()
{
    public static async Task Main(string[] args)
    {
        int res = CalcularSoma(2, 3).Result;

        Console.WriteLine(res);
        Console.ReadKey();
    }

    static async ValueTask<int> CalcularSoma(int a, int b)
    {
        if (a == 0 && b == 0)
        {
            return 0;
        }
        return await Task.Run(() => a + b);


    }
}




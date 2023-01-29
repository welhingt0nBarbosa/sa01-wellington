internal class Program
{
    private static void Main(string[] args)
    {
        decimal valorUnitario = 10;

        Console.WriteLine("Digite a contia de aviões:  ");
        int frotaAvioes = int.Parse(Console.ReadLine());
        decimal geraozao = valorUnitario * frotaAvioes;
        Console.WriteLine($"Total geral: {geraozao}");
    }
}
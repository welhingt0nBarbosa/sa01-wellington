internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("digite a quantidade de aviões: ");
        int quantidadeAvioes = int.Parse(Console.ReadLine());
        int quantidadeAcentos = 17;

        int produto = quantidadeAvioes * quantidadeAcentos;

        Console.WriteLine(produto);
    }
}
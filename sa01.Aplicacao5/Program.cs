internal class Program
{
    private static void Main(string[] args)
    {
        double faturamento1, faturamento2, faturamento3;
        
        Console.WriteLine("Digite o faturamento do primeiro trimestre: ");
        faturamento1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Agora o do 2°");
        faturamento2= double.Parse(Console.ReadLine());

        Console.WriteLine("3°...");

        faturamento3= double.Parse(Console.ReadLine());

        double media = (faturamento1+ faturamento2+faturamento3)/3;
        Console.WriteLine($"A média trimestral é: {media}");


    }
}
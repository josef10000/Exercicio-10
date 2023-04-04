namespace Exercicio_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valorSaque, notas50, notas20, notas10, notas5, notas1, resto;

            Console.Write("Digite o valor do saque: ");
            valorSaque = int.Parse(Console.ReadLine());

            notas50 = valorSaque / 50;
            resto = valorSaque % 50;

            notas20 = resto / 20;
            resto = resto % 20;

            notas10 = resto / 10;
            resto = resto % 10;

            notas5 = resto / 5;
            resto = resto % 5;

            notas1 = resto;

            Console.WriteLine("Notas de 50: " + notas50);
            Console.WriteLine("Notas de 20: " + notas20);
            Console.WriteLine("Notas de 10: " + notas10);
            Console.WriteLine("Notas de 5: " + notas5);
            Console.WriteLine("Notas de 1: " + notas1);
        }
    }
}
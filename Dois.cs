using System.Diagnostics;

class Dois
{
    static void Main()
    {
        Console.Write("Digite um número: ");
        int numero = int.Parse(Console.ReadLine());

        bool pertence = PertenceFibonacci(numero);

        if (pertence)
        {
            Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
        }
    }

    static bool PertenceFibonacci(int num)
    {
        int a = 0, b = 1;

        if (num == a || num == b) return true;

        while (b < num)
        {
            int temp = b;
            b = a + b;
            a = temp;
        }

        return b == num;
    }
    
}
    
 

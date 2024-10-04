
class Cinco
{
    static void Main()
    {
        
        Console.Write("Digite uma string para inverter: ");
        string original = Console.ReadLine();

        string invertida = InverterString(original);

        
        Console.WriteLine($"String invertida: {invertida}");
    }

    static string InverterString(string str)
    {
        char[] caracteres = new char[str.Length];

        for (int i = 0; i < str.Length; i++)
        {
            caracteres[i] = str[str.Length - 1 - i];
        }

        return new string(caracteres);
    }
}
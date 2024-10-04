class Quatro

{
    static void Main()
    {
     
        double sp = 67836.43;
        double rj = 36678.66;
        double mg = 29229.88;
        double es = 27165.48;
        double outros = 19849.53;

        double total = sp + rj + mg + es + outros;

        double percentualSP = (sp / total) * 100;
        double percentualRJ = (rj / total) * 100;
        double percentualMG = (mg / total) * 100;
        double percentualES = (es / total) * 100;
        double percentualOutros = (outros / total) * 100;

       
        Console.WriteLine($"Percentual de SP: {percentualSP:F2}%");
        Console.WriteLine($"Percentual de RJ: {percentualRJ:F2}%");
        Console.WriteLine($"Percentual de MG: {percentualMG:F2}%");
        Console.WriteLine($"Percentual de ES: {percentualES:F2}%");
        Console.WriteLine($"Percentual de Outros: {percentualOutros:F2}%");
    }
}
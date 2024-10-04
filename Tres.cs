using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

public class Faturamento
{
    public int Dia { get; set; }
    public double Valor { get; set; }
}

public class DadosFaturamento
{
    public List<Faturamento> Faturamento { get; set; }
}

class Program
{
    static void Main()
    {
        string json = File.ReadAllText("dados.json");
        var dadosFaturamento = JsonConverter.DeserializeObject<DadosFaturamento>(json);

        double menorFaturamento = double.MaxValue;
        double maiorFaturamento = double.MinValue;
        double somaFaturamento = 0;
        int diasContados = 0;

        foreach (var dia in dadosFaturamento.Faturamento)
        {
            if (dia.Valor > 0)
            {
                if (dia.Valor < menorFaturamento) menorFaturamento = dia.Valor;
                if (dia.Valor > maiorFaturamento) maiorFaturamento = dia.Valor;
                somaFaturamento += dia.Valor;
                diasContados++;
            }
        }

        double mediaFaturamento = diasContados > 0 ? somaFaturamento / diasContados : 0;

        int diasAcimaMedia = 0;
        foreach (var dia in dadosFaturamento.Faturamento)
        {
            if (dia.Valor > mediaFaturamento)
            {
                diasAcimaMedia++;
            }
        }

        Console.WriteLine($"Menor Faturamento: {menorFaturamento}");
        Console.WriteLine($"Maior Faturamento: {maiorFaturamento}");
        Console.WriteLine($"Número de dias acima da média: {diasAcimaMedia}");
    }
}

using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Atividade> listaAtividades = new List<Atividade>();

        Corrida corrida = new Corrida("14 Out 2026", 30, 4.8);
        Bicicleta bicicleta = new Bicicleta("13 Out 2026", 45, 25.0);
        Natacao natacao = new Natacao("12 Out 2026", 30, 40);

        listaAtividades.Add(corrida);
        listaAtividades.Add(bicicleta);
        listaAtividades.Add(natacao);

        foreach (Atividade atividade in listaAtividades)
        {
            Console.WriteLine(atividade.GetSummary());
        }
    }
}
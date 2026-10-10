using System;
using System.Collections.Generic;

public class AtividadeDeListagem : Atividade
{
    private int _contador;
    private List<string> _perguntas;

    public AtividadeDeListagem() : base("Atividade de Listagem", "Esta atividade ajudará você a refletir sobre os aspectos positivos de sua vida ao listar itens em uma determinada categoria.")
    {
        _perguntas = new List<string> {
            "Quem são as pessoas que você admira?",
            "Quais são seus pontos que você mais valoriza?",
            "Quem são as pessoas que te ajudaram nos últimos dias?",
            "Que experiências fez você sentir o Espírito Santo durante a semana?",
            "Quem são algumas pessoas inspirou você recentemente?",
            "Quais são algumas coisas que você aprecia em sua vida?",
            "Quais são algumas coisas que você gosta de fazer?",
        };
    }

    public void ObterPerguntaAleatoria()
    {
        Random random = new Random();
        Console.WriteLine("\nEscreva o máximo de respostas para a seguinte pergunta:");
        Console.WriteLine($"--- {_perguntas[random.Next(_perguntas.Count)]} ---");
    }

    public List<string> ObterListaDoUsuario()
    {
        List<string> lista = new List<string>();
        DateTime inicio = DateTime.Now;
        DateTime fim = inicio.AddSeconds(_duracao);

        while (DateTime.Now < fim)
        {
            Console.Write("> ");
            string resposta = Console.ReadLine();
            if (!string.IsNullOrEmpty(resposta))
            {
                lista.Add(resposta);
            }
        }
        return lista;
    }

    public void Executar()
    {
        ExibirMensagemInicial();
        
        ObterPerguntaAleatoria();
        Console.Write("Você começará em: ");
        ExibirContagemRegressiva(5);
        Console.WriteLine();

        List<string> respostas = ObterListaDoUsuario();
        _contador = respostas.Count;

        Console.WriteLine($"Você listou {_contador} itens!");
        ExibirMensagemFinal();
    }
}
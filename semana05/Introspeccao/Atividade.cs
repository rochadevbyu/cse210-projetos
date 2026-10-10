using System;
using System.Collections.Generic;
using System.Threading;

public class Atividade
{
    protected string _nome;
    protected string _descricao;
    protected int _duracao;

    public Atividade(string nome, string descricao)
    {
        _nome = nome;
        _descricao = descricao;
    }

    public void ExibirMensagemInicial()
    {
        Console.Clear();
        Console.WriteLine($"Olá, bem-vindo à {_nome}.\n");
        Console.WriteLine($"{_descricao}\n");
        Console.Write("Quantos segundos você acredita que conseguirá se concentrar nesta atividade? ");
        _duracao = int.Parse(Console.ReadLine());
        
        Console.Clear();
        Console.WriteLine("Aguarde, já vai começar...");
        ExibirProgresso(3);
    }

    public void ExibirMensagemFinal()
    {
        Console.WriteLine("\nParabéns! Bom trabalho!");
        ExibirProgresso(3);
        Console.WriteLine($"Concluído mais {_duracao} segundos da {_nome}.");
        ExibirProgresso(3);
    }

    public void ExibirProgresso(int segundos)
    {
        List<string> animacao = new List<string> { "|", "/", "-", "\\" };
        DateTime inicio = DateTime.Now;
        DateTime fim = inicio.AddSeconds(segundos);
        int i = 0;

        while (DateTime.Now < fim)
        {
            Console.Write(animacao[i]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            i = (i + 1) % animacao.Count;
        }
    }

    public void ExibirContagemRegressiva(int segundos)
    {
        for (int i = segundos; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}
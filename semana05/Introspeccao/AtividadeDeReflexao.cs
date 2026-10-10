using System;
using System.Collections.Generic;

public class AtividadeDeReflexao : Atividade
{
    private List<string> _reflexoes;
    private List<string> _perguntas;

    public AtividadeDeReflexao() : base("Atividade de Reflexão", "Esta atividade irá ajudá-lo a refletir sobre momentos de sua vida em que você demonstrou força, coragem e resiliência.")
    {
       _reflexoes = new List<string> {
            "Lembre-se de um momento em que você precisou apoiar ou defender alguém.",
            "Recorde-se de um desafio que parecia muito difícil, mas que você conseguiu superar.",
            "Traga à memória um dia em que você fez a diferença na vida de alguém que precisava de ajuda.",
            "Pense em uma situação em que você abriu mão do seu próprio conforto pelo bem de outra pessoa."
        };
        
        _perguntas = new List<string> {
            "O que tornou esse momento tão especial e inesquecível para você?",
            "Essa foi uma situação inédita ou você já tinha vivenciado algo parecido?",
            "Qual foi o gatilho inicial? Como tudo começou?",
            "Qual foi a emoção exata que você sentiu quando tudo terminou?",
            "Se você pudesse destacar o melhor detalhe dessa memória, qual seria?",
            "Que lição valiosa essa situação te ensinou sobre a sua própria força?"
        };
    }

    public string ObterReflexoesAleatorias()
    {
        Random random = new Random();
        return _reflexoes[random.Next(_reflexoes.Count)];
    }

    public string ObterPerguntasAleatorias()
    {
        Random random = new Random();
        return _perguntas[random.Next(_perguntas.Count)];
    }

    public void ExibirReflexoes()
    {
        Console.WriteLine("\nPondere sobrea seguinte situação:");
        Console.WriteLine($"--- {ObterReflexoesAleatorias()} ---");
        Console.WriteLine("\nQuando pensar em algo, pressione Enter para continuar.");
        Console.ReadLine();
    }

    public void ExibirPerguntas()
    {
        Console.WriteLine("Agora pondere a respeito das seguintes perguntas relacionadas à situação que você refletiu:");
        Console.Write("Você começará em: ");
        ExibirContagemRegressiva(5);
        Console.Clear();

        DateTime inicio = DateTime.Now;
        DateTime fim = inicio.AddSeconds(_duracao);

        while (DateTime.Now < fim)
        {
            Console.Write($"> {ObterPerguntasAleatorias()} ");
            ExibirProgresso(8);
            Console.WriteLine();
        }
    }

    public void Executar()
    {
        ExibirMensagemInicial();
        ExibirReflexoes();
        ExibirPerguntas();
        ExibirMensagemFinal();
    }
}
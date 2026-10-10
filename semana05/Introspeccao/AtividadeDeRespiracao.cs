using System;

public class AtividadeDeRespiracao : Atividade
{
    public AtividadeDeRespiracao() : base("Atividade de Respiração", "Esta atividade ajudará você a relaxar e se concontrar, por meio de exercícios de respiração guiada.")
    {
    }

    public void Executar()
    {
        ExibirMensagemInicial();

        DateTime inicio = DateTime.Now;
        DateTime fim = inicio.AddSeconds(_duracao);

        while (DateTime.Now < fim)
        {
            Console.Write("\nInspire...");
            ExibirContagemRegressiva(4);
            Console.Write("\nExpire...");
            ExibirContagemRegressiva(6);
            Console.WriteLine();
        }

        ExibirMensagemFinal();
    }
}
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // CRIATIVIDADE: Salvando a pontuação / uso em um log.
        int atividadesConcluidas = 0;
        string arquivoLog = "log_atividades.txt";

        if (File.Exists(arquivoLog))
        {
            string conteudo = File.ReadAllText(arquivoLog);
            int.TryParse(conteudo, out atividadesConcluidas);
        }

        string escolha = "";
        while (escolha != "4")
        {
            Console.Clear();
            Console.WriteLine($"Você já completou {atividadesConcluidas} atividades no total!");
            Console.WriteLine("Opções de Menu:");
            Console.WriteLine("  1. Comece sua atividade de respiração");
            Console.WriteLine("  2. Comece sua atividade de reflexão");
            Console.WriteLine("  3. Comece sua atividade de listagem");
            Console.WriteLine("  4. Sair");
            Console.Write("Selecione uma opção do menu: ");
            escolha = Console.ReadLine();

            if (escolha == "1")
            {
                AtividadeDeRespiracao respiracao = new AtividadeDeRespiracao();
                respiracao.Executar();
                atividadesConcluidas++;
            }
            else if (escolha == "2")
            {
                AtividadeDeReflexao reflexao = new AtividadeDeReflexao();
                reflexao.Executar();
                atividadesConcluidas++;
            }
            else if (escolha == "3")
            {
                AtividadeDeListagem listagem = new AtividadeDeListagem();
                listagem.Executar();
                atividadesConcluidas++;
            }

            // CRIATIVIDADE SIMPLES: Adicionando uma mensagem para opções inválidas.
            else if (escolha != "4")
            {
                Console.WriteLine("Opção inválida. Por favor, selecione uma opção válida.");
                Console.WriteLine("Pressione Enter para retornar ao menu.");
                Console.ReadLine();
            }
    

            File.WriteAllText(arquivoLog, atividadesConcluidas.ToString());
        }
    }
}
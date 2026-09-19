// Comentários de Correção (conforme feedback do professor):
// 1. As chamadas dos métodos CarregarDoArquivo e SalvarNoArquivo foram garantidas nas opções 3 e 4.
// 2. Implementado o laço 'while' na opção 5 para a gravação dos registros antes de sair, substituindo o 'if' condicional.

using System;

class Program
{
    static void Main(string[] args)
    {
        Diario meuDiario = new Diario();
        int opcao = 0;

        string[] perguntas = {
            "Quem foi a pessoa mais interessante com quem interagi hoje?",
            "Qual foi a melhor parte do meu dia?",
            "Como vi a mão do Senhor em minha vida hoje?",
            "Qual foi a emoção mais forte que senti hoje?",
            "Se eu pudesse fazer uma coisa hoje, o que seria?",
            "Quais inspirações ou ideias novas eu tive hoje?",
            "O que eu aprendi hoje que posso aplicar no futuro?",
            "Quais perguntas ou duvidas surgiram em minha mente hoje?",
            "Como posso melhorar meu dia de amanhã com base no que aconteceu hoje?",
            "O que me fez sorrir ou rir hoje?"                 
        };

        Console.WriteLine("Bem-vindo ao Programa de Diário!");

        while (opcao != 5)
        {
            Console.WriteLine("\nPor favor, selecione uma das seguintes opções:");
            Console.WriteLine("1. Escrever");
            Console.WriteLine("2. Exibir");
            Console.WriteLine("3. Carregar");
            Console.WriteLine("4. Salvar");
            Console.WriteLine("5. Sair");
            Console.Write("O que você gostaria de fazer? ");

            opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Random random = new Random();
                int indice = random.Next(perguntas.Length);
                string perguntaSorteada = perguntas[indice];

                Console.WriteLine(perguntaSorteada);
                Console.Write("> ");
                string respostaUsuario = Console.ReadLine();

                Registro novoRegistro = new Registro();
                novoRegistro._pergunta = perguntaSorteada;
                novoRegistro._resposta = respostaUsuario;

                meuDiario.AdicionarRegistro(novoRegistro);
            }
            else if (opcao == 2)
            {
                meuDiario.Exibir();
            }
            else if (opcao == 3) 
            {
                // Correção: Chamada do método CarregarDoArquivo adicionada
                Console.Write("Qual é o nome do arquivo para carregar? ");
                string nomeArquivo = Console.ReadLine();
                meuDiario.CarregarDoArquivo(nomeArquivo); 
            }
            else if (opcao == 4) 
            {
                // Correção: Chamada do método SalvarNoArquivo adicionada
                Console.Write("Qual é o nome do arquivo para salvar? ");
                string nomeArquivo = Console.ReadLine();
                meuDiario.SalvarNoArquivo(nomeArquivo); 
            }
            else if (opcao == 5) 
            {
                string decisao = "";
                
                // Correção: Laço while adicionado no lugar do if condicional
                while (decisao != "S" && decisao != "N")
                {
                    Console.Write("Deseja salvar as alterações antes de sair? (S/N): ");
                    decisao = Console.ReadLine().ToUpper(); 

                    if (decisao == "S")
                    {
                        Console.Write("Qual será o nome do arquivo? (ex: diario.json): ");
                        string nomeArquivo = Console.ReadLine();
                        meuDiario.SalvarNoArquivo(nomeArquivo);
                    }
                    else if (decisao != "N")
                    {
                        Console.WriteLine("Opção inválida. Por favor, digite S ou N.");
                    }
                }
                
                Console.WriteLine("Diário encerrado. Até logo!");
            }
        }
    }
}
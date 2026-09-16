//Atividade Adicional:
// Implementei um while para gravação dos registros em arquivo json, caso o usuário queira sair do programa.

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
            "O que me fez sorrir ou rir hoje?",
            "Quais desafios enfrentei hoje e como os superei?",
            "O que eu fiz hoje que me deixou orgulhoso de mim mesmo?",
            "Como posso ser mais grato(a) pelas coisas boas que aconteceram hoje?",
            "O que eu fiz hoje para ajudar ou apoiar alguém?",
            "Quais foram os momentos de paz ou tranquilidade que experimentei hoje?",
            "O que eu fiz hoje para cuidar de mim mesmo(a) e do meu bem-estar?",
            "Quais foram as pequenas vitórias ou conquistas que tive hoje?"
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
                Console.Write("Qual é o nome do arquivo para carregar? ");
                string nomeArquivo = Console.ReadLine();
                
            }
            else if (opcao == 4)
            {
                Console.Write("Qual é o nome do arquivo para salvar? ");
                string nomeArquivo = Console.ReadLine();
                
            }
            else if (opcao == 5)
                {
                    Console.Write("Deseja salvar as alterações antes de sair? (S/N): ");
                    string decisao = Console.ReadLine().ToUpper(); 

                    if (decisao == "S")
                    {
                        Console.Write("Qual será o nome do arquivo? (ex: diario.json): ");
                        string nomeArquivo = Console.ReadLine();
                        meuDiario.SalvarNoArquivo(nomeArquivo);
                    }
                    
                    Console.WriteLine("Diário encerrado. Até logo!");
                }
        }
    }
}
using System;
using System.IO;
using System.Text.Json;

// CRIATIVIDADE PARA PONTUAÇÃO EXTRA:
// O programa carrega as escrituras dinamicamente a partir do arquivo "book-of-mormon.json".
// Ele sorteia aleatoriamente um livro, depois um capítulo, e finalmente um versículo (ou um bloco de versículos) para o usuário memorizar.
// Não encontrei uma base em português, por isso foi utilizada em Inglês, para fins acadêmico.

class Program
{
    static void Main(string[] args)
    {        
        string jsonString = File.ReadAllText("book-of-mormon.json");

        JsonSerializerOptions options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };
        DadosLivroMormon dados = JsonSerializer.Deserialize<DadosLivroMormon>(jsonString, options);
        
        Random random = new Random();
        
        DadosLivro livroSorteado = dados.Books[random.Next(dados.Books.Count)];
        DadosCapitulo capituloSorteado = livroSorteado.Chapters[random.Next(livroSorteado.Chapters.Count)];

        int totalVersiculos = capituloSorteado.Verses.Count;
        int indiceInicial = random.Next(totalVersiculos);
        int quantidadeVersiculos = random.Next(1, 4); 

        if (indiceInicial + quantidadeVersiculos > totalVersiculos)
        {
            quantidadeVersiculos = totalVersiculos - indiceInicial;
        }

        int versiculoInicial = capituloSorteado.Verses[indiceInicial].Verse;
        int versiculoFinal = capituloSorteado.Verses[indiceInicial + quantidadeVersiculos - 1].Verse;

        string textoCombinado = "";
        for (int i = 0; i < quantidadeVersiculos; i++)
        {
            textoCombinado += capituloSorteado.Verses[indiceInicial + i].Text + " ";
        }

        Referencia referencia;
        if (versiculoInicial == versiculoFinal)
        {
            referencia = new Referencia(livroSorteado.Book, capituloSorteado.Chapter, versiculoInicial);
        }
        else
        {
            referencia = new Referencia(livroSorteado.Book, capituloSorteado.Chapter, versiculoInicial, versiculoFinal);
        }

        Escritura escritura = new Escritura(referencia, textoCombinado.Trim());

        while (true)
        {
            Console.Clear();
            Console.WriteLine(escritura.ObterTextoExibicao());
            Console.WriteLine();

            if (escritura.TodasPalavrasOcultas())
            {
                break;
            }

            Console.WriteLine("Pressione Enter para continuar ou digite 'sair' para terminar:");
            string input = Console.ReadLine();

            if (input.ToLower() == "sair")
            {
                break;
            }

            escritura.OcultarPalavrasAleatorias(3);
        }
    }
}
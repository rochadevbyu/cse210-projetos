using System;
using System.Collections.Generic;
using System.IO;

public class GerenciadorDeMetas
{
    private List<Meta> _metas;
    private int _pontos;

    public GerenciadorDeMetas()
    {
        _metas = new List<Meta>();
        _pontos = 0;
    }

    public void Iniciar()
    {
        string opcao = "";
        while (opcao != "6")
        {
            ExibirInfoJogador();
            Console.WriteLine("\nOpções do Menu:");
            Console.WriteLine("  1. Criar Nova Meta");
            Console.WriteLine("  2. Listar Metas");
            Console.WriteLine("  3. Guardar Metas num arquivo");
            Console.WriteLine("  4. Carregar Metas de um arquivo");
            Console.WriteLine("  5. Registrar Evento");
            Console.WriteLine("  6. Sair");
            Console.Write("Selecione uma opção do menu: ");
            opcao = Console.ReadLine();

            if (opcao == "1") CriarMeta();
            else if (opcao == "2") ListarDetalhesDasMetas();
            else if (opcao == "3") SalvarMetas();
            else if (opcao == "4") CarregarMetas();
            else if (opcao == "5") RegistrarEvento();
        }
    }

    public void ExibirInfoJogador()
    {
        Console.WriteLine($"\nAtualmente tem {_pontos} pontos.");
        
        Console.WriteLine($"O seu Título de Gamificação: {DeterminarNivel()}");
    }

    private string DeterminarNivel()
    {
        if (_pontos >= 5000) return "Lenda Eterna";
        if (_pontos >= 2000) return "Mestre Focado";
        if (_pontos >= 500) return "Discípulo Aplicado";
        return "Iniciante";
    }

    public void ListarDetalhesDasMetas()
    {
        Console.WriteLine("\nAs suas metas são:");
        for (int i = 0; i < _metas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_metas[i].ObterDetalhesEmTexto()}");
        }
    }

    public void CriarMeta()
    {
        Console.WriteLine("Os tipos de Metas são:");
        Console.WriteLine("  1. Meta Simples");
        Console.WriteLine("  2. Meta Eterna");
        Console.WriteLine("  3. Meta de Lista de Tarefas");
        Console.Write("Que tipo de meta gostaria de criar? ");
        string tipo = Console.ReadLine();

        Console.Write("Qual é o nome da sua meta? ");
        string nome = Console.ReadLine();
        Console.Write("Qual é uma breve descrição da sua meta? ");
        string descricao = Console.ReadLine();
        Console.Write("Qual é a quantidade de pontos associada a esta meta? ");
        string pontos = Console.ReadLine();

        if (tipo == "1")
        {
            _metas.Add(new MetaSimples(nome, descricao, pontos));
        }
        else if (tipo == "2")
        {
            _metas.Add(new MetaEterna(nome, descricao, pontos));
        }
        else if (tipo == "3")
        {
            Console.Write("Quantas vezes este objetivo precisa ser alcançado para ganhar o bónus? ");
            int total = int.Parse(Console.ReadLine());
            Console.Write("Qual é o bónus por completar a meta? ");
            int bonus = int.Parse(Console.ReadLine());
            _metas.Add(new MetaDeListaDeTarefas(nome, descricao, pontos, total, bonus));
        }
    }

    public void RegistrarEvento()
    {
        Console.WriteLine("As suas metas são:");
        for (int i = 0; i < _metas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_metas[i].ObterNome()}");
        }
        Console.Write("Qual meta cumpriu? ");
        int indiceMeta = int.Parse(Console.ReadLine()) - 1;

        Meta metaSelecionada = _metas[indiceMeta];
        metaSelecionada.RegistrarEvento(); 
        
        int pontosGanhos = metaSelecionada.ObterPontos();
        
        if (metaSelecionada is MetaDeListaDeTarefas metaLista && metaLista.EstaConcluida())
        {
            Console.WriteLine("Parabéns! Completou a sua meta de lista de tarefas.");
        }

        _pontos += pontosGanhos;
        Console.WriteLine($"Parabéns! Ganhou {pontosGanhos} pontos!");
    }

    public void SalvarMetas() 
    {
        Console.Write("Qual é o nome do arquivo (ex: metas.txt)? ");
        string arquivo = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(arquivo))
        {
            outputFile.WriteLine(_pontos);
            foreach (Meta meta in _metas)
            {
                outputFile.WriteLine(meta.ObterRepresentacaoEmTexto());
            }
        }
    }

    public void CarregarMetas() 
    {
        Console.Write("Qual é o nome do arquivo? ");
        string arquivo = Console.ReadLine();

        if (File.Exists(arquivo))
        {
            string[] linhas = File.ReadAllLines(arquivo);
            _pontos = int.Parse(linhas[0]);
            _metas.Clear();

            for (int i = 1; i < linhas.Length; i++)
            {
                string[] partes = linhas[i].Split(':');
                string tipoMeta = partes[0];
                string[] detalhes = partes[1].Split(',');

                if (tipoMeta == "MetaSimples")
                {
                    MetaSimples ms = new MetaSimples(detalhes[0], detalhes[1], detalhes[2]);
                    if (bool.Parse(detalhes[3])) ms.RegistrarEvento();
                    _metas.Add(ms);
                }
                else if (tipoMeta == "MetaEterna")
                {
                    _metas.Add(new MetaEterna(detalhes[0], detalhes[1], detalhes[2]));
                }
                else if (tipoMeta == "MetaDeListaDeTarefas")
                {
                    MetaDeListaDeTarefas mt = new MetaDeListaDeTarefas(detalhes[0], detalhes[1], detalhes[2], int.Parse(detalhes[4]), int.Parse(detalhes[3]));
                    int concluidas = int.Parse(detalhes[5]);
                    for (int j = 0; j < concluidas; j++) mt.RegistrarEvento();
                    _metas.Add(mt);
                }
            }
        }
    }
}
using System;
using System.Collections.Generic; 
using System.IO; 
using System.Text.Json; 

public class Diario
{
    
    public List<Registro> _registros;

    public Diario()
    {
        _registros = new List<Registro>();
    }

    public void AdicionarRegistro(Registro novoRegistro)
    {
        _registros.Add(novoRegistro);
    }

    public void Exibir()
    {
        if (_registros.Count == 0)
        {
            Console.WriteLine("O diário está vazio.");
        }
        else
        {
            foreach (Registro registro in _registros)
            {
                registro.Exibir();
            }
        }
    }

    public void SalvarNoArquivo(string nomeArquivo)
        {
            
            var opcoes = new JsonSerializerOptions { IncludeFields = true, WriteIndented = true };
            
            
            string formatoJson = JsonSerializer.Serialize(_registros, opcoes);
            
            
            File.WriteAllText(nomeArquivo, formatoJson);
            
            Console.WriteLine("Arquivo salvo com sucesso em formato JSON!");
        }

    public void CarregarDoArquivo(string nomeArquivo)
    {
        if (File.Exists(nomeArquivo))
        {
            var opcoes = new JsonSerializerOptions { IncludeFields = true };
            
            
            string formatoJson = File.ReadAllText(nomeArquivo);
            
            
            _registros = JsonSerializer.Deserialize<List<Registro>>(formatoJson, opcoes);
            
            Console.WriteLine("Arquivo JSON carregado com sucesso!");
        }
        else
        {
            Console.WriteLine("Arquivo não encontrado.");
        }
    }
}
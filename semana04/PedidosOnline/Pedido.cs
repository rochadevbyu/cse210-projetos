using System;
using System.Collections.Generic;

public class Pedido
{
    private List<Produto> _produtos;
    private Cliente _cliente;

    public Pedido(Cliente cliente)
    {
        _cliente = cliente;
        _produtos = new List<Produto>();
    }

    public void AdicionarProduto(Produto produto)
    {
        _produtos.Add(produto);
    }

    public double CalcularCustoTotal()
    {
        double totalProdutos = 0;
        foreach (Produto p in _produtos)
        {
            totalProdutos += p.CalcularCustoTotal();
        }

        double custoEnvio = _cliente.MoraNosEUA() ? 5.0 : 35.0;
        return totalProdutos + custoEnvio;
    }

    public string ObterEtiquetaEmbalagem()
    {
        string etiqueta = "--- ETIQUETA DE EMBALAGEM ---\n";
        foreach (Produto p in _produtos)
        {
            etiqueta += $"ID: {p.ObterId()} - Produto: {p.ObterNome()}\n";
        }
        return etiqueta;
    }

    public string ObterEtiquetaEnvio()
    {
        string etiqueta = "--- ETIQUETA DE ENVIO ---\n";
        etiqueta += $"Nome: {_cliente.ObterNome()}\n";
        etiqueta += $"Endereço:\n{_cliente.ObterEndereco().ObterEnderecoCompleto()}\n";
        return etiqueta;
    }
}
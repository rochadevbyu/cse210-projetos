using System;

class Program
{
    static void Main(string[] args)
    {
        Endereco end1 = new Endereco("Street Qualquer", "Salt Lake City", "Utah", "EUA");
        Cliente cliente1 = new Cliente("Robert Rock", end1);

        Pedido pedido1 = new Pedido(cliente1);
        pedido1.AdicionarProduto(new Produto("Notebook", "INFO-001", 1200.00, 1));
        pedido1.AdicionarProduto(new Produto("Mouse sem fio", "INFO-002", 25.00, 2));

        Console.WriteLine(pedido1.ObterEtiquetaEmbalagem());
        Console.WriteLine(pedido1.ObterEtiquetaEnvio());
        Console.WriteLine($"Preço Total do Pedido: ${pedido1.CalcularCustoTotal():0.00}\n");
        Console.WriteLine("=========================================\n");

        Endereco end2 = new Endereco("Rua Joaquim Cavalcante de Santana, 20 - Bairro Novo do Carmelo", "Camaragibe", "PE", "Brasil");
        Cliente cliente2 = new Cliente("Roberto Rocha", end2);

        Pedido pedido2 = new Pedido(cliente2);
        pedido2.AdicionarProduto(new Produto("Teclado Mecânico", "INFO-003", 80.00, 1));
        pedido2.AdicionarProduto(new Produto("Monitor 24", "INFO-004", 200.00, 1));

        Console.WriteLine(pedido2.ObterEtiquetaEmbalagem());
        Console.WriteLine(pedido2.ObterEtiquetaEnvio());
        Console.WriteLine($"Preço Total do Pedido: ${pedido2.CalcularCustoTotal():0.00}\n");

       
    }
}
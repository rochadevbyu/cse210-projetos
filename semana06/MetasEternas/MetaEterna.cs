using System;

public class MetaEterna : Meta
{
    public MetaEterna(string nome, string descricao, string pontos) : base(nome, descricao, pontos)
    {
    }

    public override void RegistrarEvento()
    {
    }

    public override bool EstaConcluida()
    {
        return false; 
    }

    public override string ObterDetalhesEmTexto()
    {
        return $"[ ] {_nome} ({_descricao})";
    }

    public override string ObterRepresentacaoEmTexto()
    {
        return $"MetaEterna:{_nome},{_descricao},{_pontos}";
    }
}
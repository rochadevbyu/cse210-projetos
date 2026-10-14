using System;

public class MetaDeListaDeTarefas : Meta
{
    private int _concluidas;
    private int _total;
    private int _bonus;

    public MetaDeListaDeTarefas(string nome, string descricao, string pontos, int total, int bonus) 
        : base(nome, descricao, pontos)
    {
        _concluidas = 0;
        _total = total;
        _bonus = bonus;
    }

    public override void RegistrarEvento()
    {
        if (_concluidas < _total)
        {
            _concluidas++;
        }
    }

    public override bool EstaConcluida()
    {
        return _concluidas >= _total;
    }

    public override string ObterDetalhesEmTexto()
    {
        string marcador = EstaConcluida() ? "[X]" : "[ ]";
        return $"{marcador} {_nome} ({_descricao}) -- Concluída {_concluidas}/{_total} vezes";
    }

    public override string ObterRepresentacaoEmTexto()
    {
        return $"MetaDeListaDeTarefas:{_nome},{_descricao},{_pontos},{_bonus},{_total},{_concluidas}";
    }

    public override int ObterPontos()
    {
    int pontosBase = base.ObterPontos();
    
    if (_concluidas == _total) 
    {
        return pontosBase + _bonus;
    }
    
    return pontosBase;
    }
}
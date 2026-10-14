using System;

public abstract class Meta
{
    protected string _nome;
    protected string _descricao;
    protected string _pontos; 

    public Meta(string nome, string descricao, string pontos)
    {
        _nome = nome;
        _descricao = descricao;
        _pontos = pontos;
    }

    public abstract void RegistrarEvento();
    public abstract bool EstaConcluida();
    public abstract string ObterDetalhesEmTexto();
    public abstract string ObterRepresentacaoEmTexto();

    public string ObterNome() { return _nome; }
    public virtual int ObterPontos() { return int.Parse(_pontos); }
    
}
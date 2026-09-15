using System;

class Program
{
    static void Main(string[] args)
    {
        Emprego emprego1 = new Emprego();
        emprego1._cargo = "Chefe da Divisão de Processos";
        emprego1._empresa = "Município de Olinda - Diretoria de Administração Previdenciária";
        emprego1._anoInicio = 2017;
        emprego1._anoFim = 2020;

        Emprego emprego2 = new Emprego();
        emprego2._cargo = "Diretor de Administração Previdenciária";
        emprego2._empresa = "Município de Olinda - Diretoria de Administração Previdenciária";
        emprego2._anoInicio = 2020;
        emprego2._anoFim = 2023;

        Emprego emprego3 = new Emprego();
        emprego3._cargo = "Diretor Vice-Presidente do OLINPREV";
        emprego3._empresa = "Município de Olinda - OLINPREV";
        emprego3._anoInicio = 2023;
        emprego3._anoFim = 2026;

        Curriculo meuCurriculo = new Curriculo();
        meuCurriculo._nome = "Roberto Rocha";

        meuCurriculo._empregos.Add(emprego1);
        meuCurriculo._empregos.Add(emprego2);
        meuCurriculo._empregos.Add(emprego3);

        meuCurriculo.Exibir();
    }
}
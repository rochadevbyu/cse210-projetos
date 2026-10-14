using System;

// COMENTÁRIO OBRIGATÓRIO - DEMONSTRAÇÃO DE CRIATIVIDADE (Critério 13).
// Para superar os requisitos básicos e adicionar mais aspetos de gamificação (como sugerido na especificação do projeto), implementei um "Sistema de Níveis e Títulos" no GerenciadorDeMetas.
// À medida que o usuário acumula pontos, ele sobe de hierarquia, começando como "Iniciante" e podendo chegar a "Lenda Eterna". Isso ajuda a manter a motivação do usuário.
// proporcionando conquistas ao longo da sua jornada de metas.

class Program
{
    static void Main(string[] args)
    {
        GerenciadorDeMetas gerenciador = new GerenciadorDeMetas();
        gerenciador.Iniciar();
    }
    
}
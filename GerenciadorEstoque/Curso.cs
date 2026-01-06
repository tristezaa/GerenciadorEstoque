using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorEstoque
{

    class Curso : Produto
    {
        public string autor { get; set; }
        public int vagas { get; set; }
        public Curso(string nome, float preco, string autor)
        {
            this.nome = nome;
            this.preco = preco;
            this.autor = autor;
        }

        public override void AdicionarEntrada()
        {
            Console.WriteLine($"Adicionar vagas liberadas para o curso \"{nome}\": ");
            Console.WriteLine("Quantidade de entrada: ");
            int entrada = int.Parse(Console.ReadLine());
            vagas += entrada;
            Console.WriteLine($"Quantidade de vagas atualizada. Vaga disponíveis: {vagas}");
        }

        public override void AdicionarSaida()
        {
            Console.WriteLine($"Registrar vagas ocupadas do curso {nome}: ");
            Console.WriteLine("Quantidade de saída: ");
            int saida = int.Parse(Console.ReadLine());
            vagas -= saida;
            Console.WriteLine($"Quantidade de vagas atualizada. Vaga disponíveis: {vagas}");
        }

        public override void Exibir()
        {
            base.Exibir();
            Console.WriteLine($"Autor: {autor}");
            Console.WriteLine($"Vagas disponíveis: {vagas}");
            Console.WriteLine("---------------------------");
        }
    }
}

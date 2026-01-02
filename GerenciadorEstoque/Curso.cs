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
            Console.WriteLine($"Adicionar entrada de vagas do produto {nome}: ");
            Console.WriteLine("Quantidade de entrada: ");
            int entrada = int.Parse(Console.ReadLine());
            vagas += entrada;
            Console.WriteLine($"Estoque atualizado. Quantidade de vagas: {vagas}");
        }

        public void AdicionarSaida()
        {
            
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

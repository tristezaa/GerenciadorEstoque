using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorEstoque
{

    class Curso : Produto
    {
        public string autor { get; set; }
        private int vagas { get; set; }
        public Curso(string nome, float preco, string autor)
        {
            this.nome = nome;
            this.preco = preco;
            this.autor = autor;
        }

        public void AdicionarEntrada()
        {
            
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

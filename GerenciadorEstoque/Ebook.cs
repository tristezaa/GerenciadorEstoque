using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorEstoque
{
    class Ebook : Produto
    {
        public string autor { get; set; }
        private int vendas { get; set; }

        public Ebook(string nome, float preco, string autor)
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
            Console.WriteLine($"Vendas: {vendas}");
            Console.WriteLine("---------------------------");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorEstoque
{
    class Ebook : Produto
    {
        public string autor { get; set; }
        public int vendas { get; set; }

        public Ebook(string nome, float preco, string autor)
        {
            this.nome = nome;
            this.preco = preco;
            this.autor = autor;
        }

        public override void AdicionarEntrada()
        {
            Console.WriteLine("produto digital, não possui estoque físico.");
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

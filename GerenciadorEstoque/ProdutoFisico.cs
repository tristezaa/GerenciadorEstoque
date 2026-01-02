using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorEstoque
{
    class ProdutoFisico : Produto
    {
        public float frete { get; set; }
        private int estoque { get; set; }

        public ProdutoFisico(string nome, float preco, float frete)
        {
            this.nome = nome;
            this.preco = preco;
            this.frete = frete;
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
            Console.WriteLine($"Frete: {frete}");
            Console.WriteLine($"Quantidade em estoque: {estoque}");
            Console.WriteLine("---------------------------");
        }
    }
}

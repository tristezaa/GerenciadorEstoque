using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorEstoque
{
    class ProdutoFisico : Produto
    {
        public float frete { get; set; }
        public int estoque { get; set; }

        public ProdutoFisico(string nome, float preco, float frete)
        {
            this.nome = nome;
            this.preco = preco;
            this.frete = frete;
        }

        public override void AdicionarEntrada()
        {
            Console.WriteLine($"Adicionar entrada no estoque do produto {nome}: ");
            Console.WriteLine("Quantidade de entrada: ");
            int entrada = int.Parse(Console.ReadLine());
            estoque += entrada;
            Console.WriteLine($"Estoque atualizado. Quantidade em estoque: {estoque}");
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

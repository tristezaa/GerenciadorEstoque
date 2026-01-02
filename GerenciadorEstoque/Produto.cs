using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace GerenciadorEstoque
{
    [JsonPolymorphic(TypeDiscriminatorPropertyName = "$tipo")]
    [JsonDerivedType(typeof(ProdutoFisico), "ProdutoFisico")]
    [JsonDerivedType(typeof(Ebook), "Ebook")]
    [JsonDerivedType(typeof(Curso), "Curso")]
    abstract class  Produto
    {
        public string nome { get; set; }
        public float preco { get; set; }

        public abstract void AdicionarEntrada();

        public virtual void Exibir()
        {
            Console.WriteLine($"Produto: {nome}");
            Console.WriteLine($"Preço: R$ {preco}");
        }


    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorEstoque
{
    interface IEstoque
    {
        void Exibir();
        void AdicionarEntrada();
        void AdicionarSaida();
    }
}

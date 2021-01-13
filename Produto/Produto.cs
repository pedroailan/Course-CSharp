using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Produto
{
    class Produto
    {
        public string Nome;
        public double Preço;
        public int Quantidade;

        public double TotalEmEstoque()
        {
            return Preço * Quantidade;
        }

        public void AdicionarProdutos (int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos (int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome
                + ", $"
                + Preço.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + TotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }

     
    }
}

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

        public Produto ()
        {
            Quantidade = 10;
        }
        public Produto(string nome, double preço)
        {
            Nome = nome;
            Preço = preço;
        }

        //Reaproveitamento de contrutor
        public Produto(string nome, double preço, int quantidade) : this(nome, preço)
        {
            Quantidade = quantidade;
        }



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

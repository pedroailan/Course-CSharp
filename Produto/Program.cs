using System;

namespace Produto
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p;
            p = new Produto();
            p.Nome = "PC";
            p.Preço = 1400.00;
            p.Quantidade = 10;

            Console.WriteLine("Dados do Produto: " + p);
            Console.WriteLine();
            Console.WriteLine();
            int qte = 10;

            p.AdicionarProdutos(qte);

            Console.WriteLine("Dados do Atualizados: " + p);

            p.RemoverProdutos(3);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Dados do Atualizados após remoção: " + p);

        }
    }
}

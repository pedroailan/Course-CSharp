using System;

namespace Produto
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string Nome = "PC";
            double Preço = 1400.00;
            int Quantidade = 10;

            //Sobrecarga de construtores
            Produto p = new Produto(Nome, Preço);

            //Sintaxe Alternativa
            Produto p2 = new Produto();

            //Sintaxe para classe que não possui construtores
            Produto p3 = new Produto { Nome = "tv" };


            

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

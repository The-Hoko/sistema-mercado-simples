using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mercado
{
    class Program
    {
        static void Main(string[] args)
        {




            Produto produto = new Produto("TV", 500.00, 10);

                 
            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade em estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine());
            
            Console.WriteLine();
            Console.WriteLine("Dados dos produtos: " + produto);

            // Adicionar itens ao estoque
            Console.WriteLine();
            Console.Write("Digite q quantidade de produtos a ser adiconado em estoque: ");
            int Adicionar_Quantidade = int.Parse(Console.ReadLine());
            produto.AdiconarProdutos(Adicionar_Quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + produto);
            
            // Remove itens do estoque 
            Console.WriteLine();
            Console.Write("Digite a quantidade que deseja remover do estoque: ");
            int Remover_Quantidade = int.Parse(Console.ReadLine());
            produto.RemoverProdutos(Remover_Quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + produto);
            
           
            Console.WriteLine(produto.Nome);
            Console.WriteLine(produto.Quantidade);
            
            Console.ReadKey();
        }
    }
}

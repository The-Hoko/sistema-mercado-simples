using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Mercado
{
    class Produto
    {
        private string _nome;
        public double  Preco { get;  set; }
        public int Quantidade { get;  set; }


        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }

        //Proprerties 
        public string Nome
        {
            get 
            { 
                return _nome; 
            }

            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }


        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdiconarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }
        // Sobreposição
        // Override indica que a operação  vem de outra classe

        public override string ToString()
        {
            return _nome
                + ", R$: "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: R$: "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }

    }
}

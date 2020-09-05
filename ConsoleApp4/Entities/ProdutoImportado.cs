using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConsoleApp4.Entities
{
    class ProdutoImportado:Product
    {
        public double TaxaImportacao { get; set; }

        public ProdutoImportado()
        {
        }

        public ProdutoImportado(string name, double price,double taxaImportacao):
            base(name,price)
        {
            TaxaImportacao = taxaImportacao;
        }

        public double Total()
        {
            return Price + TaxaImportacao;
        }

        public override string Imprimir()
        {
            return
                Name +
                " $ " +
                Price.ToString("F2", CultureInfo.InvariantCulture) +
                " (Taxa de Importação: $" +
                TaxaImportacao.ToString("F2", CultureInfo.InvariantCulture)+
                ")";
                
        }

    }
}

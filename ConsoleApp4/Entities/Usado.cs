using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ConsoleApp4.Entities
{
    class Usado:Product
    {
        public DateTime DataFabricacao { get; set; }

        public Usado()
        {
        }

        public Usado(string name, double price, DateTime dataFabricacao):
            base (name, price)
        {
            DataFabricacao = dataFabricacao;
        }

        public override string Imprimir()
        {
            return
                Name +
                "(used) $ " +
                Price.ToString("F2", CultureInfo.InvariantCulture) +
                " (Manufacture date: " +
                DataFabricacao.ToShortDateString() +
                ")";
        }
    }
}

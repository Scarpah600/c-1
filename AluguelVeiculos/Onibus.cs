using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelVeiculos
{
    class Onibus : Veiculo
    {
        public String TipoCarga { get; set; }

        public Onibus()
        {
            this.TipoCarga = "";
        }

        public Onibus(string modelo, string placa, int ano, int capacidade, String tipocarga)
            : base(placa, modelo, ano, capacidade)
        {
            this.TipoCarga = tipocarga;
        }
       
        public void ImprimeDados()
        {
            System.Console.WriteLine("Modelo {0} Placa {1} Ano{2} Capacidade{3} Tipo da Carga: {4}"
                , Modelo, Placa, Ano, capacidade, TipoCarga);
        }

    }
}

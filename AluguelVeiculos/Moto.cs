using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelVeiculos 
{
    class Moto : Veiculo
    {


        public String  Cilindradas { get; set; }

        public Moto()
        {
            this.Cilindradas = "";
        }
        public Moto(string modelo, string placa, int ano, int capacidade, String cilindradas)
            : base(placa, modelo, ano, capacidade)
        {
            this.Cilindradas = cilindradas;
        }
        public void ImprimeDados()
        {
            System.Console.WriteLine("Modelo: {0} Placa: {1} Ano: {2} Capacidade: {3} Cilindradas: {4}"
                ,Modelo,Placa,Ano,capacidade,Cilindradas);
        }
    }
}

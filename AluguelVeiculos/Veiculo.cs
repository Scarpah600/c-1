using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelVeiculos
{
    abstract class Veiculo
    {
        public String Placa{get;set;}
        public String Modelo { get; set; }
        public int Ano { get; set; }
        public int capacidade { get; set; }

        public Motorista motorista;

        public Veiculo()
        {
            this.Placa = "";
            this.Modelo = "";
            this.Ano = 0;
            this.capacidade = 0;
        }
        public Veiculo(String placa, String modelo, int ano, int capacidade)
        {
            this.Placa = placa;
            this.Modelo = modelo;
            this.Ano = ano;
            this.capacidade = capacidade;
        }
        public void ImprimeDados()
        {
            System.Console.WriteLine("Modelo:{0} Placa:{1} Ano:{3} Capacidade{4}",this.Modelo,this.Placa,this.Ano,
                this.capacidade);
        }
    }
}

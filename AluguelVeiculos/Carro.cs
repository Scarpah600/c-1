using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelVeiculos
{
    class Carro : Veiculo
    {
        public String Cor { get; set; }
        public String Potencia { get; set; }

        public Carro()
        {
            this.Cor = "";
            this.Potencia = "";
        }
        public Carro(string modelo,string placa,int ano,int capacidade,String cor, String potencia)
            :base(placa,modelo,ano,capacidade)
        {
          
             this.Cor = cor;
             this.Potencia = potencia;
        }
        public void ImprimeDados()
        {
            System.Console.WriteLine("Modelo:{0} Placa:{1} Ano:{2} Capacidade:{3} Cor:{4} Potencia:{5}"
                , this.Modelo,this.Placa,this.Ano,this.capacidade,this.Cor,this.Potencia);
        }
    }
}

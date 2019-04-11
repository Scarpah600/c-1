using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AluguelVeiculos
{
    class Opcao
    {
        public void opcao()
        {
          
          

            Carro carro = new Carro("Corsa", "ABC-2020", 2008, 4, "PRETO", "60");
            Carro carro2 = new Carro("Uno", "ABC-2020", 2008, 4, "PRETO", "70");
            Carro carro3 = new Carro("Vectra", "ABC-2020", 2008, 4, "PRETO", "65");
            Carro carro4 = new Carro("Sandero", "ABC-2020", 2008, 4, "PRETO", "130");

            Onibus onibus = new Onibus("Latao do Colegio", "WEC-1245", 1990, 20, "300 Kilos");
            Onibus onibus2 = new Onibus("Volvo ", "AVG-1379", 2010, 20, "310 Kilos");
            Onibus onibus3 = new Onibus("MB-100", "AAB-1377", 2015, 20, "320 Kilos");
            Onibus onibus4 = new Onibus("Volvo2", "AAC-1115", 1024, 20, "330 Kilos");


            Aluguel aluga = new Aluguel();
           

       
            //  System.Console.WriteLine("1 - CADASTRAR CLIENTE ");

            int opcao = 0;

            do
            {
                Cliente client = new Cliente();
                Menu menu = new Menu();
                System.Console.WriteLine("Digite o seu nome: ");
                string nome = System.Console.ReadLine();
                client.Nome = nome;
                
                
                int aluguel;
                menu.ImprimeMenu();
                aluguel = int.Parse(Console.ReadLine());


                switch (aluguel)
                {
                    case 1:
                        System.Console.WriteLine("Você Cliente: {0} Escolheu o Veiculo:  ",client.Nome);
                        carro.ImprimeDados();
                        
                        break;

                    case 2:
                        carro2.ImprimeDados();
                        break;
                    case 3:
                        carro3.ImprimeDados();
                        break;
                    case 4:
                        carro4.ImprimeDados();
                        break;
                    case 5:
                        onibus.ImprimeDados();
                        break;
                    case 6:
                        onibus2.ImprimeDados();
                        break;
                    case 7:
                        onibus3.ImprimeDados();
                        break;
                    case 8:
                        onibus4.ImprimeDados();
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }


            } while (opcao != 0);





        }
    }
}

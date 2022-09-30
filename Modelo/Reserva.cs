using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioHospedagem.Modelo
{

    public class Reserva
    {
        public List<Pessoa> Hospedes {get; set;}
        public Suite Suite {get; set;}
        public int DiasReservados {get; set;}

        public Reserva(){}
        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }
        public void CadastrarHospedes(List<Pessoa>hospedes){
            //TODO: capacidade  maior > ou  igual = ao numero de hospede
        if (Suite.Capacidade >= hospedes.Count)
        {
            Hospedes = hospedes;
        }
        else
        {

           throw new Exception("Capacidade menor do o numero de hospedes");
        }
        }
        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }
        public int ObterQuantidadeHospedes()
        { //quantidade de hospedes
            return Hospedes.Count;
        }
        public decimal CalcularValorDiaria()
        { 
            // Valor da diaria 
            decimal valor = DiasReservados * Suite.ValorDiaria;
           //desconto de 10% com hospedagem acima de 10 dias
           if (DiasReservados >= 10)
           {
            valor -= Decimal.Divide(Decimal.Multiply(valor, 10),100);
           } 
           return valor;
        }        
        
    }
}

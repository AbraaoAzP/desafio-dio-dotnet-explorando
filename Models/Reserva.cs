using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public Reserva () {}

        public Reserva (int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            //TODO: Verificar se a capacidade é maior ou igual ao número de hóspedes sendo recebido
            //IMPLEMENTE AQUI:

            //IMPLEMENTAÇÃO:

            if (Suite.Capacidade >= hospedes.Count)
            {
                Hospedes = hospedes;
            }
            else
            {
                //TODO: Retornar uma exception caso a capacidade seja menor que o número de hóspedes recebido
                //IMPLEMENTE AQUI:

                //IMPLEMENTAÇÃO:

                throw new ArgumentException("O quantidade de hóspedes não pode ser maior do que a capacidade da suíte.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            //TODO: Retorna a quantidade de hóspedes (propriedade Hospedes)
            //IMPLEMENTE AQUI:

            //IMPLEMENTAÇÃO: 

            return Hospedes.Count;
        }

        public decimal CalcularValorEstadia()
        {
            //TODO: Retorna o valor da diária
            //Cálculo: DiasReservados X Suite.ValorDiaria
            //IMPLEMENTE AQUI:

            //IMPLEMENTAÇÃO:

            decimal valor = DiasReservados * Suite.ValorDiaria;

            //Regra: Caso os dias reservados forem maior ou igual a 10, conceder um desconto de 10%
            //IMPLEMENTE AQUI:
            if(DiasReservados >= 10)
            {
                valor = DiasReservados * (Suite.ValorDiaria - (Suite.ValorDiaria * 0.10M));
            }

            return valor;
        }

        public decimal CalcularValorPessoa()
        {
            return CalcularValorEstadia() / Hospedes.Count;
        }
    }
}
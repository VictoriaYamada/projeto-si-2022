using ProjetoBanco.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco

{
    public class ContaCorrente : Conta

    {
        public ContaCorrente(Cliente cliente, int numero, decimal saldo)
            : base( numero, saldo)
        { }

        public override bool Depositar(decimal valorDeposito)
        {

            if (valorDeposito <= 0m)
            {
                MensagemTransacoes = $"O valor do depósito é inválido!";
                return false;
            }

            SetSaldo(GetSaldo() + valorDeposito);
            MensagemTransacoes = "Depósito realizado com sucesso!";
            return true;
        }
        private void SetSaldo(decimal v)
        {
            throw new NotImplementedException();
        }

        public override bool Sacar(decimal valorSaque)
        {

            if (GetSaldo() <= 0m)
            {
                MensagemTransacoes = $"O saldo é insuficiente para saque. Sua conta está com o valor atual de {GetSaldo()}";
                return false;
            }

            if (GetSaldo() < valorSaque)
            {

                MensagemTransacoes = $"Valor solicitado para o saque é {valorSaque} e o Saldo é {GetSaldo()}";
                return false;

            }

            SetSaldo(GetSaldo() - valorSaque);
            return true;
        }



    }

}
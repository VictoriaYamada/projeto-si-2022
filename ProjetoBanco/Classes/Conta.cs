using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco.Classes

{
    public abstract class Conta
    {
        private Conta(Cliente cliente, int numero, decimal saldo)

        { }

        protected Conta(int numero, decimal saldo)
        {
            Numero = numero;
            Saldo = saldo;
        }

        private decimal _saldo;
        private static Conta _Saldo;

        public int Numero { get; private set; }
        public Cliente Cliente { get; private set; }

        public decimal GetSaldo()
        { return _saldo; }

        private void SetSaldo(decimal value)
        {
            if (value >= 0)
                _saldo = value;

            else
                _saldo = 0;
        }

        public static Conta CriarContaParaCliente(Cliente cliente, int numero, decimal saldo)
        {

            if (!cliente.EhMaiorIdade)

                throw new Exception("O cliente não possúi a idade mínima para criação da conta!");

            if (numero.ToString().Length < 5)

                throw new Exception("Número da conta inválido!");

            Cliente = cliente;
            var
            Numero = numero;
            SetSaldo(saldo); 
            return _Saldo;
        }

        public int numero { get; private set; }
        public string MensagemTransacoes { get; set; }
        public decimal Saldo

        {
            get { return _saldo; }
            protected set

            {
                if (value >= 0)

                    _saldo = value;

                else

                    _saldo = 0;
            }


        }
        public abstract bool Sacar(decimal valorSaque);
        public abstract bool Depositar(decimal valorDeposito);
        public void Transferir(decimal valor, Conta destino)
        {
            var sucessoTransacaoSaque = Sacar(valor);
            var sucessoTransacaoDeposito = destino.Depositar(valor);

            if (sucessoTransacaoSaque && sucessoTransacaoDeposito)
            {
                MensagemTransacoes = "Transferência realizada com sucesso!";
            }
            MensagemTransacoes = "Falha na operação!!!";
        }

    }

}
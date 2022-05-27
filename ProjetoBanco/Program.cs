using System;



using ProjetoBanco.Classes;

namespace ProjetoBanco

{
    class Program

    {
        static void Main()
        {

            try
            {
                var Arthur = Cliente.CreateCliente("Arthur", "Rua 9 de Julho 2022", 16999222999, "999.999.999-99", new DateTime(2000, 02, 17));

                var Maria = Cliente.CreateCliente("Maria", "Rua Teste", 16999222999, "999.999.999-99", new DateTime(2000, 02, 17));

                Console.WriteLine(Arthur.ToString());

                Conta contaPoupança = new Poupança(Arthur, 445852, 1000);

                Conta contaCorrente = new ContaCorrente(Maria, 6666666, 0);

                contaPoupança.Transferir(500, contaCorrente);

                List<Conta> contas = new { contaPoupança, contaCorrente };

                Console.WriteLine(contaPoupança.GetSaldo());

                contaPoupança.Depositar(1000);

                Console.WriteLine(contaPoupança.Saldo);

                contaPoupança.Sacar(500);

                Console.WriteLine(contaPoupança.GetSaldo());

                Console.WriteLine(contaCorrente.GetSaldo());

                contaPoupança.Depositar(6600);

                Console.WriteLine(contaCorrente.GetSaldo());

                contaPoupança.Sacar(600);

                Console.WriteLine(contaPoupança.GetSaldo());
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
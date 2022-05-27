using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoBanco.Classes

{
    public class Cliente

    {
        private Cliente()

        { }

        public string Nome { get; private set; }

        public string Endereco { get; private set; }

        public long Telefone { get; private set; }

        public string CPF { get; private set; }

        public DateTime DataNascimento { get; private set; }

        public bool EhMaiorIdade => ValidarSeClienteEhMaiorDeIdade();

        public static Cliente CreateCliente(string nome, string endereco, long telefone, string cpf, DateTime dataNascimento) =>

            new Cliente { Nome = nome, Endereco = endereco, Telefone = telefone, CPF = cpf, DataNascimento = dataNascimento };

        public override string ToString() => $"Nome: {Nome} | Documento: {CPF} | Data de Nascimento: {DataNascimento} --- Sobrecrita de: { base.ToString()}";

        public bool ValidarSeClienteEhMaiorDeIdade() => DateTime.Now.Year - DataNascimento.Year >= 18;

    }

}
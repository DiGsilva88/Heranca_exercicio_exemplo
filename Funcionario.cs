using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca_exercicio_exemplo
{
    internal class Funcionario
    {

        public string Nome { get; set; }
        public int Idade { get; set; }

        public string Morada { get; set; }

        //construtor com parametros

        public Funcionario (string nome, int idade, string morada)
        {
            Nome = nome;
            idade = idade;
            Morada = morada;

        }

        //metodo

        public void ExibirInformacoes()

        {
            Console.WriteLine($"Funcionario: {Nome}, idade {Idade}, Morada {Morada}");
        }




    }
}

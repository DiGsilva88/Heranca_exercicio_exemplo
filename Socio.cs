using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca_exercicio_exemplo
{
    internal class Socio : Funcionario
    {

        public int NumeroAccoes { get; set; }

        //construtor socio


        public Socio(string nome, int idade, string morada, int n_accoes)          //temos de construir o objecto funcionario:usamos o base

            : base(nome, idade, morada)  //estes 2 pontos base está a ir buscar a referencia e só basta colocar o nome das variaveis
        {

            NumeroAccoes = n_accoes;

        }

        //metodo

        public void MostrarqtAccoes()

        {
            Console.WriteLine($" o numero de accoes é {NumeroAccoes}");
        }


        public override void ExibirInformacoes()
        {


        }
}
}

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

        /*public override void MostrarqtAccoes() *///este metodo não precisa do override ,basta ser o metodo da classe
        //se não preciso de ir a base buscar informações uso virtual
        public void MostrarqtAccoes()

        {
            //base.MostrarQtAccoes();
            Console.WriteLine($" o numero de accoes é {NumeroAccoes}");
        }


        public override void ExibirInformacoes()
        {

            base.ExibirInformacoes();//base ---> é a herança da classe Funcionario
            Console.WriteLine($"Número de acções: {NumeroAccoes}");
        }
}
}

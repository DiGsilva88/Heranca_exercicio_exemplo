using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca_exercicio_exemplo
{
    internal class Outsourcing:Funcionario

        //vai herdar nome,idade,morada
    {
        public int NumeroHoras { get; set; }

        public Outsourcing (string nome, int idade,string morada,int numeroHoras):base (nome,idade,morada)
            //temos de inicializar só o numero de horas

        {
            NumeroHoras = numeroHoras;
        }
        public override void ExibirInformacoes()
        {
            base.ExibirInformacoes();
            Console.WriteLine($"trabalhou {NumeroHoras}");
        }
}
}

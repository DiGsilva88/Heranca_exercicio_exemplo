namespace Heranca_exercicio_exemplo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //implementar a classe base-funcionario-check

            Funcionario f1=new Funcionario ("Luís",45,"Porto");
            Funcionario f2 = new Funcionario("Sara", 42, "Braga");


            //polimorfismo de referencia
            //criar o scoio chamando os construtores
            Funcionario socio1 = new Socio("Manuel", 35, "Vila Verde", 100);


            //do lado esquerdo o compilador ve o socio como um funcionario
            //new socio=> o objecto real é do tipo Socio
            //ou seja é um funcionario especializado

            Socio socio2 = new Socio("Pedro", 38, "Braga", 200);

            f1.ExibirInformacoes();
            socio1.ExibirInformacoes();
            socio2.MostrarqtAccoes();
            socio2.ExibirInformacoes();


            //o scoio também é um funcionario só que é especializado

            Funcionario socio3 = new Socio("João", 35, "Braga", 300);
            //chamo o construtor mas é um funcionario

            //polimorfismo vem do grego multiplas formas

            //se quero acrescentar algum comportamento a mais vou escrever por exemplo (nAccoes=x)

        }
    }
}

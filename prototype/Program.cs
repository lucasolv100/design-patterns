using System;

namespace prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            FuncionarioRegular funcR = new FuncionarioRegular{
                Nome = "João",
                Idade = 30,
                Tipo = "Permanente"
            };

            FuncionarioRegular cloneFuncR = (FuncionarioRegular)funcR.Clone();
            cloneFuncR.Nome = "Carlos";
            cloneFuncR.Idade = 40;


            Console.WriteLine("Detalhes do funcionário permante");
            Console.WriteLine("Nome: {0}; Idade: {1}; Tipo: {2}", funcR.Nome, funcR.Idade, funcR.Tipo);

            Console.WriteLine("Detalhes do funcionário permante clonado");
            Console.WriteLine("Nome: {0}; Idade: {1}; Tipo: {2}", cloneFuncR.Nome, cloneFuncR.Idade, cloneFuncR.Tipo);
        }
    }
}

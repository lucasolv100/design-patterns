using System;

namespace builder
{
    class Program
    {
        static void Main(string[] args)
        {
            //criar fabricante
            Fabricante fabricante = new Fabricante();

            //permitir que a classe builder fique pronta;
            ICelular celular = null;

            celular = new IphoneBuilder();
            fabricante.Construtor(celular);
            Console.WriteLine("Um novo celular foi construido: " + celular.Celular.Nome.ToString());
            Console.ReadKey();

        }
    }
}

using System;

namespace abstract_factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = ExecutorFactory.MontarCarro("Luxo");
            Carro c2 = ExecutorFactory.MontarCarro("Popular");
            Console.ReadKey();
        }
    }
}

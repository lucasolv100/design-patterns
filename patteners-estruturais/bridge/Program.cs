using System;

namespace bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            
            SmartTV minhatv = new SmartTV();
            Console.WriteLine("SELECIONE UM CANAL PARA ASSISTIR:");
            Console.WriteLine("1 - FILMES");
            Console.WriteLine("2 - DOCUMENTARIO");
            Console.WriteLine("3 - CULINARIA");
            var canalChoosed = Console.ReadKey();

            if (canalChoosed.KeyChar.ToString() == "1")
            {
                minhatv.CanalAtual = new Filme();
            }
            if (canalChoosed.KeyChar.ToString() == "2")
            {
                minhatv.CanalAtual = new Documentario();
            }
            if (canalChoosed.KeyChar.ToString() == "3")
            {
                minhatv.CanalAtual = new Culinaria();
            }

            Console.WriteLine();

            minhatv.ExibeCanalSintonizado();
            minhatv.PlayTV();

            Console.ReadKey();

        }
    }
}

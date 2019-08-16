using System;

namespace bridge
{
    public class SmartTV
    {
        public ICanal CanalAtual { get; set; }
        public void ExibeCanalSintonizado()
        {
            if (CanalAtual != null)
            {
                Console.WriteLine(CanalAtual.Canal());
            }
            else
            {
                Console.WriteLine("Por favor selecione um canal");
            }
        }

        public void PlayTV()
        {
            if (CanalAtual != null)
            {
                Console.WriteLine(CanalAtual.Status());
            }
            else
            {
                Console.WriteLine("Por favor selecione um canal para assistir");
            }
        }
    }
}
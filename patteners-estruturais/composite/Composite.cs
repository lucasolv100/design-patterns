using System;
using System.Collections.Generic;

namespace composite
{
    public class Composite : Componente
    {
        List<Componente> filhos = new List<Componente>();
        public Composite(string nome) : base(nome)
        {

        }

        public override void Adicionar(Componente c)
        {
            filhos.Add(c);
        }

        public override void Mostrar(int profundidade)
        {
            Console.WriteLine(new String('-', profundidade) + Nome);
            
            foreach (var componente in filhos)
            {
                componente.Mostrar(profundidade + 2);
            }
        }

        public override void Remover(Componente c)
        {
            filhos.Remove(c);
        }
    }
}
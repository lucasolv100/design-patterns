using System;

namespace composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite root = new Composite("Root");
            root.Adicionar(new Folha("Folha A"));
            root.Adicionar(new Folha("Folha B"));
            root.Adicionar(new Folha("Folha C"));

            Composite comp = new Composite("Composite X");
            comp.Adicionar(new Folha("Folha XA"));
            comp.Adicionar(new Folha("Folha XB"));

            root.Adicionar(comp);
            root.Adicionar(new Folha("Folha D"));


            Folha folha = new Folha("Folha E");
            root.Adicionar(folha);

            root.Remover(folha);

            root.Mostrar(1);
        }
    }
}

using System;
using System.Collections.Generic;

namespace decorator
{
    public class Emprestado : Decorator
    {
        public List<string> emprestados = new List<string>();
        public Emprestado(ItemBiblioteca item_biblioteca) : base(item_biblioteca)
        {
            
        }

        public void EmprestarItem(string nome)
        {
            emprestados.Add(nome);
            itemBiblioteca.NumeroCopias--;
        }
        public void RemoverItem(string nome)
        {
            emprestados.Remove(nome);
            itemBiblioteca.NumeroCopias++;
        }

        public override void Exibe()
        {
            base.Exibe();
            foreach (var item in emprestados)
            {
                Console.WriteLine("Emprestado " + item);
            }
        }
    }
}
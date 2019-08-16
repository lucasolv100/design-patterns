using System;

namespace decorator
{
    public class Filme : ItemBiblioteca
    {
        public Filme(string diretor, string titulo, int minutosDuracao, int numeroCopias)
        {
            Diretor = diretor;
            Titulo = titulo;
            MinutosDuracao = minutosDuracao;
            NumeroCopias = numeroCopias;
        }

        public string Diretor { get; set; }
        public string Titulo { get; set; }
        public int MinutosDuracao { get; set; }

        public override void Exibe()
        {
            Console.WriteLine("\nFilme ------------");
            Console.WriteLine("Diretor: " + Diretor);
            Console.WriteLine("Titulo: " + Titulo);
            Console.WriteLine("Minutos de duracao: " + MinutosDuracao);
            Console.WriteLine("Numero de copias: " + NumeroCopias);
        }
    }
}
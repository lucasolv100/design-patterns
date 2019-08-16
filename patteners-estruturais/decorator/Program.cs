using System;

namespace decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro("Joao", "Joao e Maria", 10);
            Filme filme = new Filme("Joao", "Joao e Maria Filme", 120, 8);

            livro.Exibe();

            filme.Exibe();

            Console.WriteLine("Emprestando um filme: ");
            Emprestado emprestado = new Emprestado(filme);
            emprestado.EmprestarItem("Carlos");
            emprestado.EmprestarItem("José");

            emprestado.Exibe();
        }
    }
}

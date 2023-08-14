namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new("Fernando", "Silva", new DateOnly(1995, 5, 20));
            Pessoa pessoa2 = new("Gisele", "Santos", new DateOnly(1989, 4, 07), "gisele@gmail.com");
         
            Livro livro = new("Rapido e Devagar", "Daniel Kahneman", "Objetiva");
            Livro livro2 = new("Essencialismo", "Greg McKeown");

            Emprestimo emprestimo = new(livro, pessoa);
            pessoa.AdicionarEmprestimo(emprestimo);
            Emprestimo emprestimo2 = new(livro, pessoa2);
            emprestimo.Devolver();
            Emprestimo emprestimo3 = new(livro2, pessoa);

            Console.ReadKey();
        }
    }
}
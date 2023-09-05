namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            Usuario usuario1 = new("Fernando", "12345678989", "11997778251", "fernando@gmail.com", new DateOnly(1995, 5, 20));
            Usuario usuario2 = new("Gisele", "98765432121", "11993322511", "gisele@gmail.com", new DateOnly(1989, 4, 07));
            biblioteca.AdicionarUsuario(usuario1);
            biblioteca.AdicionarUsuario(usuario2);


            Livro livro = new("Rapido e Devagar", 2011, 497, "Daniel Kahneman");
            MidiaDigital midiaDigial = new("Essencialismo", 2014, 216, "Greg McKeown");
            Revista revista = new("Exame", 2023, 55, 03);
            biblioteca.AdicionarItem(livro);
            biblioteca.AdicionarItem(midiaDigial);
            biblioteca.AdicionarItem(livro);

            Emprestimo emprestimo1 = new(livro, usuario1);
            Emprestimo emprestimo2 = new(revista, usuario1);
            Emprestimo emprestimo3 = new(livro, usuario2);
            Emprestimo emprestimo4 = new(midiaDigial, usuario2);

            biblioteca.EmprestarItem(emprestimo1);
            biblioteca.EmprestarItem(emprestimo2);
            biblioteca.EmprestarItem(emprestimo3);
            biblioteca.EmprestarItem(emprestimo4);

            biblioteca.DevolverItem(livro, usuario1);
            biblioteca.DevolverItem(livro, usuario2);

            biblioteca.EmprestarItem(emprestimo3);
            
            Console.ReadKey();

        }
    }
}
namespace Exercício_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Varejo varejo = new Varejo("MercadoI", "Supermercado", "98765432100001", Tipo.EmpresaIndividual);
            Empreiteira empreiteira = new Empreiteira("EmpreiteiraI", "Empreiteira Ltda", "12345678900001", Tipo.SociedadeLimitadaEmpresarial);

            varejo.InformacoesEmpresa();
            varejo.RealizarVenda();
            Console.WriteLine();
            empreiteira.InformacoesEmpresa();
            empreiteira.RealizarVenda();

            Console.ReadKey();
        }
    }
}
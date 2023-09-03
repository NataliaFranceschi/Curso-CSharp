namespace Exercício_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IEmpresa> empresas = new List<IEmpresa>();

            EnviarNotificacaoWhatsApp notificacao = new EnviarNotificacaoWhatsApp();

            IEmpresa varejo = new Varejo("MercadoI", "Supermercado", "98765432100001", Tipo.EmpresaIndividual, notificacao);
            IEmpresa empreiteira = new Empreiteira("EmpreiteiraI", "Empreiteira Ltda", "12345678900001", Tipo.SociedadeLimitadaEmpresarial);

            empresas.Add(varejo);
            empresas.Add(empreiteira);

            foreach (var empresa in empresas)
            {
                empresa.InformacoesEmpresa();
                empresa.RealizarVenda();
                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
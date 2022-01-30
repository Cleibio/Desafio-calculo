namespace Calculo_com_funcoes
{
    class Program
    {
        static void Main(string[]args)
        {
            View TelaAcessso = new View();
            var OpcaoUsuario = TelaAcessso.TelaExibicao();
            TelaAcessso.PainelExecucao(OpcaoUsuario);
        }
    }
}


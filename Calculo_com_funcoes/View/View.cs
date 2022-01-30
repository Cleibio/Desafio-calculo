namespace Calculo_com_funcoes
{
    public class View
    {
        Calculo CalcularOperacao = new Calculo();
        private string OpcaoUsuario { get; set; }
        public string TelaExibicao()
        {
            System.Console.WriteLine("             PAINEL DE TRABALHO                ");
            System.Console.WriteLine("-----------------------------------------------");
            System.Console.WriteLine("               MENU INICIAL              ");
            System.Console.WriteLine("-----------------------------------------------");
            System.Console.WriteLine("1 - Soma de valores");
            System.Console.WriteLine("2 - Subtração de valores");
            System.Console.WriteLine("3 - Multiplicação de valores");
            System.Console.WriteLine("4 - Divisão de valores");
            System.Console.WriteLine("5 - Cálculo de Média simples de valores");
            System.Console.WriteLine("6 - Limpar a tela");
            System.Console.WriteLine("X - Sair");
            System.Console.WriteLine("------------------------------------------------");
            System.Console.WriteLine("Informe uma opção conforme o menu inicial acima.");
            this.OpcaoUsuario = Console.ReadLine().ToUpper();
            System.Console.WriteLine();
            return this.OpcaoUsuario;
        }

        public void PainelExecucao(string OpcaoUsuario)
        {
            this.OpcaoUsuario = OpcaoUsuario;
            while(this.OpcaoUsuario.ToUpper() != "X")
            {
                switch(this.OpcaoUsuario)
                {
                    case "1":
                        CalcularOperacao.SomaValores();
                        break;
                    case "2":
                        CalcularOperacao.SubtrairValores();
                        break;
                    case "3":
                        CalcularOperacao.MultplicarValores();
                        break;
                    case "4":
                        CalcularOperacao.DividirValores();
                        break;
                    case "5":
                        CalcularOperacao.MediaSimples();
                        break;
                    case "6":
                        Console.Clear();
                        break;
                    default:
                        throw new ArgumentException();
                }
                TelaExibicao();
            }
            
        }
        
    }
}
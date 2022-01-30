namespace Calculo_com_funcoes
{
    public class Calculo
    {
        private int Valor { get; set; }

        public List<int> EntradaDeValores()
        {
            List<int> Numbers = new List<int>();
             Console.WriteLine("informe um número");
             Numbers.Add(int.Parse(Console.ReadLine()));
             Console.WriteLine("informe um número");
             Numbers.Add(int.Parse(Console.ReadLine()));
             Console.WriteLine("informe um número");
             Numbers.Add(int.Parse(Console.ReadLine()));
            return Numbers;
        }

        public void SomaValores()
        {
            var Somatorio = 0;
            var Valores = EntradaDeValores();
            foreach (var numbers in Valores)
            {
                Somatorio += numbers;
            }
            Console.WriteLine("O Resultado da Soma é: " + Somatorio);
        }

        public void SubtrairValores()
        {
            var Subtracao = 0;
            var contador = 0;
            var Valores = EntradaDeValores();
            foreach (var numbers in Valores)
            {
                contador++;
                if (contador == 1)
                {
                    Subtracao = numbers - Subtracao;
                }
                else
                {
                    Subtracao = Subtracao - numbers;
                }


            }
            Console.WriteLine("O Resultado da Subtração é: " + Subtracao);
        }

        public void MultplicarValores()
        {
            var Multiplicacao = 1;
            var Valores = EntradaDeValores();
            foreach (var numbers in Valores)
            {
                Multiplicacao *= numbers;
            }
            Console.WriteLine("O Resultado da Multiplicação é: " + Multiplicacao);
        }

        public void DividirValores()
        {
            float Divisao = 1;
            var contador = 0;
            var Valores = EntradaDeValores();
            foreach (var numbers in Valores)
            {
                contador++;
                if (contador == 1)
                {
                    Divisao = ((float)numbers / Divisao);
                }
                else
                {
                    Divisao = ((float)Divisao / numbers);
                }
            }
            Console.WriteLine("O Resultado da divisão é: " + Divisao);
        }

        public void MediaSimples()
        {
            var Media = 0;
            var Valores = EntradaDeValores();
            foreach (var numbers in Valores)
            {
                Media += numbers;
            }
            Console.WriteLine("O Resultado da média é: " + Media / Valores.Count());
        }
    }
}
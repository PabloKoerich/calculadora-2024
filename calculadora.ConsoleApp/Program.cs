namespace calculadora.ConsoleApp
{

    //requisito 01
    // nossa calculadora deve ter a possibilidade de somar dois numeros - OK

    //requisito 02
    // Nossa calculadora deve ter a possibilidade de fazer vária operações de soma - OK

    //requisito 03
    //várias operações de subtração. - OK

    //requisito 04
    //deve fazer as 4 operações básicas - OK

    //requisito 05
    // realizar operações com "0". falta negar divizão por zero

    //requisito 06
    //deve validar as opções no menu ?????

    //requisito 07
    //deve realizar as operações usando numeros com 2 casas. - OK



    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();

                Console.WriteLine("calculadora Tabajara 2024");

                Console.WriteLine("Digite 1 para adicionar");
                Console.WriteLine("Digite 2 para subtrair");
                Console.WriteLine("Digite 3 para multiplicar");
                Console.WriteLine("Digite 4 para dividir");

                Console.WriteLine("Digite S para sair");

                string operacao = Console.ReadLine();

                if (operacao == "S")
                    break;

                Console.WriteLine("digite o primeiro numero");

                string primeiroNumerostring = "";

                primeiroNumerostring = Console.ReadLine();

                    int primeiroNumero = Convert.ToInt32(primeiroNumerostring);
                           
                Console.WriteLine("Digite o segundo numero:");

                string segundoNumerostring = Console.ReadLine();

                int segundoNumero = Convert.ToInt32(segundoNumerostring);

                int resultado = 0;

                if (operacao == "1")
                {
                    resultado = primeiroNumero + segundoNumero;
                }

                else if (operacao == "2")
                {
                    resultado = primeiroNumero - segundoNumero;
                }

                else if (operacao == "3")
                {
                    resultado = primeiroNumero * segundoNumero;
                }

                else if (operacao == "4")
                {
                    resultado = primeiroNumero / segundoNumero;
                 }
                
                Console.WriteLine("O resultado é: " + resultado.ToString("F"));

                Console.ReadLine();

            }
        }
    }
}

              
    


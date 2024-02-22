using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMFG.ProgramacaoIV.Apresentacao
{
    internal class Program
    {
        public static ExercicioLivro exercicioLivro = new ExercicioLivro();
        static void Main(string[] args)
        {
            var escolha = 20;
            do
            {
                Console.WriteLine(" 1 - Exercicio");
                Console.WriteLine(" 2 - Exercicio");
                Console.WriteLine(" 3 - Exercicio");
                Console.WriteLine(" 4 - Exercicio");
                Console.WriteLine(" 5 - Exercicio");
                Console.WriteLine(" 6 - Exercicio");
                Console.WriteLine(" 7 - Exercicio");
                Console.WriteLine(" 8 - Exercicio");
                Console.WriteLine(" 9 - Exercicio");
                Console.WriteLine(" 0 - Sair");
                Console.WriteLine("");
                Console.Write("Digite a opção desejada: ");
                int.TryParse(Console.ReadLine(), out escolha);

                switch (escolha)
                {
                    case 1:
                        CalculadoraCambialUBRLxUSD();
                        break;
                    case 2:
                        CalculadoraCambialUSDxBRL();
                        break;
                    case 3:
                        ConsumoKmLt();
                        break;
                    case 4:
                        ConsultaIdade();
                        break;

                    case 5:
                        CalculadoraGeral();
                        break;
                    case 6:
                        ContagemVogal();
                        break;
                    case 7:
                        ContagemConsoante();
                        break;
                    case 8:
                        ClassificacaoEtaria();
                        break;
                    case 9:
                        exercicioLivro.Menu();
                        break;



                }


            } while (escolha != 0);

            
        }
    /// <summary>
    /// ////////// EXERCICIO 1 ///////////////////////////////////////////////////////////////////////////
    /// </summary>
        public static void CalculadoraCambialUBRLxUSD()
        {
            Console.Write("Digite o valor em BRL: ");
            double valorBRL = Convert.ToDouble(Console.ReadLine());
            double taxaCambio = 0.193259;
            double valorUSD = valorBRL * taxaCambio;
            Console.WriteLine($"{valorBRL} BRL é equivalente a {valorUSD} USD.");
            Console.ReadLine();

        }
        /// <summary>
        /// ////////// EXERCICIO 2 ///////////////////////////////////////////////////////////////////////////
        /// </summary>
        public static void CalculadoraCambialUSDxBRL()
        {
            Console.Write("Digite o valor em USD: ");
            double valorUSD = Convert.ToDouble(Console.ReadLine());
            double taxaCambio = 5.22;
            double valorBRL = valorUSD * taxaCambio;
            Console.WriteLine($"{valorUSD} USD é equivalente a {valorBRL} BRL.");
            Console.ReadLine();
        }
        ///////////// EXERCICIO 3 ///////////////////////////////////////////////////////////////////////////
        public static void ConsumoKmLt()
        {
            Console.Write("Digite a distância total percorrida em KM: ");
            double distanciaTotal = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o gasto de combustível em litros: ");
            double gastoCombustivel = Convert.ToDouble(Console.ReadLine());
            double mediaGasto = distanciaTotal / gastoCombustivel;
            Console.WriteLine($"A média de gasto do automóvel é de {mediaGasto} KM por litro");
            Console.ReadLine();
        }
        ///////////// EXERCICIO 4 ///////////////////////////////////////////////////////////////////////////
        public static void ConsultaIdade()
        {
            Console.Write("Digite o ano de nascimento: ");
            int anoNascimento = Convert.ToInt32(Console.ReadLine());
            int idade = DateTime.Now.Year - anoNascimento;
            Console.WriteLine($"Você tem {idade} anos.");
            Console.ReadLine();
        }
        ///////////// EXERCICIO 5 ///////////////////////////////////////////////////////////////////////////
        public static void CalculadoraGeral()
        {
            Console.WriteLine("Calculadora");
            Console.WriteLine("1. Soma");
            Console.WriteLine("2. Subtração");
            Console.WriteLine("3. Multiplicação");
            Console.WriteLine("4. Divisão");
            Console.WriteLine("5. Resto da Divisão");

            Console.Write("Escolha a operação (1-5): ");
            int escolha = Convert.ToInt32(Console.ReadLine());
            Console.Write("Digite o primeiro número: ");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double resultado = 0;

            switch (escolha)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    resultado = num1 / num2;
                    break;
                case 5:
                    resultado = num1 % num2;
                    break;
                default:
                    Console.WriteLine("Escolha inválida");
                    break;
            }
            Console.WriteLine($"Resultado: {resultado}");
            Console.ReadLine();
        }
        ///////////// EXERCICIO 6 ///////////////////////////////////////////////////////////////////////////
        public static void ContagemVogal()
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine().ToLower(); 
            int countVogais = 0;
            foreach (char letra in nome)
            {
                if ("aeiou".Contains(letra))
                {
                    countVogais++;
                }
            }
            Console.WriteLine($"O nome {nome} contém {countVogais} vogais.");
            Console.ReadLine();
        }
        ///////////// EXERCICIO 7 ///////////////////////////////////////////////////////////////////////////
        public static void ContagemConsoante()
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine().ToLower(); 
            int countConsoantes = 0;
            foreach (char letra in nome)
            {
                if ("bcdfghjklmnpqrstvwxyz".Contains(letra))
                {
                    countConsoantes++;
                }
            }
            Console.WriteLine($"O nome {nome} contém {countConsoantes} consoantes.");
            Console.ReadLine();
        }
        ///////////// EXERCICIO 8 ///////////////////////////////////////////////////////////////////////////
        public static void ClassificacaoEtaria()
        {
            Console.Write("Digite seu nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite sua data de nascimento (AAAA-MM-DD): ");
            DateTime dataNascimento = DateTime.Parse(Console.ReadLine());

            int idade = DateTime.Now.Year - dataNascimento.Year;

            string faixaEtaria = "";
            if (idade <= 19)
            {
                faixaEtaria = "Jovem";
            }
            else if (idade <= 59)
            {
                faixaEtaria = "Adulto";
            }
            else
            {
                faixaEtaria = "Idoso";
            }

            Console.WriteLine($"{nome}, você está na faixa etária: {faixaEtaria}.");
            Console.ReadLine();
        }

    }
}

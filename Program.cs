//Estagiário: Daniel Vitor
using System;

namespace Exercicio1
{
    class Program
    {
        static int lerInt()
        {
            int valorDoUsuario = 0;
            bool erro = true;
            const string mensagemDeErro = "Valor inválido, tente novamente";
            do
            {
                try
                {
                    valorDoUsuario = int.Parse(Console.ReadLine());
                    erro = false;
                }catch(ArgumentNullException e)
                {
                    Console.WriteLine(mensagemDeErro);
                }catch(FormatException e)
                {
                    Console.WriteLine(mensagemDeErro);
                }
                catch(OverflowException e)
                {
                    Console.WriteLine(mensagemDeErro);
                }
            } while (erro);
            return valorDoUsuario;
        }

        static void exercicio1() {
            Console.WriteLine("Digite o 1º número:");
            int num1 = lerInt();
            Console.WriteLine("Digite o 2º número:");
            int num2 = lerInt();
            Console.WriteLine(string.Format("Soma: {0}", num1 + num2));
            Console.WriteLine(string.Format("Subtração: {0}", num1 - num2));
            Console.WriteLine(string.Format("Multiplicação: {0}", num1 * num2));
            Console.WriteLine(string.Format("Divisão: {0}", (double)num1 / (double)num2));
            Console.WriteLine(string.Format("Divisão inteira: {0}", num1 / num2));
            Console.WriteLine(string.Format("Resto: {0}", num1 % num2));
            Console.WriteLine(string.Format("Potência: {0}", Math.Pow(num1, num2)));
        }
        static void exercicio2() {
            Console.WriteLine("Digite um número");
            string inputDoUsuario = Console.ReadLine().Replace(".", ",");
            bool flutuante = inputDoUsuario.Contains(",");
            double convertido = 0.0;
            bool valido = true;
            try
            {
                convertido = double.Parse(inputDoUsuario);
            }catch(ArgumentNullException e)
            {
                valido = false;
            }catch(FormatException e)
            {
                valido = false;
            }catch(OverflowException e)
            {
                valido = false;
            }

            if (valido) {
                if (flutuante)
                {
                    Console.WriteLine("Flutuante");
                }
                else
                {
                    Console.WriteLine("Inteiro");
                }
            }
            else
            {
                Console.WriteLine("Não é um número válido");
            }
        }
        static void exercicio3() {
            Console.WriteLine("Digite qualquer coisa");
            string texto = Console.ReadLine();
            Console.WriteLine(string.Format("{0} - {1} - {2}", texto.Length, texto.ToLower(), texto.ToUpper()));
        }
        static void exercicio4() {
            Console.WriteLine("Digite um texto qualquer");
            string texto = Console.ReadLine().ToLower();
            Console.WriteLine("Digite o subtexto que você quer buscar dentro desse texto");
            string subTexto = Console.ReadLine().ToLower();
            Console.WriteLine(string.Format("{0} Ocorrências", texto.Split(subTexto).Length - 1));
        }
        static void exercicio5() {
            Console.WriteLine("Digite um texto qualquer: ");
            string texto = Console.ReadLine();
            const char caractereDesejado = '-';
            //Usar IndexOf ao invés de LastIndexOf caso queira a primeira ocorrência ao invés da última
            int posicaoDoCaractere = texto.LastIndexOf(caractereDesejado);
            bool caractereExisteNaString = posicaoDoCaractere != -1;
            if (caractereExisteNaString)
            {
                string textoAteOCaractere = texto.Substring(0, posicaoDoCaractere + 1);
                string novoTexto = texto.Replace(textoAteOCaractere, "").Trim();
                Console.WriteLine(novoTexto);
            }
            else
            {
                DateTime dataAtual = DateTime.Now;
                Console.WriteLine("{0} - {1}", dataAtual, texto);
            }
        }
        static void exercicio6() {
            Console.WriteLine("Digite uma data:");
            string texto = Console.ReadLine();
            bool dataValida = true;
            try
            {
                DateTime.Parse(texto);
            }catch(FormatException e)
            {
                dataValida = false;
            }catch(ArgumentNullException e)
            {
                dataValida = false;
            }
            Console.WriteLine(dataValida ? "Data válida" : "Data inválida");
        }
        static void exercicio7() {
            Console.WriteLine("Digite um data e hora");
            string texto = Console.ReadLine();
            string[] dataEHora = texto.Split(" ");
            string data = dataEHora[0];
            string hora = dataEHora[1];
            string[] dataSeparada = data.Split("/");
            string[] horaSeparada = hora.Split(":");
            Console.WriteLine(string.Format("Dia {0} do mês {1} do ano {2}, as {3} horas, {4} minutos e {5} segundos.",
                dataSeparada[0], dataSeparada[1], dataSeparada[2], horaSeparada[0], horaSeparada[1], horaSeparada[2]));
        }
        static void exercicio8() {
            Console.WriteLine("Digite a 1ª data:");
            DateTime data1 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Digite a 2ª data:");
            DateTime data2 = DateTime.Parse(Console.ReadLine());
            if(data1 > data2)
            {
                Console.WriteLine("Erro: A primeira data é maior que a segunda");
            }
            else
            {
                TimeSpan diferenca = data2 - data1;
                Console.WriteLine("Diferença entre as datas:");
                Console.WriteLine("-------------------------");
                if(diferenca.TotalDays >= 365)
                {
                    int anos = (int)(diferenca.TotalDays / 365);
                    Console.WriteLine(string.Format("Diferença em anos: {0}", anos));
                }
                else if (diferenca.TotalDays >= 30)
                {
                    int meses = (int)(diferenca.TotalDays / 30);
                    Console.WriteLine(string.Format("Diferença em meses: {0}", meses));
                }
                else if (diferenca.TotalDays >= 1)
                {
                    int dias = (int)(diferenca.TotalDays);
                    Console.WriteLine(string.Format("Diferença em dias: {0}", dias));
                }
                else
                {
                    int horas = (int)(diferenca.TotalHours);
                    int minutos = (int)(diferenca.TotalMinutes);
                    int segundos = (int)(diferenca.TotalSeconds);
                    Console.WriteLine(string.Format("Diferença em horas: {0}", horas));
                    Console.WriteLine(string.Format("Diferença em minutos: {0}", minutos));
                    Console.WriteLine(string.Format("Diferença em segundos: {0}", segundos));
                }
            }
        }
        static void exercicio9() {
            Console.WriteLine("Digite o dia:");
            int dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o mes:");
            int mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o ano:");
            int ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a hora:");
            int hora = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os minutos:");
            int minutos = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os segundos:");
            int segundos = int.Parse(Console.ReadLine());
            try
            {
                DateTime data = new DateTime(ano, mes, dia, hora , minutos , segundos);
                Console.WriteLine("Nenhum problema encontrado");
            }catch(ArgumentOutOfRangeException e)
            {
                

                if (mes < 1 || mes > 12)
                {
                        Console.WriteLine("O parâmetro referente ao mês é inválido");
                }
                else
                {
                    if (dia > DateTime.DaysInMonth(ano, mes) || dia < 1)
                    {
                        Console.WriteLine("O parâmetro referente ao dia é inválido");
                    }
                }
                if(ano < 1)
                {
                    Console.WriteLine("O parâmetro referente ao ano é inválido");
                }
                if(hora < 0 || hora > 24)
                {
                    Console.WriteLine("O parâmetro referente às horas é inválido");
                }
                if(minutos < 0 || minutos > 59)
                {
                    Console.WriteLine("O parâmetro referente aos minutos é inválido");
                }
                if(segundos < 0 || segundos > 59)
                {
                    Console.WriteLine("O parâmetro referente aos segundos é inválido");
                }
            }
        }
        static void menu()
        {
            bool continuar = true;
            do {
                Console.WriteLine("Selecione o exercício:");
                Console.WriteLine("----------------------------------------------");
                for(int i = 1; i <= 9; i++) {
                    Console.WriteLine(string.Format("{0}-Exercício {0}", i));
                }
                Console.WriteLine("10-Sair");
                int opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        exercicio1();
                        break;
                    case 2:
                        exercicio2();
                        break;
                    case 3:
                        exercicio3();
                        break;
                    case 4:
                        exercicio4();
                        break;
                    case 5:
                        exercicio5();
                        break;
                    case 6:
                        exercicio6();
                        break;
                    case 7:
                        exercicio7();
                        break;
                    case 8:
                        exercicio8();
                        break;
                    case 9:
                        exercicio9();
                        break;
                    case 10:
                        Console.WriteLine("Fim do programa");
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida, tente novamente");
                        break;

                }
            } while (continuar);
        }
        static void Main(string[] args)
        {
            menu();
            Console.ReadKey();
        }
    }
}

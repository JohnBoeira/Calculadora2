using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraOrientada.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {             
            string opcao = "";             
            Calculadora cal = new Calculadora();
            while (true)
            {
                Console.WriteLine("Selecione a operação: {0}1 para soma {0}2 para subtrair {0}3 para dividir {0}4 para multiplicar {0}5 para mostar resultados {0}---S Para sair", Environment.NewLine);
                opcao = Console.ReadLine();
                //MENU
                switch (opcao)
                {
                    case "1": cal.Somar(opcao); Console.WriteLine(cal.resultados[cal.contador]); cal.contador++; break;
                    case "2": cal.Subtrair(opcao); Console.WriteLine(cal.resultados[cal.contador]); cal.contador++; break;
                    case "3": cal.Dividir(opcao); Console.WriteLine(cal.resultados[cal.contador]); cal.contador++; break;
                    case "4": cal.Multiplicar(opcao); Console.WriteLine(cal.resultados[cal.contador]); break;
                    case "5": Listar(cal); break;
                }
                //CASO s            
                if (opcao.Equals("s", StringComparison.OrdinalIgnoreCase))
                {
                   break;
                }
                //VALIDAÇÃO
                else if (opcao != "1" && opcao != "2" && opcao != "3" && opcao !="4" && opcao != "5")
                {
                    Console.WriteLine("Operação inválida");
                }             
                Console.ReadLine();
                Console.Clear();
            }
        }
        private static void Listar(Calculadora cal)
        {
            for (int i = 0; i <= cal.contador; i++)
            {
                Console.WriteLine(cal.resultados[i]);
            }
        }
    }
}

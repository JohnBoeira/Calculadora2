using System;

namespace CalculadoraOrientada.ConsoleApp
{
    internal class Calculadora
    {
        public double primeiroValor, segundoValor, resultado;
        public int contador = 0;
        public string[] resultados = new string[100];
        public void SalvarResultado(string opcao)
        {
            //FORMATANDO ARRAY STRING
            switch (opcao)
            {
                case "1": resultados[contador] = primeiroValor.ToString() + "+" + segundoValor.ToString() + "=" + resultado.ToString(); ; break;
                case "2": resultados[contador] = primeiroValor.ToString() + "-" + segundoValor.ToString() + "=" + resultado.ToString(); ; break;
                case "3": resultados[contador] = primeiroValor.ToString() + "/" + segundoValor.ToString() + "=" + resultado.ToString(); ; break;
                case "4": resultados[contador] = primeiroValor.ToString() + "*" + segundoValor.ToString() + "=" + resultado.ToString(); ; break;
            }            
        }
        public void PedirValores()
        {
            Console.WriteLine("Primeiro valor:");
            primeiroValor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("segundo valor:");
            segundoValor = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();         
        }    
        //OPERAÇÕES
        public void Somar(string opcao)
        {
            PedirValores();
            resultado= primeiroValor + segundoValor;
            SalvarResultado(opcao);           
        }
        public void Subtrair(string opcao)
        {
            PedirValores();
            resultado= primeiroValor - segundoValor;
            SalvarResultado(opcao);          
        }
        public void Dividir(string opcao)
        {
            PedirValores();
            //VALIDAÇÃO
            if (segundoValor == 0)
            {
                Console.WriteLine("Não é possível dividir por 0!");        
            }
            else
            {
                resultado = primeiroValor / segundoValor;
                SalvarResultado(opcao);
              
            }     
        }
        public void Multiplicar(string opcao)
        {
           PedirValores();
           resultado= primeiroValor * segundoValor;
           SalvarResultado(opcao);
           
        }
    }
}

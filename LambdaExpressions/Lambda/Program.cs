using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            // Passa a referência do método
            ActionCalculaInteiros(ActionSomaInteiros, 1, 1);

            var soma = FuncCalculaInteiros(FuncSomaInteiros, 2, 2);
            Console.WriteLine("Soma utilizando Func: " + soma);
            Console.ReadLine();
        }

        // Actions não devolvem valores, mas podem receber parâmetros
        // Definindo um método que receba uma action genérica
        // os parâmetros genérios da action devem ser os mesmos e na mesma quantidade do método que será passado como parâmetro
        // para o método que recebe a Action
        public static void ActionCalculaInteiros(Action<int, int> Calcula, int num1, int num2)
        {
            // Irá executar o método que foi passado por parâmetros
            // Como existem dois parâmetros genéricos definidos na Action, deve ser passado dois parâmetros para a chamada
            // do método
            Calcula(num1, num2);
        }

        public static int FuncCalculaInteiros(Func<int, int, int> Calcula, int num1, int num2)
        {
            return Calcula(num1, num2);
        }

        public static void ActionSomaInteiros(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }

        // A assinatura desse método deve ser igual a assinatura da Func no método onde ela será recebida
        public static int FuncSomaInteiros(int num1, int num2)
        {
            return num1 + num2;
        }
    }

    public class Employee
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}

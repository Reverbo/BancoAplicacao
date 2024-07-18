using System.Runtime.CompilerServices;

namespace Banco.Aplicacao
{
    public class ContaBancaria
    {
        public int ValorDepositado { get; set; }
        public int ValorSacado { get; set; }

        public int Depositar()
        {
            int valorDepositado = ValorDepositado;
            Console.WriteLine("Quanto você deseja depositar?");
            valorDepositado = Convert.ToInt16(Console.ReadLine());
            return valorDepositado;
        }

        public int Sacar()
        {
            if (ValorDepositado < ValorSacado)
            {

                throw new ArgumentException("Parameter cannot be null");

            }

            int valorSacado = ValorSacado;
            Console.WriteLine("Quanto você deseja sacar");
            valorSacado = Convert.ToInt16(Console.ReadLine());

            return valorSacado;
        }

        public int SaldoBancario()
        {

            int verificarSaldo = Depositar() - Sacar();

            return verificarSaldo;

        }
        public static void Main(string[] args)
        {

            var conta = new ContaBancaria();
            int saldoBacario = conta.SaldoBancario();

            Console.WriteLine($"Seu saldo restante é de:{saldoBacario}");


        }
    }
}



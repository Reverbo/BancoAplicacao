using Banco.Aplicacao.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Aplicacao.Repositories
{
    internal class DepositarSaldo : IDepositar
    {
        public int ValorDepositado { get; set; }

        public int Depositar()
        {
            Console.WriteLine("Quanto você deseja depositar?");
            ValorDepositado = Convert.ToInt16(Console.ReadLine());
            return ValorDepositado;
        }
    }
}

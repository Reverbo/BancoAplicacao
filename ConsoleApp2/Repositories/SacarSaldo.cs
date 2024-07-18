using Banco.Aplicacao.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Aplicacao.Repositories
{
    internal class SacarSaldo : ISacar
    {
        public int ValorDepositado { get; set; }
        public int ValorSacado { get; set; }
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
    }
}

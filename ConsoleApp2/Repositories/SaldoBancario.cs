using Banco.Aplicacao.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Aplicacao.Repositories
{
    internal class SaldoBancario
    {
        private readonly ISacar _sacar;
        private readonly IDepositar _depositar;

        public SaldoBancario(ISacar sacar, IDepositar depositar)
        {
            _sacar = sacar;
            _depositar = depositar;
        }

        public int SaldoBancarioConta()
        {
            int verificarSaldo = _depositar.Depositar() - _sacar.Sacar();
            return verificarSaldo;
        }
    }
}

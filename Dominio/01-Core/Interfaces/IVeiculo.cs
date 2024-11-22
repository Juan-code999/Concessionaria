using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio._01_Core.Interfaces
{
    public interface IVeiculo
    {
        string ExibirDetalhes();
        double CalcularConsumo(double distancia);
    }
}

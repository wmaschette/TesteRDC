using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Interfaces
{
    public interface ISinais
    {
        IEnumerable<DadosSinais> ValidarSinais(string[] dados);
    }
}

using Dominio.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Interfaces
{
    public interface ISoldados
    {
        DadosSoldados VerificarSoldadoSobrevivente(int quantidade);
    }
}

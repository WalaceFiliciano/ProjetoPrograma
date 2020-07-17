using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models.Enums
{
    public enum SalesStatus : int
    {
        Pendente = 0,
        Faturado = 1,
        Cancelado = 2,
    }
}

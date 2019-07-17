using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_test.Domain.Entities.Cardapio
{
    public class Cardapio
    {
        public int CardapioId { get; set; }
        public string nameProduct { get; set; }
        public int AveragePreparationTime { get; set; }

    }
}

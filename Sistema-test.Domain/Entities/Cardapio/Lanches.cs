using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_test.Domain.Entities.Cardapio
{
    class Lanches
    {
        public int LanchesId { get; set; }
        public string nameProduct { get; set; }
        public int AveragePreparationTime { get; set; }
        public DateTime DateCreate { get; set; }
        public DateTime MyProperty { get; set; }

    }
}

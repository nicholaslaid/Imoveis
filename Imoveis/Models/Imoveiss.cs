using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Imoveis.Models
{
    public class Imoveiss
    {
        public int id { get; set; }
        public string cidade { get; set; }

        public string bairro { get; set; }

        public string type { get; set; }

        public float value { get; set; }

        public int qtd_de_quartos { get; set; }

        public int qtd_de_banheiros { get; set; }

        public int qtd_de_salas { get; set; }

        public int qtd_de_vagas { get; set; }
    }
}

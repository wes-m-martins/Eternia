using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eternia
{
    public class Aldeao
    {
        public int ID { get; set; }
        public TipoNativo Genero {get; set;}
        public string Nome { get; set; }

        private Aldeao (TipoNativo tipo, int id, string nome)
        {
            this.ID = id;
            this.Genero = tipo;
            this.Nome = nome;
        }
    }
}

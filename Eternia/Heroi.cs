using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eternia
{
    public abstract class Heroi: Nativo
    {
        protected Heroi(string nome)
        {
            Nome = nome;
        }

        public TipoHeroi Genero { get; set; }
        public uint ATK { get; set; }
        public uint DEF { get; set; }
        public uint MAG { get; set; }
        public uint RES { get; set; }
        public uint HP { get => this.HP; 
            set
            {
                if (value >= HPMAX)
                    HP = HPMAX;
            }
                }
        public uint HPMAX { get; set; }
        public Status Status { get; set; }

       

    }
}

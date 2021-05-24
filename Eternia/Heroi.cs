using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eternia
{
    public abstract class Heroi
    {
        protected int ID {get; set;}
        protected string Nome { get; set; }
        public TipoHeroi Genero { get; set; }
        public uint ATK { get; set; }
        public uint DEF { get; set; }
        public uint MAG { get; set; }
        public uint RES { get; set; }
        public uint HP { get; set; }
        public uint HPMAX { get; set; }
        public Status Status { get; set; }

        public override string ToString()
        {
            string retorno = "";
            retorno += this.ID + " |";
            retorno += this.Nome + " |";
            retorno += this.Genero + " |";
            retorno += this.ATK + " |";
            retorno += this.DEF + " |";
            retorno += this.MAG + " |";
            retorno += this.RES + " |";
            retorno += this.HP + " |";
            retorno += this.HPMAX + " |";
            retorno += this.Status;
            return retorno;


        }

    }
}

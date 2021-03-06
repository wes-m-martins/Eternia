using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eternia
{
    class Mage : Heroi
    {
        public Mage(int id, string nome, TipoHeroi genero, uint atk, uint def, uint mag, uint res, uint hp, uint hpmax, Status status)
        {
            this.ID = id;
            this.Nome = nome;
            this.Genero = (TipoHeroi) genero;
            this.ATK = atk;
            this.DEF = def;
            this.MAG = mag;
            this.RES = res;
            this.HP = hp;
            this.HPMAX = hpmax;
            this.Status = status;
        }
    }
}

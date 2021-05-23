using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eternia
{
    class Healer : Heroi
    {
        private Healer(string nome, TipoHeroi genero, uint atk, uint def, uint mag, uint res, uint hp, uint hpmax) : base(nome)
        {
            this.Nome = nome;
            this.Genero = genero;
            this.ATK = atk;
            this.DEF = def;
            this.MAG = mag;
            this.RES = res;
            this.HP = hp;
            this.HPMAX = hpmax;
        }
    }
}

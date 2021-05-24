using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eternia
{
    class Warrior : Heroi
    {
        public Warrior(int id, string nome, TipoHeroi genero, uint atk, uint def, uint mag, uint res, uint hp, uint hpmax,int status)
        {
            this.ID = id;
            this.Nome = nome;
            this.Genero = (TipoHeroi)genero;
            this.ATK = atk;
            this.DEF = def;
            this.MAG = mag;
            this.RES = res;
            this.HP = hp;
            this.HPMAX = hpmax;
            this.Status = (Status)status;
        }
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

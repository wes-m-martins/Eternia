using System;
using System.Collections.Generic;

namespace Eternia
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Aldeao> Aldeoes = new List <Aldeao>();
            List <Heroi> Herois = new List <Heroi>();

            var nome = "";
            uint opcao =0, atk =0, def =0, mag =0, res =0, hp =0, hpmax = 0;
            int id = 0, status = 0;
            var genero = 0;

            Console.WriteLine("Bem vindo a Eternia");
            Console.WriteLine("O que você será em nossa terra?? ");
            Console.WriteLine("1 - Aldeão ");
            Console.WriteLine("2 - Heroi");
            opcao = Convert.ToUInt32(Console.ReadLine());

            if (opcao ==2)
            {
                Console.WriteLine("Qual o seu nome, bravo herói?? ");
                nome = Console.ReadLine();
                Console.WriteLine("Que tipo de herói é você?? 1 - Brawler | 2 - Healer | 3 - Mage | 4 - Warrior ?? ");
                genero = int.Parse (Console.ReadLine());

                Console.WriteLine("Qual seu poder de ataque físico?");
                atk = Convert.ToUInt32( Console.ReadLine());
                Console.WriteLine("Qual seu poder de defesa física?");
                def = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine("Qual se poder de ataque magico?");
                mag = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine("Qual se poder de defesa magica?");
                res = Convert.ToUInt32( Console.ReadLine());
                Console.WriteLine("Qual se poder de Vida?");
                hp = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine("Qual se poder de Vida Total?");
                hpmax = Convert.ToUInt32(Console.ReadLine());
                Console.WriteLine("Qual status? 1 - Vivo | 2 - Morto ");
                status = int.Parse(Console.ReadLine());

                switch (genero )
                {
                    case 1:
                        Brawler newbrawler = new Brawler (id= (Herois.Count+1), nome = nome, (TipoHeroi)(genero = genero), atk = atk, def = def, mag = mag, res = res, hp = hp, hpmax = hpmax, status = status);
                        Herois.Add(newbrawler);
                        break;
                   case 2:
                        Healer newhealer = new Healer(id = (Herois.Count + 1), nome = nome, (TipoHeroi)(genero = genero), atk = atk, def = def, mag = mag, res = res, hp = hp, hpmax = hpmax, status = status);
                        Herois.Add(newhealer);
                        break;
                    case 3:
                        Mage newmage = new Mage(id = (Herois.Count + 1), nome = nome, (TipoHeroi)(genero = genero), atk = atk, def = def, mag = mag, res = res, hp = hp, hpmax = hpmax, (Status)(status = status));
                        Herois.Add(newmage);
                        break;
                    case 4:
                        Warrior newwarrior = new Warrior(id = (Herois.Count + 1), nome = nome, (TipoHeroi)(genero = genero), atk = atk, def = def, mag = mag, res = res, hp = hp, hpmax = hpmax, status = status);
                        Herois.Add(newwarrior);
                        break;
                    
                }
                foreach (Heroi hero in Herois)
                {
                    Console.WriteLine(hero);
                }

            }


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jogo_rpg_c_.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string nameHero, string heroType, int level, int power, int defense) : base(nameHero, heroType, level, power, defense){}
        
        public override string Attack(){ 
        // O override significa que o filho sobreescreve o pai

            return this.nameHero + " Atacou com a sua espada";
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jogo_rpg_c_.src.Entities
{
    public class Devil: Hero
    {
        public Devil(string nameHero, string heroType, int level, int power, int defense) : base(nameHero, heroType, level, power, defense){}

        public override string Imprimir(){
            return $"Malvado {nameHero} - Forca de Ataque ({power}) - Defesa ({defense})";
        } 
    }
}
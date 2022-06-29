using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace jogo_rpg_c_.src.Entities
{
    public abstract class Hero 
    {
        
        public string nameHero;
        public int level;
        public string heroType;
        public int power;
        public int defense;

        public Hero(string nameHero, string heroType, int level, int power, int defense){
            this.nameHero = nameHero;
            this.heroType = heroType;
            this.level = level;
            this.power = power;
            this.defense = defense;
        }

        public int GetDefense(){
            return this.defense;
        }

        public int GetPower(){
            return this.power;
        }

        public void SetDefense(int defense){
            this.defense = defense;
        }
        public void SetPower(int power){
            this.power = power;
        }

        public override string ToString(){
            return nameHero + " " + heroType + " " + level;
        }

        public virtual string Attack(){ //O virtual permite que o metodo pai seja sobreescrito pelo filho
            return this.nameHero + " Atacou";
        }

        public virtual string Imprimir(){
            return $"Heroi {nameHero} - Forca de Ataque ({power}) - Defesa ({defense})";
        } 
       
    }
}
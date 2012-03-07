using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pokemon.ViewModel
{
    public class GeneratedViewModel
    {
        private int _generatedPokemonId;
        private int _lvl;
        private int _genAttackStat;
        private int _genDefenseStat;
        private int _genSpAttackStat;
        private int _genSpDefenseStat;
        private int _genSpeedStat;
        private string _nature;
        private string _characteristic;
        private int _firstEvolved;
        private int _secondEvolved;
        private bool _shined;
        private string _ability;
        private int currentExp;

        public int GeneratedPokemonId { get; set; }
        public int Lvl { get; set; }
        public int GenAttackStat { get; set; }
        public int GenDefenseStat { get; set; }
        public int GenSpAttackStat { get; set; }
        public int GenSpDefenseStat { get; set; }
        public int GenSpeedStat { get; set; }
        public string Nature { get; set; }
        public string Characteristic { get; set; }
        public int FirstEvolved { get; set; }
        public int SecondEvolved { get; set; }
        public bool Shined { get; set; }
        public string Ability { get; set; }
        public int CurrentExp { get; set; }
    }
}
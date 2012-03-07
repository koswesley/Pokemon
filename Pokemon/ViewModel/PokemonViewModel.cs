using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pokemon.Models;
using System.Reflection;

namespace Pokemon.ViewModel
{
    public class PokemonViewModel
    {
        private int _pokemonId;
        private string _name;
        private int evoLevel;
        private string _abilityOne;
        private string _abilityTwo;
        private string _abilityThee;
        private float _maleGenderPercent;
        private string _primaryType;
        private string _subType;
        private int _hpStat;
        private int attackStat;
        private int _defenseStat;
        private int _spAttackStat;
        private int _spDefenseStat;
        private int _speedStat;
        private int _levelSpeed;
        private int _baseExp;
        private int _baseCatch;

        public int PokemonId { get; set; }
        public string Name { get; set; }
        public int EvoLevel { get; set; }
        public string AbilityOne { get; set; }
        public string AbilityTwo { get; set; }
        public string AbilityThree { get; set; }
        public float MaleGenderPercent { get; set; }
        public string PrimaryType { get; set; }
        public string Subtype { get; set; }
        public int HPStat { get; set; }
        public int AttackStat { get; set; }
        public int DefenseStat { get; set; }
        public int SpAttackStat { get; set; }
        public int SpDefenseStat { get; set; }
        public int SpeedStat { get; set; }
        public int LevelSpeed { get; set; }
        public int BaseExp { get; set; }
        public int BaseCatch { get; set; }
    }
}
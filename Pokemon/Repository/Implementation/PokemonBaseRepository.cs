using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pokemon.Repository.Interface;
using Pokemon.Models;
using Pokemon.ViewModel;
using System.Data;

namespace Pokemon.Repository.Implementation
{
    public class PokemonBaseRepository : IPokemonBaseRepository
    {
        private PokemonDBEntities _dataContext = new PokemonDBEntities();
        public void UpdateBasePokemon(PokemonViewModel pkmnVM)
        {
                PokemonBase pkmn = _dataContext.PokemonBases.FirstOrDefault(x => x.PokemonId == pkmnVM.PokemonId);
            
                _dataContext.Attach(pkmn);

                pkmn.Name = pkmnVM.Name;
                pkmn.EvoLevel = pkmnVM.EvoLevel;
                pkmn.AbilityOne = pkmnVM.AbilityOne;
                pkmn.AbilityTwo = pkmnVM.AbilityTwo;
                pkmn.AbilityThree = pkmnVM.AbilityThree;
                pkmn.MaleGenderPercent = pkmnVM.MaleGenderPercent;
                pkmn.PrimaryType = pkmnVM.PrimaryType;
                pkmn.SubType = pkmnVM.Subtype;
                pkmn.HPStat = pkmnVM.HPStat;
                pkmn.AttackStat = pkmnVM.AttackStat;
                pkmn.DefenseStat = pkmnVM.DefenseStat;
                pkmn.SpAttackStat = pkmnVM.SpAttackStat;
                pkmn.SpDefenseStat = pkmnVM.SpDefenseStat;
                pkmn.SpeedStat = pkmnVM.SpeedStat;
                pkmn.LevelSpeed = pkmnVM.LevelSpeed;
                pkmn.BaseExp = pkmnVM.BaseExp;
                pkmn.BaseCatch = pkmnVM.BaseCatch;

                try
                {
                    _dataContext.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Could not save changes {0}", ex);
                }

        }

        public List<PokemonBase> GetBasePokemon()
        {
                return _dataContext.PokemonBases.ToList();
        }
    }
}
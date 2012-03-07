using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pokemon.ViewModel;
using Pokemon.Models;

namespace Pokemon.Repository.Interface
{
    interface IPokemonBaseRepository
    {
        List<PokemonBase> GetBasePokemon();
        void UpdateBasePokemon(PokemonViewModel pokemonViewModel);
    }
}

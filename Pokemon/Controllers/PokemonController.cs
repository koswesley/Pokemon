using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pokemon.Models;
using Pokemon.ViewModel;
using System.Web.UI;
using System.Web.Helpers;
using Pokemon.Repository.Implementation;

namespace Pokemon.Controllers
{
    public class PokemonController : Controller
    {
        private PokemonBaseRepository repo = new PokemonBaseRepository();
        //
        // GET: /Pokemon/

        public ViewResult BasePokemon()
        {
            return View(repo.GetBasePokemon());
        }


        public ViewResult GeneratePokemon()
        {
            GeneratedPokemon generatedPokemon = new GeneratedPokemon();
            return View(generatedPokemon);
        }

        [HttpPost]
        public void CreatePokemon(GeneratedPokemon generatedPokemon)
        {
            var i = 0;
            ++i;
        }

        [HttpPost]
        public ActionResult SaveBasePokemon(PokemonViewModel pokemonViewModel)
        {
            try
            {
                repo.UpdateBasePokemon(pokemonViewModel);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
            }
            return null;
        }
    }
}
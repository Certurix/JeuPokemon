using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuPokemon
{
    internal class Joueur
    {
        // Attributs
        private string nom;
        private int mancheGagnee;
        private float argent;
        private List<Pokemon> pokemons;

        // Accesseurs
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        public int MancheGagnee
        {
            get { return mancheGagnee; }
            set { mancheGagnee = value; }
        }

        public float Argent
        {
            get { return argent; }
            set { argent = value; }
        }
 
        public List<string> Pokemons
            { get { return pokemons; } }

        public Joueur(string nom, int mancheGagnee, float argent)
        {
            this.nom = nom;
            this.mancheGagnee = mancheGagnee;
            this.argent = argent;
            this.pokemons = new List<string>();
        }

        public void ChoisirPokemon() { }

        public void AjouterPokemon() { }

        public Attaque ChoisirAttaque(Pokemon pokemon) { }

        public Pokemon RecupererPokemon(int pokemonId) { }

        public void AfficherPokemons() { }

        public void Afficher() { }

    }
}

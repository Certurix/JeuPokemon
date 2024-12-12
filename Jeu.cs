using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuPokemon
{
    internal class Jeu
    {
        private List<String> joueurs = new List<String>();

        public void Jouer()
        {
            joueurs.Clear();

            // Démarrage du jeu
            Console.WriteLine("Joueur 1, saisissez votre nom");
        }
    }
}

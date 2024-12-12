using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuPokemon
{
    internal class Attaque
    {
        private string nom;
        private string type;
        private string categorieAttaque;
        private float precision;
        private int puissance;
        private int pp;

        public Attaque(string nom, string type, string categorieAttaque, float precision, int puissance, int pp)
        {
            this.nom = nom;
            this.type = type;
            this.categorieAttaque = categorieAttaque;
            this.precision = precision;
            this.puissance = puissance;
            this.pp = pp;
        }
    }
}

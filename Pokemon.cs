using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuPokemon
{
    internal class Pokemon
    {
        private string nom;
        private int prix;
        private string[] types;
        private int pointsDeVie;
        private int niveau;
        private int attaque;
        private int attaqueSpeciale;
        private int defense;
        private int defenseSpeciale;
        private int vitesse;
        private List<Attaque> attaques;

        public string Nom { get => nom; set => nom = value; }
        public int Prix { get => prix; set => prix = value; }
        public string[] Types { get => types; set => types = value; }
        public int PointsDeVie { get => pointsDeVie; set => pointsDeVie = value; }
        public int Niveau { get => niveau; set => niveau = value; }
        public int Attaque { get => attaque; set => attaque = value; }
        public int AttaqueSpeciale { get => attaqueSpeciale; set => attaqueSpeciale = value; }
        public int Defense { get => defense; set => defense = value; }
        public int DefenseSpeciale { get => defenseSpeciale; set => defenseSpeciale = value; }
        public int Vitesse { get => vitesse; set => vitesse = value; }

        public Pokemon(string nom, int prix, string[] types, int pointsDeVie, int niveau, int attaque, int attaqueSpeciale, int defense, int defenseSpeciale, int vitesse)
        {
            this.nom = nom;
            this.prix = prix;
            this.types = types;
            this.pointsDeVie = pointsDeVie;
            this.niveau = niveau;
            this.attaque = attaque;
            this.attaqueSpeciale = attaqueSpeciale;
            this.defense = defense;
            this.defenseSpeciale = defenseSpeciale;
            this.vitesse = vitesse;
            this.attaques = new List<Attaque>();
        }

        public void AjouterAttaque(Attaque attaque) { }

        public void Attaquer(Pokemon pokemon, Attaque attaque) { }

        public bool EstKO() { }

        public string AfficherAttaques() { }

        public string Afficher() { }
    }
}

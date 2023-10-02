using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursHeritage
{
    class Vehicule
    {
        private string immatriculation;
        private string couleur;
        protected float poids;
        protected int vitesseMaxAutoroute;
        protected int vitesseActuelle;

        public Vehicule(string immat, string couleur, float poids)
        {
            this.immatriculation = immat;
            this.couleur = couleur;
            this.poids = poids;
            this.vitesseMaxAutoroute = 80;
            this.vitesseActuelle = 0;
        }

        public virtual void AfficheToi()
        {
            Console.WriteLine("Je suis un véhicule d'immatriculation : " + immatriculation);
            Console.WriteLine("Couleur : " + couleur);
            Console.WriteLine("Poids : " + poids + " kg");
            Console.WriteLine("Vitesse Maximale sur l'autoroute : " + vitesseMaxAutoroute + " km/h");
            Console.WriteLine("Vitesse Actuelle : " + vitesseActuelle + " km/h");
        }

        public override string ToString()
        {
            return "Immatriculation : " + immatriculation + "\nCouleur : " + couleur + "\nPoids : " + poids;
        }

        public virtual void Accelerer()
        {
            vitesseActuelle += 10;
        }
    }

}

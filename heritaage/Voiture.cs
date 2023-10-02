using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursHeritage
{
    class Voiture : Vehicule
    {
        private int nbPassagers;

        public Voiture(string immat, string couleur, float poids, int passagers)
            : base(immat, couleur, poids)
        {
            nbPassagers = passagers;
            vitesseMaxAutoroute = 130;
        }

        public override void AfficheToi()
        {
            base.AfficheToi();
            Console.WriteLine("Je suis une voiture.");
            Console.WriteLine("Nombre de passagers : " + nbPassagers);
        }
    }
}

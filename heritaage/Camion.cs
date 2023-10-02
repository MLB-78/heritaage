using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursHeritage
{
    class Camion : Vehicule
    {
        private int nbRoues;
        
        public Camion(string immat, string couleur, float poids, int roues)
            : base(immat, couleur, poids)
        {
            nbRoues = roues;
            vitesseMaxAutoroute = 90;
        }

        public override void AfficheToi()
        {
            base.AfficheToi();
            Console.WriteLine("Je suis un camion.");
            Console.WriteLine("Nombre de roues : " + nbRoues);
        }
    }

    class Autobus : Vehicule
    {
        private string type;

        public Autobus(string immat, string couleur, float poids, string type)
            : base(immat, couleur, poids)
        {
            this.type = type;
        }

        public override void AfficheToi()
        {
            base.AfficheToi();
            Console.WriteLine("Je suis un autobus de type : " + type);
        }

        public override void Accelerer()
        {
            vitesseActuelle += 5;
        }
    }

    class DeuxRoues : Vehicule
    {
        public DeuxRoues(string immat, string couleur, float poids, string type)
            : base(immat, couleur, poids)
        {
        }

        public override void Accelerer()
        {
            vitesseActuelle += 15;
        }


        public override void AfficheToi()
        {
            base.AfficheToi();
            Console.WriteLine("Je suis un 2 roues.");
        }

        public override string ToString()
        {
            return base.ToString() + "\nJe suis un 2 roues.";
        }
    }

    class Moto : DeuxRoues
    {
        public Moto(string immat, string couleur, float poids, string type)
            : base(immat, couleur, poids, type)
        {
        }

        public override void AfficheToi()
        {
            base.AfficheToi();
            Console.WriteLine("Je suis une moto et l'on a besoin d'un permis pour me conduire.");
        }
    }

    class Velo : DeuxRoues
    {
        public Velo(string immat, string couleur, float poids, string type)
            : base(immat, couleur, poids, type)
        {
        }

        public override void AfficheToi()
        {
            base.AfficheToi();
            Console.WriteLine("Je suis un vélo et on n'a pas besoin de permis pour m'utiliser.");
        }
    }
}


using CoursHeritage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heritaage
{
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
}



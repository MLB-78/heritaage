using CoursHeritage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heritaage
{
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

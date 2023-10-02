using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoursHeritage
{
    class Program
    {
        static void Main(string[] args)
        {
            // Création d'objets de différents types de véhicules
            Vehicule vehicule = new Vehicule("502 HG 80", "Orange", 1800);
            Voiture voiture = new Voiture("5507 VG 22", "Noire", 1100, 5);
            Camion camion = new Camion("2541 BH 78", "Bleu", 3500, 6);
            Autobus autobusA = new Autobus("123 AB 45", "Rouge", 5000, "A");
            Autobus autobusB = new Autobus("789 CD 67", "Vert", 4000, "B");
            DeuxRoues moto = new Moto("ABC 123", "Noire", 200, "Moto");
            DeuxRoues velo = new Velo("XYZ 987", "Rouge", 15, "Velo");

            // Accélérer les véhicules
            vehicule.Accelerer();
            voiture.Accelerer();
            camion.Accelerer();
            autobusA.Accelerer();
            autobusB.Accelerer();
            moto.Accelerer();
            velo.Accelerer();

            // Création d'une liste de véhicules
            List<Vehicule> lesVehicules = new List<Vehicule>
            {
                vehicule,
                voiture,
                camion,
                autobusA,
                autobusB,
                moto,
                velo
            };

            Console.WriteLine("\n---------affichage véhicules--------\n");

            foreach (Vehicule v in lesVehicules)
            {
                v.AfficheToi();
                Console.WriteLine("--------------------------");
            }

            Console.ReadKey();
        }
    }
}

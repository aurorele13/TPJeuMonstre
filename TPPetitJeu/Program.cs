using System;

namespace TPPetitJeu
{
    class Program
    {
        static void Main(string[] args)
        {
            Joueur joueur = new Joueur();
            MonstreFacile monstre = new MonstreFacile();
            MonstreDifficile monstreDiff = new MonstreDifficile();
            Random random = new Random();

            while (joueur.StatusAlive)
            { 
            int tirageMonstre = random.Next(1, 3);

            if (tirageMonstre == 2)
                monstre = monstreDiff;

            int déJoueur = De.LancerLeDe();
            int déMonstre = De.LancerLeDe();
            
            if (déJoueur>=déMonstre)
            joueur.Attaquer(monstre);
            else
            monstre.Attaquer(joueur);
            
           
            }
            Console.WriteLine($" Snif, vous êtes mort...\n Bravo!! Vous avez tué {joueur.NbFacile} monstres faciles et {joueur.NbDiff} monstres difficiles." +
               $"Vous avez donc obtenu {joueur.Points} points.");
            Console.ReadKey();


        }
    }
}

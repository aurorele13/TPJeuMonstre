using System;
using System.Collections.Generic;
using System.Text;

namespace TPPetitJeu
{
    class MonstreFacile
    {
        public bool StatusAlive { get;}

        public virtual void Attaquer(Joueur joueur)
        {
            int déJoueur = De.LancerLeDe();
            if (déJoueur > 2)
                joueur.SubirDegats(10);
        }
    }
}

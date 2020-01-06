using System;
using System.Collections.Generic;
using System.Text;

namespace TPPetitJeu
{
    class MonstreDifficile:MonstreFacile
    {
      public override void Attaquer(Joueur joueur)
        {
            base.Attaquer(joueur);
            int déMonstreDiff = De.LancerLeDe();
            if (déMonstreDiff != 6)
                joueur.SubirDegats(déMonstreDiff * 5);
        }
    }
}

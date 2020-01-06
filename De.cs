using System;
using System.Collections.Generic;
using System.Text;

namespace TPPetitJeu
{
    class De
    {
        public static int LancerLeDe()
        {
            
            Random random = new Random();
            int valeurDe = random.Next(1, 7);

            return valeurDe;
        }
    }
}

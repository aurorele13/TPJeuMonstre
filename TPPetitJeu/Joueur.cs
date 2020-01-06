using System;
using System.Collections.Generic;
using System.Text;

namespace TPPetitJeu
{
    class Joueur
    {
        private int _points;
        private int _pv;
        private int _nbMonstreDiff;
        private int _nbMonstreFacile;

        public int NbDiff
        {
            get { return _nbMonstreDiff; }
        }


        public int NbFacile { get { return _nbMonstreFacile; } }


        public int PV { get { return _pv; } }
        public bool StatusAlive
        {
            get
            {
                if (PV > 0)
                    return true;
                else
                    return false;
            }
        }
        public int Points
        {
            get { return _points; }
        }
        public Joueur()
        {
            _pv = 150;
            _points = 0;
            _nbMonstreDiff = 0;
            _nbMonstreFacile = 0;
        }
        public void Attaquer(MonstreFacile monstre)
        {

            if (monstre is MonstreDifficile)
            {
                _points += 2;
                _nbMonstreDiff++;
            }
            else
            {
                _points++;
                _nbMonstreFacile++;
            }
        }


        public void SubirDegats(int dégatsSubis)
        {
            _pv = _pv - dégatsSubis;
        }
    }
}

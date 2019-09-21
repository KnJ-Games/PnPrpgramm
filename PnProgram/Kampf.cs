using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PnProgram
{
    public class Kampf
    {
        private Spiel spiel;

        private Kampfvorbereitung KAMPFVORBEREITUNG;

        private List<Gegner> gegnerListe;

        public Kampf(Spiel Spiel, Kampfvorbereitung kampfvorbereitung)
        {
            spiel = Spiel;

            KAMPFVORBEREITUNG = kampfvorbereitung;

            gegnerListe = new List<Gegner>();

        }

        public void GegnerHinzufügen()
        {
            gegnerListe.Add(new Gegner(this, gegnerListe.Count));
            KAMPFVORBEREITUNG.GegnerKarteAnzeigen(gegnerListe[gegnerListe.Count - 1].GetGegnerKarte());
        }

        public List<Gegner> GetGegnerListe()
        {
            return gegnerListe;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PnProgram
{
    public class Spiel
    {
        private Start START;

        private List<Spieler> spielerListe;

        public Spiel(Start start)
        {
            START = start;
            spielerListe = new List<Spieler>();
        }

        public void SpielerHinzufügen()
        {
            spielerListe.Add(new Spieler(this, spielerListe.Count));
            START.SpielerKarteAnzeigen(spielerListe[spielerListe.Count - 1].getSpielerKarte());
        }



        public List<Spieler> GetSpielerListe()
        {
            return spielerListe;
        }

        public void setSpielerListe(List<Spieler> spielerListe)
        {
            this.spielerListe = spielerListe;
        }
    }
}

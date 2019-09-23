using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PnProgram
{
    public partial class Kampfvorbereitung : Form
    {

        Kampf Kampf;

        public Kampfvorbereitung(Spiel spiel)
        {
            InitializeComponent();
            Kampf = new Kampf(spiel, this);
        }

        private void Button_GegnerHinzufügen_Click(object sender, EventArgs e)
        {
            Kampf.GegnerHinzufügen();
            GegnerKartenPositionieren();
        }

        public void GegnerKarteAnzeigen(GegnerKarte gegnerKarte)
        {
            this.Controls.Add(gegnerKarte);
        }

        private void GegnerKartenPositionieren()
        {
            int YOFFSET = 80;

            int platzFürLinks = 0;
            int yZähler = 30;
            while (true)
            {
                if ((yZähler + YOFFSET) < this.Height)
                {
                    yZähler += YOFFSET;
                    platzFürLinks++;
                }
                else
                {
                    break;
                }
            }

            int X;
            int Y;
            int anzahlLinks = 0;
            int anzahlRechts = 0;
            for (int i = 1; i < Kampf.GetGegnerListe().Count + 1; i++)
            {
                Boolean hatPlatz = i <= platzFürLinks;
                if (hatPlatz)
                {
                    X = 10;
                    Y = (i - 1) * YOFFSET;
                    anzahlLinks++;
                }
                else
                {
                    X = 540;
                    Y = ((i - 1) - platzFürLinks) * YOFFSET;
                    anzahlRechts++;
                }
                Kampf.GetGegnerListe()[i - 1].GetGegnerKarte().Location = new Point(X, Y);
            }

            Buttons_SetLocation(platzFürLinks, anzahlLinks, anzahlRechts);
        }

        private void Buttons_SetLocation(int platzFürLinks, int anzahlLinks, int anzahlRechts)
        {

            int YOFFSET = 80;
            int X;
            int Y;
            if (platzFürLinks > anzahlLinks)
            {
                X = 10;
                Y = Kampf.GetGegnerListe().Count * YOFFSET + 10;
            }
            else
            {
                X = 540;
                Y = anzahlRechts * YOFFSET + 10;
            }
            button_GegnerHinzufügen.Location = new Point(X, Y);
            button_KampfStarten.Location = new Point(X + 145, Y);
        }

        private void Button_KampfStarten_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Start : Form
    {

        public Spiel Spiel;
        public Start()
        {
            InitializeComponent();
            Spiel = new Spiel(this);

        }

        public void SpielerKarteAnzeigen(SpielerKarte spielerKarte)
        {
            this.Controls.Add(spielerKarte);
        }

        private void Button_SpielerHinzufügen_Click(object sender, EventArgs e)
        {
            Spiel.SpielerHinzufügen();
            SpielerKartenPositionieren();
        }

        private void Button_KampfBeginnen_Click(object sender, EventArgs e)
        {
            if (Spiel.GetSpielerListe().Count > 0)
            {
                Kampfvorbereitung kampfvorbereitung = new Kampfvorbereitung(Spiel);
                kampfvorbereitung.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bitte fügen sie mindestens einen Spieler hinzu.");
            }

        }

        private void SpielerKartenPositionieren()
        {
            int platzFürLinks = 0;
            int yZähler = 30;
            while (true)
            {
                if ((yZähler + 160) < this.Height)
                {
                    yZähler += 160;
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
            for (int i = 1; i < Spiel.GetSpielerListe().Count + 1; i++)
            {
                Boolean hatPlatz = i <= platzFürLinks;
                if (hatPlatz)
                {
                    X = 10;
                    Y = (i - 1) * 160;
                    anzahlLinks++;
                } else
                {
                    X = 540;
                    Y = ((i - 1) - platzFürLinks) * 160;
                    anzahlRechts++;
                }
                Spiel.GetSpielerListe()[i - 1].getSpielerKarte().Location = new Point(X, Y);
            }

            Buttons_SetLocation(platzFürLinks, anzahlLinks, anzahlRechts);
        }

        private void Buttons_SetLocation(int platzFürLinks, int anzahlLinks, int anzahlRechts)
        {
            int X;
            int Y;
            if (platzFürLinks > anzahlLinks)
            {
                X = 10;
                Y = Spiel.GetSpielerListe().Count * 160 + 10;
            }
            else
            {
                X = 540;
                Y = anzahlRechts * 160 + 10;
            }
            button_SpielerHinzufügen.Location = new Point(X, Y);
            button_KampfBeginnen.Location = new Point(X + 145, Y);
        }

        public Spiel getSpiel()
        {
            return Spiel;
        }

        public void setSpiel(Spiel spiel)
        {
            Spiel = spiel;
        }

        private void Start_Resize(object sender, EventArgs e)
        {
            SpielerKartenPositionieren();
        }

        private void Start_Load(object sender, EventArgs e)
        {

        }
    }
}

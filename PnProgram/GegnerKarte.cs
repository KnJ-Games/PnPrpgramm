using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PnProgram
{
    public class GegnerKarte : System.Windows.Forms.GroupBox
    {

        private int BREITE = 520;
        private int HÖHE = 70;

        private int STANDARTYOFFSET = 10;
        private int YOFFSET = 70;

        private int GEGNERNUMMER;

        Kampf KAMPF;

        System.Windows.Forms.Label label_name = FormService.LabelErstellen(10, 10, "Name:");
        System.Windows.Forms.TextBox textBox_Spielername = FormService.TextBoxErstellen(60, 10, 100);

        System.Windows.Forms.Label label_Leben = FormService.LabelErstellen(170, 10, "Leben:");
        System.Windows.Forms.NumericUpDown numericUpDown_Leben = FormService.NumericUpDownErstellen(220, 10, 30, 0, 100, 1);
        System.Windows.Forms.Label label_von_Leben = FormService.LabelErstellen(260, 10, "von");
        System.Windows.Forms.TextBox textBox_MaxLeben = FormService.TextBoxErstellen(290, 10, 30);

        System.Windows.Forms.Label label_Ausdauer = FormService.LabelErstellen(350, 10, "Ausdauer:");
        System.Windows.Forms.NumericUpDown numericUpDown_Ausdauer = FormService.NumericUpDownErstellen(410, 10, 30, 0, 100, 1);
        System.Windows.Forms.Label label_von_Ausdauer = FormService.LabelErstellen(450, 10, "von");
        System.Windows.Forms.TextBox textBox_MaxAusdauer = FormService.TextBoxErstellen(480, 10, 30);

        System.Windows.Forms.Label label_Angriff = FormService.LabelErstellen(10, 40, "Angriff:");
        System.Windows.Forms.NumericUpDown numericUpDown_Angriff = FormService.NumericUpDownErstellen(50, 40, 40, 1, 100, 1);

        System.Windows.Forms.Label label_Astralenergie = FormService.LabelErstellen(120, 40, "Astralenergie:");
        System.Windows.Forms.NumericUpDown numericUpDown_Astralenergie = FormService.NumericUpDownErstellen(190, 40, 40, 1, 100, 1);

        public GegnerKarte(int gegnernummer, Kampf kampf)
        {
            this.Location = new System.Drawing.Point(10, STANDARTYOFFSET + gegnernummer * YOFFSET);

            KAMPF = kampf;

            GEGNERNUMMER = gegnernummer;

            InitializeComponent();
        }

        private void InitializeComponent()
        {
            Groesse_Festlegen(BREITE, HÖHE);

            AddControlls();

            AddEventHandler();
        }

        private void Groesse_Festlegen(int breite, int höhe)
        {
            this.Width = breite;
            this.Height = höhe;
        }

        private void AddControlls()
        {
            this.Controls.Add(textBox_MaxAusdauer);
            this.Controls.Add(numericUpDown_Ausdauer);
            this.Controls.Add(label_Ausdauer);
            this.Controls.Add(label_von_Ausdauer);

            this.Controls.Add(textBox_MaxLeben);

            this.Controls.Add(textBox_Spielername);
            this.Controls.Add(label_name);
            this.Controls.Add(label_von_Leben);
            this.Controls.Add(numericUpDown_Leben);
            this.Controls.Add(label_Leben);

            this.Controls.Add(numericUpDown_Astralenergie);
            this.Controls.Add(label_Astralenergie);

            this.Controls.Add(numericUpDown_Angriff);
            this.Controls.Add(label_Angriff);
        }

        private void AddEventHandler()
        {
            this.textBox_Spielername.TextChanged += new EventHandler(this.GegnerAktualisieren);
            this.textBox_MaxLeben.TextChanged += new EventHandler(this.GegnerAktualisieren);
            this.textBox_MaxAusdauer.TextChanged += new EventHandler(this.GegnerAktualisieren);

            this.numericUpDown_Leben.ValueChanged += new EventHandler(this.GegnerAktualisieren);
            this.numericUpDown_Ausdauer.ValueChanged += new EventHandler(this.GegnerAktualisieren);
            this.numericUpDown_Angriff.ValueChanged += new EventHandler(this.GegnerAktualisieren);
            this.numericUpDown_Astralenergie.ValueChanged += new EventHandler(this.GegnerAktualisieren);
        }

        private void GegnerAktualisieren(object sender, System.EventArgs e)
        {
            KAMPF.GetGegnerListe()[GEGNERNUMMER].setName(this.textBox_Spielername.Text);
            KAMPF.GetGegnerListe()[GEGNERNUMMER].setAktLebel(Convert.ToInt32(this.numericUpDown_Leben.Value));
            KAMPF.GetGegnerListe()[GEGNERNUMMER].setAusdauer(Convert.ToInt32(this.numericUpDown_Ausdauer.Value));
            KAMPF.GetGegnerListe()[GEGNERNUMMER].setAngriffswert(Convert.ToInt32(this.numericUpDown_Angriff.Value));
        }

        public int GetGEGNERNUMMER()
        {
            return GEGNERNUMMER;
        }

        public int getSTANDARTYOFFSET()
        {
            return STANDARTYOFFSET;
        }

        public void setSTANDARTYOFFSET(int STANDARTYOFFSET)
        {
            this.STANDARTYOFFSET = STANDARTYOFFSET;
        }

        public int getYOFFSET()
        {
            return YOFFSET;
        }

        public void setYOFFSET(int YOFFSET)
        {
            this.YOFFSET = YOFFSET;
        }
    }
}

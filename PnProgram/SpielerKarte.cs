using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PnProgram
{
    public class SpielerKarte : System.Windows.Forms.GroupBox
    {

        private int BREITE = 520;
        private int HÖHE = 150;


        private int STANDARTYOFFSET = 10;
        private int YOFFSET = 150;

        private int SPIELERNUMMER;

        Spieler SPIELER;

        System.Windows.Forms.Label label_name = FormService.LabelErstellen(10, 10, "Name:");
        System.Windows.Forms.TextBox textBox_Spielername = FormService.TextBoxErstellen(60, 10, 100);

        System.Windows.Forms.Label label_Leben = FormService.LabelErstellen(170, 10, "Leben:");
        System.Windows.Forms.NumericUpDown numericUpDown_Leben = FormService.NumericUpDownErstellen(220, 10, 40, 0, 100, 10);
        System.Windows.Forms.Label label_von_Leben = FormService.LabelErstellen(260, 10, "von");
        System.Windows.Forms.NumericUpDown textBox_MaxLeben = FormService.NumericUpDownErstellen(290, 10, 40, 1, 100, 10);

        System.Windows.Forms.Label label_Ausdauer = FormService.LabelErstellen(350, 10, "Ausdauer:");
        System.Windows.Forms.NumericUpDown numericUpDown_Ausdauer = FormService.NumericUpDownErstellen(410, 10, 40, 0, 100, 10);
        System.Windows.Forms.Label label_von_Ausdauer = FormService.LabelErstellen(450, 10, "von");
        System.Windows.Forms.NumericUpDown textBox_MaxAusdauer = FormService.NumericUpDownErstellen(480, 10, 40, 1, 100, 10);

        System.Windows.Forms.Label label_Angriff = FormService.LabelErstellen(10, 40, "Angriff:");
        System.Windows.Forms.NumericUpDown numericUpDown_Angriff = FormService.NumericUpDownErstellen(50, 40, 40, 1, 100, 1);

        System.Windows.Forms.Label label_Astralenergie = FormService.LabelErstellen(120, 40, "Astralenergie:");
        System.Windows.Forms.NumericUpDown numericUpDown_Astralenergie = FormService.NumericUpDownErstellen(190, 40, 40, 1, 100, 1);

        System.Windows.Forms.Label label_Bronze = FormService.LabelErstellen(10, 70, "Bronze");
        System.Windows.Forms.Label label_Silber = FormService.LabelErstellen(60, 70, "Silber");
        System.Windows.Forms.Label label_Gold = FormService.LabelErstellen(110, 70, "Gold");
        System.Windows.Forms.Label label_Diamenten = FormService.LabelErstellen(200, 70, "Diamanten");
        System.Windows.Forms.Label label_Inventarplatz = FormService.LabelErstellen(280, 70, "Inventarplatz");

        System.Windows.Forms.NumericUpDown numericUpDown_Bronze = FormService.NumericUpDownErstellen(10, 100, 40, 0, 100, 0);
        System.Windows.Forms.NumericUpDown numericUpDown_Silber = FormService.NumericUpDownErstellen(60, 100, 40, 0, 100, 0);
        System.Windows.Forms.NumericUpDown numericUpDown_Gold = FormService.NumericUpDownErstellen(110, 100, 40, 0, 100, 0);
        System.Windows.Forms.NumericUpDown numericUpDown_Diamanten = FormService.NumericUpDownErstellen(200, 100, 40, 0, 1000, 0);
        System.Windows.Forms.NumericUpDown numericUpDown_Inventarplatz = FormService.NumericUpDownErstellen(280, 100, 40, 0, 100, 0);

        System.Windows.Forms.Button button_statuseffekte = FormService.ButtonErstellen(360, 50, 140, "Statuseffekte");
        System.Windows.Forms.CheckedListBox checkedListBox_Statuseffekte = FormService.CheckedListBoxErstellen(360, 80, 140, 70);

        public SpielerKarte(int spielernummer, Spieler spieler)
        {
            this.Location = new System.Drawing.Point(10, STANDARTYOFFSET + spielernummer * YOFFSET);

            SPIELER = spieler;

            SPIELERNUMMER = spielernummer;

            Groesse_Festlegen(BREITE, HÖHE);

            AddControlls();

            AddEventHandler();

            StatuseffekteAktualisieren();
        }

        private void Groesse_Festlegen(int breite, int höhe)
        {
            this.Width = breite;
            this.Height = höhe;
        }
        

        private void AddControlls()
        {
            this.Controls.Add(button_statuseffekte);
            this.Controls.Add(checkedListBox_Statuseffekte);


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

            this.Controls.Add(label_Inventarplatz);
            this.Controls.Add(label_Diamenten);
            this.Controls.Add(label_Gold);
            this.Controls.Add(label_Silber);
            this.Controls.Add(label_Bronze);

            this.Controls.Add(numericUpDown_Inventarplatz);
            this.Controls.Add(numericUpDown_Diamanten);
            this.Controls.Add(numericUpDown_Gold);
            this.Controls.Add(numericUpDown_Silber);
            this.Controls.Add(numericUpDown_Bronze);   
        }

        private void AddEventHandler()
        {
            this.textBox_Spielername.TextChanged += new EventHandler(this.SpielerAktualisieren);
            this.textBox_MaxLeben.TextChanged += new EventHandler(this.SpielerAktualisieren);
            this.textBox_MaxAusdauer.TextChanged += new EventHandler(this.SpielerAktualisieren);

            this.numericUpDown_Leben.ValueChanged += new EventHandler(this.SpielerAktualisieren);
            this.numericUpDown_Ausdauer.ValueChanged += new EventHandler(this.SpielerAktualisieren);
            this.numericUpDown_Angriff.ValueChanged += new EventHandler(this.SpielerAktualisieren);
            this.numericUpDown_Astralenergie.ValueChanged += new EventHandler(this.SpielerAktualisieren);
            this.numericUpDown_Bronze.ValueChanged += new EventHandler(this.SpielerAktualisieren);
            this.numericUpDown_Silber.ValueChanged += new EventHandler(this.SpielerAktualisieren);
            this.numericUpDown_Gold.ValueChanged += new EventHandler(this.SpielerAktualisieren);
            this.numericUpDown_Diamanten.ValueChanged += new EventHandler(this.SpielerAktualisieren);
            this.numericUpDown_Inventarplatz.ValueChanged += new EventHandler(this.SpielerAktualisieren);

            this.button_statuseffekte.Click += new EventHandler(Button_Statuseffekte_Click);
        }

        public void StatuseffekteAktualisieren()
        {
            foreach (Statuseffekt statuseffekt in SPIELER.getStatuseffekte())
            {
                if (statuseffekt.getWIRDANGEZEIGT())
                {
                    this.checkedListBox_Statuseffekte.Items.Add(statuseffekt.getBEZEICHNUNG(), statuseffekt.getSTATUS());
                }  
            } 
        }

        private void Button_Statuseffekte_Click(object sender, System.EventArgs e)
        {
            Form_Statuseffekte form_Statuseffekte = new Form_Statuseffekte(SPIELER);
            form_Statuseffekte.ShowDialog();
        }

        private void SpielerAktualisieren(object sender, System.EventArgs e)
        {
            SPIELER.setName(this.textBox_Spielername.Text);
            SPIELER.setAktLebel(Convert.ToInt32(this.numericUpDown_Leben.Value));
            SPIELER.setAusdauer(Convert.ToInt32(this.numericUpDown_Ausdauer.Value));
            SPIELER.setAngriffswert(Convert.ToInt32(this.numericUpDown_Angriff.Value));
            SPIELER.setBronze(Convert.ToInt32(this.numericUpDown_Bronze.Value));
            SPIELER.setSilber(Convert.ToInt32(this.numericUpDown_Silber.Value));
            SPIELER.setGold(Convert.ToInt32(this.numericUpDown_Gold.Value));
            SPIELER.setDiamanten(Convert.ToInt32(this.numericUpDown_Diamanten.Value));
            SPIELER.setInventarplatz(Convert.ToInt32(this.numericUpDown_Diamanten.Value));
        }

        public int GetSPIELERNUMMER()
        {
            return SPIELERNUMMER;
        }


    }
}

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
    public partial class Form_Statuseffekte : Form
    {
        Spieler SPIELER;
        public Form_Statuseffekte(Spieler spieler)
        {
            SPIELER = spieler;

            InitializeComponent();

            ListenFüllen();

        }

        private void ListenFüllen()
        {
            CheckedListBox_AngezeigtFüllen();
            CheckedListBox_StatusFüllen();
        }

        private void CheckedListBox_AngezeigtFüllen()
        {
            foreach (Statuseffekt statuseffekt in SPIELER.getStatuseffekte())
            {
                checkedListBox_Angezeigt.Items.Add(statuseffekt.getBEZEICHNUNG(), statuseffekt.getWIRDANGEZEIGT());
            }
        }

        private void CheckedListBox_StatusFüllen()
        {
            foreach (Statuseffekt statuseffekt in SPIELER.getStatuseffekte())
            {
                checkedListBox_Status.Items.Add(statuseffekt.getBEZEICHNUNG(), statuseffekt.getSTATUS());
            }
        }

        private void Button_AnwendenUndSchließen_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < checkedListBox_Angezeigt.Items.Count; i++)
            {
                if (checkedListBox_Angezeigt.GetItemChecked(i))
                {
                }
            }
        }
    }
}

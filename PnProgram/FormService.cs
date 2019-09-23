using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PnProgram
{
    public static class FormService
    {
        public static System.Windows.Forms.TextBox TextBoxErstellen(int posX, int posY, int breite)
        {
            System.Windows.Forms.TextBox textBox = new System.Windows.Forms.TextBox();

            textBox.Location = new System.Drawing.Point(posX, posY);
            textBox.Width = breite;

            return textBox;
        }

        public static System.Windows.Forms.Label LabelErstellen(int posX, int posY, String text)
        {
            System.Windows.Forms.Label label = new System.Windows.Forms.Label();

            label.Location = new System.Drawing.Point(posX, posY);
            label.Text = text;

            return label;
        }

        public static System.Windows.Forms.Button ButtonErstellen(int posX, int posY, int breite, String text)
        {
            System.Windows.Forms.Button button = new System.Windows.Forms.Button();

            button.Location = new System.Drawing.Point(posX, posY);
            button.Text = text;
            button.Width = breite;

            return button;
        }
        public static System.Windows.Forms.NumericUpDown NumericUpDownErstellen(int posX, int posY, int breite, int min, int max, int start)
        {
            System.Windows.Forms.NumericUpDown numericUpDown = new System.Windows.Forms.NumericUpDown();

            numericUpDown.Location = new System.Drawing.Point(posX, posY);
            numericUpDown.Width = breite;
            numericUpDown.Minimum = min;
            numericUpDown.Maximum = max;
            numericUpDown.Value = start;

            return numericUpDown;
        }

        public static System.Windows.Forms.CheckedListBox CheckedListBoxErstellen(int posX, int posY, int breite, int höhe)
        {
            System.Windows.Forms.CheckedListBox checkedlistbox = new System.Windows.Forms.CheckedListBox();

            checkedlistbox.Location = new System.Drawing.Point(posX, posY);
            checkedlistbox.Width = breite;
            checkedlistbox.Height = höhe;

            return checkedlistbox;
        }
    }


}

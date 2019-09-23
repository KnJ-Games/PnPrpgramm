namespace PnProgram
{
    partial class Kampfvorbereitung
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_KampfStarten = new System.Windows.Forms.Button();
            this.button_GegnerHinzufügen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_KampfStarten
            // 
            this.button_KampfStarten.Location = new System.Drawing.Point(157, 12);
            this.button_KampfStarten.Name = "button_KampfStarten";
            this.button_KampfStarten.Size = new System.Drawing.Size(139, 23);
            this.button_KampfStarten.TabIndex = 3;
            this.button_KampfStarten.Text = "Kampf starten";
            this.button_KampfStarten.UseVisualStyleBackColor = true;
            this.button_KampfStarten.Click += new System.EventHandler(this.Button_KampfStarten_Click);
            // 
            // button_GegnerHinzufügen
            // 
            this.button_GegnerHinzufügen.Location = new System.Drawing.Point(12, 12);
            this.button_GegnerHinzufügen.Name = "button_GegnerHinzufügen";
            this.button_GegnerHinzufügen.Size = new System.Drawing.Size(139, 23);
            this.button_GegnerHinzufügen.TabIndex = 2;
            this.button_GegnerHinzufügen.Text = "Gegner hinzufügen";
            this.button_GegnerHinzufügen.UseVisualStyleBackColor = true;
            this.button_GegnerHinzufügen.Click += new System.EventHandler(this.Button_GegnerHinzufügen_Click);
            // 
            // Kampfvorbereitung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 661);
            this.Controls.Add(this.button_KampfStarten);
            this.Controls.Add(this.button_GegnerHinzufügen);
            this.Name = "Kampfvorbereitung";
            this.Text = "Kampfvorbereitung";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_KampfStarten;
        private System.Windows.Forms.Button button_GegnerHinzufügen;
    }
}
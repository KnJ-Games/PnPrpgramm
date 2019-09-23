namespace PnProgram
{
    partial class Start
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_SpielerHinzufügen = new System.Windows.Forms.Button();
            this.button_KampfBeginnen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_SpielerHinzufügen
            // 
            this.button_SpielerHinzufügen.Location = new System.Drawing.Point(10, 10);
            this.button_SpielerHinzufügen.Name = "button_SpielerHinzufügen";
            this.button_SpielerHinzufügen.Size = new System.Drawing.Size(139, 23);
            this.button_SpielerHinzufügen.TabIndex = 0;
            this.button_SpielerHinzufügen.Text = "Spieler hinzufügen";
            this.button_SpielerHinzufügen.UseVisualStyleBackColor = true;
            this.button_SpielerHinzufügen.Click += new System.EventHandler(this.Button_SpielerHinzufügen_Click);
            // 
            // button_KampfBeginnen
            // 
            this.button_KampfBeginnen.Location = new System.Drawing.Point(155, 10);
            this.button_KampfBeginnen.Name = "button_KampfBeginnen";
            this.button_KampfBeginnen.Size = new System.Drawing.Size(139, 23);
            this.button_KampfBeginnen.TabIndex = 1;
            this.button_KampfBeginnen.Text = "Kampf beginnen";
            this.button_KampfBeginnen.UseVisualStyleBackColor = true;
            this.button_KampfBeginnen.Click += new System.EventHandler(this.Button_KampfBeginnen_Click);
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 661);
            this.Controls.Add(this.button_KampfBeginnen);
            this.Controls.Add(this.button_SpielerHinzufügen);
            this.Name = "Start";
            this.Text = "PnProgram";
            this.Load += new System.EventHandler(this.Start_Load);
            this.Resize += new System.EventHandler(this.Start_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_SpielerHinzufügen;
        private System.Windows.Forms.Button button_KampfBeginnen;
    }
}


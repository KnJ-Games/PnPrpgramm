namespace PnProgram
{
    partial class Form_Statuseffekte
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
            this.checkedListBox_Angezeigt = new System.Windows.Forms.CheckedListBox();
            this.label_Angezeigt = new System.Windows.Forms.Label();
            this.label_StatusÄndern = new System.Windows.Forms.Label();
            this.checkedListBox_Status = new System.Windows.Forms.CheckedListBox();
            this.button_AnwendenUndSchließen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox_Angezeigt
            // 
            this.checkedListBox_Angezeigt.FormattingEnabled = true;
            this.checkedListBox_Angezeigt.Location = new System.Drawing.Point(12, 35);
            this.checkedListBox_Angezeigt.Name = "checkedListBox_Angezeigt";
            this.checkedListBox_Angezeigt.Size = new System.Drawing.Size(120, 319);
            this.checkedListBox_Angezeigt.TabIndex = 0;
            // 
            // label_Angezeigt
            // 
            this.label_Angezeigt.AutoSize = true;
            this.label_Angezeigt.Location = new System.Drawing.Point(12, 9);
            this.label_Angezeigt.Name = "label_Angezeigt";
            this.label_Angezeigt.Size = new System.Drawing.Size(81, 13);
            this.label_Angezeigt.TabIndex = 1;
            this.label_Angezeigt.Text = "Wird angezeigt:";
            // 
            // label_StatusÄndern
            // 
            this.label_StatusÄndern.AutoSize = true;
            this.label_StatusÄndern.Location = new System.Drawing.Point(172, 9);
            this.label_StatusÄndern.Name = "label_StatusÄndern";
            this.label_StatusÄndern.Size = new System.Drawing.Size(76, 13);
            this.label_StatusÄndern.TabIndex = 3;
            this.label_StatusÄndern.Text = "Status ändern:";
            // 
            // checkedListBox_Status
            // 
            this.checkedListBox_Status.FormattingEnabled = true;
            this.checkedListBox_Status.Location = new System.Drawing.Point(175, 35);
            this.checkedListBox_Status.Name = "checkedListBox_Status";
            this.checkedListBox_Status.Size = new System.Drawing.Size(120, 319);
            this.checkedListBox_Status.TabIndex = 2;
            // 
            // button_AnwendenUndSchließen
            // 
            this.button_AnwendenUndSchließen.Location = new System.Drawing.Point(79, 360);
            this.button_AnwendenUndSchließen.Name = "button_AnwendenUndSchließen";
            this.button_AnwendenUndSchließen.Size = new System.Drawing.Size(148, 23);
            this.button_AnwendenUndSchließen.TabIndex = 4;
            this.button_AnwendenUndSchließen.Text = "Anwenden und Schließen";
            this.button_AnwendenUndSchließen.UseVisualStyleBackColor = true;
            this.button_AnwendenUndSchließen.Click += new System.EventHandler(this.Button_AnwendenUndSchließen_Click);
            // 
            // Form_Statuseffekte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 393);
            this.Controls.Add(this.button_AnwendenUndSchließen);
            this.Controls.Add(this.label_StatusÄndern);
            this.Controls.Add(this.checkedListBox_Status);
            this.Controls.Add(this.label_Angezeigt);
            this.Controls.Add(this.checkedListBox_Angezeigt);
            this.Name = "Form_Statuseffekte";
            this.Text = "Form_Statuseffekte";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox_Angezeigt;
        private System.Windows.Forms.Label label_Angezeigt;
        private System.Windows.Forms.Label label_StatusÄndern;
        private System.Windows.Forms.CheckedListBox checkedListBox_Status;
        private System.Windows.Forms.Button button_AnwendenUndSchließen;
    }
}
namespace httpNASA
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnDataLancio = new System.Windows.Forms.Button();
            this.gbImpostazioni = new System.Windows.Forms.GroupBox();
            this.txtImmaginiscaricate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLimitaAnno = new System.Windows.Forms.CheckBox();
            this.cbAvvio = new System.Windows.Forms.CheckBox();
            this.lblCrediti = new System.Windows.Forms.Label();
            this.txtCrediti = new System.Windows.Forms.TextBox();
            this.lblDescrizione = new System.Windows.Forms.Label();
            this.txtDescrizione = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbImpostazioni.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(9, 8);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // btnDataLancio
            // 
            this.btnDataLancio.Location = new System.Drawing.Point(9, 182);
            this.btnDataLancio.Name = "btnDataLancio";
            this.btnDataLancio.Size = new System.Drawing.Size(227, 30);
            this.btnDataLancio.TabIndex = 1;
            this.btnDataLancio.Text = "Vai alla data di Lancio.";
            this.btnDataLancio.UseVisualStyleBackColor = true;
            this.btnDataLancio.Click += new System.EventHandler(this.btnDataLancio_Click);
            // 
            // gbImpostazioni
            // 
            this.gbImpostazioni.Controls.Add(this.txtImmaginiscaricate);
            this.gbImpostazioni.Controls.Add(this.label1);
            this.gbImpostazioni.Controls.Add(this.cbLimitaAnno);
            this.gbImpostazioni.Controls.Add(this.cbAvvio);
            this.gbImpostazioni.Location = new System.Drawing.Point(9, 218);
            this.gbImpostazioni.Name = "gbImpostazioni";
            this.gbImpostazioni.Size = new System.Drawing.Size(227, 114);
            this.gbImpostazioni.TabIndex = 2;
            this.gbImpostazioni.TabStop = false;
            this.gbImpostazioni.Text = "Impostazioni";
            // 
            // txtImmaginiscaricate
            // 
            this.txtImmaginiscaricate.BackColor = System.Drawing.SystemColors.Info;
            this.txtImmaginiscaricate.Location = new System.Drawing.Point(129, 83);
            this.txtImmaginiscaricate.Name = "txtImmaginiscaricate";
            this.txtImmaginiscaricate.ReadOnly = true;
            this.txtImmaginiscaricate.Size = new System.Drawing.Size(67, 20);
            this.txtImmaginiscaricate.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Immagini scaricate oggi:";
            // 
            // cbLimitaAnno
            // 
            this.cbLimitaAnno.AutoSize = true;
            this.cbLimitaAnno.Location = new System.Drawing.Point(6, 42);
            this.cbLimitaAnno.Name = "cbLimitaAnno";
            this.cbLimitaAnno.Size = new System.Drawing.Size(182, 17);
            this.cbLimitaAnno.TabIndex = 3;
            this.cbLimitaAnno.Text = " Limita intervallo all\'anno corrente";
            this.cbLimitaAnno.UseVisualStyleBackColor = true;
            this.cbLimitaAnno.CheckedChanged += new System.EventHandler(this.cbLimitaAnno_CheckedChanged);
            // 
            // cbAvvio
            // 
            this.cbAvvio.AutoSize = true;
            this.cbAvvio.Location = new System.Drawing.Point(6, 19);
            this.cbAvvio.Name = "cbAvvio";
            this.cbAvvio.Size = new System.Drawing.Size(194, 17);
            this.cbAvvio.TabIndex = 3;
            this.cbAvvio.Text = "Visualizza immagine di oggi all\'avvio";
            this.cbAvvio.UseVisualStyleBackColor = true;
            // 
            // lblCrediti
            // 
            this.lblCrediti.AutoSize = true;
            this.lblCrediti.Location = new System.Drawing.Point(12, 347);
            this.lblCrediti.Name = "lblCrediti";
            this.lblCrediti.Size = new System.Drawing.Size(135, 13);
            this.lblCrediti.TabIndex = 3;
            this.lblCrediti.Text = "Crediti immagine e copiright";
            // 
            // txtCrediti
            // 
            this.txtCrediti.BackColor = System.Drawing.SystemColors.Info;
            this.txtCrediti.Location = new System.Drawing.Point(15, 363);
            this.txtCrediti.Name = "txtCrediti";
            this.txtCrediti.ReadOnly = true;
            this.txtCrediti.Size = new System.Drawing.Size(227, 20);
            this.txtCrediti.TabIndex = 4;
            // 
            // lblDescrizione
            // 
            this.lblDescrizione.AutoSize = true;
            this.lblDescrizione.Location = new System.Drawing.Point(12, 447);
            this.lblDescrizione.Name = "lblDescrizione";
            this.lblDescrizione.Size = new System.Drawing.Size(71, 13);
            this.lblDescrizione.TabIndex = 5;
            this.lblDescrizione.Text = "Descrizione : ";
            // 
            // txtDescrizione
            // 
            this.txtDescrizione.BackColor = System.Drawing.SystemColors.Info;
            this.txtDescrizione.Location = new System.Drawing.Point(12, 463);
            this.txtDescrizione.Multiline = true;
            this.txtDescrizione.Name = "txtDescrizione";
            this.txtDescrizione.Size = new System.Drawing.Size(1227, 136);
            this.txtDescrizione.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(248, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(991, 448);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 602);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtDescrizione);
            this.Controls.Add(this.lblDescrizione);
            this.Controls.Add(this.txtCrediti);
            this.Controls.Add(this.lblCrediti);
            this.Controls.Add(this.gbImpostazioni);
            this.Controls.Add(this.btnDataLancio);
            this.Controls.Add(this.monthCalendar1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Immagine del giorno";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.gbImpostazioni.ResumeLayout(false);
            this.gbImpostazioni.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnDataLancio;
        private System.Windows.Forms.GroupBox gbImpostazioni;
        private System.Windows.Forms.TextBox txtImmaginiscaricate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbLimitaAnno;
        private System.Windows.Forms.CheckBox cbAvvio;
        private System.Windows.Forms.Label lblCrediti;
        private System.Windows.Forms.TextBox txtCrediti;
        private System.Windows.Forms.Label lblDescrizione;
        private System.Windows.Forms.TextBox txtDescrizione;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


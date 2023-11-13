namespace CRUD_file_accesso_diretto
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
            this.Aggiungi = new System.Windows.Forms.Button();
            this.Prodotto = new System.Windows.Forms.TextBox();
            this.Prezzo = new System.Windows.Forms.TextBox();
            this.Resetta = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CERCA = new System.Windows.Forms.Button();
            this.RIcercaProdottoTEXT = new System.Windows.Forms.TextBox();
            this.ModificaProdotto = new System.Windows.Forms.TextBox();
            this.ModificaPrezzo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Modifica = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.cancellazioneLogicaTEXT = new System.Windows.Forms.TextBox();
            this.CancellazioneLogica = new System.Windows.Forms.Button();
            this.CancellazioneFisica = new System.Windows.Forms.Button();
            this.cancellazionefisicaTEXT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Recupera = new System.Windows.Forms.Button();
            this.RecuperaTEXT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Aggiungi
            // 
            this.Aggiungi.BackColor = System.Drawing.Color.Transparent;
            this.Aggiungi.Location = new System.Drawing.Point(51, 23);
            this.Aggiungi.Name = "Aggiungi";
            this.Aggiungi.Size = new System.Drawing.Size(234, 64);
            this.Aggiungi.TabIndex = 0;
            this.Aggiungi.Text = "AGGIUNGI";
            this.Aggiungi.UseVisualStyleBackColor = false;
            this.Aggiungi.Click += new System.EventHandler(this.Aggiungi_Click);
            // 
            // Prodotto
            // 
            this.Prodotto.Location = new System.Drawing.Point(51, 106);
            this.Prodotto.Name = "Prodotto";
            this.Prodotto.Size = new System.Drawing.Size(100, 20);
            this.Prodotto.TabIndex = 1;
            // 
            // Prezzo
            // 
            this.Prezzo.Location = new System.Drawing.Point(185, 106);
            this.Prezzo.Name = "Prezzo";
            this.Prezzo.Size = new System.Drawing.Size(100, 20);
            this.Prezzo.TabIndex = 2;
            // 
            // Resetta
            // 
            this.Resetta.BackColor = System.Drawing.Color.IndianRed;
            this.Resetta.Location = new System.Drawing.Point(365, 20);
            this.Resetta.Name = "Resetta";
            this.Resetta.Size = new System.Drawing.Size(234, 64);
            this.Resetta.TabIndex = 3;
            this.Resetta.Text = "RESETTA FILE";
            this.Resetta.UseVisualStyleBackColor = false;
            this.Resetta.Click += new System.EventHandler(this.Resetta_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "PRODOTTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "PREZZO";
            // 
            // CERCA
            // 
            this.CERCA.BackColor = System.Drawing.Color.Transparent;
            this.CERCA.Location = new System.Drawing.Point(51, 168);
            this.CERCA.Name = "CERCA";
            this.CERCA.Size = new System.Drawing.Size(234, 64);
            this.CERCA.TabIndex = 6;
            this.CERCA.Text = "RICERCA";
            this.CERCA.UseVisualStyleBackColor = false;
            this.CERCA.Click += new System.EventHandler(this.CERCA_Click);
            // 
            // RIcercaProdottoTEXT
            // 
            this.RIcercaProdottoTEXT.Location = new System.Drawing.Point(51, 251);
            this.RIcercaProdottoTEXT.Name = "RIcercaProdottoTEXT";
            this.RIcercaProdottoTEXT.Size = new System.Drawing.Size(234, 20);
            this.RIcercaProdottoTEXT.TabIndex = 8;
            this.RIcercaProdottoTEXT.TextChanged += new System.EventHandler(this.RIcercaProdottoTEXT_TextChanged);
            // 
            // ModificaProdotto
            // 
            this.ModificaProdotto.Location = new System.Drawing.Point(51, 406);
            this.ModificaProdotto.Name = "ModificaProdotto";
            this.ModificaProdotto.Size = new System.Drawing.Size(234, 20);
            this.ModificaProdotto.TabIndex = 9;
            // 
            // ModificaPrezzo
            // 
            this.ModificaPrezzo.Location = new System.Drawing.Point(51, 466);
            this.ModificaPrezzo.Name = "ModificaPrezzo";
            this.ModificaPrezzo.Size = new System.Drawing.Size(234, 20);
            this.ModificaPrezzo.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "PRODOTTO DA MODIFICARE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "PREZZO DA MODIFICARE";
            // 
            // Modifica
            // 
            this.Modifica.BackColor = System.Drawing.Color.Transparent;
            this.Modifica.Location = new System.Drawing.Point(51, 323);
            this.Modifica.Name = "Modifica";
            this.Modifica.Size = new System.Drawing.Size(234, 64);
            this.Modifica.TabIndex = 13;
            this.Modifica.Text = "MODIFICA";
            this.Modifica.UseVisualStyleBackColor = false;
            this.Modifica.Click += new System.EventHandler(this.Modifica_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "PRODOTTO DA RICERCARE";
            // 
            // cancellazioneLogicaTEXT
            // 
            this.cancellazioneLogicaTEXT.Location = new System.Drawing.Point(365, 251);
            this.cancellazioneLogicaTEXT.Name = "cancellazioneLogicaTEXT";
            this.cancellazioneLogicaTEXT.Size = new System.Drawing.Size(234, 20);
            this.cancellazioneLogicaTEXT.TabIndex = 15;
            // 
            // CancellazioneLogica
            // 
            this.CancellazioneLogica.Location = new System.Drawing.Point(365, 168);
            this.CancellazioneLogica.Name = "CancellazioneLogica";
            this.CancellazioneLogica.Size = new System.Drawing.Size(234, 64);
            this.CancellazioneLogica.TabIndex = 16;
            this.CancellazioneLogica.Text = "CANCELLAZIONE LOGICA";
            this.CancellazioneLogica.UseVisualStyleBackColor = true;
            this.CancellazioneLogica.Click += new System.EventHandler(this.CancellazioneLogica_Click);
            // 
            // CancellazioneFisica
            // 
            this.CancellazioneFisica.Location = new System.Drawing.Point(365, 323);
            this.CancellazioneFisica.Name = "CancellazioneFisica";
            this.CancellazioneFisica.Size = new System.Drawing.Size(234, 64);
            this.CancellazioneFisica.TabIndex = 17;
            this.CancellazioneFisica.Text = "CANCELLAZIONE FISICA";
            this.CancellazioneFisica.UseVisualStyleBackColor = true;
            this.CancellazioneFisica.Click += new System.EventHandler(this.CancellazioneFisica_Click);
            // 
            // cancellazionefisicaTEXT
            // 
            this.cancellazionefisicaTEXT.Location = new System.Drawing.Point(365, 406);
            this.cancellazionefisicaTEXT.Name = "cancellazionefisicaTEXT";
            this.cancellazionefisicaTEXT.Size = new System.Drawing.Size(234, 20);
            this.cancellazionefisicaTEXT.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "PRODOTTO DA CANCELLARE";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(365, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "PRODOTTO DA CANCELLARE";
            // 
            // Recupera
            // 
            this.Recupera.Location = new System.Drawing.Point(682, 168);
            this.Recupera.Name = "Recupera";
            this.Recupera.Size = new System.Drawing.Size(234, 63);
            this.Recupera.TabIndex = 21;
            this.Recupera.Text = "RECUPERA";
            this.Recupera.UseVisualStyleBackColor = true;
            this.Recupera.Click += new System.EventHandler(this.Recupera_Click);
            // 
            // RecuperaTEXT
            // 
            this.RecuperaTEXT.Location = new System.Drawing.Point(682, 251);
            this.RecuperaTEXT.Name = "RecuperaTEXT";
            this.RecuperaTEXT.Size = new System.Drawing.Size(234, 20);
            this.RecuperaTEXT.TabIndex = 22;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 636);
            this.Controls.Add(this.RecuperaTEXT);
            this.Controls.Add(this.Recupera);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cancellazionefisicaTEXT);
            this.Controls.Add(this.CancellazioneFisica);
            this.Controls.Add(this.CancellazioneLogica);
            this.Controls.Add(this.cancellazioneLogicaTEXT);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Modifica);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ModificaPrezzo);
            this.Controls.Add(this.ModificaProdotto);
            this.Controls.Add(this.RIcercaProdottoTEXT);
            this.Controls.Add(this.CERCA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Resetta);
            this.Controls.Add(this.Prezzo);
            this.Controls.Add(this.Prodotto);
            this.Controls.Add(this.Aggiungi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Aggiungi;
        private System.Windows.Forms.TextBox Prodotto;
        private System.Windows.Forms.TextBox Prezzo;
        private System.Windows.Forms.Button Resetta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CERCA;
        private System.Windows.Forms.TextBox RIcercaProdottoTEXT;
        private System.Windows.Forms.TextBox ModificaProdotto;
        private System.Windows.Forms.TextBox ModificaPrezzo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Modifica;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cancellazioneLogicaTEXT;
        private System.Windows.Forms.Button CancellazioneLogica;
        private System.Windows.Forms.Button CancellazioneFisica;
        private System.Windows.Forms.TextBox cancellazionefisicaTEXT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button Recupera;
        private System.Windows.Forms.TextBox RecuperaTEXT;
    }
}


namespace Flashcards
{
    partial class Form1
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
            this.btnStudera = new System.Windows.Forms.Button();
            this.btnVisaDeck = new System.Windows.Forms.Button();
            this.lblTitel = new System.Windows.Forms.Label();
            this.gbxDeckMeny = new System.Windows.Forms.GroupBox();
            this.btnNyttDeck = new System.Windows.Forms.Button();
            this.btnAddKort = new System.Windows.Forms.Button();
            this.btnDelDeck = new System.Windows.Forms.Button();
            this.lbxDeckList = new System.Windows.Forms.ListBox();
            this.btnTillbaka = new System.Windows.Forms.Button();
            this.btnStudDeck = new System.Windows.Forms.Button();
            this.tbxKortFråga = new System.Windows.Forms.TextBox();
            this.tbxKortSvar = new System.Windows.Forms.TextBox();
            this.lblKortFråga = new System.Windows.Forms.Label();
            this.lblKortSvar = new System.Windows.Forms.Label();
            this.btnAddKort4real = new System.Windows.Forms.Button();
            this.gbxDeckRed = new System.Windows.Forms.GroupBox();
            this.lblDeckNamn = new System.Windows.Forms.Label();
            this.btnSkapaDeck = new System.Windows.Forms.Button();
            this.tbxDeckNamn = new System.Windows.Forms.TextBox();
            this.btnTillbakFrånKort = new System.Windows.Forms.Button();
            this.lblKortFråg = new System.Windows.Forms.Label();
            this.btnVisaSvar = new System.Windows.Forms.Button();
            this.gbxKortStud = new System.Windows.Forms.GroupBox();
            this.lblKorSvar = new System.Windows.Forms.Label();
            this.btnRättSvar = new System.Windows.Forms.Button();
            this.btnFelSvar = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnSpara = new System.Windows.Forms.Button();
            this.gbxDeckMeny.SuspendLayout();
            this.gbxDeckRed.SuspendLayout();
            this.gbxKortStud.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStudera
            // 
            this.btnStudera.Location = new System.Drawing.Point(139, 173);
            this.btnStudera.Name = "btnStudera";
            this.btnStudera.Size = new System.Drawing.Size(112, 40);
            this.btnStudera.TabIndex = 0;
            this.btnStudera.Text = "Studera";
            this.btnStudera.UseVisualStyleBackColor = true;
            this.btnStudera.Click += new System.EventHandler(this.btnStudera_Click);
            // 
            // btnVisaDeck
            // 
            this.btnVisaDeck.Location = new System.Drawing.Point(139, 219);
            this.btnVisaDeck.Name = "btnVisaDeck";
            this.btnVisaDeck.Size = new System.Drawing.Size(112, 40);
            this.btnVisaDeck.TabIndex = 1;
            this.btnVisaDeck.Text = "Mina deck";
            this.btnVisaDeck.UseVisualStyleBackColor = true;
            this.btnVisaDeck.Click += new System.EventHandler(this.btnVisaDeck_Click);
            // 
            // lblTitel
            // 
            this.lblTitel.AutoSize = true;
            this.lblTitel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitel.ForeColor = System.Drawing.Color.Snow;
            this.lblTitel.Location = new System.Drawing.Point(107, 112);
            this.lblTitel.Name = "lblTitel";
            this.lblTitel.Size = new System.Drawing.Size(188, 39);
            this.lblTitel.TabIndex = 2;
            this.lblTitel.Text = "Flashcards";
            // 
            // gbxDeckMeny
            // 
            this.gbxDeckMeny.Controls.Add(this.btnSpara);
            this.gbxDeckMeny.Controls.Add(this.btnNyttDeck);
            this.gbxDeckMeny.Controls.Add(this.btnAddKort);
            this.gbxDeckMeny.Controls.Add(this.btnDelDeck);
            this.gbxDeckMeny.Location = new System.Drawing.Point(12, 12);
            this.gbxDeckMeny.Name = "gbxDeckMeny";
            this.gbxDeckMeny.Size = new System.Drawing.Size(371, 54);
            this.gbxDeckMeny.TabIndex = 3;
            this.gbxDeckMeny.TabStop = false;
            this.gbxDeckMeny.Text = "Meny";
            this.gbxDeckMeny.Visible = false;
            // 
            // btnNyttDeck
            // 
            this.btnNyttDeck.Location = new System.Drawing.Point(21, 19);
            this.btnNyttDeck.Name = "btnNyttDeck";
            this.btnNyttDeck.Size = new System.Drawing.Size(72, 23);
            this.btnNyttDeck.TabIndex = 3;
            this.btnNyttDeck.Text = "Nytt deck";
            this.btnNyttDeck.UseVisualStyleBackColor = true;
            this.btnNyttDeck.Click += new System.EventHandler(this.btnNyttDeck_Click);
            // 
            // btnAddKort
            // 
            this.btnAddKort.Enabled = false;
            this.btnAddKort.Location = new System.Drawing.Point(99, 19);
            this.btnAddKort.Name = "btnAddKort";
            this.btnAddKort.Size = new System.Drawing.Size(72, 23);
            this.btnAddKort.TabIndex = 1;
            this.btnAddKort.Text = "Lägg till kort";
            this.btnAddKort.UseVisualStyleBackColor = true;
            this.btnAddKort.Click += new System.EventHandler(this.btnAddKort_Click);
            // 
            // btnDelDeck
            // 
            this.btnDelDeck.Enabled = false;
            this.btnDelDeck.Location = new System.Drawing.Point(177, 19);
            this.btnDelDeck.Name = "btnDelDeck";
            this.btnDelDeck.Size = new System.Drawing.Size(86, 23);
            this.btnDelDeck.TabIndex = 0;
            this.btnDelDeck.Text = "Radera Deck";
            this.btnDelDeck.UseVisualStyleBackColor = true;
            this.btnDelDeck.Click += new System.EventHandler(this.btnDelDeck_Click);
            // 
            // lbxDeckList
            // 
            this.lbxDeckList.FormattingEnabled = true;
            this.lbxDeckList.Items.AddRange(new object[] {
            "Japanska",
            "Franska",
            "Fysik"});
            this.lbxDeckList.Location = new System.Drawing.Point(18, 72);
            this.lbxDeckList.Name = "lbxDeckList";
            this.lbxDeckList.Size = new System.Drawing.Size(348, 290);
            this.lbxDeckList.TabIndex = 4;
            this.lbxDeckList.Visible = false;
            this.lbxDeckList.SelectedIndexChanged += new System.EventHandler(this.lbxDeckList_SelectedIndexChanged);
            // 
            // btnTillbaka
            // 
            this.btnTillbaka.Location = new System.Drawing.Point(276, 374);
            this.btnTillbaka.Name = "btnTillbaka";
            this.btnTillbaka.Size = new System.Drawing.Size(90, 23);
            this.btnTillbaka.TabIndex = 3;
            this.btnTillbaka.Text = "Tillbaka";
            this.btnTillbaka.UseVisualStyleBackColor = true;
            this.btnTillbaka.Visible = false;
            this.btnTillbaka.Click += new System.EventHandler(this.btnTillbaka_Click);
            // 
            // btnStudDeck
            // 
            this.btnStudDeck.Enabled = false;
            this.btnStudDeck.Location = new System.Drawing.Point(18, 374);
            this.btnStudDeck.Name = "btnStudDeck";
            this.btnStudDeck.Size = new System.Drawing.Size(91, 23);
            this.btnStudDeck.TabIndex = 4;
            this.btnStudDeck.Text = "Studera deck";
            this.btnStudDeck.UseVisualStyleBackColor = true;
            this.btnStudDeck.Visible = false;
            this.btnStudDeck.Click += new System.EventHandler(this.btnStudDeck_Click);
            // 
            // tbxKortFråga
            // 
            this.tbxKortFråga.Location = new System.Drawing.Point(73, 25);
            this.tbxKortFråga.Name = "tbxKortFråga";
            this.tbxKortFråga.Size = new System.Drawing.Size(189, 20);
            this.tbxKortFråga.TabIndex = 5;
            this.tbxKortFråga.Visible = false;
            // 
            // tbxKortSvar
            // 
            this.tbxKortSvar.Location = new System.Drawing.Point(73, 55);
            this.tbxKortSvar.Name = "tbxKortSvar";
            this.tbxKortSvar.Size = new System.Drawing.Size(189, 20);
            this.tbxKortSvar.TabIndex = 6;
            this.tbxKortSvar.Visible = false;
            // 
            // lblKortFråga
            // 
            this.lblKortFråga.AutoSize = true;
            this.lblKortFråga.Location = new System.Drawing.Point(21, 25);
            this.lblKortFråga.Name = "lblKortFråga";
            this.lblKortFråga.Size = new System.Drawing.Size(34, 13);
            this.lblKortFråga.TabIndex = 7;
            this.lblKortFråga.Text = "Fråga";
            this.lblKortFråga.Visible = false;
            // 
            // lblKortSvar
            // 
            this.lblKortSvar.AutoSize = true;
            this.lblKortSvar.Location = new System.Drawing.Point(21, 58);
            this.lblKortSvar.Name = "lblKortSvar";
            this.lblKortSvar.Size = new System.Drawing.Size(29, 13);
            this.lblKortSvar.TabIndex = 8;
            this.lblKortSvar.Text = "Svar";
            this.lblKortSvar.Visible = false;
            // 
            // btnAddKort4real
            // 
            this.btnAddKort4real.Location = new System.Drawing.Point(187, 94);
            this.btnAddKort4real.Name = "btnAddKort4real";
            this.btnAddKort4real.Size = new System.Drawing.Size(75, 23);
            this.btnAddKort4real.TabIndex = 9;
            this.btnAddKort4real.Text = "Lägg till kort";
            this.btnAddKort4real.UseVisualStyleBackColor = true;
            this.btnAddKort4real.Visible = false;
            this.btnAddKort4real.Click += new System.EventHandler(this.btnAddKort4real_Click);
            // 
            // gbxDeckRed
            // 
            this.gbxDeckRed.Controls.Add(this.lblDeckNamn);
            this.gbxDeckRed.Controls.Add(this.btnSkapaDeck);
            this.gbxDeckRed.Controls.Add(this.tbxDeckNamn);
            this.gbxDeckRed.Controls.Add(this.btnTillbakFrånKort);
            this.gbxDeckRed.Controls.Add(this.tbxKortFråga);
            this.gbxDeckRed.Controls.Add(this.btnAddKort4real);
            this.gbxDeckRed.Controls.Add(this.lblKortFråga);
            this.gbxDeckRed.Controls.Add(this.lblKortSvar);
            this.gbxDeckRed.Controls.Add(this.tbxKortSvar);
            this.gbxDeckRed.Location = new System.Drawing.Point(55, 112);
            this.gbxDeckRed.Name = "gbxDeckRed";
            this.gbxDeckRed.Size = new System.Drawing.Size(268, 135);
            this.gbxDeckRed.TabIndex = 10;
            this.gbxDeckRed.TabStop = false;
            this.gbxDeckRed.Text = "Skapa deck";
            this.gbxDeckRed.Visible = false;
            // 
            // lblDeckNamn
            // 
            this.lblDeckNamn.AutoSize = true;
            this.lblDeckNamn.Location = new System.Drawing.Point(6, 32);
            this.lblDeckNamn.Name = "lblDeckNamn";
            this.lblDeckNamn.Size = new System.Drawing.Size(62, 13);
            this.lblDeckNamn.TabIndex = 15;
            this.lblDeckNamn.Text = "Deck namn";
            // 
            // btnSkapaDeck
            // 
            this.btnSkapaDeck.Location = new System.Drawing.Point(106, 94);
            this.btnSkapaDeck.Name = "btnSkapaDeck";
            this.btnSkapaDeck.Size = new System.Drawing.Size(75, 23);
            this.btnSkapaDeck.TabIndex = 14;
            this.btnSkapaDeck.Text = "Skapa deck";
            this.btnSkapaDeck.UseVisualStyleBackColor = true;
            this.btnSkapaDeck.Click += new System.EventHandler(this.btnSkapaDeck_Click);
            // 
            // tbxDeckNamn
            // 
            this.tbxDeckNamn.Location = new System.Drawing.Point(74, 29);
            this.tbxDeckNamn.Name = "tbxDeckNamn";
            this.tbxDeckNamn.Size = new System.Drawing.Size(188, 20);
            this.tbxDeckNamn.TabIndex = 11;
            this.tbxDeckNamn.TextChanged += new System.EventHandler(this.tbxDeckNamn_TextChanged);
            // 
            // btnTillbakFrånKort
            // 
            this.btnTillbakFrånKort.Location = new System.Drawing.Point(8, 94);
            this.btnTillbakFrånKort.Name = "btnTillbakFrånKort";
            this.btnTillbakFrånKort.Size = new System.Drawing.Size(75, 23);
            this.btnTillbakFrånKort.TabIndex = 10;
            this.btnTillbakFrånKort.Text = "Tillbaka";
            this.btnTillbakFrånKort.UseVisualStyleBackColor = true;
            this.btnTillbakFrånKort.Click += new System.EventHandler(this.btnTillbakFrånKort_Click);
            // 
            // lblKortFråg
            // 
            this.lblKortFråg.AutoSize = true;
            this.lblKortFråg.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKortFråg.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKortFråg.Location = new System.Drawing.Point(26, 45);
            this.lblKortFråg.Name = "lblKortFråg";
            this.lblKortFråg.Size = new System.Drawing.Size(82, 31);
            this.lblKortFråg.TabIndex = 11;
            this.lblKortFråg.Text = "Blank";
            // 
            // btnVisaSvar
            // 
            this.btnVisaSvar.Location = new System.Drawing.Point(140, 238);
            this.btnVisaSvar.Name = "btnVisaSvar";
            this.btnVisaSvar.Size = new System.Drawing.Size(75, 23);
            this.btnVisaSvar.TabIndex = 12;
            this.btnVisaSvar.Text = "Visa svar";
            this.btnVisaSvar.UseVisualStyleBackColor = true;
            this.btnVisaSvar.Click += new System.EventHandler(this.btnVisaSvar_Click);
            // 
            // gbxKortStud
            // 
            this.gbxKortStud.Controls.Add(this.lblKorSvar);
            this.gbxKortStud.Controls.Add(this.btnRättSvar);
            this.gbxKortStud.Controls.Add(this.btnFelSvar);
            this.gbxKortStud.Controls.Add(this.lblKortFråg);
            this.gbxKortStud.Controls.Add(this.btnVisaSvar);
            this.gbxKortStud.Location = new System.Drawing.Point(12, 72);
            this.gbxKortStud.Name = "gbxKortStud";
            this.gbxKortStud.Size = new System.Drawing.Size(371, 325);
            this.gbxKortStud.TabIndex = 13;
            this.gbxKortStud.TabStop = false;
            this.gbxKortStud.Text = "Studera";
            this.gbxKortStud.Visible = false;
            // 
            // lblKorSvar
            // 
            this.lblKorSvar.AutoSize = true;
            this.lblKorSvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKorSvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblKorSvar.Location = new System.Drawing.Point(26, 120);
            this.lblKorSvar.Name = "lblKorSvar";
            this.lblKorSvar.Size = new System.Drawing.Size(121, 31);
            this.lblKorSvar.TabIndex = 15;
            this.lblKorSvar.Text = "Blankare";
            this.lblKorSvar.Visible = false;
            // 
            // btnRättSvar
            // 
            this.btnRättSvar.Location = new System.Drawing.Point(181, 238);
            this.btnRättSvar.Name = "btnRättSvar";
            this.btnRättSvar.Size = new System.Drawing.Size(75, 23);
            this.btnRättSvar.TabIndex = 14;
            this.btnRättSvar.Text = "Rätt";
            this.btnRättSvar.UseVisualStyleBackColor = true;
            this.btnRättSvar.Visible = false;
            this.btnRättSvar.Click += new System.EventHandler(this.btnRättSvar_Click);
            // 
            // btnFelSvar
            // 
            this.btnFelSvar.Location = new System.Drawing.Point(100, 238);
            this.btnFelSvar.Name = "btnFelSvar";
            this.btnFelSvar.Size = new System.Drawing.Size(75, 23);
            this.btnFelSvar.TabIndex = 13;
            this.btnFelSvar.Text = "Fel";
            this.btnFelSvar.UseVisualStyleBackColor = true;
            this.btnFelSvar.Visible = false;
            this.btnFelSvar.Click += new System.EventHandler(this.btnFelSvar_Click);
            // 
            // btnSpara
            // 
            this.btnSpara.Location = new System.Drawing.Point(269, 19);
            this.btnSpara.Name = "btnSpara";
            this.btnSpara.Size = new System.Drawing.Size(75, 23);
            this.btnSpara.TabIndex = 4;
            this.btnSpara.Text = "Spara";
            this.btnSpara.UseVisualStyleBackColor = true;
            this.btnSpara.Click += new System.EventHandler(this.btnSpara_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(398, 409);
            this.Controls.Add(this.gbxKortStud);
            this.Controls.Add(this.gbxDeckRed);
            this.Controls.Add(this.btnStudDeck);
            this.Controls.Add(this.btnTillbaka);
            this.Controls.Add(this.lbxDeckList);
            this.Controls.Add(this.gbxDeckMeny);
            this.Controls.Add(this.lblTitel);
            this.Controls.Add(this.btnVisaDeck);
            this.Controls.Add(this.btnStudera);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbxDeckMeny.ResumeLayout(false);
            this.gbxDeckRed.ResumeLayout(false);
            this.gbxDeckRed.PerformLayout();
            this.gbxKortStud.ResumeLayout(false);
            this.gbxKortStud.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStudera;
        private System.Windows.Forms.Button btnVisaDeck;
        private System.Windows.Forms.Label lblTitel;
        private System.Windows.Forms.GroupBox gbxDeckMeny;
        private System.Windows.Forms.Button btnDelDeck;
        private System.Windows.Forms.ListBox lbxDeckList;
        private System.Windows.Forms.Button btnAddKort;
        private System.Windows.Forms.Button btnTillbaka;
        private System.Windows.Forms.Button btnNyttDeck;
        private System.Windows.Forms.Button btnStudDeck;
        private System.Windows.Forms.TextBox tbxKortFråga;
        private System.Windows.Forms.TextBox tbxKortSvar;
        private System.Windows.Forms.Label lblKortFråga;
        private System.Windows.Forms.Label lblKortSvar;
        private System.Windows.Forms.Button btnAddKort4real;
        private System.Windows.Forms.GroupBox gbxDeckRed;
        private System.Windows.Forms.Button btnTillbakFrånKort;
        private System.Windows.Forms.TextBox tbxDeckNamn;
        private System.Windows.Forms.Button btnSkapaDeck;
        private System.Windows.Forms.Label lblDeckNamn;
        private System.Windows.Forms.Label lblKortFråg;
        private System.Windows.Forms.Button btnVisaSvar;
        private System.Windows.Forms.GroupBox gbxKortStud;
        private System.Windows.Forms.Label lblKorSvar;
        private System.Windows.Forms.Button btnRättSvar;
        private System.Windows.Forms.Button btnFelSvar;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnSpara;
    }
}


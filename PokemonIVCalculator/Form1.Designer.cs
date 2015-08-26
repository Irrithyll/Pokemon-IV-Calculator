namespace PokemonIVCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imgHeader = new System.Windows.Forms.PictureBox();
            this.labelSPECIES = new System.Windows.Forms.Label();
            this.labelLEVEL = new System.Windows.Forms.Label();
            this.BoxSpecies = new System.Windows.Forms.ComboBox();
            this.BoxLevel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.statATK = new System.Windows.Forms.TextBox();
            this.statDEF = new System.Windows.Forms.TextBox();
            this.statSPATK = new System.Windows.Forms.TextBox();
            this.statSPDEF = new System.Windows.Forms.TextBox();
            this.statSPD = new System.Windows.Forms.TextBox();
            this.EVSPD = new System.Windows.Forms.TextBox();
            this.EVSPDEF = new System.Windows.Forms.TextBox();
            this.EVSPATK = new System.Windows.Forms.TextBox();
            this.EVDEF = new System.Windows.Forms.TextBox();
            this.EVATK = new System.Windows.Forms.TextBox();
            this.EVHP = new System.Windows.Forms.TextBox();
            this.imgSpecies = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.BoxNature = new System.Windows.Forms.ComboBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelerror = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.IVHP = new System.Windows.Forms.Label();
            this.IVATK = new System.Windows.Forms.Label();
            this.IVDEF = new System.Windows.Forms.Label();
            this.IVSPATK = new System.Windows.Forms.Label();
            this.IVSPDEF = new System.Windows.Forms.Label();
            this.IVSPD = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.statHP = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imgHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSpecies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // imgHeader
            // 
            this.imgHeader.Image = ((System.Drawing.Image)(resources.GetObject("imgHeader.Image")));
            this.imgHeader.InitialImage = ((System.Drawing.Image)(resources.GetObject("imgHeader.InitialImage")));
            this.imgHeader.Location = new System.Drawing.Point(15, 12);
            this.imgHeader.Name = "imgHeader";
            this.imgHeader.Size = new System.Drawing.Size(468, 68);
            this.imgHeader.TabIndex = 0;
            this.imgHeader.TabStop = false;
            // 
            // labelSPECIES
            // 
            this.labelSPECIES.AutoSize = true;
            this.labelSPECIES.Location = new System.Drawing.Point(44, 121);
            this.labelSPECIES.Name = "labelSPECIES";
            this.labelSPECIES.Size = new System.Drawing.Size(52, 13);
            this.labelSPECIES.TabIndex = 1;
            this.labelSPECIES.Text = "SPECIES";
            // 
            // labelLEVEL
            // 
            this.labelLEVEL.AutoSize = true;
            this.labelLEVEL.Location = new System.Drawing.Point(56, 157);
            this.labelLEVEL.Name = "labelLEVEL";
            this.labelLEVEL.Size = new System.Drawing.Size(40, 13);
            this.labelLEVEL.TabIndex = 2;
            this.labelLEVEL.Text = "LEVEL";
            // 
            // BoxSpecies
            // 
            this.BoxSpecies.AllowDrop = true;
            this.BoxSpecies.FormattingEnabled = true;
            this.BoxSpecies.Location = new System.Drawing.Point(120, 118);
            this.BoxSpecies.Name = "BoxSpecies";
            this.BoxSpecies.Size = new System.Drawing.Size(143, 21);
            this.BoxSpecies.TabIndex = 4;
            this.BoxSpecies.SelectedIndexChanged += new System.EventHandler(this.BoxSpecies_SelectedIndexChanged);
            this.BoxSpecies.TextChanged += new System.EventHandler(this.BoxSpecies_TextChanged);
            // 
            // BoxLevel
            // 
            this.BoxLevel.AcceptsReturn = true;
            this.BoxLevel.Location = new System.Drawing.Point(154, 154);
            this.BoxLevel.MaxLength = 3;
            this.BoxLevel.Name = "BoxLevel";
            this.BoxLevel.Size = new System.Drawing.Size(60, 20);
            this.BoxLevel.TabIndex = 5;
            this.BoxLevel.Text = "50";
            this.BoxLevel.TextChanged += new System.EventHandler(this.BoxLevel_TextChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "STATS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "EVs";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "HP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(152, 215);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "ATK";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(208, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "DEF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(261, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "SPATK";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(323, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "SPDEF";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(388, 215);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "SPD";
            // 
            // statATK
            // 
            this.statATK.AcceptsReturn = true;
            this.statATK.Location = new System.Drawing.Point(150, 237);
            this.statATK.MaxLength = 3;
            this.statATK.Name = "statATK";
            this.statATK.Size = new System.Drawing.Size(37, 20);
            this.statATK.TabIndex = 15;
            this.statATK.Text = "54";
            this.statATK.TextChanged += new System.EventHandler(this.statATK_TextChanged);
            // 
            // statDEF
            // 
            this.statDEF.AcceptsReturn = true;
            this.statDEF.Location = new System.Drawing.Point(204, 237);
            this.statDEF.MaxLength = 3;
            this.statDEF.Name = "statDEF";
            this.statDEF.Size = new System.Drawing.Size(37, 20);
            this.statDEF.TabIndex = 16;
            this.statDEF.Text = "54";
            this.statDEF.TextChanged += new System.EventHandler(this.statDEF_TextChanged);
            // 
            // statSPATK
            // 
            this.statSPATK.AcceptsReturn = true;
            this.statSPATK.Location = new System.Drawing.Point(264, 237);
            this.statSPATK.MaxLength = 3;
            this.statSPATK.Name = "statSPATK";
            this.statSPATK.Size = new System.Drawing.Size(37, 20);
            this.statSPATK.TabIndex = 17;
            this.statSPATK.Text = "70";
            this.statSPATK.TextChanged += new System.EventHandler(this.statSPATK_TextChanged);
            // 
            // statSPDEF
            // 
            this.statSPDEF.AcceptsReturn = true;
            this.statSPDEF.Location = new System.Drawing.Point(326, 237);
            this.statSPDEF.MaxLength = 3;
            this.statSPDEF.Name = "statSPDEF";
            this.statSPDEF.Size = new System.Drawing.Size(37, 20);
            this.statSPDEF.TabIndex = 18;
            this.statSPDEF.Text = "70";
            this.statSPDEF.TextChanged += new System.EventHandler(this.statSPDEF_TextChanged);
            // 
            // statSPD
            // 
            this.statSPD.AcceptsReturn = true;
            this.statSPD.Location = new System.Drawing.Point(380, 237);
            this.statSPD.MaxLength = 3;
            this.statSPD.Name = "statSPD";
            this.statSPD.Size = new System.Drawing.Size(37, 20);
            this.statSPD.TabIndex = 19;
            this.statSPD.Text = "50";
            this.statSPD.TextChanged += new System.EventHandler(this.statSPD_TextChanged);
            // 
            // EVSPD
            // 
            this.EVSPD.AcceptsReturn = true;
            this.EVSPD.Location = new System.Drawing.Point(380, 270);
            this.EVSPD.MaxLength = 3;
            this.EVSPD.Name = "EVSPD";
            this.EVSPD.Size = new System.Drawing.Size(37, 20);
            this.EVSPD.TabIndex = 25;
            this.EVSPD.Text = "0";
            this.EVSPD.TextChanged += new System.EventHandler(this.EVSPD_TextChanged);
            // 
            // EVSPDEF
            // 
            this.EVSPDEF.AcceptsReturn = true;
            this.EVSPDEF.Location = new System.Drawing.Point(326, 270);
            this.EVSPDEF.MaxLength = 3;
            this.EVSPDEF.Name = "EVSPDEF";
            this.EVSPDEF.Size = new System.Drawing.Size(37, 20);
            this.EVSPDEF.TabIndex = 24;
            this.EVSPDEF.Text = "0";
            this.EVSPDEF.TextChanged += new System.EventHandler(this.EVSPDEF_TextChanged);
            // 
            // EVSPATK
            // 
            this.EVSPATK.AcceptsReturn = true;
            this.EVSPATK.Location = new System.Drawing.Point(264, 270);
            this.EVSPATK.MaxLength = 3;
            this.EVSPATK.Name = "EVSPATK";
            this.EVSPATK.Size = new System.Drawing.Size(37, 20);
            this.EVSPATK.TabIndex = 23;
            this.EVSPATK.Text = "0";
            this.EVSPATK.TextChanged += new System.EventHandler(this.EVSPATK_TextChanged);
            // 
            // EVDEF
            // 
            this.EVDEF.AcceptsReturn = true;
            this.EVDEF.Location = new System.Drawing.Point(204, 270);
            this.EVDEF.MaxLength = 3;
            this.EVDEF.Name = "EVDEF";
            this.EVDEF.Size = new System.Drawing.Size(37, 20);
            this.EVDEF.TabIndex = 22;
            this.EVDEF.Text = "0";
            this.EVDEF.TextChanged += new System.EventHandler(this.EVDEF_TextChanged);
            // 
            // EVATK
            // 
            this.EVATK.AcceptsReturn = true;
            this.EVATK.Location = new System.Drawing.Point(150, 270);
            this.EVATK.MaxLength = 3;
            this.EVATK.Name = "EVATK";
            this.EVATK.Size = new System.Drawing.Size(37, 20);
            this.EVATK.TabIndex = 21;
            this.EVATK.Text = "0";
            this.EVATK.TextChanged += new System.EventHandler(this.EVATK_TextChanged);
            // 
            // EVHP
            // 
            this.EVHP.AcceptsReturn = true;
            this.EVHP.Location = new System.Drawing.Point(97, 270);
            this.EVHP.MaxLength = 3;
            this.EVHP.Name = "EVHP";
            this.EVHP.Size = new System.Drawing.Size(37, 20);
            this.EVHP.TabIndex = 20;
            this.EVHP.Text = "0";
            this.EVHP.TextChanged += new System.EventHandler(this.EVHP_TextChanged);
            // 
            // imgSpecies
            // 
            this.imgSpecies.Image = ((System.Drawing.Image)(resources.GetObject("imgSpecies.Image")));
            this.imgSpecies.Location = new System.Drawing.Point(316, 95);
            this.imgSpecies.Name = "imgSpecies";
            this.imgSpecies.Size = new System.Drawing.Size(112, 117);
            this.imgSpecies.TabIndex = 26;
            this.imgSpecies.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(134, 323);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "NATURE";
            // 
            // BoxNature
            // 
            this.BoxNature.AllowDrop = true;
            this.BoxNature.FormattingEnabled = true;
            this.BoxNature.Location = new System.Drawing.Point(204, 320);
            this.BoxNature.Name = "BoxNature";
            this.BoxNature.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BoxNature.Size = new System.Drawing.Size(96, 21);
            this.BoxNature.TabIndex = 28;
            this.BoxNature.Text = "None";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(171, 371);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(152, 33);
            this.buttonCalculate.TabIndex = 29;
            this.buttonCalculate.Text = "CALCULATE";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // labelerror
            // 
            this.labelerror.AutoSize = true;
            this.labelerror.ForeColor = System.Drawing.Color.Red;
            this.labelerror.Location = new System.Drawing.Point(184, 348);
            this.labelerror.Name = "labelerror";
            this.labelerror.Size = new System.Drawing.Size(0, 13);
            this.labelerror.TabIndex = 30;
            // 
            // textBox2
            // 
            this.textBox2.AcceptsReturn = true;
            this.textBox2.Location = new System.Drawing.Point(21, 544);
            this.textBox2.MaxLength = 3;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(448, 20);
            this.textBox2.TabIndex = 31;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 528);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Copyable Output";
            // 
            // IVHP
            // 
            this.IVHP.AutoSize = true;
            this.IVHP.Location = new System.Drawing.Point(87, 485);
            this.IVHP.Name = "IVHP";
            this.IVHP.Size = new System.Drawing.Size(10, 13);
            this.IVHP.TabIndex = 33;
            this.IVHP.Text = "-";
            // 
            // IVATK
            // 
            this.IVATK.AutoSize = true;
            this.IVATK.Location = new System.Drawing.Point(142, 485);
            this.IVATK.Name = "IVATK";
            this.IVATK.Size = new System.Drawing.Size(10, 13);
            this.IVATK.TabIndex = 34;
            this.IVATK.Text = "-";
            // 
            // IVDEF
            // 
            this.IVDEF.AutoSize = true;
            this.IVDEF.Location = new System.Drawing.Point(195, 485);
            this.IVDEF.Name = "IVDEF";
            this.IVDEF.Size = new System.Drawing.Size(10, 13);
            this.IVDEF.TabIndex = 35;
            this.IVDEF.Text = "-";
            // 
            // IVSPATK
            // 
            this.IVSPATK.AutoSize = true;
            this.IVSPATK.Location = new System.Drawing.Point(256, 485);
            this.IVSPATK.Name = "IVSPATK";
            this.IVSPATK.Size = new System.Drawing.Size(10, 13);
            this.IVSPATK.TabIndex = 36;
            this.IVSPATK.Text = "-";
            // 
            // IVSPDEF
            // 
            this.IVSPDEF.AutoSize = true;
            this.IVSPDEF.Location = new System.Drawing.Point(313, 485);
            this.IVSPDEF.Name = "IVSPDEF";
            this.IVSPDEF.Size = new System.Drawing.Size(10, 13);
            this.IVSPDEF.TabIndex = 37;
            this.IVSPDEF.Text = "-";
            // 
            // IVSPD
            // 
            this.IVSPD.AutoSize = true;
            this.IVSPD.Location = new System.Drawing.Point(377, 485);
            this.IVSPD.Name = "IVSPD";
            this.IVSPD.Size = new System.Drawing.Size(10, 13);
            this.IVSPD.TabIndex = 38;
            this.IVSPD.Text = "-";
            this.IVSPD.Click += new System.EventHandler(this.IVSPD_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(370, 455);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 13);
            this.label12.TabIndex = 44;
            this.label12.Text = "SPD";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(305, 455);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "SPDEF";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(243, 455);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 13);
            this.label14.TabIndex = 42;
            this.label14.Text = "SPATK";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(190, 455);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(28, 13);
            this.label15.TabIndex = 41;
            this.label15.Text = "DEF";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(134, 455);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(28, 13);
            this.label16.TabIndex = 40;
            this.label16.Text = "ATK";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(85, 455);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(22, 13);
            this.label17.TabIndex = 39;
            this.label17.Text = "HP";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(187, 430);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(126, 13);
            this.label18.TabIndex = 45;
            this.label18.Text = "Your Pokemon\'s IVs are :";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // statHP
            // 
            this.statHP.AcceptsReturn = true;
            this.statHP.Location = new System.Drawing.Point(97, 237);
            this.statHP.MaxLength = 3;
            this.statHP.Name = "statHP";
            this.statHP.Size = new System.Drawing.Size(37, 20);
            this.statHP.TabIndex = 14;
            this.statHP.Text = "105";
            this.statHP.TextChanged += new System.EventHandler(this.statHP_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(308, 79);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(144, 133);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(493, 586);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.statHP);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.IVSPD);
            this.Controls.Add(this.IVSPDEF);
            this.Controls.Add(this.IVSPATK);
            this.Controls.Add(this.IVDEF);
            this.Controls.Add(this.IVATK);
            this.Controls.Add(this.IVHP);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelerror);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.BoxNature);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.imgSpecies);
            this.Controls.Add(this.EVSPD);
            this.Controls.Add(this.EVSPDEF);
            this.Controls.Add(this.EVSPATK);
            this.Controls.Add(this.EVDEF);
            this.Controls.Add(this.EVATK);
            this.Controls.Add(this.EVHP);
            this.Controls.Add(this.statSPD);
            this.Controls.Add(this.statSPDEF);
            this.Controls.Add(this.statSPATK);
            this.Controls.Add(this.statDEF);
            this.Controls.Add(this.statATK);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BoxLevel);
            this.Controls.Add(this.BoxSpecies);
            this.Controls.Add(this.labelLEVEL);
            this.Controls.Add(this.labelSPECIES);
            this.Controls.Add(this.imgHeader);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSpecies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imgHeader;
        private System.Windows.Forms.Label labelSPECIES;
        private System.Windows.Forms.Label labelLEVEL;
        private System.Windows.Forms.ComboBox BoxSpecies;
        private System.Windows.Forms.TextBox BoxLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox statATK;
        private System.Windows.Forms.TextBox statDEF;
        private System.Windows.Forms.TextBox statSPATK;
        private System.Windows.Forms.TextBox statSPDEF;
        private System.Windows.Forms.TextBox statSPD;
        private System.Windows.Forms.TextBox EVSPD;
        private System.Windows.Forms.TextBox EVSPDEF;
        private System.Windows.Forms.TextBox EVSPATK;
        private System.Windows.Forms.TextBox EVDEF;
        private System.Windows.Forms.TextBox EVATK;
        private System.Windows.Forms.TextBox EVHP;
        private System.Windows.Forms.PictureBox imgSpecies;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox BoxNature;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelerror;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label IVHP;
        private System.Windows.Forms.Label IVATK;
        private System.Windows.Forms.Label IVDEF;
        private System.Windows.Forms.Label IVSPATK;
        private System.Windows.Forms.Label IVSPDEF;
        private System.Windows.Forms.Label IVSPD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox statHP;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}


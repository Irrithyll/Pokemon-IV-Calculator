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
            this.BoxSpecies = new System.Windows.Forms.ComboBox();
            this.BoxLevel = new System.Windows.Forms.TextBox();
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
            this.BoxNature = new System.Windows.Forms.ComboBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.labelerror = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
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
            this.statHP = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imgSpecies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BoxSpecies
            // 
            this.BoxSpecies.AllowDrop = true;
            this.BoxSpecies.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.BoxSpecies.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoxSpecies.Font = new System.Drawing.Font("Power Green Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxSpecies.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BoxSpecies.FormattingEnabled = true;
            this.BoxSpecies.Location = new System.Drawing.Point(127, 108);
            this.BoxSpecies.Name = "BoxSpecies";
            this.BoxSpecies.Size = new System.Drawing.Size(173, 35);
            this.BoxSpecies.TabIndex = 4;
            this.BoxSpecies.SelectedIndexChanged += new System.EventHandler(this.BoxSpecies_SelectedIndexChanged);
            this.BoxSpecies.TextChanged += new System.EventHandler(this.BoxSpecies_TextChanged);
            // 
            // BoxLevel
            // 
            this.BoxLevel.AcceptsReturn = true;
            this.BoxLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.BoxLevel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BoxLevel.Cursor = System.Windows.Forms.Cursors.Default;
            this.BoxLevel.Font = new System.Drawing.Font("Power Green Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BoxLevel.Location = new System.Drawing.Point(127, 153);
            this.BoxLevel.MaxLength = 3;
            this.BoxLevel.Name = "BoxLevel";
            this.BoxLevel.Size = new System.Drawing.Size(50, 34);
            this.BoxLevel.TabIndex = 5;
            this.BoxLevel.Text = "50";
            this.BoxLevel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BoxLevel.TextChanged += new System.EventHandler(this.BoxLevel_TextChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Power Green Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.label7.Location = new System.Drawing.Point(254, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 27);
            this.label7.TabIndex = 11;
            this.label7.Text = "SPATK";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Power Green Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.label8.Location = new System.Drawing.Point(316, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 27);
            this.label8.TabIndex = 12;
            this.label8.Text = "SPDEF";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Power Green Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.label9.Location = new System.Drawing.Point(381, 194);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 27);
            this.label9.TabIndex = 13;
            this.label9.Text = "SPD";
            // 
            // statATK
            // 
            this.statATK.AcceptsReturn = true;
            this.statATK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.statATK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statATK.Font = new System.Drawing.Font("Power Green Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statATK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.statATK.Location = new System.Drawing.Point(150, 226);
            this.statATK.MaxLength = 3;
            this.statATK.Name = "statATK";
            this.statATK.Size = new System.Drawing.Size(50, 27);
            this.statATK.TabIndex = 15;
            this.statATK.Text = "66";
            this.statATK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.statATK.TextChanged += new System.EventHandler(this.statATK_TextChanged);
            // 
            // statDEF
            // 
            this.statDEF.AcceptsReturn = true;
            this.statDEF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.statDEF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statDEF.Font = new System.Drawing.Font("Power Green Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statDEF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.statDEF.Location = new System.Drawing.Point(204, 226);
            this.statDEF.MaxLength = 3;
            this.statDEF.Name = "statDEF";
            this.statDEF.Size = new System.Drawing.Size(50, 27);
            this.statDEF.TabIndex = 16;
            this.statDEF.Text = "66";
            this.statDEF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.statDEF.TextChanged += new System.EventHandler(this.statDEF_TextChanged);
            // 
            // statSPATK
            // 
            this.statSPATK.AcceptsReturn = true;
            this.statSPATK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.statSPATK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statSPATK.Font = new System.Drawing.Font("Power Green Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statSPATK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.statSPATK.Location = new System.Drawing.Point(264, 226);
            this.statSPATK.MaxLength = 3;
            this.statSPATK.Name = "statSPATK";
            this.statSPATK.Size = new System.Drawing.Size(50, 27);
            this.statSPATK.TabIndex = 17;
            this.statSPATK.Text = "77";
            this.statSPATK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.statSPATK.TextChanged += new System.EventHandler(this.statSPATK_TextChanged);
            // 
            // statSPDEF
            // 
            this.statSPDEF.AcceptsReturn = true;
            this.statSPDEF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.statSPDEF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statSPDEF.Font = new System.Drawing.Font("Power Green Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statSPDEF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.statSPDEF.Location = new System.Drawing.Point(326, 226);
            this.statSPDEF.MaxLength = 3;
            this.statSPDEF.Name = "statSPDEF";
            this.statSPDEF.Size = new System.Drawing.Size(50, 27);
            this.statSPDEF.TabIndex = 18;
            this.statSPDEF.Text = "78";
            this.statSPDEF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.statSPDEF.TextChanged += new System.EventHandler(this.statSPDEF_TextChanged);
            // 
            // statSPD
            // 
            this.statSPD.AcceptsReturn = true;
            this.statSPD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.statSPD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statSPD.Font = new System.Drawing.Font("Power Green Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statSPD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.statSPD.Location = new System.Drawing.Point(380, 226);
            this.statSPD.MaxLength = 3;
            this.statSPD.Name = "statSPD";
            this.statSPD.Size = new System.Drawing.Size(50, 27);
            this.statSPD.TabIndex = 19;
            this.statSPD.Text = "61";
            this.statSPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.statSPD.TextChanged += new System.EventHandler(this.statSPD_TextChanged);
            // 
            // EVSPD
            // 
            this.EVSPD.AcceptsReturn = true;
            this.EVSPD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.EVSPD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EVSPD.Font = new System.Drawing.Font("Power Green Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EVSPD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EVSPD.Location = new System.Drawing.Point(380, 259);
            this.EVSPD.MaxLength = 3;
            this.EVSPD.Name = "EVSPD";
            this.EVSPD.Size = new System.Drawing.Size(50, 27);
            this.EVSPD.TabIndex = 25;
            this.EVSPD.Text = "0";
            this.EVSPD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EVSPD.TextChanged += new System.EventHandler(this.EVSPD_TextChanged);
            // 
            // EVSPDEF
            // 
            this.EVSPDEF.AcceptsReturn = true;
            this.EVSPDEF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.EVSPDEF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EVSPDEF.Font = new System.Drawing.Font("Power Green Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EVSPDEF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EVSPDEF.Location = new System.Drawing.Point(326, 259);
            this.EVSPDEF.MaxLength = 3;
            this.EVSPDEF.Name = "EVSPDEF";
            this.EVSPDEF.Size = new System.Drawing.Size(50, 27);
            this.EVSPDEF.TabIndex = 24;
            this.EVSPDEF.Text = "0";
            this.EVSPDEF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EVSPDEF.TextChanged += new System.EventHandler(this.EVSPDEF_TextChanged);
            // 
            // EVSPATK
            // 
            this.EVSPATK.AcceptsReturn = true;
            this.EVSPATK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.EVSPATK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EVSPATK.Font = new System.Drawing.Font("Power Green Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EVSPATK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EVSPATK.Location = new System.Drawing.Point(264, 259);
            this.EVSPATK.MaxLength = 3;
            this.EVSPATK.Name = "EVSPATK";
            this.EVSPATK.Size = new System.Drawing.Size(50, 27);
            this.EVSPATK.TabIndex = 23;
            this.EVSPATK.Text = "0";
            this.EVSPATK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EVSPATK.TextChanged += new System.EventHandler(this.EVSPATK_TextChanged);
            // 
            // EVDEF
            // 
            this.EVDEF.AcceptsReturn = true;
            this.EVDEF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.EVDEF.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EVDEF.Font = new System.Drawing.Font("Power Green Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EVDEF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EVDEF.Location = new System.Drawing.Point(204, 259);
            this.EVDEF.MaxLength = 3;
            this.EVDEF.Name = "EVDEF";
            this.EVDEF.Size = new System.Drawing.Size(50, 27);
            this.EVDEF.TabIndex = 22;
            this.EVDEF.Text = "0";
            this.EVDEF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EVDEF.TextChanged += new System.EventHandler(this.EVDEF_TextChanged);
            // 
            // EVATK
            // 
            this.EVATK.AcceptsReturn = true;
            this.EVATK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.EVATK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EVATK.Font = new System.Drawing.Font("Power Green Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EVATK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EVATK.Location = new System.Drawing.Point(150, 259);
            this.EVATK.MaxLength = 3;
            this.EVATK.Name = "EVATK";
            this.EVATK.Size = new System.Drawing.Size(50, 27);
            this.EVATK.TabIndex = 21;
            this.EVATK.Text = "0";
            this.EVATK.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EVATK.TextChanged += new System.EventHandler(this.EVATK_TextChanged);
            // 
            // EVHP
            // 
            this.EVHP.AcceptsReturn = true;
            this.EVHP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.EVHP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EVHP.Font = new System.Drawing.Font("Power Green Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EVHP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.EVHP.Location = new System.Drawing.Point(97, 259);
            this.EVHP.MaxLength = 3;
            this.EVHP.Name = "EVHP";
            this.EVHP.Size = new System.Drawing.Size(50, 27);
            this.EVHP.TabIndex = 20;
            this.EVHP.Text = "0";
            this.EVHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EVHP.TextChanged += new System.EventHandler(this.EVHP_TextChanged);
            // 
            // imgSpecies
            // 
            this.imgSpecies.BackColor = System.Drawing.Color.Transparent;
            this.imgSpecies.Location = new System.Drawing.Point(339, 68);
            this.imgSpecies.Name = "imgSpecies";
            this.imgSpecies.Size = new System.Drawing.Size(112, 117);
            this.imgSpecies.TabIndex = 26;
            this.imgSpecies.TabStop = false;
            // 
            // BoxNature
            // 
            this.BoxNature.AllowDrop = true;
            this.BoxNature.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.BoxNature.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BoxNature.Font = new System.Drawing.Font("Power Green Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoxNature.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.BoxNature.FormattingEnabled = true;
            this.BoxNature.Location = new System.Drawing.Point(125, 312);
            this.BoxNature.Name = "BoxNature";
            this.BoxNature.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BoxNature.Size = new System.Drawing.Size(173, 35);
            this.BoxNature.TabIndex = 28;
            this.BoxNature.Text = "ADAMANT";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Font = new System.Drawing.Font("Power Green Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCalculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
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
            this.labelerror.Location = new System.Drawing.Point(38, 68);
            this.labelerror.Name = "labelerror";
            this.labelerror.Size = new System.Drawing.Size(0, 13);
            this.labelerror.TabIndex = 30;
            // 
            // textBox2
            // 
            this.textBox2.AcceptsReturn = true;
            this.textBox2.Location = new System.Drawing.Point(24, 560);
            this.textBox2.MaxLength = 3;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(361, 20);
            this.textBox2.TabIndex = 31;
            // 
            // IVHP
            // 
            this.IVHP.AutoSize = true;
            this.IVHP.BackColor = System.Drawing.Color.Transparent;
            this.IVHP.Font = new System.Drawing.Font("Power Green Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IVHP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.IVHP.Location = new System.Drawing.Point(94, 439);
            this.IVHP.Name = "IVHP";
            this.IVHP.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.IVHP.Size = new System.Drawing.Size(43, 27);
            this.IVHP.TabIndex = 33;
            this.IVHP.Text = "-";
            this.IVHP.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IVATK
            // 
            this.IVATK.AutoSize = true;
            this.IVATK.BackColor = System.Drawing.Color.Transparent;
            this.IVATK.Font = new System.Drawing.Font("Power Green Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IVATK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.IVATK.Location = new System.Drawing.Point(151, 439);
            this.IVATK.Name = "IVATK";
            this.IVATK.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.IVATK.Size = new System.Drawing.Size(43, 27);
            this.IVATK.TabIndex = 34;
            this.IVATK.Text = "-";
            this.IVATK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IVDEF
            // 
            this.IVDEF.AutoSize = true;
            this.IVDEF.BackColor = System.Drawing.Color.Transparent;
            this.IVDEF.Font = new System.Drawing.Font("Power Green Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IVDEF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.IVDEF.Location = new System.Drawing.Point(204, 439);
            this.IVDEF.Name = "IVDEF";
            this.IVDEF.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.IVDEF.Size = new System.Drawing.Size(43, 27);
            this.IVDEF.TabIndex = 35;
            this.IVDEF.Text = "-";
            this.IVDEF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IVSPATK
            // 
            this.IVSPATK.AutoSize = true;
            this.IVSPATK.BackColor = System.Drawing.Color.Transparent;
            this.IVSPATK.Font = new System.Drawing.Font("Power Green Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IVSPATK.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.IVSPATK.Location = new System.Drawing.Point(265, 439);
            this.IVSPATK.Name = "IVSPATK";
            this.IVSPATK.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.IVSPATK.Size = new System.Drawing.Size(43, 27);
            this.IVSPATK.TabIndex = 36;
            this.IVSPATK.Text = "-";
            this.IVSPATK.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IVSPDEF
            // 
            this.IVSPDEF.AutoSize = true;
            this.IVSPDEF.BackColor = System.Drawing.Color.Transparent;
            this.IVSPDEF.Font = new System.Drawing.Font("Power Green Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IVSPDEF.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.IVSPDEF.Location = new System.Drawing.Point(322, 439);
            this.IVSPDEF.Name = "IVSPDEF";
            this.IVSPDEF.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.IVSPDEF.Size = new System.Drawing.Size(43, 27);
            this.IVSPDEF.TabIndex = 37;
            this.IVSPDEF.Text = "-";
            this.IVSPDEF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IVSPD
            // 
            this.IVSPD.AutoSize = true;
            this.IVSPD.BackColor = System.Drawing.Color.Transparent;
            this.IVSPD.Font = new System.Drawing.Font("Power Green Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IVSPD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.IVSPD.Location = new System.Drawing.Point(386, 439);
            this.IVSPD.Name = "IVSPD";
            this.IVSPD.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.IVSPD.Size = new System.Drawing.Size(43, 27);
            this.IVSPD.TabIndex = 38;
            this.IVSPD.Text = "-";
            this.IVSPD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IVSPD.Click += new System.EventHandler(this.IVSPD_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Power Green Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.label12.Location = new System.Drawing.Point(383, 412);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 27);
            this.label12.TabIndex = 44;
            this.label12.Text = "SPD";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Power Green Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.label13.Location = new System.Drawing.Point(318, 412);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 27);
            this.label13.TabIndex = 43;
            this.label13.Text = "SPDEF";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Power Green Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.label14.Location = new System.Drawing.Point(256, 412);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 27);
            this.label14.TabIndex = 42;
            this.label14.Text = "SPATK";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Power Green Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.label15.Location = new System.Drawing.Point(203, 412);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 27);
            this.label15.TabIndex = 41;
            this.label15.Text = "DEF";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Power Green Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.label16.Location = new System.Drawing.Point(147, 412);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 27);
            this.label16.TabIndex = 40;
            this.label16.Text = "ATK";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Power Green Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.label17.Location = new System.Drawing.Point(98, 412);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(34, 27);
            this.label17.TabIndex = 39;
            this.label17.Text = "HP";
            // 
            // statHP
            // 
            this.statHP.AcceptsReturn = true;
            this.statHP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.statHP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statHP.Font = new System.Drawing.Font("Power Green Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statHP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.statHP.Location = new System.Drawing.Point(97, 226);
            this.statHP.MaxLength = 3;
            this.statHP.Name = "statHP";
            this.statHP.Size = new System.Drawing.Size(50, 27);
            this.statHP.TabIndex = 14;
            this.statHP.Text = "105";
            this.statHP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.statHP.TextChanged += new System.EventHandler(this.statHP_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(442, 292);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(144, 133);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Power Green Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.label6.Location = new System.Drawing.Point(201, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 27);
            this.label6.TabIndex = 10;
            this.label6.Text = "DEF";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Power Green Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.label5.Location = new System.Drawing.Point(145, 194);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 27);
            this.label5.TabIndex = 9;
            this.label5.Text = "ATK";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Power Green Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.label4.Location = new System.Drawing.Point(96, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 27);
            this.label4.TabIndex = 8;
            this.label4.Text = "HP";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Power Green Small", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.button1.Location = new System.Drawing.Point(390, 554);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 33);
            this.button1.TabIndex = 48;
            this.button1.Text = "COPY";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(493, 586);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.statHP);
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
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelerror);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.BoxNature);
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
            this.Controls.Add(this.BoxLevel);
            this.Controls.Add(this.BoxSpecies);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imgSpecies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox BoxSpecies;
        private System.Windows.Forms.TextBox BoxLevel;
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
        private System.Windows.Forms.ComboBox BoxNature;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label labelerror;
        private System.Windows.Forms.TextBox textBox2;
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
        private System.Windows.Forms.TextBox statHP;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}


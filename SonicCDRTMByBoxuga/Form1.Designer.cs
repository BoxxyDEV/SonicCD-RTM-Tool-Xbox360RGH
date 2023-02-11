namespace SonicUnleashedRTMByBoxuga
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ConnectButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StatsGroupbox = new System.Windows.Forms.GroupBox();
            this.refreshbtn = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.LivesStat = new System.Windows.Forms.Label();
            this.ScoreStat = new System.Windows.Forms.Label();
            this.ScoreBox = new System.Windows.Forms.GroupBox();
            this.CustomScoreBTN = new System.Windows.Forms.Button();
            this.CustomScoreNum = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.NineNineNineKScore = new System.Windows.Forms.Button();
            this.FiveHundredKScore = new System.Windows.Forms.Button();
            this.OneHundredKScore = new System.Windows.Forms.Button();
            this.ScoreNineNineNineHundred = new System.Windows.Forms.Button();
            this.ZeroScore = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.SetRingsCustomBTN = new System.Windows.Forms.Button();
            this.RingsCustomNum = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.NineNineNineRings = new System.Windows.Forms.Button();
            this.HundredFiveRings = new System.Windows.Forms.Button();
            this.HundredRings = new System.Windows.Forms.Button();
            this.FiveZeroRings = new System.Windows.Forms.Button();
            this.NoRings = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LivesEditorbtn = new System.Windows.Forms.Button();
            this.LivesEditorNum = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Boxudotga = new System.Windows.Forms.Button();
            this.actions = new System.Windows.Forms.Label();
            this.stattimer = new System.Windows.Forms.Timer(this.components);
            this.YTBoxuga = new System.Windows.Forms.Button();
            this.UpdateCheckerBTN = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.StatsGroupbox.SuspendLayout();
            this.ScoreBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomScoreNum)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RingsCustomNum)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LivesEditorNum)).BeginInit();
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.BackColor = System.Drawing.Color.White;
            this.ConnectButton.ForeColor = System.Drawing.Color.Black;
            this.ConnectButton.Location = new System.Drawing.Point(12, 12);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(75, 23);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = false;
            this.ConnectButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Enabled = false;
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(88, 49);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "99 Lives";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.StatsGroupbox);
            this.groupBox1.Controls.Add(this.ScoreBox);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(12, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 279);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mods";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // StatsGroupbox
            // 
            this.StatsGroupbox.Controls.Add(this.refreshbtn);
            this.StatsGroupbox.Controls.Add(this.checkBox1);
            this.StatsGroupbox.Controls.Add(this.LivesStat);
            this.StatsGroupbox.Controls.Add(this.ScoreStat);
            this.StatsGroupbox.Location = new System.Drawing.Point(226, 138);
            this.StatsGroupbox.Name = "StatsGroupbox";
            this.StatsGroupbox.Size = new System.Drawing.Size(238, 135);
            this.StatsGroupbox.TabIndex = 5;
            this.StatsGroupbox.TabStop = false;
            this.StatsGroupbox.Text = "Current Stats";
            // 
            // refreshbtn
            // 
            this.refreshbtn.Enabled = false;
            this.refreshbtn.Location = new System.Drawing.Point(157, 101);
            this.refreshbtn.Name = "refreshbtn";
            this.refreshbtn.Size = new System.Drawing.Size(75, 23);
            this.refreshbtn.TabIndex = 4;
            this.refreshbtn.Text = "Refresh";
            this.refreshbtn.UseVisualStyleBackColor = true;
            this.refreshbtn.Click += new System.EventHandler(this.refreshbtn_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Enabled = false;
            this.checkBox1.Location = new System.Drawing.Point(7, 109);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(88, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "Auto Refresh";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // LivesStat
            // 
            this.LivesStat.AutoSize = true;
            this.LivesStat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LivesStat.Location = new System.Drawing.Point(6, 50);
            this.LivesStat.Name = "LivesStat";
            this.LivesStat.Size = new System.Drawing.Size(155, 21);
            this.LivesStat.TabIndex = 2;
            this.LivesStat.Text = "Lives: Connect First";
            // 
            // ScoreStat
            // 
            this.ScoreStat.AutoSize = true;
            this.ScoreStat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreStat.Location = new System.Drawing.Point(6, 21);
            this.ScoreStat.Name = "ScoreStat";
            this.ScoreStat.Size = new System.Drawing.Size(159, 21);
            this.ScoreStat.TabIndex = 1;
            this.ScoreStat.Text = "Score: Connect First";
            // 
            // ScoreBox
            // 
            this.ScoreBox.Controls.Add(this.CustomScoreBTN);
            this.ScoreBox.Controls.Add(this.CustomScoreNum);
            this.ScoreBox.Controls.Add(this.label3);
            this.ScoreBox.Controls.Add(this.NineNineNineKScore);
            this.ScoreBox.Controls.Add(this.FiveHundredKScore);
            this.ScoreBox.Controls.Add(this.OneHundredKScore);
            this.ScoreBox.Controls.Add(this.ScoreNineNineNineHundred);
            this.ScoreBox.Controls.Add(this.ZeroScore);
            this.ScoreBox.Location = new System.Drawing.Point(6, 138);
            this.ScoreBox.Name = "ScoreBox";
            this.ScoreBox.Size = new System.Drawing.Size(214, 135);
            this.ScoreBox.TabIndex = 4;
            this.ScoreBox.TabStop = false;
            this.ScoreBox.Text = "Score";
            // 
            // CustomScoreBTN
            // 
            this.CustomScoreBTN.Enabled = false;
            this.CustomScoreBTN.Location = new System.Drawing.Point(110, 104);
            this.CustomScoreBTN.Name = "CustomScoreBTN";
            this.CustomScoreBTN.Size = new System.Drawing.Size(96, 23);
            this.CustomScoreBTN.TabIndex = 7;
            this.CustomScoreBTN.Text = "Set";
            this.CustomScoreBTN.UseVisualStyleBackColor = true;
            this.CustomScoreBTN.Click += new System.EventHandler(this.CustomScoreBTN_Click);
            // 
            // CustomScoreNum
            // 
            this.CustomScoreNum.Enabled = false;
            this.CustomScoreNum.Location = new System.Drawing.Point(6, 107);
            this.CustomScoreNum.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.CustomScoreNum.Name = "CustomScoreNum";
            this.CustomScoreNum.Size = new System.Drawing.Size(98, 20);
            this.CustomScoreNum.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Custom";
            // 
            // NineNineNineKScore
            // 
            this.NineNineNineKScore.Enabled = false;
            this.NineNineNineKScore.Location = new System.Drawing.Point(110, 78);
            this.NineNineNineKScore.Name = "NineNineNineKScore";
            this.NineNineNineKScore.Size = new System.Drawing.Size(97, 23);
            this.NineNineNineKScore.TabIndex = 4;
            this.NineNineNineKScore.Text = "999k Score";
            this.NineNineNineKScore.UseVisualStyleBackColor = true;
            this.NineNineNineKScore.Click += new System.EventHandler(this.NineNineNineKScore_Click);
            // 
            // FiveHundredKScore
            // 
            this.FiveHundredKScore.Enabled = false;
            this.FiveHundredKScore.Location = new System.Drawing.Point(111, 49);
            this.FiveHundredKScore.Name = "FiveHundredKScore";
            this.FiveHundredKScore.Size = new System.Drawing.Size(97, 23);
            this.FiveHundredKScore.TabIndex = 3;
            this.FiveHundredKScore.Text = "500k Score";
            this.FiveHundredKScore.UseVisualStyleBackColor = true;
            this.FiveHundredKScore.Click += new System.EventHandler(this.FiveHundredKScore_Click);
            // 
            // OneHundredKScore
            // 
            this.OneHundredKScore.Enabled = false;
            this.OneHundredKScore.Location = new System.Drawing.Point(7, 49);
            this.OneHundredKScore.Name = "OneHundredKScore";
            this.OneHundredKScore.Size = new System.Drawing.Size(97, 23);
            this.OneHundredKScore.TabIndex = 2;
            this.OneHundredKScore.Text = "100k Score";
            this.OneHundredKScore.UseVisualStyleBackColor = true;
            this.OneHundredKScore.Click += new System.EventHandler(this.OneHundredKScore_Click);
            // 
            // ScoreNineNineNineHundred
            // 
            this.ScoreNineNineNineHundred.Enabled = false;
            this.ScoreNineNineNineHundred.Location = new System.Drawing.Point(110, 19);
            this.ScoreNineNineNineHundred.Name = "ScoreNineNineNineHundred";
            this.ScoreNineNineNineHundred.Size = new System.Drawing.Size(98, 23);
            this.ScoreNineNineNineHundred.TabIndex = 1;
            this.ScoreNineNineNineHundred.Text = "999 Score";
            this.ScoreNineNineNineHundred.UseVisualStyleBackColor = true;
            this.ScoreNineNineNineHundred.Click += new System.EventHandler(this.ScoreNineNineNineHundred_Click);
            // 
            // ZeroScore
            // 
            this.ZeroScore.Enabled = false;
            this.ZeroScore.Location = new System.Drawing.Point(6, 19);
            this.ZeroScore.Name = "ZeroScore";
            this.ZeroScore.Size = new System.Drawing.Size(98, 23);
            this.ZeroScore.TabIndex = 0;
            this.ZeroScore.Text = "0 Score";
            this.ZeroScore.UseVisualStyleBackColor = true;
            this.ZeroScore.Click += new System.EventHandler(this.ZeroScore_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.SetRingsCustomBTN);
            this.groupBox3.Controls.Add(this.RingsCustomNum);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.NineNineNineRings);
            this.groupBox3.Controls.Add(this.HundredFiveRings);
            this.groupBox3.Controls.Add(this.HundredRings);
            this.groupBox3.Controls.Add(this.FiveZeroRings);
            this.groupBox3.Controls.Add(this.NoRings);
            this.groupBox3.Location = new System.Drawing.Point(226, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 112);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Rings";
            // 
            // SetRingsCustomBTN
            // 
            this.SetRingsCustomBTN.Location = new System.Drawing.Point(159, 78);
            this.SetRingsCustomBTN.Name = "SetRingsCustomBTN";
            this.SetRingsCustomBTN.Size = new System.Drawing.Size(64, 23);
            this.SetRingsCustomBTN.TabIndex = 8;
            this.SetRingsCustomBTN.Text = "Set";
            this.SetRingsCustomBTN.UseVisualStyleBackColor = true;
            this.SetRingsCustomBTN.Click += new System.EventHandler(this.SetRingsCustomBTN_Click);
            // 
            // RingsCustomNum
            // 
            this.RingsCustomNum.Enabled = false;
            this.RingsCustomNum.Location = new System.Drawing.Point(9, 81);
            this.RingsCustomNum.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.RingsCustomNum.Name = "RingsCustomNum";
            this.RingsCustomNum.Size = new System.Drawing.Size(143, 20);
            this.RingsCustomNum.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 18);
            this.label2.TabIndex = 7;
            this.label2.Text = "Custom";
            // 
            // NineNineNineRings
            // 
            this.NineNineNineRings.Enabled = false;
            this.NineNineNineRings.Location = new System.Drawing.Point(158, 49);
            this.NineNineNineRings.Name = "NineNineNineRings";
            this.NineNineNineRings.Size = new System.Drawing.Size(65, 23);
            this.NineNineNineRings.TabIndex = 4;
            this.NineNineNineRings.Text = "999 Rings";
            this.NineNineNineRings.UseVisualStyleBackColor = true;
            this.NineNineNineRings.Click += new System.EventHandler(this.NineNineNineRings_Click);
            // 
            // HundredFiveRings
            // 
            this.HundredFiveRings.Enabled = false;
            this.HundredFiveRings.Location = new System.Drawing.Point(85, 49);
            this.HundredFiveRings.Name = "HundredFiveRings";
            this.HundredFiveRings.Size = new System.Drawing.Size(67, 23);
            this.HundredFiveRings.TabIndex = 3;
            this.HundredFiveRings.Text = "150 Rings";
            this.HundredFiveRings.UseVisualStyleBackColor = true;
            this.HundredFiveRings.Click += new System.EventHandler(this.HundredFiveRings_Click);
            // 
            // HundredRings
            // 
            this.HundredRings.Enabled = false;
            this.HundredRings.Location = new System.Drawing.Point(158, 20);
            this.HundredRings.Name = "HundredRings";
            this.HundredRings.Size = new System.Drawing.Size(66, 23);
            this.HundredRings.TabIndex = 2;
            this.HundredRings.Text = "100 Rings";
            this.HundredRings.UseVisualStyleBackColor = true;
            this.HundredRings.Click += new System.EventHandler(this.HundredRings_Click);
            // 
            // FiveZeroRings
            // 
            this.FiveZeroRings.Enabled = false;
            this.FiveZeroRings.Location = new System.Drawing.Point(85, 20);
            this.FiveZeroRings.Name = "FiveZeroRings";
            this.FiveZeroRings.Size = new System.Drawing.Size(67, 23);
            this.FiveZeroRings.TabIndex = 1;
            this.FiveZeroRings.Text = "50 Rings";
            this.FiveZeroRings.UseVisualStyleBackColor = true;
            this.FiveZeroRings.Click += new System.EventHandler(this.FiveZeroRings_Click);
            // 
            // NoRings
            // 
            this.NoRings.Enabled = false;
            this.NoRings.Location = new System.Drawing.Point(6, 21);
            this.NoRings.Name = "NoRings";
            this.NoRings.Size = new System.Drawing.Size(73, 23);
            this.NoRings.TabIndex = 0;
            this.NoRings.Text = "0 Rings";
            this.NoRings.UseVisualStyleBackColor = true;
            this.NoRings.Click += new System.EventHandler(this.NoRings_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.LivesEditorbtn);
            this.groupBox2.Controls.Add(this.LivesEditorNum);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(6, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(214, 112);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lives";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "Custom";
            // 
            // LivesEditorbtn
            // 
            this.LivesEditorbtn.Enabled = false;
            this.LivesEditorbtn.Location = new System.Drawing.Point(88, 78);
            this.LivesEditorbtn.Name = "LivesEditorbtn";
            this.LivesEditorbtn.Size = new System.Drawing.Size(75, 23);
            this.LivesEditorbtn.TabIndex = 5;
            this.LivesEditorbtn.Text = "Set";
            this.LivesEditorbtn.UseVisualStyleBackColor = true;
            this.LivesEditorbtn.Click += new System.EventHandler(this.LivesEditorbtn_Click);
            // 
            // LivesEditorNum
            // 
            this.LivesEditorNum.Enabled = false;
            this.LivesEditorNum.Location = new System.Drawing.Point(6, 78);
            this.LivesEditorNum.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.LivesEditorNum.Name = "LivesEditorNum";
            this.LivesEditorNum.Size = new System.Drawing.Size(74, 20);
            this.LivesEditorNum.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(88, 19);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "50 Lives";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(6, 20);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "0 Lives";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Boxudotga
            // 
            this.Boxudotga.ForeColor = System.Drawing.Color.Black;
            this.Boxudotga.Location = new System.Drawing.Point(491, 70);
            this.Boxudotga.Name = "Boxudotga";
            this.Boxudotga.Size = new System.Drawing.Size(112, 23);
            this.Boxudotga.TabIndex = 5;
            this.Boxudotga.Text = "Boxuga\'s Site";
            this.Boxudotga.UseVisualStyleBackColor = true;
            this.Boxudotga.Click += new System.EventHandler(this.Boxudotga_Click);
            // 
            // actions
            // 
            this.actions.AutoSize = true;
            this.actions.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actions.Location = new System.Drawing.Point(14, 332);
            this.actions.Name = "actions";
            this.actions.Size = new System.Drawing.Size(82, 21);
            this.actions.TabIndex = 6;
            this.actions.Text = "Welcome";
            // 
            // stattimer
            // 
            this.stattimer.Interval = 1000;
            this.stattimer.Tick += new System.EventHandler(this.stattimer_Tick);
            // 
            // YTBoxuga
            // 
            this.YTBoxuga.BackColor = System.Drawing.Color.White;
            this.YTBoxuga.ForeColor = System.Drawing.Color.Black;
            this.YTBoxuga.Location = new System.Drawing.Point(491, 41);
            this.YTBoxuga.Name = "YTBoxuga";
            this.YTBoxuga.Size = new System.Drawing.Size(112, 23);
            this.YTBoxuga.TabIndex = 3;
            this.YTBoxuga.Text = "Boxuga\'s YouTube";
            this.YTBoxuga.UseVisualStyleBackColor = false;
            this.YTBoxuga.Click += new System.EventHandler(this.YTBoxuga_Click);
            // 
            // UpdateCheckerBTN
            // 
            this.UpdateCheckerBTN.BackColor = System.Drawing.Color.White;
            this.UpdateCheckerBTN.ForeColor = System.Drawing.Color.Black;
            this.UpdateCheckerBTN.Location = new System.Drawing.Point(491, 105);
            this.UpdateCheckerBTN.Name = "UpdateCheckerBTN";
            this.UpdateCheckerBTN.Size = new System.Drawing.Size(112, 23);
            this.UpdateCheckerBTN.TabIndex = 7;
            this.UpdateCheckerBTN.Text = "Check for Updates";
            this.UpdateCheckerBTN.UseVisualStyleBackColor = false;
            this.UpdateCheckerBTN.Click += new System.EventHandler(this.UpdateCheckerBTN_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(615, 362);
            this.Controls.Add(this.UpdateCheckerBTN);
            this.Controls.Add(this.actions);
            this.Controls.Add(this.Boxudotga);
            this.Controls.Add(this.YTBoxuga);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ConnectButton);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sonic CD (Mod Tool) for Xbox 360 RGH/JTAG By Boxuga";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.StatsGroupbox.ResumeLayout(false);
            this.StatsGroupbox.PerformLayout();
            this.ScoreBox.ResumeLayout(false);
            this.ScoreBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomScoreNum)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RingsCustomNum)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LivesEditorNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button NineNineNineRings;
        private System.Windows.Forms.Button HundredFiveRings;
        private System.Windows.Forms.Button HundredRings;
        private System.Windows.Forms.Button FiveZeroRings;
        private System.Windows.Forms.Button NoRings;
        private System.Windows.Forms.Button Boxudotga;
        private System.Windows.Forms.Button LivesEditorbtn;
        private System.Windows.Forms.NumericUpDown LivesEditorNum;
        private System.Windows.Forms.Label actions;
        private System.Windows.Forms.Button SetRingsCustomBTN;
        private System.Windows.Forms.NumericUpDown RingsCustomNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox ScoreBox;
        private System.Windows.Forms.Button CustomScoreBTN;
        private System.Windows.Forms.NumericUpDown CustomScoreNum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button NineNineNineKScore;
        private System.Windows.Forms.Button FiveHundredKScore;
        private System.Windows.Forms.Button OneHundredKScore;
        private System.Windows.Forms.Button ScoreNineNineNineHundred;
        private System.Windows.Forms.Button ZeroScore;
        private System.Windows.Forms.GroupBox StatsGroupbox;
        private System.Windows.Forms.Label LivesStat;
        private System.Windows.Forms.Label ScoreStat;
        private System.Windows.Forms.Timer stattimer;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button refreshbtn;
        private System.Windows.Forms.Button YTBoxuga;
        private System.Windows.Forms.Button UpdateCheckerBTN;
    }
}


namespace RTS_game
{
    partial class RTSGame
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnSaveStats = new System.Windows.Forms.Button();
            this.grpUnit = new System.Windows.Forms.GroupBox();
            this.lblUnitDisplay = new System.Windows.Forms.Label();
            this.grpStats = new System.Windows.Forms.GroupBox();
            this.lblSpeedStat = new System.Windows.Forms.Label();
            this.lblHealthStat = new System.Windows.Forms.Label();
            this.lblRangeStat = new System.Windows.Forms.Label();
            this.lblAttackStat = new System.Windows.Forms.Label();
            this.lblBonus = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtRangeBonus = new System.Windows.Forms.TextBox();
            this.txtSpeedBonus = new System.Windows.Forms.TextBox();
            this.txtAttackBonus = new System.Windows.Forms.TextBox();
            this.txtHealthBonus = new System.Windows.Forms.TextBox();
            this.lblRange = new System.Windows.Forms.Label();
            this.lblAttack = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.grpMap = new System.Windows.Forms.GroupBox();
            this.TxtMapDisplay = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblTimeDisplay = new System.Windows.Forms.Label();
            this.btnHeal = new System.Windows.Forms.Button();
            this.btnKill = new System.Windows.Forms.Button();
            this.radioCalm = new System.Windows.Forms.RadioButton();
            this.radioFury = new System.Windows.Forms.RadioButton();
            this.radioFear = new System.Windows.Forms.RadioButton();
            this.radioCourage = new System.Windows.Forms.RadioButton();
            this.grpEffects = new System.Windows.Forms.GroupBox();
            this.fileMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendFeedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpUnit.SuspendLayout();
            this.grpStats.SuspendLayout();
            this.grpMap.SuspendLayout();
            this.grpEffects.SuspendLayout();
            this.fileMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(18, 541);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(151, 64);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnPause
            // 
            this.btnPause.Enabled = false;
            this.btnPause.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(18, 472);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(70, 63);
            this.btnPause.TabIndex = 5;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnSaveStats
            // 
            this.btnSaveStats.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveStats.Location = new System.Drawing.Point(66, 170);
            this.btnSaveStats.Name = "btnSaveStats";
            this.btnSaveStats.Size = new System.Drawing.Size(90, 29);
            this.btnSaveStats.TabIndex = 22;
            this.btnSaveStats.Text = "Save";
            this.btnSaveStats.UseVisualStyleBackColor = true;
            // 
            // grpUnit
            // 
            this.grpUnit.Controls.Add(this.lblUnitDisplay);
            this.grpUnit.Enabled = false;
            this.grpUnit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUnit.Location = new System.Drawing.Point(12, 27);
            this.grpUnit.Name = "grpUnit";
            this.grpUnit.Size = new System.Drawing.Size(162, 115);
            this.grpUnit.TabIndex = 22;
            this.grpUnit.TabStop = false;
            this.grpUnit.Text = "Unit";
            // 
            // lblUnitDisplay
            // 
            this.lblUnitDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblUnitDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUnitDisplay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnitDisplay.Location = new System.Drawing.Point(6, 23);
            this.lblUnitDisplay.Name = "lblUnitDisplay";
            this.lblUnitDisplay.Size = new System.Drawing.Size(150, 86);
            this.lblUnitDisplay.TabIndex = 1;
            this.lblUnitDisplay.Text = "Name: Borris\r\nClass: Warrior\r\nFaction: Sunlander";
            this.lblUnitDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // grpStats
            // 
            this.grpStats.Controls.Add(this.lblSpeedStat);
            this.grpStats.Controls.Add(this.lblHealthStat);
            this.grpStats.Controls.Add(this.lblRangeStat);
            this.grpStats.Controls.Add(this.lblAttackStat);
            this.grpStats.Controls.Add(this.lblBonus);
            this.grpStats.Controls.Add(this.lblTotal);
            this.grpStats.Controls.Add(this.txtRangeBonus);
            this.grpStats.Controls.Add(this.txtSpeedBonus);
            this.grpStats.Controls.Add(this.txtAttackBonus);
            this.grpStats.Controls.Add(this.txtHealthBonus);
            this.grpStats.Controls.Add(this.lblRange);
            this.grpStats.Controls.Add(this.lblAttack);
            this.grpStats.Controls.Add(this.btnSaveStats);
            this.grpStats.Controls.Add(this.lblSpeed);
            this.grpStats.Controls.Add(this.lblHealth);
            this.grpStats.Enabled = false;
            this.grpStats.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStats.Location = new System.Drawing.Point(12, 148);
            this.grpStats.Name = "grpStats";
            this.grpStats.Size = new System.Drawing.Size(162, 206);
            this.grpStats.TabIndex = 23;
            this.grpStats.TabStop = false;
            this.grpStats.Text = "Stats";
            // 
            // lblSpeedStat
            // 
            this.lblSpeedStat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblSpeedStat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSpeedStat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeedStat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblSpeedStat.Location = new System.Drawing.Point(66, 137);
            this.lblSpeedStat.Name = "lblSpeedStat";
            this.lblSpeedStat.Size = new System.Drawing.Size(40, 27);
            this.lblSpeedStat.TabIndex = 43;
            this.lblSpeedStat.Text = "1";
            this.lblSpeedStat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHealthStat
            // 
            this.lblHealthStat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblHealthStat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblHealthStat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealthStat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblHealthStat.Location = new System.Drawing.Point(66, 35);
            this.lblHealthStat.Name = "lblHealthStat";
            this.lblHealthStat.Size = new System.Drawing.Size(40, 27);
            this.lblHealthStat.TabIndex = 42;
            this.lblHealthStat.Text = "87";
            this.lblHealthStat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblRangeStat
            // 
            this.lblRangeStat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRangeStat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRangeStat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRangeStat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblRangeStat.Location = new System.Drawing.Point(66, 104);
            this.lblRangeStat.Name = "lblRangeStat";
            this.lblRangeStat.Size = new System.Drawing.Size(40, 27);
            this.lblRangeStat.TabIndex = 41;
            this.lblRangeStat.Text = "2";
            this.lblRangeStat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAttackStat
            // 
            this.lblAttackStat.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAttackStat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAttackStat.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttackStat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblAttackStat.Location = new System.Drawing.Point(66, 68);
            this.lblAttackStat.Name = "lblAttackStat";
            this.lblAttackStat.Size = new System.Drawing.Size(40, 27);
            this.lblAttackStat.TabIndex = 40;
            this.lblAttackStat.Text = "57";
            this.lblAttackStat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBonus
            // 
            this.lblBonus.AutoSize = true;
            this.lblBonus.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBonus.Location = new System.Drawing.Point(111, 17);
            this.lblBonus.Name = "lblBonus";
            this.lblBonus.Size = new System.Drawing.Size(46, 15);
            this.lblBonus.TabIndex = 39;
            this.lblBonus.Text = "Bonus: ";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(65, 17);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(39, 15);
            this.lblTotal.TabIndex = 38;
            this.lblTotal.Text = "Total: ";
            // 
            // txtRangeBonus
            // 
            this.txtRangeBonus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRangeBonus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRangeBonus.Location = new System.Drawing.Point(116, 104);
            this.txtRangeBonus.Name = "txtRangeBonus";
            this.txtRangeBonus.Size = new System.Drawing.Size(40, 27);
            this.txtRangeBonus.TabIndex = 37;
            this.txtRangeBonus.Text = "+1";
            this.txtRangeBonus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSpeedBonus
            // 
            this.txtSpeedBonus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSpeedBonus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpeedBonus.Location = new System.Drawing.Point(116, 137);
            this.txtSpeedBonus.Name = "txtSpeedBonus";
            this.txtSpeedBonus.Size = new System.Drawing.Size(40, 27);
            this.txtSpeedBonus.TabIndex = 36;
            this.txtSpeedBonus.Text = "-1";
            this.txtSpeedBonus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAttackBonus
            // 
            this.txtAttackBonus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAttackBonus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAttackBonus.Location = new System.Drawing.Point(116, 68);
            this.txtAttackBonus.Name = "txtAttackBonus";
            this.txtAttackBonus.Size = new System.Drawing.Size(40, 27);
            this.txtAttackBonus.TabIndex = 35;
            this.txtAttackBonus.Text = "+7";
            this.txtAttackBonus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtHealthBonus
            // 
            this.txtHealthBonus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtHealthBonus.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHealthBonus.Location = new System.Drawing.Point(116, 35);
            this.txtHealthBonus.Name = "txtHealthBonus";
            this.txtHealthBonus.Size = new System.Drawing.Size(40, 27);
            this.txtHealthBonus.TabIndex = 34;
            this.txtHealthBonus.Text = "-13";
            this.txtHealthBonus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRange
            // 
            this.lblRange.AutoSize = true;
            this.lblRange.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRange.Location = new System.Drawing.Point(6, 107);
            this.lblRange.Name = "lblRange";
            this.lblRange.Size = new System.Drawing.Size(54, 19);
            this.lblRange.TabIndex = 33;
            this.lblRange.Text = "Range:";
            // 
            // lblAttack
            // 
            this.lblAttack.AutoSize = true;
            this.lblAttack.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttack.Location = new System.Drawing.Point(6, 71);
            this.lblAttack.Name = "lblAttack";
            this.lblAttack.Size = new System.Drawing.Size(54, 19);
            this.lblAttack.TabIndex = 32;
            this.lblAttack.Text = "Attack:";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.Location = new System.Drawing.Point(6, 140);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(52, 19);
            this.lblSpeed.TabIndex = 31;
            this.lblSpeed.Text = "Speed:";
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth.Location = new System.Drawing.Point(6, 38);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(56, 19);
            this.lblHealth.TabIndex = 30;
            this.lblHealth.Text = "Health:";
            // 
            // grpMap
            // 
            this.grpMap.Controls.Add(this.TxtMapDisplay);
            this.grpMap.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMap.Location = new System.Drawing.Point(180, 27);
            this.grpMap.Name = "grpMap";
            this.grpMap.Size = new System.Drawing.Size(308, 578);
            this.grpMap.TabIndex = 26;
            this.grpMap.TabStop = false;
            this.grpMap.Text = "Map";
            // 
            // TxtMapDisplay
            // 
            this.TxtMapDisplay.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtMapDisplay.Location = new System.Drawing.Point(6, 23);
            this.TxtMapDisplay.Name = "TxtMapDisplay";
            this.TxtMapDisplay.Size = new System.Drawing.Size(296, 549);
            this.TxtMapDisplay.TabIndex = 0;
            this.TxtMapDisplay.Text = "";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblTimeDisplay
            // 
            this.lblTimeDisplay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTimeDisplay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTimeDisplay.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimeDisplay.Location = new System.Drawing.Point(97, 472);
            this.lblTimeDisplay.Name = "lblTimeDisplay";
            this.lblTimeDisplay.Size = new System.Drawing.Size(71, 63);
            this.lblTimeDisplay.TabIndex = 27;
            this.lblTimeDisplay.Text = "Time:\r\n0:00";
            this.lblTimeDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnHeal
            // 
            this.btnHeal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHeal.Location = new System.Drawing.Point(6, 69);
            this.btnHeal.Name = "btnHeal";
            this.btnHeal.Size = new System.Drawing.Size(70, 30);
            this.btnHeal.TabIndex = 24;
            this.btnHeal.Text = "Heal";
            this.btnHeal.UseVisualStyleBackColor = true;
            // 
            // btnKill
            // 
            this.btnKill.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKill.Location = new System.Drawing.Point(86, 69);
            this.btnKill.Name = "btnKill";
            this.btnKill.Size = new System.Drawing.Size(71, 30);
            this.btnKill.TabIndex = 30;
            this.btnKill.Text = "Kill";
            this.btnKill.UseVisualStyleBackColor = true;
            // 
            // radioCalm
            // 
            this.radioCalm.AutoSize = true;
            this.radioCalm.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCalm.Location = new System.Drawing.Point(6, 40);
            this.radioCalm.Name = "radioCalm";
            this.radioCalm.Size = new System.Drawing.Size(60, 23);
            this.radioCalm.TabIndex = 2;
            this.radioCalm.Text = "Calm";
            this.radioCalm.UseVisualStyleBackColor = true;
            // 
            // radioFury
            // 
            this.radioFury.AutoSize = true;
            this.radioFury.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFury.Location = new System.Drawing.Point(93, 17);
            this.radioFury.Name = "radioFury";
            this.radioFury.Size = new System.Drawing.Size(54, 23);
            this.radioFury.TabIndex = 1;
            this.radioFury.Text = "Fury";
            this.radioFury.UseVisualStyleBackColor = true;
            // 
            // radioFear
            // 
            this.radioFear.AutoSize = true;
            this.radioFear.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioFear.Location = new System.Drawing.Point(93, 40);
            this.radioFear.Name = "radioFear";
            this.radioFear.Size = new System.Drawing.Size(55, 23);
            this.radioFear.TabIndex = 3;
            this.radioFear.Text = "Fear";
            this.radioFear.UseVisualStyleBackColor = true;
            // 
            // radioCourage
            // 
            this.radioCourage.AutoSize = true;
            this.radioCourage.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioCourage.Location = new System.Drawing.Point(6, 17);
            this.radioCourage.Name = "radioCourage";
            this.radioCourage.Size = new System.Drawing.Size(81, 23);
            this.radioCourage.TabIndex = 4;
            this.radioCourage.Text = "Courage";
            this.radioCourage.UseVisualStyleBackColor = true;
            // 
            // grpEffects
            // 
            this.grpEffects.Controls.Add(this.radioCourage);
            this.grpEffects.Controls.Add(this.radioFear);
            this.grpEffects.Controls.Add(this.radioFury);
            this.grpEffects.Controls.Add(this.radioCalm);
            this.grpEffects.Controls.Add(this.btnKill);
            this.grpEffects.Controls.Add(this.btnHeal);
            this.grpEffects.Enabled = false;
            this.grpEffects.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEffects.Location = new System.Drawing.Point(12, 360);
            this.grpEffects.Name = "grpEffects";
            this.grpEffects.Size = new System.Drawing.Size(162, 106);
            this.grpEffects.TabIndex = 25;
            this.grpEffects.TabStop = false;
            this.grpEffects.Text = "Effects";
            // 
            // fileMenu
            // 
            this.fileMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.fileMenu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.fileMenu.Location = new System.Drawing.Point(0, 0);
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.fileMenu.Size = new System.Drawing.Size(500, 24);
            this.fileMenu.TabIndex = 28;
            this.fileMenu.Text = "fileMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.loadToolStripMenuItem,
            this.toolStripSeparator2,
            this.settingsToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // loadToolStripMenuItem
            // 
            this.loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            this.loadToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadToolStripMenuItem.Text = "Load";
            this.loadToolStripMenuItem.Click += new System.EventHandler(this.loadToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendFeedbackToolStripMenuItem,
            this.toolStripSeparator3,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // sendFeedbackToolStripMenuItem
            // 
            this.sendFeedbackToolStripMenuItem.Name = "sendFeedbackToolStripMenuItem";
            this.sendFeedbackToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.sendFeedbackToolStripMenuItem.Text = "Send feedback";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(143, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // RTSGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 617);
            this.Controls.Add(this.fileMenu);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTimeDisplay);
            this.Controls.Add(this.grpMap);
            this.Controls.Add(this.grpEffects);
            this.Controls.Add(this.grpStats);
            this.Controls.Add(this.grpUnit);
            this.Controls.Add(this.btnPause);
            this.MainMenuStrip = this.fileMenu;
            this.Name = "RTSGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RTS Battle Royale";
            this.grpUnit.ResumeLayout(false);
            this.grpStats.ResumeLayout(false);
            this.grpStats.PerformLayout();
            this.grpMap.ResumeLayout(false);
            this.grpEffects.ResumeLayout(false);
            this.grpEffects.PerformLayout();
            this.fileMenu.ResumeLayout(false);
            this.fileMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnSaveStats;
        private System.Windows.Forms.GroupBox grpUnit;
        private System.Windows.Forms.GroupBox grpStats;
        private System.Windows.Forms.Label lblRange;
        private System.Windows.Forms.Label lblAttack;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.TextBox txtRangeBonus;
        private System.Windows.Forms.TextBox txtSpeedBonus;
        private System.Windows.Forms.TextBox txtAttackBonus;
        private System.Windows.Forms.TextBox txtHealthBonus;
        private System.Windows.Forms.GroupBox grpMap;
        private System.Windows.Forms.Label lblBonus;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblSpeedStat;
        private System.Windows.Forms.Label lblHealthStat;
        private System.Windows.Forms.Label lblRangeStat;
        private System.Windows.Forms.Label lblAttackStat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblTimeDisplay;
        private System.Windows.Forms.Label lblUnitDisplay;
        private System.Windows.Forms.Button btnHeal;
        private System.Windows.Forms.Button btnKill;
        private System.Windows.Forms.RadioButton radioCalm;
        private System.Windows.Forms.RadioButton radioFury;
        private System.Windows.Forms.RadioButton radioFear;
        private System.Windows.Forms.RadioButton radioCourage;
        private System.Windows.Forms.GroupBox grpEffects;
        private System.Windows.Forms.RichTextBox TxtMapDisplay;
        private System.Windows.Forms.MenuStrip fileMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendFeedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}


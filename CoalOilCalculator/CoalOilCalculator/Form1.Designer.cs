namespace CoalOilCalculator
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.Help = new System.Windows.Forms.ToolStripMenuItem();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.inputNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CTCValue = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CoalOilValue = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BitumenValue = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CrudeOilValue = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CoalGasolineValue = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.inputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.coalDustOption = new System.Windows.Forms.ToolStripMenuItem();
            this.coalBricketOption = new System.Windows.Forms.ToolStripMenuItem();
            this.infernalDustOption = new System.Windows.Forms.ToolStripMenuItem();
            this.infernalBricketOption = new System.Windows.Forms.ToolStripMenuItem();
            this.ligniteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ligniteDustOption = new System.Windows.Forms.ToolStripMenuItem();
            this.ligniteBricketOption = new System.Windows.Forms.ToolStripMenuItem();
            this.processingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.combinationOvenOption = new System.Windows.Forms.ToolStripMenuItem();
            this.liquefactionOption = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Settings,
            this.Help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(719, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // Settings
            // 
            this.Settings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inputToolStripMenuItem,
            this.processingToolStripMenuItem});
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(74, 24);
            this.Settings.Text = "Settings";
            // 
            // Help
            // 
            this.Help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.Help.Name = "Help";
            this.Help.Size = new System.Drawing.Size(53, 24);
            this.Help.Text = "Help";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(13, 387);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(100, 23);
            this.CalculateButton.TabIndex = 1;
            this.CalculateButton.Text = "calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // inputNumber
            // 
            this.inputNumber.Location = new System.Drawing.Point(13, 359);
            this.inputNumber.Name = "inputNumber";
            this.inputNumber.Size = new System.Drawing.Size(100, 22);
            this.inputNumber.TabIndex = 2;
            this.inputNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.inputNumber.TextChanged += new System.EventHandler(this.inputNumber_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Coal Tar Creosote (mB)";
            // 
            // CTCValue
            // 
            this.CTCValue.AutoSize = true;
            this.CTCValue.Location = new System.Drawing.Point(13, 49);
            this.CTCValue.Name = "CTCValue";
            this.CTCValue.Size = new System.Drawing.Size(16, 17);
            this.CTCValue.TabIndex = 4;
            this.CTCValue.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Coal Oil (mB)";
            // 
            // CoalOilValue
            // 
            this.CoalOilValue.AutoSize = true;
            this.CoalOilValue.Location = new System.Drawing.Point(13, 83);
            this.CoalOilValue.Name = "CoalOilValue";
            this.CoalOilValue.Size = new System.Drawing.Size(16, 17);
            this.CoalOilValue.TabIndex = 6;
            this.CoalOilValue.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Bitumen (mB)";
            // 
            // BitumenValue
            // 
            this.BitumenValue.AutoSize = true;
            this.BitumenValue.Location = new System.Drawing.Point(13, 117);
            this.BitumenValue.Name = "BitumenValue";
            this.BitumenValue.Size = new System.Drawing.Size(16, 17);
            this.BitumenValue.TabIndex = 8;
            this.BitumenValue.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Crude Oil (mB)";
            // 
            // CrudeOilValue
            // 
            this.CrudeOilValue.AutoSize = true;
            this.CrudeOilValue.Location = new System.Drawing.Point(13, 151);
            this.CrudeOilValue.Name = "CrudeOilValue";
            this.CrudeOilValue.Size = new System.Drawing.Size(16, 17);
            this.CrudeOilValue.TabIndex = 10;
            this.CrudeOilValue.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Coal Gasoline (mB)";
            // 
            // CoalGasolineValue
            // 
            this.CoalGasolineValue.AutoSize = true;
            this.CoalGasolineValue.Location = new System.Drawing.Point(13, 185);
            this.CoalGasolineValue.Name = "CoalGasolineValue";
            this.CoalGasolineValue.Size = new System.Drawing.Size(16, 17);
            this.CoalGasolineValue.TabIndex = 12;
            this.CoalGasolineValue.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CoalOilCalculator.Properties.Resources.no_AI_here_2;
            this.pictureBox1.Location = new System.Drawing.Point(563, 298);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(262, 242);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // inputToolStripMenuItem
            // 
            this.inputToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coalToolStripMenuItem,
            this.ligniteToolStripMenuItem});
            this.inputToolStripMenuItem.Image = global::CoalOilCalculator.Properties.Resources.coal;
            this.inputToolStripMenuItem.Name = "inputToolStripMenuItem";
            this.inputToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.inputToolStripMenuItem.Text = "Input";
            // 
            // coalToolStripMenuItem
            // 
            this.coalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.coalDustOption,
            this.coalBricketOption,
            this.infernalDustOption,
            this.infernalBricketOption});
            this.coalToolStripMenuItem.Image = global::CoalOilCalculator.Properties.Resources.coal;
            this.coalToolStripMenuItem.Name = "coalToolStripMenuItem";
            this.coalToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.coalToolStripMenuItem.Text = "Coal";
            // 
            // coalDustOption
            // 
            this.coalDustOption.Image = global::CoalOilCalculator.Properties.Resources.powder_coal;
            this.coalDustOption.Name = "coalDustOption";
            this.coalDustOption.Size = new System.Drawing.Size(177, 24);
            this.coalDustOption.Text = "Dust/Gem";
            this.coalDustOption.Click += new System.EventHandler(this.dustToolStripMenuItem_Click);
            // 
            // coalBricketOption
            // 
            this.coalBricketOption.Image = global::CoalOilCalculator.Properties.Resources.briquette_coal;
            this.coalBricketOption.Name = "coalBricketOption";
            this.coalBricketOption.Size = new System.Drawing.Size(177, 24);
            this.coalBricketOption.Text = "Bricket";
            this.coalBricketOption.Click += new System.EventHandler(this.bricketToolStripMenuItem_Click);
            // 
            // infernalDustOption
            // 
            this.infernalDustOption.Image = global::CoalOilCalculator.Properties.Resources.coal_infernal;
            this.infernalDustOption.Name = "infernalDustOption";
            this.infernalDustOption.Size = new System.Drawing.Size(177, 24);
            this.infernalDustOption.Text = "Infernal Dust";
            this.infernalDustOption.Click += new System.EventHandler(this.infernalDustToolStripMenuItem_Click);
            // 
            // infernalBricketOption
            // 
            this.infernalBricketOption.Image = global::CoalOilCalculator.Properties.Resources.coal_infernal;
            this.infernalBricketOption.Name = "infernalBricketOption";
            this.infernalBricketOption.Size = new System.Drawing.Size(177, 24);
            this.infernalBricketOption.Text = "Infernal Bricket";
            this.infernalBricketOption.Click += new System.EventHandler(this.infernalBricketToolStripMenuItem_Click);
            // 
            // ligniteToolStripMenuItem
            // 
            this.ligniteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ligniteDustOption,
            this.ligniteBricketOption});
            this.ligniteToolStripMenuItem.Image = global::CoalOilCalculator.Properties.Resources.lignite;
            this.ligniteToolStripMenuItem.Name = "ligniteToolStripMenuItem";
            this.ligniteToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.ligniteToolStripMenuItem.Text = "Lignite";
            // 
            // ligniteDustOption
            // 
            this.ligniteDustOption.Image = global::CoalOilCalculator.Properties.Resources.powder_lignite;
            this.ligniteDustOption.Name = "ligniteDustOption";
            this.ligniteDustOption.Size = new System.Drawing.Size(145, 24);
            this.ligniteDustOption.Text = "Dust/Gem";
            this.ligniteDustOption.Click += new System.EventHandler(this.dustGemToolStripMenuItem_Click);
            // 
            // ligniteBricketOption
            // 
            this.ligniteBricketOption.Image = global::CoalOilCalculator.Properties.Resources.briquette_lignite;
            this.ligniteBricketOption.Name = "ligniteBricketOption";
            this.ligniteBricketOption.Size = new System.Drawing.Size(145, 24);
            this.ligniteBricketOption.Text = "Bricket";
            this.ligniteBricketOption.Click += new System.EventHandler(this.bricketToolStripMenuItem1_Click);
            // 
            // processingToolStripMenuItem
            // 
            this.processingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.combinationOvenOption,
            this.liquefactionOption});
            this.processingToolStripMenuItem.Image = global::CoalOilCalculator.Properties.Resources.coal_oil;
            this.processingToolStripMenuItem.Name = "processingToolStripMenuItem";
            this.processingToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.processingToolStripMenuItem.Text = "Coal Oil / CTC method";
            // 
            // combinationOvenOption
            // 
            this.combinationOvenOption.Image = global::CoalOilCalculator.Properties.Resources.combination_oven;
            this.combinationOvenOption.Name = "combinationOvenOption";
            this.combinationOvenOption.Size = new System.Drawing.Size(231, 24);
            this.combinationOvenOption.Text = "Combination Oven";
            this.combinationOvenOption.Click += new System.EventHandler(this.combinationOvenToolStripMenuItem_Click);
            // 
            // liquefactionOption
            // 
            this.liquefactionOption.Image = global::CoalOilCalculator.Properties.Resources.liquefaction_machine;
            this.liquefactionOption.Name = "liquefactionOption";
            this.liquefactionOption.Size = new System.Drawing.Size(231, 24);
            this.liquefactionOption.Text = "I. Liquefaction Machine";
            this.liquefactionOption.Click += new System.EventHandler(this.iLiquefactionMachineToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Image = global::CoalOilCalculator.Properties.Resources.plate_titanium;
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 422);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CoalGasolineValue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CrudeOilValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BitumenValue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CoalOilValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CTCValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputNumber);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Coal Oil Calculator";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem Settings;
        private System.Windows.Forms.ToolStripMenuItem Help;
        private System.Windows.Forms.ToolStripMenuItem inputToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem coalDustOption;
        private System.Windows.Forms.ToolStripMenuItem coalBricketOption;
        private System.Windows.Forms.ToolStripMenuItem infernalDustOption;
        private System.Windows.Forms.ToolStripMenuItem infernalBricketOption;
        private System.Windows.Forms.ToolStripMenuItem ligniteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ligniteDustOption;
        private System.Windows.Forms.ToolStripMenuItem ligniteBricketOption;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.TextBox inputNumber;
        private System.Windows.Forms.ToolStripMenuItem processingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem combinationOvenOption;
        private System.Windows.Forms.ToolStripMenuItem liquefactionOption;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CTCValue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label CoalOilValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label BitumenValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label CrudeOilValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CoalGasolineValue;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


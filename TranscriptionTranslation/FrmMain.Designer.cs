namespace TranscriptionTranslation
{
    partial class FrmMain
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
            this.PnlMain = new System.Windows.Forms.Panel();
            this.LblMainText = new System.Windows.Forms.Label();
            this.TxtSequence = new System.Windows.Forms.TextBox();
            this.BtnSwitchDnaRna = new System.Windows.Forms.Button();
            this.BtnComplementaryStrand = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.GrpMode = new System.Windows.Forms.GroupBox();
            this.RbtnExpressive = new System.Windows.Forms.RadioButton();
            this.RbtnCompact = new System.Windows.Forms.RadioButton();
            this.BtnTranslate = new System.Windows.Forms.Button();
            this.LblFrameOne = new System.Windows.Forms.Label();
            this.TxtFrameOne = new System.Windows.Forms.TextBox();
            this.TxtFrameTwo = new System.Windows.Forms.TextBox();
            this.LblFrameTwo = new System.Windows.Forms.Label();
            this.TxtFrameThree = new System.Windows.Forms.TextBox();
            this.LblFrameThree = new System.Windows.Forms.Label();
            this.BtnInfo = new System.Windows.Forms.Button();
            this.PnlMain.SuspendLayout();
            this.GrpMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlMain
            // 
            this.PnlMain.Controls.Add(this.BtnInfo);
            this.PnlMain.Controls.Add(this.TxtFrameThree);
            this.PnlMain.Controls.Add(this.LblFrameThree);
            this.PnlMain.Controls.Add(this.TxtFrameTwo);
            this.PnlMain.Controls.Add(this.LblFrameTwo);
            this.PnlMain.Controls.Add(this.TxtFrameOne);
            this.PnlMain.Controls.Add(this.LblFrameOne);
            this.PnlMain.Controls.Add(this.BtnTranslate);
            this.PnlMain.Controls.Add(this.GrpMode);
            this.PnlMain.Controls.Add(this.BtnReset);
            this.PnlMain.Controls.Add(this.BtnComplementaryStrand);
            this.PnlMain.Controls.Add(this.BtnSwitchDnaRna);
            this.PnlMain.Controls.Add(this.TxtSequence);
            this.PnlMain.Controls.Add(this.LblMainText);
            this.PnlMain.Location = new System.Drawing.Point(0, 0);
            this.PnlMain.Name = "PnlMain";
            this.PnlMain.Size = new System.Drawing.Size(731, 522);
            this.PnlMain.TabIndex = 0;
            // 
            // LblMainText
            // 
            this.LblMainText.AutoSize = true;
            this.LblMainText.Location = new System.Drawing.Point(12, 18);
            this.LblMainText.Name = "LblMainText";
            this.LblMainText.Size = new System.Drawing.Size(168, 13);
            this.LblMainText.TabIndex = 0;
            this.LblMainText.Text = "Insert the DNA or RNA sequence:";
            // 
            // TxtSequence
            // 
            this.TxtSequence.Location = new System.Drawing.Point(15, 34);
            this.TxtSequence.Multiline = true;
            this.TxtSequence.Name = "TxtSequence";
            this.TxtSequence.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtSequence.Size = new System.Drawing.Size(390, 152);
            this.TxtSequence.TabIndex = 1;
            // 
            // BtnSwitchDnaRna
            // 
            this.BtnSwitchDnaRna.Location = new System.Drawing.Point(411, 35);
            this.BtnSwitchDnaRna.Name = "BtnSwitchDnaRna";
            this.BtnSwitchDnaRna.Size = new System.Drawing.Size(124, 33);
            this.BtnSwitchDnaRna.TabIndex = 2;
            this.BtnSwitchDnaRna.Text = "Switch DNA <-> RNA";
            this.BtnSwitchDnaRna.UseVisualStyleBackColor = true;
            // 
            // BtnComplementaryStrand
            // 
            this.BtnComplementaryStrand.Location = new System.Drawing.Point(411, 74);
            this.BtnComplementaryStrand.Name = "BtnComplementaryStrand";
            this.BtnComplementaryStrand.Size = new System.Drawing.Size(124, 33);
            this.BtnComplementaryStrand.TabIndex = 3;
            this.BtnComplementaryStrand.Text = "Complementary Strand";
            this.BtnComplementaryStrand.UseVisualStyleBackColor = true;
            // 
            // BtnReset
            // 
            this.BtnReset.Location = new System.Drawing.Point(411, 113);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(124, 33);
            this.BtnReset.TabIndex = 4;
            this.BtnReset.Text = "Reset";
            this.BtnReset.UseVisualStyleBackColor = true;
            // 
            // GrpMode
            // 
            this.GrpMode.Controls.Add(this.RbtnCompact);
            this.GrpMode.Controls.Add(this.RbtnExpressive);
            this.GrpMode.Location = new System.Drawing.Point(541, 34);
            this.GrpMode.Name = "GrpMode";
            this.GrpMode.Size = new System.Drawing.Size(175, 152);
            this.GrpMode.TabIndex = 5;
            this.GrpMode.TabStop = false;
            this.GrpMode.Text = "Mode";
            // 
            // RbtnExpressive
            // 
            this.RbtnExpressive.AutoSize = true;
            this.RbtnExpressive.Checked = true;
            this.RbtnExpressive.Location = new System.Drawing.Point(12, 19);
            this.RbtnExpressive.Name = "RbtnExpressive";
            this.RbtnExpressive.Size = new System.Drawing.Size(76, 17);
            this.RbtnExpressive.TabIndex = 0;
            this.RbtnExpressive.TabStop = true;
            this.RbtnExpressive.Text = "Expressive";
            this.RbtnExpressive.UseVisualStyleBackColor = true;
            // 
            // RbtnCompact
            // 
            this.RbtnCompact.AutoSize = true;
            this.RbtnCompact.Location = new System.Drawing.Point(12, 42);
            this.RbtnCompact.Name = "RbtnCompact";
            this.RbtnCompact.Size = new System.Drawing.Size(67, 17);
            this.RbtnCompact.TabIndex = 1;
            this.RbtnCompact.TabStop = true;
            this.RbtnCompact.Text = "Compact";
            this.RbtnCompact.UseVisualStyleBackColor = true;
            // 
            // BtnTranslate
            // 
            this.BtnTranslate.Location = new System.Drawing.Point(411, 152);
            this.BtnTranslate.Name = "BtnTranslate";
            this.BtnTranslate.Size = new System.Drawing.Size(124, 33);
            this.BtnTranslate.TabIndex = 6;
            this.BtnTranslate.Text = "Translate";
            this.BtnTranslate.UseVisualStyleBackColor = true;
            // 
            // LblFrameOne
            // 
            this.LblFrameOne.AutoSize = true;
            this.LblFrameOne.Location = new System.Drawing.Point(12, 198);
            this.LblFrameOne.Name = "LblFrameOne";
            this.LblFrameOne.Size = new System.Drawing.Size(45, 13);
            this.LblFrameOne.TabIndex = 7;
            this.LblFrameOne.Text = "Frame 1";
            // 
            // TxtFrameOne
            // 
            this.TxtFrameOne.Location = new System.Drawing.Point(15, 214);
            this.TxtFrameOne.Multiline = true;
            this.TxtFrameOne.Name = "TxtFrameOne";
            this.TxtFrameOne.ReadOnly = true;
            this.TxtFrameOne.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtFrameOne.Size = new System.Drawing.Size(701, 78);
            this.TxtFrameOne.TabIndex = 8;
            // 
            // TxtFrameTwo
            // 
            this.TxtFrameTwo.Location = new System.Drawing.Point(15, 320);
            this.TxtFrameTwo.Multiline = true;
            this.TxtFrameTwo.Name = "TxtFrameTwo";
            this.TxtFrameTwo.ReadOnly = true;
            this.TxtFrameTwo.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtFrameTwo.Size = new System.Drawing.Size(701, 78);
            this.TxtFrameTwo.TabIndex = 10;
            // 
            // LblFrameTwo
            // 
            this.LblFrameTwo.AutoSize = true;
            this.LblFrameTwo.Location = new System.Drawing.Point(12, 304);
            this.LblFrameTwo.Name = "LblFrameTwo";
            this.LblFrameTwo.Size = new System.Drawing.Size(45, 13);
            this.LblFrameTwo.TabIndex = 9;
            this.LblFrameTwo.Text = "Frame 2";
            // 
            // TxtFrameThree
            // 
            this.TxtFrameThree.Location = new System.Drawing.Point(15, 426);
            this.TxtFrameThree.Multiline = true;
            this.TxtFrameThree.Name = "TxtFrameThree";
            this.TxtFrameThree.ReadOnly = true;
            this.TxtFrameThree.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TxtFrameThree.Size = new System.Drawing.Size(701, 78);
            this.TxtFrameThree.TabIndex = 12;
            // 
            // LblFrameThree
            // 
            this.LblFrameThree.AutoSize = true;
            this.LblFrameThree.Location = new System.Drawing.Point(12, 410);
            this.LblFrameThree.Name = "LblFrameThree";
            this.LblFrameThree.Size = new System.Drawing.Size(45, 13);
            this.LblFrameThree.TabIndex = 11;
            this.LblFrameThree.Text = "Frame 3";
            // 
            // BtnInfo
            // 
            this.BtnInfo.Location = new System.Drawing.Point(694, 9);
            this.BtnInfo.Name = "BtnInfo";
            this.BtnInfo.Size = new System.Drawing.Size(22, 22);
            this.BtnInfo.TabIndex = 13;
            this.BtnInfo.Text = "?";
            this.BtnInfo.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 522);
            this.Controls.Add(this.PnlMain);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(747, 561);
            this.MinimumSize = new System.Drawing.Size(747, 561);
            this.Name = "FrmMain";
            this.Text = "Translation of DNA and RNA";
            this.PnlMain.ResumeLayout(false);
            this.PnlMain.PerformLayout();
            this.GrpMode.ResumeLayout(false);
            this.GrpMode.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlMain;
        private System.Windows.Forms.Label LblMainText;
        private System.Windows.Forms.Button BtnComplementaryStrand;
        private System.Windows.Forms.Button BtnSwitchDnaRna;
        private System.Windows.Forms.TextBox TxtSequence;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.GroupBox GrpMode;
        private System.Windows.Forms.RadioButton RbtnCompact;
        private System.Windows.Forms.RadioButton RbtnExpressive;
        private System.Windows.Forms.Button BtnTranslate;
        private System.Windows.Forms.Label LblFrameOne;
        private System.Windows.Forms.TextBox TxtFrameTwo;
        private System.Windows.Forms.Label LblFrameTwo;
        private System.Windows.Forms.TextBox TxtFrameOne;
        private System.Windows.Forms.Button BtnInfo;
        private System.Windows.Forms.TextBox TxtFrameThree;
        private System.Windows.Forms.Label LblFrameThree;
    }
}


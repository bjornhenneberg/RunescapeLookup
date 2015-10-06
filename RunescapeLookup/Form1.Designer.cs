namespace RunescapeLookup
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
            this.txtPlayerName = new System.Windows.Forms.TextBox();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.btnLookup = new System.Windows.Forms.Button();
            this.lblOverall = new System.Windows.Forms.Label();
            this.lblOverallRank = new System.Windows.Forms.Label();
            this.lblOverallLevel = new System.Windows.Forms.Label();
            this.lblOverallExp = new System.Windows.Forms.Label();
            this.lblRank = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblExperince = new System.Windows.Forms.Label();
            this.Highscore = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblAttackRank = new System.Windows.Forms.Label();
            this.lblAttackLevel = new System.Windows.Forms.Label();
            this.lblAttackExp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lblDefenceRank = new System.Windows.Forms.Label();
            this.lblDefenceLevel = new System.Windows.Forms.Label();
            this.lblDefenceExp = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Highscore.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPlayerName
            // 
            this.txtPlayerName.Location = new System.Drawing.Point(88, 12);
            this.txtPlayerName.Name = "txtPlayerName";
            this.txtPlayerName.Size = new System.Drawing.Size(100, 20);
            this.txtPlayerName.TabIndex = 0;
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Location = new System.Drawing.Point(12, 15);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(70, 13);
            this.lblPlayerName.TabIndex = 1;
            this.lblPlayerName.Text = "Player Name:";
            // 
            // btnLookup
            // 
            this.btnLookup.Location = new System.Drawing.Point(194, 12);
            this.btnLookup.Name = "btnLookup";
            this.btnLookup.Size = new System.Drawing.Size(78, 20);
            this.btnLookup.TabIndex = 2;
            this.btnLookup.Text = "Load";
            this.btnLookup.UseVisualStyleBackColor = true;
            this.btnLookup.Click += new System.EventHandler(this.btnLookup_Click);
            // 
            // lblOverall
            // 
            this.lblOverall.AutoSize = true;
            this.lblOverall.Location = new System.Drawing.Point(3, 23);
            this.lblOverall.Name = "lblOverall";
            this.lblOverall.Size = new System.Drawing.Size(43, 13);
            this.lblOverall.TabIndex = 3;
            this.lblOverall.Text = "Overall:";
            // 
            // lblOverallRank
            // 
            this.lblOverallRank.AutoSize = true;
            this.lblOverallRank.Location = new System.Drawing.Point(61, 23);
            this.lblOverallRank.Name = "lblOverallRank";
            this.lblOverallRank.Size = new System.Drawing.Size(0, 13);
            this.lblOverallRank.TabIndex = 4;
            // 
            // lblOverallLevel
            // 
            this.lblOverallLevel.AutoSize = true;
            this.lblOverallLevel.Location = new System.Drawing.Point(120, 23);
            this.lblOverallLevel.Name = "lblOverallLevel";
            this.lblOverallLevel.Size = new System.Drawing.Size(0, 13);
            this.lblOverallLevel.TabIndex = 5;
            // 
            // lblOverallExp
            // 
            this.lblOverallExp.AutoSize = true;
            this.lblOverallExp.Location = new System.Drawing.Point(188, 23);
            this.lblOverallExp.Name = "lblOverallExp";
            this.lblOverallExp.Size = new System.Drawing.Size(0, 13);
            this.lblOverallExp.TabIndex = 6;
            // 
            // lblRank
            // 
            this.lblRank.AutoSize = true;
            this.lblRank.Location = new System.Drawing.Point(61, 7);
            this.lblRank.Name = "lblRank";
            this.lblRank.Size = new System.Drawing.Size(33, 13);
            this.lblRank.TabIndex = 7;
            this.lblRank.Text = "Rank";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(120, 7);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(33, 13);
            this.lblLevel.TabIndex = 8;
            this.lblLevel.Text = "Level";
            // 
            // lblExperince
            // 
            this.lblExperince.AutoSize = true;
            this.lblExperince.Location = new System.Drawing.Point(188, 7);
            this.lblExperince.Name = "lblExperince";
            this.lblExperince.Size = new System.Drawing.Size(60, 13);
            this.lblExperince.TabIndex = 9;
            this.lblExperince.Text = "Experience";
            // 
            // Highscore
            // 
            this.Highscore.Controls.Add(this.tabPage1);
            this.Highscore.Controls.Add(this.tabPage2);
            this.Highscore.Controls.Add(this.tabPage3);
            this.Highscore.Location = new System.Drawing.Point(12, 38);
            this.Highscore.Name = "Highscore";
            this.Highscore.SelectedIndex = 0;
            this.Highscore.Size = new System.Drawing.Size(260, 232);
            this.Highscore.TabIndex = 10;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblDefenceRank);
            this.tabPage1.Controls.Add(this.lblDefenceLevel);
            this.tabPage1.Controls.Add(this.lblDefenceExp);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.lblAttackRank);
            this.tabPage1.Controls.Add(this.lblAttackLevel);
            this.tabPage1.Controls.Add(this.lblAttackExp);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lblOverall);
            this.tabPage1.Controls.Add(this.lblExperince);
            this.tabPage1.Controls.Add(this.lblOverallRank);
            this.tabPage1.Controls.Add(this.lblLevel);
            this.tabPage1.Controls.Add(this.lblOverallLevel);
            this.tabPage1.Controls.Add(this.lblRank);
            this.tabPage1.Controls.Add(this.lblOverallExp);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(252, 206);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Highscore";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblAttackRank
            // 
            this.lblAttackRank.AutoSize = true;
            this.lblAttackRank.Location = new System.Drawing.Point(61, 40);
            this.lblAttackRank.Name = "lblAttackRank";
            this.lblAttackRank.Size = new System.Drawing.Size(0, 13);
            this.lblAttackRank.TabIndex = 11;
            // 
            // lblAttackLevel
            // 
            this.lblAttackLevel.AutoSize = true;
            this.lblAttackLevel.Location = new System.Drawing.Point(120, 40);
            this.lblAttackLevel.Name = "lblAttackLevel";
            this.lblAttackLevel.Size = new System.Drawing.Size(0, 13);
            this.lblAttackLevel.TabIndex = 12;
            // 
            // lblAttackExp
            // 
            this.lblAttackExp.AutoSize = true;
            this.lblAttackExp.Location = new System.Drawing.Point(188, 40);
            this.lblAttackExp.Name = "lblAttackExp";
            this.lblAttackExp.Size = new System.Drawing.Size(0, 13);
            this.lblAttackExp.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Attack:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(252, 206);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Minigames";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(252, 206);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Adventure Log";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // lblDefenceRank
            // 
            this.lblDefenceRank.AutoSize = true;
            this.lblDefenceRank.Location = new System.Drawing.Point(61, 57);
            this.lblDefenceRank.Name = "lblDefenceRank";
            this.lblDefenceRank.Size = new System.Drawing.Size(0, 13);
            this.lblDefenceRank.TabIndex = 15;
            // 
            // lblDefenceLevel
            // 
            this.lblDefenceLevel.AutoSize = true;
            this.lblDefenceLevel.Location = new System.Drawing.Point(120, 57);
            this.lblDefenceLevel.Name = "lblDefenceLevel";
            this.lblDefenceLevel.Size = new System.Drawing.Size(0, 13);
            this.lblDefenceLevel.TabIndex = 16;
            // 
            // lblDefenceExp
            // 
            this.lblDefenceExp.AutoSize = true;
            this.lblDefenceExp.Location = new System.Drawing.Point(188, 57);
            this.lblDefenceExp.Name = "lblDefenceExp";
            this.lblDefenceExp.Size = new System.Drawing.Size(0, 13);
            this.lblDefenceExp.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Defence:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 279);
            this.Controls.Add(this.Highscore);
            this.Controls.Add(this.btnLookup);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.txtPlayerName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Highscore.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPlayerName;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Button btnLookup;
        private System.Windows.Forms.Label lblOverall;
        private System.Windows.Forms.Label lblOverallRank;
        private System.Windows.Forms.Label lblOverallLevel;
        private System.Windows.Forms.Label lblOverallExp;
        private System.Windows.Forms.Label lblRank;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblExperince;
        private System.Windows.Forms.TabControl Highscore;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblAttackRank;
        private System.Windows.Forms.Label lblAttackLevel;
        private System.Windows.Forms.Label lblAttackExp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDefenceRank;
        private System.Windows.Forms.Label lblDefenceLevel;
        private System.Windows.Forms.Label lblDefenceExp;
        private System.Windows.Forms.Label label5;
    }
}


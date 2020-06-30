namespace RandomColorGame
{
    partial class frmMain
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoEasy = new System.Windows.Forms.RadioButton();
            this.rdoNormal = new System.Windows.Forms.RadioButton();
            this.rdoHard = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblInstruct = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoHard);
            this.groupBox1.Controls.Add(this.rdoNormal);
            this.groupBox1.Controls.Add(this.rdoEasy);
            this.groupBox1.Location = new System.Drawing.Point(13, 299);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(423, 108);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Difficulty Select";
            // 
            // rdoEasy
            // 
            this.rdoEasy.AutoSize = true;
            this.rdoEasy.Location = new System.Drawing.Point(30, 52);
            this.rdoEasy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoEasy.Name = "rdoEasy";
            this.rdoEasy.Size = new System.Drawing.Size(77, 29);
            this.rdoEasy.TabIndex = 0;
            this.rdoEasy.TabStop = true;
            this.rdoEasy.Text = "Easy";
            this.rdoEasy.UseVisualStyleBackColor = true;
            this.rdoEasy.CheckedChanged += new System.EventHandler(this.rdoEasy_CheckedChanged);
            // 
            // rdoNormal
            // 
            this.rdoNormal.AutoSize = true;
            this.rdoNormal.Location = new System.Drawing.Point(158, 52);
            this.rdoNormal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoNormal.Name = "rdoNormal";
            this.rdoNormal.Size = new System.Drawing.Size(95, 29);
            this.rdoNormal.TabIndex = 1;
            this.rdoNormal.TabStop = true;
            this.rdoNormal.Text = "Normal";
            this.rdoNormal.UseVisualStyleBackColor = true;
            this.rdoNormal.CheckedChanged += new System.EventHandler(this.rdoNormal_CheckedChanged);
            // 
            // rdoHard
            // 
            this.rdoHard.AutoSize = true;
            this.rdoHard.Location = new System.Drawing.Point(309, 52);
            this.rdoHard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rdoHard.Name = "rdoHard";
            this.rdoHard.Size = new System.Drawing.Size(75, 29);
            this.rdoHard.TabIndex = 2;
            this.rdoHard.TabStop = true;
            this.rdoHard.Text = "Hard";
            this.rdoHard.UseVisualStyleBackColor = true;
            this.rdoHard.CheckedChanged += new System.EventHandler(this.rdoHard_CheckedChanged);
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(43, 417);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(84, 36);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "&Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(314, 417);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(83, 36);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblInstruct
            // 
            this.lblInstruct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblInstruct.Location = new System.Drawing.Point(12, 13);
            this.lblInstruct.Name = "lblInstruct";
            this.lblInstruct.Size = new System.Drawing.Size(434, 281);
            this.lblInstruct.TabIndex = 0;
            this.lblInstruct.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 467);
            this.Controls.Add(this.lblInstruct);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmMain";
            this.Text = "Random Color Game";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoHard;
        private System.Windows.Forms.RadioButton rdoNormal;
        private System.Windows.Forms.RadioButton rdoEasy;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblInstruct;
    }
}


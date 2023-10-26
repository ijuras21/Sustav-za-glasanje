namespace Glasanje {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.OIBTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GlasanjeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ForLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AgainstLabel = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.AbstainedLabel = new System.Windows.Forms.Label();
            this.VoteBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OIBTextBox
            // 
            this.OIBTextBox.Location = new System.Drawing.Point(42, 51);
            this.OIBTextBox.Name = "OIBTextBox";
            this.OIBTextBox.Size = new System.Drawing.Size(192, 20);
            this.OIBTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter OIB:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Choose option:";
            // 
            // GlasanjeComboBox
            // 
            this.GlasanjeComboBox.FormattingEnabled = true;
            this.GlasanjeComboBox.Location = new System.Drawing.Point(42, 117);
            this.GlasanjeComboBox.Name = "GlasanjeComboBox";
            this.GlasanjeComboBox.Size = new System.Drawing.Size(121, 21);
            this.GlasanjeComboBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vote results:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "FOR:";
            // 
            // ForLabel
            // 
            this.ForLabel.AutoSize = true;
            this.ForLabel.Location = new System.Drawing.Point(401, 54);
            this.ForLabel.Name = "ForLabel";
            this.ForLabel.Size = new System.Drawing.Size(13, 13);
            this.ForLabel.TabIndex = 6;
            this.ForLabel.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(302, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "AGAINST:";
            // 
            // AgainstLabel
            // 
            this.AgainstLabel.AutoSize = true;
            this.AgainstLabel.Location = new System.Drawing.Point(401, 80);
            this.AgainstLabel.Name = "AgainstLabel";
            this.AgainstLabel.Size = new System.Drawing.Size(13, 13);
            this.AgainstLabel.TabIndex = 8;
            this.AgainstLabel.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 108);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "ABSTAINED:";
            // 
            // AbstainedLabel
            // 
            this.AbstainedLabel.AutoSize = true;
            this.AbstainedLabel.Location = new System.Drawing.Point(401, 108);
            this.AbstainedLabel.Name = "AbstainedLabel";
            this.AbstainedLabel.Size = new System.Drawing.Size(13, 13);
            this.AbstainedLabel.TabIndex = 10;
            this.AbstainedLabel.Text = "0";
            // 
            // VoteBtn
            // 
            this.VoteBtn.Location = new System.Drawing.Point(169, 117);
            this.VoteBtn.Name = "VoteBtn";
            this.VoteBtn.Size = new System.Drawing.Size(65, 23);
            this.VoteBtn.TabIndex = 11;
            this.VoteBtn.Text = "Vote";
            this.VoteBtn.UseVisualStyleBackColor = true;
            this.VoteBtn.Click += new System.EventHandler(this.VoteBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 170);
            this.Controls.Add(this.VoteBtn);
            this.Controls.Add(this.AbstainedLabel);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AgainstLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ForLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GlasanjeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OIBTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voting";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OIBTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox GlasanjeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ForLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label AgainstLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label AbstainedLabel;
        private System.Windows.Forms.Button VoteBtn;
    }
}


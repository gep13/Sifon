﻿namespace Sifon.Forms.Other
{
    partial class FirstTimeRun
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
            this.labelWarn3 = new System.Windows.Forms.Label();
            this.labelWarn2 = new System.Windows.Forms.Label();
            this.labelWarn1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelWarn3
            // 
            this.labelWarn3.AutoSize = true;
            this.labelWarn3.ForeColor = System.Drawing.Color.Red;
            this.labelWarn3.Location = new System.Drawing.Point(16, 73);
            this.labelWarn3.Name = "labelWarn3";
            this.labelWarn3.Size = new System.Drawing.Size(281, 13);
            this.labelWarn3.TabIndex = 14;
            this.labelWarn3.Text = "as well as other parameters before the first run and save it.";
            // 
            // labelWarn2
            // 
            this.labelWarn2.AutoSize = true;
            this.labelWarn2.ForeColor = System.Drawing.Color.Red;
            this.labelWarn2.Location = new System.Drawing.Point(16, 57);
            this.labelWarn2.Name = "labelWarn2";
            this.labelWarn2.Size = new System.Drawing.Size(279, 13);
            this.labelWarn2.TabIndex = 13;
            this.labelWarn2.Text = "Please change the profile name, prefix, website root folder";
            // 
            // labelWarn1
            // 
            this.labelWarn1.AutoSize = true;
            this.labelWarn1.ForeColor = System.Drawing.Color.Red;
            this.labelWarn1.Location = new System.Drawing.Point(16, 31);
            this.labelWarn1.Name = "labelWarn1";
            this.labelWarn1.Size = new System.Drawing.Size(151, 13);
            this.labelWarn1.TabIndex = 12;
            this.labelWarn1.Text = "Since this is your first time run..";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(16, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Once done, you\'ll be able to process with the rest of them";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(16, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Most Sifon features will not be available until at least one ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(16, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "profile is set up and selected.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.labelWarn1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.labelWarn2);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.labelWarn3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(314, 200);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WARNING!";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(178, 160);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "I understand that";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FirstTimeRun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 227);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FirstTimeRun";
            this.Text = "Welcome to Sifon!";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelWarn3;
        private System.Windows.Forms.Label labelWarn2;
        private System.Windows.Forms.Label labelWarn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
    }
}
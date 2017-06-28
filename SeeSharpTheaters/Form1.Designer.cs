﻿namespace SeeSharpTheaters
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
            this.label1 = new System.Windows.Forms.Label();
            this.movieListLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.resultOfLoadLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.loadTimesButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.showMoviesButton = new System.Windows.Forms.Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.pinTextBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.movieTimesFilePathDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Movie Listings File Path:";
            // 
            // movieListLabel
            // 
            this.movieListLabel.AutoSize = true;
            this.movieListLabel.Location = new System.Drawing.Point(25, 232);
            this.movieListLabel.Name = "movieListLabel";
            this.movieListLabel.Size = new System.Drawing.Size(0, 13);
            this.movieListLabel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "PIN:";
            // 
            // resultOfLoadLabel
            // 
            this.resultOfLoadLabel.AutoSize = true;
            this.resultOfLoadLabel.Location = new System.Drawing.Point(25, 136);
            this.resultOfLoadLabel.Name = "resultOfLoadLabel";
            this.resultOfLoadLabel.Size = new System.Drawing.Size(157, 13);
            this.resultOfLoadLabel.TabIndex = 3;
            this.resultOfLoadLabel.Text = "Success or Error Message Here";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(364, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Your Total Is:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "How many tickets?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(364, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Order Number";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(201, 37);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 8;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // loadTimesButton
            // 
            this.loadTimesButton.Location = new System.Drawing.Point(28, 94);
            this.loadTimesButton.Name = "loadTimesButton";
            this.loadTimesButton.Size = new System.Drawing.Size(248, 23);
            this.loadTimesButton.TabIndex = 9;
            this.loadTimesButton.Text = "Load Movie Times";
            this.loadTimesButton.UseVisualStyleBackColor = true;
            this.loadTimesButton.Click += new System.EventHandler(this.loadTimesButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(362, 103);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 23);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Calculate Total";
            this.calculateButton.UseVisualStyleBackColor = true;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(362, 151);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(100, 23);
            this.confirmButton.TabIndex = 11;
            this.confirmButton.Text = "Confirm Order";
            this.confirmButton.UseVisualStyleBackColor = true;
            // 
            // showMoviesButton
            // 
            this.showMoviesButton.Location = new System.Drawing.Point(28, 192);
            this.showMoviesButton.Name = "showMoviesButton";
            this.showMoviesButton.Size = new System.Drawing.Size(248, 23);
            this.showMoviesButton.TabIndex = 12;
            this.showMoviesButton.Text = "Show Movie Times";
            this.showMoviesButton.UseVisualStyleBackColor = true;
            this.showMoviesButton.Click += new System.EventHandler(this.showMoviesButton_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(28, 40);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(167, 20);
            this.filePathTextBox.TabIndex = 13;
            // 
            // pinTextBox
            // 
            this.pinTextBox.Location = new System.Drawing.Point(115, 63);
            this.pinTextBox.Name = "pinTextBox";
            this.pinTextBox.Size = new System.Drawing.Size(80, 20);
            this.pinTextBox.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(362, 40);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 15;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(362, 66);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(194, 17);
            this.checkBox1.TabIndex = 16;
            this.checkBox1.Text = "3D: Check this to buy tickets for 3D";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // movieTimesFilePathDialog
            // 
            this.movieTimesFilePathDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 408);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.pinTextBox);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.showMoviesButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.loadTimesButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.resultOfLoadLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.movieListLabel);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Welcome to See Sharp Movie Theater";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label movieListLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label resultOfLoadLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button loadTimesButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button showMoviesButton;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.TextBox pinTextBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.OpenFileDialog movieTimesFilePathDialog;
    }
}

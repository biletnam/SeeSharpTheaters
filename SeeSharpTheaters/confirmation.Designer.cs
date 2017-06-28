namespace SeeSharpTheaters
{
    partial class confirmation
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
            this.label2 = new System.Windows.Forms.Label();
            this.returnToMainButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(31, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please proceed to the cashier with your confirmation number to pay for the ticket" +
    "s. Your number is 48271.\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Order Confirmed!";
            // 
            // returnToMainButton
            // 
            this.returnToMainButton.Location = new System.Drawing.Point(78, 89);
            this.returnToMainButton.Name = "returnToMainButton";
            this.returnToMainButton.Size = new System.Drawing.Size(110, 23);
            this.returnToMainButton.TabIndex = 2;
            this.returnToMainButton.Text = "Click to Return";
            this.returnToMainButton.UseVisualStyleBackColor = true;
            this.returnToMainButton.Click += new System.EventHandler(this.returnToMainButton_Click);
            // 
            // confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 132);
            this.Controls.Add(this.returnToMainButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "confirmation";
            this.Text = "Order Confirmation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button returnToMainButton;
    }
}
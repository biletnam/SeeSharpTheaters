namespace SeeSharpTheaters
{
    partial class seeSharpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(seeSharpForm));
            this.pathLabel = new System.Windows.Forms.Label();
            this.movieListLabel = new System.Windows.Forms.Label();
            this.pinLabel = new System.Windows.Forms.Label();
            this.resultOfLoadLabel = new System.Windows.Forms.Label();
            this.orderTotalLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.browseButton = new System.Windows.Forms.Button();
            this.loadTimesButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.confirmButton = new System.Windows.Forms.Button();
            this.showMoviesButton = new System.Windows.Forms.Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.pinTextBox = new System.Windows.Forms.TextBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.surcharge3DBox = new System.Windows.Forms.CheckBox();
            this.movieTimesFilePathDialog = new System.Windows.Forms.OpenFileDialog();
            this.realDLogo = new System.Windows.Forms.PictureBox();
            this.adminLinkLabel = new System.Windows.Forms.LinkLabel();
            this.submitPinLinkLabel = new System.Windows.Forms.LinkLabel();
            this.incorrectPinLabel = new System.Windows.Forms.Label();
            this.closeAdminLinkLabel = new System.Windows.Forms.LinkLabel();
            this.splashPage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.realDLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splashPage)).BeginInit();
            this.SuspendLayout();
            // 
            // pathLabel
            // 
            this.pathLabel.AutoSize = true;
            this.pathLabel.Location = new System.Drawing.Point(9, 290);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(121, 13);
            this.pathLabel.TabIndex = 0;
            this.pathLabel.Text = "Movie Listings File Path:";
            // 
            // movieListLabel
            // 
            this.movieListLabel.AutoSize = true;
            this.movieListLabel.Location = new System.Drawing.Point(9, 64);
            this.movieListLabel.Name = "movieListLabel";
            this.movieListLabel.Size = new System.Drawing.Size(0, 13);
            this.movieListLabel.TabIndex = 1;
            // 
            // pinLabel
            // 
            this.pinLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pinLabel.AutoSize = true;
            this.pinLabel.Location = new System.Drawing.Point(476, 367);
            this.pinLabel.Name = "pinLabel";
            this.pinLabel.Size = new System.Drawing.Size(28, 13);
            this.pinLabel.TabIndex = 2;
            this.pinLabel.Text = "PIN:";
            this.pinLabel.Visible = false;
            // 
            // resultOfLoadLabel
            // 
            this.resultOfLoadLabel.AutoSize = true;
            this.resultOfLoadLabel.Location = new System.Drawing.Point(286, 367);
            this.resultOfLoadLabel.Name = "resultOfLoadLabel";
            this.resultOfLoadLabel.Size = new System.Drawing.Size(0, 13);
            this.resultOfLoadLabel.TabIndex = 3;
            // 
            // orderTotalLabel
            // 
            this.orderTotalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.orderTotalLabel.AutoSize = true;
            this.orderTotalLabel.Location = new System.Drawing.Point(364, 185);
            this.orderTotalLabel.Name = "orderTotalLabel";
            this.orderTotalLabel.Size = new System.Drawing.Size(0, 13);
            this.orderTotalLabel.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(359, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "How many tickets?";
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(185, 303);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 23);
            this.browseButton.TabIndex = 8;
            this.browseButton.Text = "Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // loadTimesButton
            // 
            this.loadTimesButton.Location = new System.Drawing.Point(12, 360);
            this.loadTimesButton.Name = "loadTimesButton";
            this.loadTimesButton.Size = new System.Drawing.Size(248, 23);
            this.loadTimesButton.TabIndex = 9;
            this.loadTimesButton.Text = "Load Movie Times";
            this.loadTimesButton.UseVisualStyleBackColor = true;
            this.loadTimesButton.Click += new System.EventHandler(this.loadTimesButton_Click);
            this.loadTimesButton.MouseLeave += new System.EventHandler(this.loadTimesButtom_MouseLeave);
            this.loadTimesButton.MouseHover += new System.EventHandler(this.loadTimesButton_MouseHover);
            // 
            // calculateButton
            // 
            this.calculateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.calculateButton.Location = new System.Drawing.Point(362, 157);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(100, 23);
            this.calculateButton.TabIndex = 10;
            this.calculateButton.Text = "Calculate Total";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // confirmButton
            // 
            this.confirmButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.confirmButton.Location = new System.Drawing.Point(363, 221);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(100, 23);
            this.confirmButton.TabIndex = 11;
            this.confirmButton.Text = "Confirm Order";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Visible = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // showMoviesButton
            // 
            this.showMoviesButton.Location = new System.Drawing.Point(12, 24);
            this.showMoviesButton.Name = "showMoviesButton";
            this.showMoviesButton.Size = new System.Drawing.Size(248, 23);
            this.showMoviesButton.TabIndex = 12;
            this.showMoviesButton.Text = "Show Movie Times";
            this.showMoviesButton.UseVisualStyleBackColor = true;
            this.showMoviesButton.Click += new System.EventHandler(this.showMoviesButton_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(12, 306);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(167, 20);
            this.filePathTextBox.TabIndex = 13;
            // 
            // pinTextBox
            // 
            this.pinTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pinTextBox.Location = new System.Drawing.Point(510, 364);
            this.pinTextBox.Name = "pinTextBox";
            this.pinTextBox.Size = new System.Drawing.Size(80, 20);
            this.pinTextBox.TabIndex = 14;
            this.pinTextBox.Visible = false;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.quantityTextBox.Location = new System.Drawing.Point(362, 40);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 15;
            // 
            // surcharge3DBox
            // 
            this.surcharge3DBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.surcharge3DBox.AutoSize = true;
            this.surcharge3DBox.Location = new System.Drawing.Point(362, 66);
            this.surcharge3DBox.Name = "surcharge3DBox";
            this.surcharge3DBox.Size = new System.Drawing.Size(194, 17);
            this.surcharge3DBox.TabIndex = 16;
            this.surcharge3DBox.Text = "3D: Check this to buy tickets for 3D";
            this.surcharge3DBox.UseVisualStyleBackColor = true;
            this.surcharge3DBox.CheckedChanged += new System.EventHandler(this.surcharge3dBox_CheckedChange);
            // 
            // movieTimesFilePathDialog
            // 
            this.movieTimesFilePathDialog.FileName = "openFileDialog1";
            // 
            // realDLogo
            // 
            this.realDLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.realDLogo.Image = ((System.Drawing.Image)(resources.GetObject("realDLogo.Image")));
            this.realDLogo.Location = new System.Drawing.Point(362, 90);
            this.realDLogo.Name = "realDLogo";
            this.realDLogo.Size = new System.Drawing.Size(178, 50);
            this.realDLogo.TabIndex = 17;
            this.realDLogo.TabStop = false;
            this.realDLogo.Visible = false;
            // 
            // adminLinkLabel
            // 
            this.adminLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adminLinkLabel.AutoSize = true;
            this.adminLinkLabel.Location = new System.Drawing.Point(513, 389);
            this.adminLinkLabel.Name = "adminLinkLabel";
            this.adminLinkLabel.Size = new System.Drawing.Size(77, 13);
            this.adminLinkLabel.TabIndex = 18;
            this.adminLinkLabel.TabStop = true;
            this.adminLinkLabel.Text = "Admin Settings";
            this.adminLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.adminLinkLabel_LinkClicked);
            // 
            // submitPinLinkLabel
            // 
            this.submitPinLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.submitPinLinkLabel.AutoSize = true;
            this.submitPinLinkLabel.Location = new System.Drawing.Point(533, 389);
            this.submitPinLinkLabel.Name = "submitPinLinkLabel";
            this.submitPinLinkLabel.Size = new System.Drawing.Size(57, 13);
            this.submitPinLinkLabel.TabIndex = 19;
            this.submitPinLinkLabel.TabStop = true;
            this.submitPinLinkLabel.Text = "Submit Pin";
            this.submitPinLinkLabel.Visible = false;
            this.submitPinLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.submitPinLinkLabel_LinkClicked);
            // 
            // incorrectPinLabel
            // 
            this.incorrectPinLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.incorrectPinLabel.AutoSize = true;
            this.incorrectPinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrectPinLabel.ForeColor = System.Drawing.Color.Red;
            this.incorrectPinLabel.Location = new System.Drawing.Point(513, 348);
            this.incorrectPinLabel.Name = "incorrectPinLabel";
            this.incorrectPinLabel.Size = new System.Drawing.Size(80, 13);
            this.incorrectPinLabel.TabIndex = 20;
            this.incorrectPinLabel.Text = "Incorrect Pin";
            this.incorrectPinLabel.Visible = false;
            // 
            // closeAdminLinkLabel
            // 
            this.closeAdminLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeAdminLinkLabel.AutoSize = true;
            this.closeAdminLinkLabel.Location = new System.Drawing.Point(484, 389);
            this.closeAdminLinkLabel.Name = "closeAdminLinkLabel";
            this.closeAdminLinkLabel.Size = new System.Drawing.Size(106, 13);
            this.closeAdminLinkLabel.TabIndex = 21;
            this.closeAdminLinkLabel.TabStop = true;
            this.closeAdminLinkLabel.Text = "Close Admin Settings";
            this.closeAdminLinkLabel.Visible = false;
            this.closeAdminLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.closeAdminLinkLabel_LinkClicked);
            // 
            // splashPage
            // 
            this.splashPage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splashPage.Image = ((System.Drawing.Image)(resources.GetObject("splashPage.Image")));
            this.splashPage.Location = new System.Drawing.Point(-2, -3);
            this.splashPage.Name = "splashPage";
            this.splashPage.Size = new System.Drawing.Size(605, 412);
            this.splashPage.TabIndex = 22;
            this.splashPage.TabStop = false;
            this.splashPage.Click += new System.EventHandler(this.splashPage_Click);
            // 
            // seeSharpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 408);
            this.Controls.Add(this.splashPage);
            this.Controls.Add(this.closeAdminLinkLabel);
            this.Controls.Add(this.incorrectPinLabel);
            this.Controls.Add(this.submitPinLinkLabel);
            this.Controls.Add(this.adminLinkLabel);
            this.Controls.Add(this.realDLogo);
            this.Controls.Add(this.surcharge3DBox);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.pinTextBox);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.showMoviesButton);
            this.Controls.Add(this.confirmButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.loadTimesButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.orderTotalLabel);
            this.Controls.Add(this.resultOfLoadLabel);
            this.Controls.Add(this.pinLabel);
            this.Controls.Add(this.movieListLabel);
            this.Controls.Add(this.pathLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "seeSharpForm";
            this.Text = "Welcome to See Sharp Movie Theater";
            ((System.ComponentModel.ISupportInitialize)(this.realDLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splashPage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.Label movieListLabel;
        private System.Windows.Forms.Label pinLabel;
        private System.Windows.Forms.Label resultOfLoadLabel;
        private System.Windows.Forms.Label orderTotalLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Button loadTimesButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Button showMoviesButton;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.TextBox pinTextBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.CheckBox surcharge3DBox;
        private System.Windows.Forms.OpenFileDialog movieTimesFilePathDialog;
        private System.Windows.Forms.PictureBox realDLogo;
        private System.Windows.Forms.LinkLabel adminLinkLabel;
        private System.Windows.Forms.LinkLabel submitPinLinkLabel;
        private System.Windows.Forms.Label incorrectPinLabel;
        private System.Windows.Forms.LinkLabel closeAdminLinkLabel;
        private System.Windows.Forms.PictureBox splashPage;
    }
}


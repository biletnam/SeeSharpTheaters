using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SeeSharpTheaters
{
    public partial class seeSharpForm : Form
    {
        public seeSharpForm()
        {
            InitializeComponent();
            ShowAdminSettings(isAdmin);
        }

        string[] movieListArray = new string[6] { "Casablanca", "Gone With The Wind", "Lawrence of Arabia", "Citizen Kane", "Roman Holiday", "It’s a Wonderful Life" };
        const double SALES_TAX = 0.05;
        const double TICKET_PRICE = 8.00;
        const double SURCHARGE_3D = 2.00;
        bool isAdmin = false;
        const string ADMIN_PASSWORD = "ISDS309";



        private void showMoviesButton_Click(object sender, EventArgs e)
        {
            movieListLabel.Text = "";
            for (int i =0; i<movieListArray.Length; ++i)
            {
                movieListLabel.Text += movieListArray[i] + "\n";
            }
        }

        private void browseButton_Click(object sender, EventArgs e)
        {
            movieTimesFilePathDialog.ShowDialog();
            filePathTextBox.Text = movieTimesFilePathDialog.FileName;
        }

        private void loadTimesButton_Click(object sender, EventArgs e)
        {
            if (pinTextBox.Text == "ISDS309")
            {
                try
                {
                    FileStream fs = new FileStream(filePathTextBox.Text, FileMode.Open, FileAccess.Read);
                    StreamReader reader = new StreamReader(fs);

                    for (int i = 0; i < 6; ++i)
                    {
                        movieListArray[i] = reader.ReadLine();
                    }
                    reader.Close();
                    fs.Close();
                    resultOfLoadLabel.Text = "Movies loaded successfully";
                }
                catch (ArgumentException)
                {
                    resultOfLoadLabel.Text = "File Path Can't Be Blank.";
                }
                catch (FileNotFoundException)
                {
                    resultOfLoadLabel.Text = "That file does not exist!";
                }
            }
            else
            {
                resultOfLoadLabel.Text = "That is not a correct Employee PIN";
            }
        }

        private void loadTimesButton_MouseHover(object sender, EventArgs e)
        {
            loadTimesButton.Text = "This Option is For Employees Only";
        }

        private void loadTimesButtom_MouseLeave(object sender, EventArgs e)
        {
            loadTimesButton.Text = "Load Movie Times";
        }

        private double CalculateTotal(int qty, bool surcharge)
        {
            double price = TICKET_PRICE;
            if(surcharge == true)
            {
                price += SURCHARGE_3D;
            }
            double postTax = (qty * price) * (1 + SALES_TAX);
            return postTax;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double total;
                int qty = Convert.ToInt32(quantityTextBox.Text);
                total = CalculateTotal(qty, surcharge3DBox.Checked);

                orderTotalLabel.Text = "Your Total is: " + total.ToString("C");
                confirmButton.Visible = true;
            }
            catch(FormatException)
            {
                orderTotalLabel.Text = "That's a strange number of tickets...\nLet's try again.";
            }
        }

        private void surcharge3dBox_CheckedChange(object sender, EventArgs e)
        {
            if (surcharge3DBox.Checked == true)
            {
                this.BackColor = System.Drawing.Color.Turquoise;
                realDLogo.Visible = true;
            }
            else
            {
                this.BackColor = seeSharpForm.DefaultBackColor;
                realDLogo.Visible = false;
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Form confirmation = new confirmation();
            confirmation.ShowDialog();
            quantityTextBox.Text = "";
            orderTotalLabel.Text = "";
            splashPage.Visible = true;
        }

        private void adminLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            pinTextBox.Visible = true;
            pinLabel.Visible = true;
            adminLinkLabel.Visible = false;
            submitPinLinkLabel.Visible = true;
        }
        private void ShowAdminSettings(bool isAdmin)
        {
            pathLabel.Visible = isAdmin;
            filePathTextBox.Visible = isAdmin;
            browseButton.Visible = isAdmin;
            loadTimesButton.Visible = isAdmin;
        }

        private void submitPinLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(pinTextBox.Text == ADMIN_PASSWORD)
            {
                incorrectPinLabel.Visible = false;
                pinTextBox.Visible = false;
                pinTextBox.Text = "";
                pinLabel.Visible = false;
                ShowAdminSettings(true);
                submitPinLinkLabel.Visible = false;
                closeAdminLinkLabel.Visible = true;
            }
            else
            {
                incorrectPinLabel.Visible = true;
            }
        }

        private void closeAdminLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowAdminSettings(false);
            closeAdminLinkLabel.Visible = false;
            adminLinkLabel.Visible = true;

        }

        private void splashPage_Click(object sender, EventArgs e)
        {
            splashPage.Visible = false;
        }
    }
}

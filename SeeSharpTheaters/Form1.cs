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
        }

        string[] movieListArray = new string[6] { "Casablanca", "Gone With The Wind", "Lawrence of Arabia", "Citizen Kane", "Roman Holiday", "It’s a Wonderful Life" };
        const double SALES_TAX = 0.05;
        const double TICKET_PRICE = 8.00;
        const double SURCHARGE_3D = 2.00;



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
                    resultOfLoadLabel.Text = "Successfully Loaded Movies";
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

        private double CalculateTotal(int qty, double price)
        {
            double postTax = (qty * price) * (1 + SALES_TAX);
            return postTax;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double total;
            int qty = Convert.ToInt32(quantityTextBox.Text);
            if(surcharge3DBox.Checked)
            {
               total = CalculateTotal(qty, (TICKET_PRICE + SURCHARGE_3D));
            }
            else
            {
               total = CalculateTotal(qty, TICKET_PRICE);
            }

            orderTotalLabel.Text = "Your Total is: " + total.ToString("C");
            confirmButton.Visible = true;
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
    }
}

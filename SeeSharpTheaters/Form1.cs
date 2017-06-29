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
using System.Diagnostics;

namespace SeeSharpTheaters
{
    public partial class seeSharpForm : Form
    {     
        public seeSharpForm()
        {
            InitializeComponent();
            ShowAdminSettings(isAdmin);
            showMoviesButton.Focus();
        }
        string[] movieListArray = new string[6] { "Casablanca", "Gone With The Wind", "Lawrence of Arabia", "Citizen Kane", "Roman Holiday", "It’s a Wonderful Life" };
        const double SALES_TAX = 0.05;
        const double TICKET_PRICE = 8.00;
        const double SURCHARGE_3D = 2.00;
        bool isAdmin = false;
        const string ADMIN_PASSWORD = "ISDS309";
        int pinNumClicks = 0;
        

        private void showMoviesButton_Click(object sender, EventArgs e)
        {
            //Show movies in the movieListArray[]. Unless a custom on has been loaded, it will show the default array, from it's initialization on line 23
            movieListLabel.Text = "";
            for (int i =0; i<movieListArray.Length; ++i)
            {
                movieListLabel.Text += movieListArray[i] + "\n";
            }                       
        }
        private void browseButton_Click(object sender, EventArgs e)
        {
            //Browse button opens an Open File Dialog, and upon selecting the file, the file path will be puth in the movie times file path.
            movieTimesFilePathDialog.ShowDialog();
            filePathTextBox.Text = movieTimesFilePathDialog.FileName;
        }
        private void loadTimesButton_Click(object sender, EventArgs e)
        {
                try
                {
                //New File stream for opening a custom movie listing. overwrites the values in the movieListArray[]
                    FileStream fs = new FileStream(filePathTextBox.Text, FileMode.Open, FileAccess.Read);
                    StreamReader reader = new StreamReader(fs);
                // each line of the .txt file becomes a record in the array
                    for (int i = 0; i < 6; ++i)
                    {
                        movieListArray[i] = reader.ReadLine();
                    }
                    reader.Close();
                    fs.Close();
                // if this works, display a success message
                    resultOfLoadLabel.Text = "Movies loaded successfully";
                splashPage.Visible = true;
                }
                catch (ArgumentException)
                {
                //catch blank file paths
                    resultOfLoadLabel.Text = "File Path Can't Be Blank.";
                }
                catch (FileNotFoundException)
                {
                //catch incorrect file paths
                    resultOfLoadLabel.Text = "That file does not exist!";
                }
        }     
        private void calculateButton_Click(object sender, EventArgs e)
        {
            string error = "That's a strange number of tickets...\nLet's try again.";
            try
            {
                //Calculate the total owed and display it into an outputlabel
                double total;
                
                uint qty = Convert.ToUInt32(quantityTextBox.Text);
                total = CalculateTotal(qty, surcharge3DBox.Checked);

                orderTotalLabel.Text = "Your Total is: " + total.ToString("C");
                //turn on the confirmButton when price successfully calculates.
                confirmButton.Visible = true;
            }
            catch(FormatException)
            {
                //catch a non integer in the quantity.
                orderTotalLabel.Text = error;
                confirmButton.Visible = false;
            }
            catch(OverflowException)
            {
                //Catch a negative integer in the quantity.
                orderTotalLabel.Text = error;
                confirmButton.Visible = false;
            }
        }
        private void surcharge3dBox_CheckedChange(object sender, EventArgs e)
        {
            //When the box is checked, the background changes to turquoise and the Real D logo shows.
            if (surcharge3DBox.Checked == true)
            {
                this.BackColor = System.Drawing.Color.Turquoise;
                realDLogo.Visible = true;
            }
            else
            {
                //When unchecked it returns to normal. 
                this.BackColor = seeSharpForm.DefaultBackColor;
                realDLogo.Visible = false;
            }
        }
        private void confirmButton_Click(object sender, EventArgs e)
        {
            //Open a new form when the confirmation burron is clicked. Show the splash page when complete.
            Form confirmation = new confirmation();
            confirmation.ShowDialog();
            this.BackColor = seeSharpForm.DefaultBackColor;
            splashPage.Visible = true;
        }
        private void adminLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Show controls to input an employee Pin
            ReceivingPinControlsVisible(true);
            //Hide the original admin settings label
            adminLinkLabel.Visible = false;
            //let user immediately start putting in the pin, by giving the box focus.
            pinTextBox.Focus();
            //Disable all the customer controls, while administrator is using.
            CustomerControlsEnabled(false);
            //Show option to back out to splash page
            closeAdminLinkLabel.Visible = true;
        }
        private void closeAdminLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //show splash page when exiting admin panel
            splashPage.Visible = true;
        }
        private void splashPage_Click(object sender, EventArgs e)
        {
            //Click to begin, also resets all fields back to what they should be at the start of the cycle.
            splashPage.Visible = false;
            Reset();
        }
        private void pinTextBox_Return(object sender, KeyPressEventArgs e)
        {
            //if a user presses enter on the pin texdt box it, it will execute the button click event.
            if (e.KeyChar == (char)13)
            {
                this.submitPinButton_Click(sender, new EventArgs());
            }

        }
        private void submitPinButton_Click(object sender, EventArgs e)
        {
            //Gives the user a few tries to get the pin right. If they fail, starts over at the splash page which will reset everything.
            if (pinNumClicks <= 3)
            {
                if (pinTextBox.Text == ADMIN_PASSWORD)
                {
                    incorrectPinLabel.Visible = false;
                    pinTextBox.Visible = false;
                    pinTextBox.Text = "";
                    pinLabel.Visible = false;
                    ShowAdminSettings(true);
                    submitPinButton.Visible = false;
                    closeAdminLinkLabel.Visible = true;
                }
                else
                {
                    incorrectPinLabel.Visible = true;
                    incorrectPinLabel.Text = "Incorrect PIN";
                    pinNumClicks++;
                }
            }
            else
            {
                splashPage.Visible = true;
                incorrectPinLabel.Text = "You tried too many PINs";
            }
        }
        private double CalculateTotal(uint qty, bool surcharge)
        {
            //Calculate method. Takes a uint quantity, and a boolean. The second argument for this method should always be surcharge3DBox.Checked to return a True or False statement based on the form. 
            double price = TICKET_PRICE;
            if (surcharge == true)
            {
                price += SURCHARGE_3D;
            }
            double postTax = (qty * price) * (1 + SALES_TAX);
            return postTax;
        }
        private void ReceivingPinControlsVisible(bool vis)
        {
            //takes a boolean and sets the .Visible properties of all the controls related to accepting a user Pin and sets them to whatever the value of the argument was that was passed through.
            pinTextBox.Visible = vis;
            pinLabel.Visible = vis;
            submitPinButton.Visible = vis;
        }
        private void CustomerControlsEnabled(bool enabled)
        {
            //Passes a boolean through to the .Enabled property of all the non admin related controls.
            showMoviesButton.Enabled = enabled;
            quantityTextBox.Enabled = enabled;
            surcharge3DBox.Enabled = enabled;
        }
        private void ShowAdminSettings(bool isAdmin)
        {
            //passes a boolean through to the .Visible property of the admin panel controls.
            pathLabel.Visible = isAdmin;
            filePathTextBox.Visible = isAdmin;
            browseButton.Visible = isAdmin;
            loadTimesButton.Visible = isAdmin;
        }
        private void Reset()
        {
            //Wipes everything out and returns the form to it's beginning state. 
            CustomerControlsEnabled(true);
            ShowAdminSettings(false);
            ReceivingPinControlsVisible(false);           
            surcharge3DBox.Checked = false;
            quantityTextBox.Text = "";
            pinTextBox.Text = "";
            incorrectPinLabel.Text = "";
            resultOfLoadLabel.Text = "";
            movieListLabel.Text = "";
            closeAdminLinkLabel.Visible = false;
            adminLinkLabel.Visible = true;
            confirmButton.Visible = false;
            orderTotalLabel.Text = "";
        }
    }
}

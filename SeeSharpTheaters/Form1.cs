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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] movieListArray = new string[6] { "Casablanca", "Gone With The Wind", "Lawrence of Arabia", "Citizen Kane", "Roman Holiday", "It’s a Wonderful Life" };

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
                    resultOfLoadLabel.Text = "Whoops! File Path Can't Be Blank.";
                }
                catch (FileNotFoundException)
                {
                    resultOfLoadLabel.Text = "Uh Oh! Looks like that file doesn't exist.";
                }
            }
            else
            {
                resultOfLoadLabel.Text = "That is not a correct Employee PIN";
            }
        }
    }
}

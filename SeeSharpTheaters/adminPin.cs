using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SeeSharpTheaters
{
    public partial class adminPin : Form
    {
        public adminPin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value = pinTextBox.Text;
            this.Close();
        }

        public string getText()
        {
            return pinTextBox.Text;
        }
    }
}

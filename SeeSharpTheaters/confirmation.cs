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
    public partial class confirmation : Form
    {
        public confirmation()
        {
            InitializeComponent();
        }

        private void returnToMainButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4FormsTest2
{
    public partial class ShowErrorMessage : Form
    {
        public string Error { get; set; }
        public ShowErrorMessage(string error)
        {
            InitializeComponent();
            Error = error;
        }

        private void ShowErrorMessage_Load(object sender, EventArgs e)
        {
            errorLabel.Text = Error;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void errorLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

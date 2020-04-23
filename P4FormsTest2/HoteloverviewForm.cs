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
    public partial class HoteloverviewForm : Form
    {
        public HoteloverviewForm()
        {
            InitializeComponent();
        }

        private void resButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 reservationsform = new Form1();
            reservationsform.Closed += (s, args) => this.Close();
            reservationsform.Show();
        }

        private void hotButton_Click(object sender, EventArgs e)
        {

        }

        private void gueButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuestmanagementForm guestmanagementform = new GuestmanagementForm();
            guestmanagementform.Closed += (s, args) => this.Close();
            guestmanagementform.Show();
        }
    }
}

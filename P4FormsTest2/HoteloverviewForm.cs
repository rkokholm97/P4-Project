using System;
using System.Drawing;
using System.Windows.Forms;

namespace P4FormsTest2
{
    public partial class HoteloverviewForm : Form
    {
        public Form1 WinForm1 { get; set; }
        
        public HoteloverviewForm(Form1 winForm1)
        {
            WinForm1 = winForm1;
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
            GuestmanagementForm guestmanagementform = new GuestmanagementForm(WinForm1);
            guestmanagementform.Closed += (s, args) => this.Close();
            guestmanagementform.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void HoteloverviewForm_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                string roomNumberString = Convert.ToString(WinForm1.rooms[i].Number);
                Button newButton = new Button();
                newButton.Text = (roomNumberString + "\n\n" + "AVA");
                newButton.BackColor = Color.Green;
                newButton.Width = 80;
                newButton.Height = 80;
                flowLayoutPanel2.Controls.Add(newButton);
                /*if (roomNumberString[0] == '1')
                {
                    Button newButton = new Button();
                    newButton.Text = (roomNumberString + "\n\n" + "AVA");
                    newButton.BackColor = Color.Green;
                    newButton.Width = 80;
                    newButton.Height = 80;
                    flowLayoutPanel2.Controls.Add(newButton);
                }*/
            }
        }
    }
}

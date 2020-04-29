using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace P4FormsTest2
{
    public partial class HoteloverviewForm : Form
    {
        public ReservationsForm ReservationsForm { get; set; }
        public List<Room> Rooms { get; set; }
        
        public HoteloverviewForm(ReservationsForm winForm1)
        {
            ReservationsForm = winForm1;
            Rooms = ReservationsForm.rooms;
            InitializeComponent();
        }

        private void resButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReservationsForm reservationsform = new ReservationsForm();
            reservationsform.Closed += (s, args) => this.Close();
            reservationsform.Show();
        }

        private void hotButton_Click(object sender, EventArgs e)
        {

        }

        private void gueButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuestmanagementForm guestmanagementform = new GuestmanagementForm(ReservationsForm);
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
            /*foreach(Room room in Rooms)
            {
                if(room.Number)
            } /*

            for (int i = 0; i < 3; i++)
            {
                string roomNumberString = Convert.ToString(Rooms[i].Number);
                Button newButton = new Button();
                newButton.Text = (roomNumberString + "\n\n" + "AVA");
                newButton.BackColor = Color.Green;
                newButton.Width = 80;
                newButton.Height = 80;
                floorTablePanel.Controls.Add(newButton);
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

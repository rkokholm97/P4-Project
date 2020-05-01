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
            Rooms.Sort();
            Rooms.Reverse();
            int floorcount = Convert.ToInt32(Math.Floor(Convert.ToDouble(Rooms[0].Number) / 100 + 1));
            label1.Text = floorcount.ToString();

            TableLayoutPanel floorTablePanel = new TableLayoutPanel();
            floorTablePanel.AutoScroll = true;
            floorTablePanel.RowCount = floorcount * 2;

            tableLayoutPanel2.Controls.Add(floorTablePanel, 0, 1);

            for(int i = 0; i < floorTablePanel.RowCount; i++)
            {
                if(i%2 == 0)
                {
                    Label floorLabel = new Label();
                    //floorLabel.Text = "Floor" + i.ToString();
                    floorLabel.Text = "Floor x";
                    floorTablePanel.Controls.Add(floorLabel);
                } else
                {
                    TableLayoutPanel roomstable = new TableLayoutPanel();
                    roomstable.ColumnCount = 8;
                    roomstable.Dock = DockStyle.Fill;
                    roomstable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
                    TableLayoutStyleCollection styles = roomstable.ColumnStyles;
                    roomstable.RowCount = 3;

                    foreach(ColumnStyle style in styles)
                    {
                        style.SizeType = SizeType.Percent;
                        style.Width = 50;
                    }
                    foreach(RowStyle style in styles)
                    {
                        style.SizeType = SizeType.Absolute;
                        style.Height = 20;
                    }

                    floorTablePanel.Controls.Add(roomstable);
                }

            }

            /*for (int i = 0; i < floorcount; i++)
            {
                string roomNumberString = Convert.ToString(Rooms[i].Number);
                Button newButton = new Button();
                newButton.Text = (roomNumberString + "\n\n" + "AVA");
                newButton.BackColor = Color.Green;
                newButton.Width = 80;
                newButton.Height = 80;
                floorTablePanel.Controls.Add(newButton);
                if (roomNumberString[0] == '1')
                {
                    Button newButton = new Button();
                    newButton.Text = (roomNumberString + "\n\n" + "AVA");
                    newButton.BackColor = Color.Green;
                    newButton.Width = 80;
                    newButton.Height = 80;
                    flowLayoutPanel2.Controls.Add(newButton);
                }
            }*/
        }

        private void newRoomBtn_Click(object sender, EventArgs e)
        {
            NewRoomForm newRoomForm = new NewRoomForm(ReservationsForm);
            newRoomForm.Show();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

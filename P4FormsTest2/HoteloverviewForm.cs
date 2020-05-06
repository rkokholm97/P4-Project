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

            //get the amount of floors
            int floorcount = Convert.ToInt32(Math.Floor(Convert.ToDouble(Rooms[0].Number) / 100 + 1));

            //create two containers that are tablelayoutpanels for the floor overview and the button grid. Add to tablelayoutpanel2.

            floorTablePanel.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            floorTablePanel.MaximumSize = new Size(floorTablePanel.Width, floorTablePanel.Height);
            floorTablePanel.AutoScroll = true;

            for (int i = 0; i < floorTablePanel.RowCount; i++)
            {
                floorTablePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 100));
            }

            TableLayoutPanel buttonTablePanel = new TableLayoutPanel();
            buttonTablePanel.ColumnCount = 1;
            buttonTablePanel.RowCount = floorcount;
            buttonTablePanel.AutoScroll = true;
            buttonTablePanel.Dock = DockStyle.Fill;
            tableLayoutPanel2.Controls.Add(buttonTablePanel, 1, 0);

            //Create a button for each floor and add to the button grid
            int floornumberButton = floorcount - 1;
            for (int i = 0; i < buttonTablePanel.RowCount; i++)
            {
                buttonTablePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 80));
                Button b = new Button();
                b.Text = "Floor " + floornumberButton.ToString();
                b.Dock = DockStyle.Top;
                b.Height = 80;
                buttonTablePanel.Controls.Add(b, 0, i);
                floornumberButton--;
            }
            //Create a subgrid and label for each floor. Add both to the floorTabelPanel.
            int x = floorcount - 1;
            for (int i = 0; i < floorcount*2; i++)
            {
                /*Label l = new Label();
                l.Text = "Floor" + x.ToString();
                floorPanel.Controls.Add(l);*/
                TableLayoutPanel roomstable = new TableLayoutPanel();
                roomstable.ColumnCount = 8;
                roomstable.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
                roomstable.RowCount = 3;
                //roomstable.Dock = DockStyle.Top;

                for (int j = 0; j < roomstable.ColumnCount; j++)
                {
                    roomstable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 12));
                }
                    
                for (int j = 0; j < roomstable.RowCount; j++)
                {
                    //roomstable.RowStyles.Add(new RowStyle(SizeType.Percent, 33));
                    roomstable.RowStyles.Add(new RowStyle(SizeType.Absolute, 80));
                    /*Button b = new Button();
                    b.Text = "test";
                    roomstable.Controls.Add(b,0,j);*/
                }
                    
                //floorPanel.Controls.Add(roomstable);                     
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

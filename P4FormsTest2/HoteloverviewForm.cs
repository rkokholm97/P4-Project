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

        public TableLayoutPanel buttonTablePanel { get; set; } = new TableLayoutPanel();
        
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
            printFloorButtonPanel();
            printRooms();

            int vertScrollWidth = SystemInformation.VerticalScrollBarWidth;

            floorTablePanel.Padding = new Padding(0, 0, vertScrollWidth, 0);
            floorTablePanel.ScrollControlIntoView(floorTable_0);

        }

        private void scrollToFloor(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string floornumber = button.Text.Split(' ')[1];
            string tablename = "floorTable_" + floornumber;
            TableLayoutPanel table;

            foreach(Control control in floorTablePanel.Controls)
            {
                if(control is TableLayoutPanel && control.Name == tablename)
                {
                    table = (TableLayoutPanel)control;
                    floorTablePanel.ScrollControlIntoView(table);
                }
            }        
        }

        private void viewRoomInfo(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Room r = null;
            foreach(Room room in Rooms)
            {
                if(room.Number == Int32.Parse(button.Name.Split('_')[1]))
                {
                    r = room;
                }
            }

            viewRoomForm form = new viewRoomForm(r, this);
            form.Show();
        }

        private void newRoomBtn_Click(object sender, EventArgs e)
        {
            NewRoomForm newRoomForm = new NewRoomForm(this);
            newRoomForm.Show();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clearRoomButtons()
        {
            for (int i = floorTablePanel.Controls.Count - 1; i >= 0; --i)
            {
                if (floorTablePanel.Controls[i] is TableLayoutPanel)
                {
                    TableLayoutPanel table = (TableLayoutPanel)floorTablePanel.Controls[i];
                    for (int j = table.Controls.Count - 1; j >= 0; --j)
                    {
                        table.Controls[j].Dispose();
                    }               
                }
            }        
        }

        private void clearFloorButtonPanel()
        {
            for (int i = buttonTablePanel.Controls.Count - 1; i >= 0; --i)
            {
                buttonTablePanel.Controls[i].Dispose();
            }
        }

        public void printRooms()
        {
            clearRoomButtons();
            foreach (Room room in Rooms)
            {
                decimal x = Math.Floor(Convert.ToDecimal(room.Number / 100));
                int floornumber = (int)x;

                foreach (Control control in floorTablePanel.Controls)
                {
                    if (control is TableLayoutPanel)
                    {
                        string[] tableFloorNumber = control.Name.Split('_');
                        if (floornumber == Int32.Parse(tableFloorNumber[1]))
                        {
                            Button b = new Button();
                            b.Name = "room_" + room.Number.ToString();
                            b.Text = (room.Number.ToString());                            
                            b.Font = new Font(b.Font, FontStyle.Bold);
                            
                            b.FlatStyle = FlatStyle.Flat;
                            b.FlatAppearance.BorderColor = Color.White;

                            switch(room.Status.ToString())
                            {
                                case "Available":
                                    b.BackColor = Color.Green;
                                    b.ForeColor = Color.White;
                                    break;
                                case "Occupied":
                                    b.BackColor = Color.RoyalBlue;
                                    b.ForeColor = Color.White;
                                    break;
                                case "Outoforder":
                                    b.BackColor = Color.Brown;
                                    b.ForeColor = Color.White;
                                    break;
                                case "Outofservice":
                                    b.BackColor = Color.Yellow;
                                    b.ForeColor = Color.Black;
                                    break;
                            }

                            if (room.IsSuite == true)
                            {
                                b.BackColor = Color.Goldenrod;
                                b.Font = new Font(b.Font, FontStyle.Bold);
                                b.ForeColor = Color.Black;
                            }

                            b.Width = 80;
                            b.Height = 80;
                            b.Dock = DockStyle.Fill;
                            b.Margin = new Padding(0, 0, 0, 0);
                            b.Click += new EventHandler(viewRoomInfo);
                            control.Controls.Add(b);
                        }
                    }
                }
            }
        }

        public void printFloorButtonPanel()
        {
            clearFloorButtonPanel();
            //get the amount of floors
            int floorcount = Convert.ToInt32(Math.Floor(Convert.ToDouble(Rooms[Rooms.Count - 1].Number) / 100 + 1));

            buttonTablePanel.ColumnCount = 1;
            buttonTablePanel.RowCount = floorcount;
            buttonTablePanel.AutoScroll = true;
            buttonTablePanel.Dock = DockStyle.Fill;
            tableLayoutPanel2.Controls.Add(buttonTablePanel, 1, 0);

            //Create a button for each floor and add to the button grid
            int floorLabelNumber = floorcount - 1;
            for (int i = 0; i < buttonTablePanel.RowCount; i++)
            {
                buttonTablePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 50));
                Button b = new Button();
                b.Text = "Floor " + floorLabelNumber.ToString();
                b.Dock = DockStyle.Top;
                b.Height = 50;
                b.Click += new EventHandler(scrollToFloor);
                buttonTablePanel.Controls.Add(b, 0, i);
                floorLabelNumber--;
            }
        }
    }
}

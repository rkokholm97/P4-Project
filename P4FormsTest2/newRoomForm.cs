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
using Newtonsoft.Json;

namespace P4FormsTest2
{
    public partial class NewRoomForm : Form
    {
        Form1 Form1 { get; set; }
        public NewRoomForm(Form1 form1)
        {
            InitializeComponent();
            Form1 = form1;
        }

        public void NewRoomForm_Load(object sender, EventArgs e)
        {
            
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addRoomBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int floor = Int32.Parse(floorField.Text);
                int roomnumber = Int32.Parse(roomNumberField.Text) + (100*floor);            
                int maxoccupants = Convert.ToInt32(maxOccupantsField.Value);
                bool issuite = false;
                if (suiteRadio.Checked == true)
                {
                    issuite = true;
                }
                int rownumber = 0;
                foreach(Room room in Form1.rooms)
                {
                    if (floor == room.Floor)
                    {
                        rownumber++;
                    }
                }

                Room r = new Room(roomnumber, issuite, maxoccupants, floor, rownumber);
                Form1.rooms.Add(r);

                Form1.rooms.Sort();

                Form1.printRooms();
                /*int i = Form1.rooms.Count() - 1;
                Label l = new Label();
                l.Dock = DockStyle.Fill;
                l.Text = r.Number.ToString();
                l.Font = new Font(l.Font, FontStyle.Bold);
                l.TextAlign = ContentAlignment.MiddleCenter;
                l.Name = "roomLabel " + r.Number.ToString();
                Form1.tableLayoutPanel4.Controls.Add(l, 0, i);
                Form1.tableLayoutPanel4.SetColumnSpan(l, 1);*/

                File.WriteAllText(@"..\..\..\rooms.json", JsonConvert.SerializeObject(Form1.rooms, Formatting.Indented));

                this.Close();
            }
            catch (Exception)
            {
                this.Close();
            }
        }

    }
}

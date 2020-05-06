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
        HoteloverviewForm HoteloverviewForm { get; set; }
        public NewRoomForm(HoteloverviewForm form1)
        {
            InitializeComponent();
            HoteloverviewForm = form1;
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
                foreach(Room room in HoteloverviewForm.Rooms)
                {
                    if (floor == room.Floor)
                    {
                        rownumber++;
                    }
                }

                Room r = new Room(roomnumber, issuite, maxoccupants, floor, rownumber);
                HoteloverviewForm.Rooms.Add(r);
                HoteloverviewForm.Rooms.Sort();

                File.WriteAllText(@"..\..\..\rooms.json", JsonConvert.SerializeObject(HoteloverviewForm.Rooms, Formatting.Indented));
                HoteloverviewForm.printRooms();
                HoteloverviewForm.printFloorButtonPanel();
                this.Close();
            }
            catch (Exception)
            {
                this.Close();
            }
        }

    }
}

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
    public partial class EditRoomForm : Form
    {
        public Room Room { get; set; }
        public HoteloverviewForm HoteloverviewForm { get; set; }

        public List<String> statuses = new List<String>();

        public EditRoomForm(Room room, HoteloverviewForm hoteloverviewForm)
        {
            InitializeComponent();
            Room = room;
            HoteloverviewForm = hoteloverviewForm;
        }

        public void EditRoomForm_Load(object sender, EventArgs e)
        {
            statuses.Add("Available");
            statuses.Add("Occupied");
            statuses.Add("Out Of Order");
            statuses.Add("Out Of Service");
            
            statusDropDown.DataSource = statuses;

            floorField.Value = Room.Floor;
            roomNumberField.Value = Room.Number - (Room.Floor*100);
            maxOccupantsField.Value = Room.MaxOccupants;

            if(Room.IsSuite == true)
            {
                suiteRadio.Checked = true;
            } else
            {
                regularRadio.Checked = true;
            }

            switch(Room.Status)
            {
                case Room.Statusnum.Available:
                    statusDropDown.SelectedItem = statuses[0];
                    break;
                case Room.Statusnum.Occupied:
                    statusDropDown.SelectedItem = statuses[1];
                    break;
                case Room.Statusnum.Outoforder:
                    statusDropDown.SelectedItem = statuses[2];
                    break;
                case Room.Statusnum.Outofservice:
                    statusDropDown.SelectedItem = statuses[3];
                    break;
            }
            
        }

        private void titleLabel_Click(object sender, EventArgs e)
        {

        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editRoomBtn_Click(object sender, EventArgs e)
        {
            List<String> errors = new List<String>();

            if (floorField.Value > 10 || floorField.Value < 0)
            {
                errors.Add("Floor number must be between 0 and 10");
            }
            
            if(roomNumberField.Value > 24 || roomNumberField.Value <= 0)
            {
                errors.Add("Room number must be between 1 and 24");
            }

            if(errors.Count > 0)
            {
                ShowErrorMessage error = new ShowErrorMessage(errors[0]);
                error.Show();
            } else
            {
                Room.Floor = Convert.ToInt32(floorField.Value);
                Room.Number = 100*Room.Floor + Convert.ToInt32(roomNumberField.Value);           
                Room.MaxOccupants = Convert.ToInt32(maxOccupantsField.Value);

                if (suiteRadio.Checked == true)
                {
                    Room.IsSuite = true;
                }
                else
                {
                    Room.IsSuite = false;
                }

                string statuschoice = statusDropDown.SelectedItem.ToString();
                switch (statuschoice)
                {
                    case "Available":
                        Room.Status = Room.Statusnum.Available;
                        break;
                    case "Occupied":
                        Room.Status = Room.Statusnum.Occupied;
                        break;
                    case "Out Of Order":
                        Room.Status = Room.Statusnum.Outoforder;
                        break;
                    case "Out Of Service":
                        Room.Status = Room.Statusnum.Outofservice;
                        break;
                }
                HoteloverviewForm.printRooms();
                this.Close();
            }      
        }
    }
}

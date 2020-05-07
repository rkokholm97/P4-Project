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
    public partial class viewRoomForm : Form
    {
        public Room Room { get; set; }
        public HoteloverviewForm HoteloverviewForm { get; set; }
        public viewRoomForm(Room room, HoteloverviewForm hoteloverviewForm)
        {
            InitializeComponent();
            Room = room;
            HoteloverviewForm = hoteloverviewForm;
        }

        private void viewRoomForm_Load(object sender, EventArgs e)
        {
            roomTitleLabel.Text = "Room " + Room.Number.ToString();
            this.Text = "Room " + Room.Number.ToString();

            floorNumberLabel.Text = Room.Floor.ToString();
            maxOccupantsLabel.Text = Room.MaxOccupants.ToString();
            statusLabel.ForeColor = Color.Green;
            statusLabel.Font = new Font(statusLabel.Font, FontStyle.Bold);

            if (Room.IsSuite == true)
            {
                roomTypeLabel.Text = "Suite";
                roomTypeLabel.ForeColor = Color.Goldenrod;
                roomTypeLabel.Font = new Font(statusLabel.Font, FontStyle.Bold);
            } else
            {
                roomTypeLabel.Text = "Regular";
            }
            

            switch(Room.Status.ToString())
            {
                case "Available":
                    statusLabel.Text = "Available";
                    break;
                case "Occupied":
                    statusLabel.Text = "Occupied";
                    statusLabel.ForeColor = Color.RoyalBlue;
                    break;
                case "Outoforder":
                    statusLabel.Text = "Out Of Order";
                    statusLabel.ForeColor = Color.Brown;
                    break;
                case "Outofservice":
                    statusLabel.Text = "Out Of Service";
                    statusLabel.ForeColor = Color.Yellow;
                    break;
            }

        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteRoom_btn_Click(object sender, EventArgs e)
        {
            bool error = false;
            foreach(Room room in HoteloverviewForm.Rooms)
            {
                if(room.Number == Room.Number)
                {
                    foreach(Reservation reservation in HoteloverviewForm.ReservationsForm.reservations)
                    {
                        if(reservation.Room.Number == room.Number)
                        {
                            error = true;
                        }
                    }

                    if (error == false)
                    {
                        HoteloverviewForm.Rooms.Remove(room);
                        File.WriteAllText(@"..\..\..\rooms.json", JsonConvert.SerializeObject(HoteloverviewForm.Rooms, Formatting.Indented));
                        HoteloverviewForm.printRooms();
                        HoteloverviewForm.printFloorButtonPanel();
                        this.Close();
                        break;
                    }
                    else
                    {
                        ShowErrorMessage errorMessage = new ShowErrorMessage("You can't delete a room that has been or is currently booked");
                        errorMessage.Show();
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void editRoomButton_Click(object sender, EventArgs e)
        {
            EditRoomForm form = new EditRoomForm(Room, HoteloverviewForm);
            form.Show();
        }
    }
}

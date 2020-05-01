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
    public partial class EditReservationForm : Form
    {
        ReservationsForm ResForm = new ReservationsForm();
        Reservation r { get; set; }
        public ListBox roomSelectionField = new ListBox();
        public EditReservationForm(ReservationsForm resForm, Reservation reservation)
        {
            InitializeComponent();
            ResForm = resForm;
            r = reservation;
        }

        public void EditReservationForm_Load(object sender, EventArgs e)
        {
            roomSelectionField.Size = new Size(277, 160);
            roomSelectionField.Location = new Point(12, 288);

            foreach (Room room in ResForm.rooms)
            {
                roomSelectionField.Items.Add(room);
            }

            this.Controls.Add(roomSelectionField);

            editResNameField.Text = r.Name;
            editResEmailField.Text = r.Email;
            editResPhoneField.Text = r.PhoneNumber;
            editResAdultsField.Value = r.NumberOfAdults;
            editResChildrenField.Value = r.NumberOfChildren;
            editResStartField.SetDate(r.Start);
            editResEndField.SetDate(r.End);
            roomSelectionField.SetSelected(GetSelectedRoomIndex(r.Room.Number), true);
            this.Text = "Edit Reservation: " + r.Id.ToString();
        }

        private int GetSelectedRoomIndex(int roomnumber)
        {
            foreach(var listBoxItem in roomSelectionField.Items)
            {
                string itemtext = roomSelectionField.GetItemText(listBoxItem);
                if (itemtext == roomnumber.ToString())
                {
                    return roomSelectionField.Items.IndexOf(listBoxItem);
                }
            }
            return 0;
        }

        private void editResCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editResConfirmButton_Click(object sender, EventArgs e)
        {
            string name = editResNameField.Text;
            string email = editResEmailField.Text;
            string phone = editResPhoneField.Text;
            DateTime start = editResStartField.SelectionStart;
            DateTime end = editResEndField.SelectionStart;
            int adults = Convert.ToInt32(Math.Round(editResAdultsField.Value, 0));
            int children = Convert.ToInt32(Math.Round(editResChildrenField.Value, 0));
            Room selectedRoom = roomSelectionField.SelectedItem as Room;
            bool availability = true;
            
            try {
                foreach (Reservation reservation in ResForm.reservations)
                {
                    if (reservation.Room.Number == selectedRoom.Number)
                    {
                        if ((start >= reservation.Start && start <= reservation.End) || (end <= reservation.End && end >= reservation.Start))
                        {
                            if(reservation != r)
                            {
                                availability = false;
                            }                    
                        }
                    }
                }

                if (availability == true)
                {
                    if (start > end)
                    {
                        ShowErrorMessage error = new ShowErrorMessage("Start date cannot be later than end date");
                        error.Show();
                    }
                    else
                    {
                        r.Name = editResNameField.Text;
                        r.Email = editResEmailField.Text;
                        r.PhoneNumber = editResPhoneField.Text;
                        r.Start = editResStartField.SelectionStart;
                        r.End = editResEndField.SelectionStart;
                        r.NumberOfAdults = Convert.ToInt32(Math.Round(editResAdultsField.Value, 0));
                        r.NumberOfChildren = Convert.ToInt32(Math.Round(editResChildrenField.Value, 0));
                        r.Room = roomSelectionField.SelectedItem as Room;

                        File.WriteAllText(@"..\..\..\reservations.json", JsonConvert.SerializeObject(ResForm.reservations, Formatting.Indented));
                        File.WriteAllText(@"..\..\..\rooms.json", JsonConvert.SerializeObject(ResForm.rooms, Formatting.Indented));

                        ResForm.printReservations();

                        this.Close();
                    }
                }
                else
                {
                    ShowErrorMessage errorwindow = new ShowErrorMessage("Selected room is already booked at that time.");
                    errorwindow.Show();
                }
            } catch (Exception)
            {
                ShowErrorMessage error = new ShowErrorMessage("Please fill out all fields and select a room");
                error.Show();
            }
        }
    }
}

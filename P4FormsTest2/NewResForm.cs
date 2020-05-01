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
using System.Collections.ObjectModel;

namespace P4FormsTest2
{
    public partial class NewResForm : Form
    {
        public ReservationsForm form1;
        public ListBox roomSelectionField = new ListBox();
        public NewResForm(ReservationsForm callingForm)
        {
            form1 = callingForm;
            InitializeComponent();
        }

        public void Form2_load(object sender, EventArgs e)
        {
            roomSelectionField.Size = new Size(277, 160);
            roomSelectionField.Location = new Point(12, 288);

            foreach (Room room in form1.rooms)
            {
                roomSelectionField.Items.Add(room);
            }

            this.Controls.Add(roomSelectionField);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void newResCancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newResConfirmButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = newResNameField.Text;
                string email = newResEmailField.Text;
                string phone = newResPhoneField.Text;
                DateTime start = newResStartField.SelectionStart;
                DateTime end = newResEndField.SelectionStart;
                int adults = Convert.ToInt32(Math.Round(newResAdultsField.Value, 0));
                int children = Convert.ToInt32(Math.Round(newResChildrenField.Value, 0));
                Room selectedRoom = roomSelectionField.SelectedItem as Room;

                bool availability = true;

                foreach (Reservation reservation in form1.reservations)
                {
                    if (reservation.Room.Number == selectedRoom.Number)
                    {
                        if ((start >= reservation.Start && start <= reservation.End) || (end <= reservation.End && end >= reservation.Start))
                        {
                            availability = false;
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
                        Reservation r = new Reservation(name, selectedRoom, start, end, phone, email, adults, children);
                        form1.reservations.Add(r);
                        int i = form1.reservations.Count() - 1;

                        Button b = new Button();
                        b.Dock = DockStyle.Fill;
                        b.Text = name;
                        b.Name = r.Id.ToString();
                        b.Click += new EventHandler(form1.resViewButton_Click);
                        form1.tableLayoutPanel4.Controls.Add(b, 1, i);
                        form1.tableLayoutPanel4.SetColumnSpan(b, 4);

                        File.WriteAllText(@"..\..\..\reservations.json", JsonConvert.SerializeObject(form1.reservations, Formatting.Indented));
                        File.WriteAllText(@"..\..\..\rooms.json", JsonConvert.SerializeObject(form1.rooms, Formatting.Indented));

                        form1.printReservations();

                        this.Close();
                    }

                }
                else
                {
                    ShowErrorMessage errorwindow = new ShowErrorMessage("Selected room is already booked at that time.");
                    errorwindow.Show();
                }
            }
            catch(Exception)
            {
                ShowErrorMessage error = new ShowErrorMessage("Please fill out all fields and select a room");
                error.Show();
            }     

        }
                 
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

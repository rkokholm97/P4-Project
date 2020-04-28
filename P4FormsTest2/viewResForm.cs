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
    public partial class viewResForm : Form
    {
        Reservation r { get; set; }
        Form1 form1;
        Button button;
        public viewResForm(Reservation reservation, Form1 form, Button btn)
        {
            InitializeComponent();
            r = reservation;
            form1 = form;
            button = btn;
        }

        private void viewResForm_Load(object sender, EventArgs e)
        {
            viewResIdLabel.Text = r.Id.ToString();
            viewResNameLabel.Text = r.Name;
            viewResEmailLabel.Text = r.Email;
            viewResPhoneLabel.Text = r.PhoneNumber;
            viewResAdultsAmount.Text = r.NumberOfAdults.ToString();
            viewResChildrenAmount.Text = r.NumberOfChildren.ToString();
            viewResTotalGuestsAmount.Text = r.NumberOfGuests.ToString();
            viewResStartLabel.Text = r.Start.ToString();
            viewResEndLabel.Text = r.End.ToString();
            viewResRoomLabel.Text = r.Room.Number.ToString();
            this.Text = "Reservation Detals - Reservation ID " + r.Id.ToString();
        }

        private void testBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void viewResDeleteBtn_Click(object sender, EventArgs e)
        {
            foreach(Reservation reservation in form1.reservations)
            {
                if(reservation.Id == r.Id)
                {
                    form1.reservations.Remove(r);
                    File.WriteAllText(@"..\..\..\reservations.json", JsonConvert.SerializeObject(form1.reservations, Formatting.Indented));
                    File.WriteAllText(@"..\..\..\rooms.json", JsonConvert.SerializeObject(form1.rooms, Formatting.Indented));

                    // Remove Button from UI
                    form1.Controls.Remove(button);
                    button.Dispose();

                    Close();
                    break;
                }
            }
        }
    }
}

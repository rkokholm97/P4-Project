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
    public partial class GuestmanagementForm : Form
    {
        public ReservationsForm WinForm1 { get; set; }
        public List<Reservation> reservations = new List<Reservation>();
        public GuestmanagementForm(ReservationsForm winForm1)
        {
            WinForm1 = winForm1;
            InitializeComponent();
        }

        //Gets run once when the form is loaded
        private void GuestmanagementForm_Load(object sender, EventArgs e)
        {
            reservations = JsonConvert.DeserializeObject<List<Reservation>>(File.ReadAllText(@"..\..\..\reservations.json"));
            LoadGuests();
            SetColor(AllButton, Color.DarkCyan, Color.White);
            SetColor(FutureButton, Color.Gainsboro, Color.Black);
            SetColor(PreviousButton, Color.Gainsboro, Color.Black);
            SetColor(CurrentButton, Color.Gainsboro, Color.Black);
            label1.Text = DateTime.Now.ToString();
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
            this.Hide();
            HoteloverviewForm hoteloverviewForm = new HoteloverviewForm(WinForm1);
            hoteloverviewForm.Closed += (s, args) => this.Close();
            hoteloverviewForm.Show();
        }

        private void gueButton_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        //Add each guest to the visual list of guests
        private void LoadGuests()
        {
            ClearRows();
            foreach(Reservation reservation in reservations)
            {
                GuestListGrid.Rows.Add(reservation.Name, reservation.Room.Number.ToString(), reservation.NumberOfGuests.ToString(), reservation.Start.ToString("dd/MM/yyyy"), reservation.End.ToString("dd/MM/yyyy"));
            }
        }

        private void ClearRows()
        {
            GuestListGrid.Rows.Clear();
        }

        //Set the list to only show current guests
        private void CurrentButton_Click(object sender, EventArgs e)
        {
            ClearRows();
            foreach(Reservation reservation in reservations)
            {
                if(DateTime.Now >= reservation.Start && DateTime.Now <= reservation.End)
                {
                    GuestListGrid.Rows.Add(reservation.Name, reservation.Room.Number.ToString(), reservation.NumberOfGuests.ToString(), reservation.Start.ToString("dd/MM/yyyy"), reservation.End.ToString("dd/MM/yyyy"));
                }
            }
            Button button = (Button)sender;
            SetColor(button, Color.DarkCyan, Color.White);
            SetColor(AllButton, Color.Gainsboro, Color.Black);
            SetColor(PreviousButton, Color.Gainsboro, Color.Black);
            SetColor(FutureButton, Color.Gainsboro, Color.Black);
        }

        //Set the list to only show previous guests
        private void PreviousButton_Click(object sender, EventArgs e)
        {
            ClearRows();
            foreach (Reservation reservation in reservations)
            {      
                if (DateTime.Now > reservation.End)
                {
                    GuestListGrid.Rows.Add(reservation.Name, reservation.Room.Number.ToString(), reservation.NumberOfGuests.ToString(), reservation.Start.ToString("dd/MM/yyyy"), reservation.End.ToString("dd/MM/yyyy"));
                }
            }
            Button button = (Button)sender;
            SetColor(button, Color.DarkCyan, Color.White);
            SetColor(AllButton, Color.Gainsboro, Color.Black);
            SetColor(FutureButton, Color.Gainsboro, Color.Black);
            SetColor(CurrentButton, Color.Gainsboro, Color.Black);
        }

        //Set the list to only show future guests
        private void FutureButton_Click(object sender, EventArgs e)
        {
            ClearRows();
            foreach (Reservation reservation in reservations)
            {
                if (DateTime.Now < reservation.Start)
                {
                    GuestListGrid.Rows.Add(reservation.Name, reservation.Room.Number.ToString(), reservation.NumberOfGuests.ToString(), reservation.Start.ToString("dd/MM/yyyy"), reservation.End.ToString("dd/MM/yyyy"));
                }
            }
            Button button = (Button)sender;
            SetColor(button, Color.DarkCyan, Color.White);
            SetColor(AllButton, Color.Gainsboro, Color.Black);
            SetColor(PreviousButton, Color.Gainsboro, Color.Black);
            SetColor(CurrentButton, Color.Gainsboro, Color.Black);
        }

        //Set the list to show all guests
        private void AllButton_Click(object sender, EventArgs e)
        {
            LoadGuests();
            Button button = (Button)sender;
            SetColor(button, Color.DarkCyan, Color.White);
            SetColor(FutureButton, Color.Gainsboro, Color.Black);
            SetColor(PreviousButton, Color.Gainsboro, Color.Black);
            SetColor(CurrentButton, Color.Gainsboro, Color.Black);
        }

        private void SetColor(Button button, Color back, Color fore)
        {
            button.BackColor = back;
            button.ForeColor = fore;
        }

        //Show the guests whos name, room number, check in or out date contains the input from the search field
        private void searchButton_Click(object sender, EventArgs e)
        {
            ClearRows();
            string searchtext = searchField.Text;
            foreach (Reservation reservation in reservations)
            {
                if (reservation.Name.Contains(searchtext) || reservation.Room.Number.ToString().Contains(searchtext) || reservation.Start.ToString().Contains(searchtext) || reservation.End.ToString().Contains(searchtext))
                {
                    GuestListGrid.Rows.Add(reservation.Name, reservation.Room.Number.ToString(), reservation.NumberOfGuests.ToString(), reservation.Start.ToString("dd/MM/yyyy"), reservation.End.ToString("dd/MM/yyyy"));
                }
            }
            searchField.Text = "";
        }
    }
}

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
using System.Globalization;

namespace P4FormsTest2
{
    public partial class Form1 : Form
    {
        public List<Reservation> reservations;
        public List<Room> rooms = new List<Room>();
        public DateTime WeekShownStart;
        public DateTime WeekShownEnd;
        public int CurrentWeek;

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            reservations = JsonConvert.DeserializeObject<List<Reservation>>(File.ReadAllText(@"C:\Users\rasmu\source\repos\P4-Project\reservations.json"));
            rooms = JsonConvert.DeserializeObject<List<Room>>(File.ReadAllText(@"C:\Users\rasmu\source\repos\P4-Project\rooms.json"));
            printReservations();
            printRooms();

            WeekShownStart = GetStartOfWeek(DateTime.Now);
            WeekShownEnd = GetEndOfWeek(DateTime.Now);

            GetCurrentWeek();

            mondayDateLabel.Text = WeekShownStart.ToString("dd/MM");
            tuesdayDateLabel.Text = WeekShownStart.AddDays(1).ToString("dd/MM");
            wednesdayDateLabel.Text = WeekShownStart.AddDays(2).ToString("dd/MM");
            thursdayDateLabel.Text = WeekShownStart.AddDays(3).ToString("dd/MM");
            fridayDateLabel.Text = WeekShownEnd.AddDays(-2).ToString("dd/MM");
            saturdayDateLabel.Text = WeekShownEnd.AddDays(-1).ToString("dd/MM");
            sundayDateLabel.Text = WeekShownEnd.ToString("dd/MM");

            weekNumberLabel.Text = "Week " + CurrentWeek.ToString();

        }

        private void resButton_Click(object sender, EventArgs e)
        {
            resPanel.Show();
            guePanel.Hide();
            hotPanel.Hide();
        }

        private void hotButton_Click(object sender, EventArgs e)
        {
            hotPanel.Show();
            guePanel.Hide();
            resPanel.Hide();
        }

        private void gueButton_Click(object sender, EventArgs e)
        {
            guePanel.Show();
            resPanel.Hide();
            hotPanel.Hide();
        }

        private void guePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void resPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void newResButton_Click(object sender, EventArgs e)
        {
            int availableRooms = 0;
            foreach (Room room in rooms)
            {
                if (room.IsAvailable == true)
                {
                    availableRooms++;
                }
            }

            if (availableRooms > 0)
            {
                NewResForm newResForm = new NewResForm(this);
                newResForm.Show();
            }
            else
            {
                ShowErrorMessage showErrorMessage = new ShowErrorMessage("No rooms available");
                showErrorMessage.Show();
            }

        }

        public void printReservations()
        {
            List<Reservation> relevantReservations = new List<Reservation>();
            foreach(Reservation reservation in reservations)
            {
                if(reservation.Start > WeekShownStart || reservation.End < WeekShownEnd)
                {
                    relevantReservations.Add(reservation);
                }
            }

            if (reservations != null)
            {
                
                int i = 0;
                foreach (Reservation reservation in relevantReservations)
                {
                    int startColoumn;
                    if (reservation.Start < WeekShownStart)
                    {
                        // set startColumn accordingly
                    } else
                    {
                        // set startColumn accordingly
                    }

                    Button b = new Button();
                    b.Dock = DockStyle.Fill;
                    b.Text = reservation.Name;
                    b.Name = reservation.Id.ToString();
                    b.Click += new EventHandler(resViewButton_Click);
                    tableLayoutPanel4.Controls.Add(b, 1, i);
                    tableLayoutPanel4.SetColumnSpan(b, 4);
                    i++;
                }
            } else
            {

            }

        }
        public void printRooms()
        {
            int i = 0;
            foreach (Room room in rooms)
            {
                Label l = new Label();
                l.Dock = DockStyle.Fill;
                l.Text = room.Number.ToString();
                l.Font = new Font(l.Font, FontStyle.Bold);
                l.TextAlign = ContentAlignment.MiddleCenter;
                l.Name = "roomLabel " + room.Number.ToString();
                tableLayoutPanel4.Controls.Add(l, 0, i);
                tableLayoutPanel4.SetColumnSpan(l, 1);
                i++;
            }
        }

        public void resViewButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Reservation r = null;

            foreach (Reservation reservation in reservations)
            {
                if (reservation.Id == Int32.Parse(btn.Name))
                {
                    r = reservation;
                    
                } 
            }

            viewResForm viewResForm = new viewResForm(r, this, btn);
            viewResForm.Show();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText(@"C:\Users\rasmu\source\repos\P4-Project\reservations.json", JsonConvert.SerializeObject(reservations, Formatting.Indented));
            File.WriteAllText(@"C:\Users\rasmu\source\repos\P4-Project\rooms.json", JsonConvert.SerializeObject(rooms, Formatting.Indented));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void roomLabel101_Click(object sender, EventArgs e)
        {

        }

        public DateTime GetStartOfWeek(DateTime time)
        {
            DayOfWeek currentWeekDay = DateTime.Now.DayOfWeek;
            int daysFromWeekStart = currentWeekDay - DayOfWeek.Monday;
            DateTime currentWeekStartDate = DateTime.Now.AddDays(-daysFromWeekStart);
            return currentWeekStartDate;
        }
        public DateTime GetEndOfWeek(DateTime time)
        {
            DayOfWeek currentWeekDay = time.DayOfWeek;
            int daysToWeekEnd = (currentWeekDay - DayOfWeek.Saturday)/-1;
            DateTime currentWeekStartDate = DateTime.Now.AddDays(daysToWeekEnd+1);
            return currentWeekStartDate;
        }

        private void decreaseWeekBtn_Click(object sender, EventArgs e)
        {
            GetCurrentWeek();
            WeekShownStart = WeekShownStart.AddDays(-7);
            WeekShownEnd = WeekShownEnd.AddDays(-7);
            weekNumberLabel.Text = "Week " + CurrentWeek.ToString();

            mondayDateLabel.Text = WeekShownStart.ToString("dd/MM");
            tuesdayDateLabel.Text = WeekShownStart.AddDays(1).ToString("dd/MM");
            wednesdayDateLabel.Text = WeekShownStart.AddDays(2).ToString("dd/MM");
            thursdayDateLabel.Text = WeekShownStart.AddDays(3).ToString("dd/MM");
            fridayDateLabel.Text = WeekShownEnd.AddDays(-2).ToString("dd/MM");
            saturdayDateLabel.Text = WeekShownEnd.AddDays(-1).ToString("dd/MM");
            sundayDateLabel.Text = WeekShownEnd.ToString("dd/MM");

        }

        private void increaseWeekBtn_Click(object sender, EventArgs e)
        {
            
            WeekShownStart = WeekShownStart.AddDays(7);
            WeekShownEnd = WeekShownEnd.AddDays(7);
            GetCurrentWeek();
            weekNumberLabel.Text = "Week " + CurrentWeek.ToString();

            mondayDateLabel.Text = WeekShownStart.ToString("dd/MM");
            tuesdayDateLabel.Text = WeekShownStart.AddDays(1).ToString("dd/MM");
            wednesdayDateLabel.Text = WeekShownStart.AddDays(2).ToString("dd/MM");
            thursdayDateLabel.Text = WeekShownStart.AddDays(3).ToString("dd/MM");
            fridayDateLabel.Text = WeekShownEnd.AddDays(-2).ToString("dd/MM");
            saturdayDateLabel.Text = WeekShownEnd.AddDays(-1).ToString("dd/MM");
            sundayDateLabel.Text = WeekShownEnd.ToString("dd/MM");

        }

        private void GetCurrentWeek()
        {
            // Get the Calendar associated with a specific culture.
            CultureInfo cultureInfo = new CultureInfo("en-US");
            Calendar calendar = cultureInfo.Calendar;

            // Get the DateTime properties for GetWeekOfYear parameters and get the week number.
            CalendarWeekRule calendarWeekRule = cultureInfo.DateTimeFormat.CalendarWeekRule;
            DayOfWeek firstDayOfWeek = cultureInfo.DateTimeFormat.FirstDayOfWeek;
            CurrentWeek = calendar.GetWeekOfYear(WeekShownStart, calendarWeekRule, firstDayOfWeek);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void newRoomBtn_Click(object sender, EventArgs e)
        {
            NewRoomForm newRoomForm = new NewRoomForm(this);
            newRoomForm.Show();
        }
    }
}

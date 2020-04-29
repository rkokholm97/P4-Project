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
        public List<Reservation> reservations { get; set; } = new List<Reservation>();
        public List<Reservation> relevantReservations { get; set; } = new List<Reservation>();
        public List<Room> rooms { get; set; } = new List<Room>();
        public DateTime WeekShownStart;
        public DateTime WeekShownEnd;
        public int CurrentWeek;

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            reservations = JsonConvert.DeserializeObject<List<Reservation>>(File.ReadAllText(@"..\..\..\reservations.json"));
            rooms = JsonConvert.DeserializeObject<List<Room>>(File.ReadAllText(@"..\..\..\rooms.json"));


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

            rooms.Sort();
            printRooms();
            printReservations();
            
        }

        private void resButton_Click(object sender, EventArgs e)
        {

        }

        private void hotButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoteloverviewForm hoteloverviewform = new HoteloverviewForm(this);
            hoteloverviewform.Closed += (s, args) => this.Close();
            hoteloverviewform.Show();
        }

        private void gueButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            GuestmanagementForm guestmanagementform = new GuestmanagementForm(this);
            guestmanagementform.Closed += (s, args) => this.Close();
            guestmanagementform.Show();
            
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
                NewResForm newResForm = new NewResForm(this);
                newResForm.Show();
        }

        public void printReservations()
        {
            ClearReservationButtons();
            UpdateRelevantReservations();

            if (relevantReservations != null)
            {
                
                int i = 0;
                DayOfWeek day;
                foreach (Reservation reservation in relevantReservations)
                {
                    int startColoumn;
                    int endColoumn;
                    if (reservation.Start <= WeekShownStart)
                    {
                        day = reservation.Start.DayOfWeek;
                        startColoumn = 1;
                    } else
                    {
                        day = reservation.Start.DayOfWeek;
                        switch(day.ToString())
                        {
                            case "Monday":
                                startColoumn = 1;
                                break;
                            case "Tuesday":
                                startColoumn = 2;
                                break;
                            case "Wednesday":
                                startColoumn = 3;
                                break;
                            case "Thursday":
                                startColoumn = 4;
                                break;
                            case "Friday":
                                startColoumn = 5;
                                break;
                            case "Saturday":
                                startColoumn = 6;
                                break;
                            case "Sunday":
                                startColoumn = 7;
                                break;
                            default:
                                startColoumn = 1;
                                break;
                        }
                    }

                    if(reservation.End >= WeekShownEnd)
                    {
                        endColoumn = 7;
                    } else
                    {
                        day = reservation.End.DayOfWeek;
                        switch (day.ToString())
                        {
                            case "Monday":
                                endColoumn = 1;
                                break;
                            case "Tuesday":
                                endColoumn = 2;
                                break;
                            case "Wednesday":
                                endColoumn = 3;
                                break;
                            case "Thursday":
                                endColoumn = 4;
                                break;
                            case "Friday":
                                endColoumn = 5;
                                break;
                            case "Saturday":
                                endColoumn = 6;
                                break;
                            case "Sunday":
                                endColoumn = 7;
                                break;
                            default:
                                endColoumn = 7;
                                break;
                        }
                    }

                    Button b = new Button();
                    b.Dock = DockStyle.Fill;
                    //b.Text = reservation.Name;
                    b.Text = reservation.Start.ToString("dd/MM") + " - " + reservation.End.ToString("dd/MM");
                    b.Name = reservation.Id.ToString();
                    b.Click += new EventHandler(resViewButton_Click);

                    int row = 0;

                    TableLayoutControlCollection table = tableLayoutPanel4.Controls;
                    for(int j = 0; j < table.Count; j++)
                    {
                        if(table[j] is Label)
                        {
                            Label label = (Label)table[j];
                            int number = Int32.Parse(label.Text);
                            if(reservation.Room.Number == number)
                            {
                                row = tableLayoutPanel4.GetRow(table[j]);
                            }
                        }
                    }

                    tableLayoutPanel4.Controls.Add(b, startColoumn, row);
                    tableLayoutPanel4.SetColumnSpan(b, endColoumn - startColoumn + 1);
                    i++;
                }
            } else
            {

            }

        }
        public void printRooms()
        {
            ClearRoomLabels();

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
            File.WriteAllText(@"..\..\..\reservations.json", JsonConvert.SerializeObject(reservations, Formatting.Indented));
            File.WriteAllText(@"..\..\..\rooms.json", JsonConvert.SerializeObject(rooms, Formatting.Indented));
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
            printReservations();
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
            printReservations();
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

        private void newRoomBtn_Click(object sender, EventArgs e)
        {
            NewRoomForm newRoomForm = new NewRoomForm(this);
            newRoomForm.Show();
        }

        private void ClearReservationButtons()
        {
            for (int i = tableLayoutPanel4.Controls.Count - 1; i >= 0; --i)
            {
                if(tableLayoutPanel4.Controls[i] is Button)
                {
                    tableLayoutPanel4.Controls[i].Dispose();
                }         
            }          
        }

        private void ClearRoomLabels()
        {
            for (int i = tableLayoutPanel4.Controls.Count - 1; i >= 0; --i)
            {
                if (tableLayoutPanel4.Controls[i] is Label)
                {
                    tableLayoutPanel4.Controls[i].Dispose();
                }
            }
        }

        private void UpdateRelevantReservations()
        {
            List<Reservation> updatedReservations = new List<Reservation>();        
            foreach (Reservation reservation in reservations)
            {
                if ((reservation.Start >= WeekShownStart && reservation.Start <= WeekShownEnd) || (reservation.End <= WeekShownEnd && reservation.End > WeekShownStart || (WeekShownStart > reservation.Start && WeekShownEnd < reservation.End)))
                {
                    updatedReservations.Add(reservation);
                }
            }
            relevantReservations = updatedReservations;
        }
    }
}

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
    public partial class ReservationsForm : Form
    {
        public List<Reservation> reservations { get; set; } = new List<Reservation>();
        public List<Reservation> relevantReservations { get; set; } = new List<Reservation>();
        public List<Room> rooms { get; set; } = new List<Room>();
        public User LoggedInUser { get; set; }
        public DateTime WeekShownStart;
        public DateTime WeekShownEnd;
        public int CurrentWeek;

        public ReservationsForm()
        {
            //LoggedInUser = user;
            InitializeComponent();
        }

        //Gets run once when the form is loaded
        public void Form1_Load(object sender, EventArgs e)
        {
            //Load data from files
            reservations = JsonConvert.DeserializeObject<List<Reservation>>(File.ReadAllText(@"..\..\..\reservations.json"));
            rooms = JsonConvert.DeserializeObject<List<Room>>(File.ReadAllText(@"..\..\..\rooms.json"));


            WeekShownStart = GetStartOfWeek(DateTime.Now);
            WeekShownEnd = GetEndOfWeek(DateTime.Now);

            GetCurrentWeek();

            //Set date labels
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
        //Open hotel overview window
        private void hotButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            HoteloverviewForm hoteloverviewform = new HoteloverviewForm(this);
            hoteloverviewform.Closed += (s, args) => this.Close();
            hoteloverviewform.Show();
        }

        //Open guest management window
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

        //Clear the table of reservations and print out reservations relevant to the current week
        //Is called whenever an update is made to the reservations or the shown week - Adding, deleting or editing a reservation or changing week
        public void printReservations()
        {
            ClearReservationButtons();
            UpdateRelevantReservations();

            if (relevantReservations != null)
            {
                
                int i = 0;
                DayOfWeek day;
                int startColoumn = 1;
                int endColoumn = 1;
                foreach (Reservation reservation in relevantReservations)
                {
                    //Set the start and end columns based on the specific reservations start and end day
                    if (reservation.Start <= WeekShownStart)
                    {
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

                    //Create a button for the reservation
                    Button b = new Button();
                    b.Dock = DockStyle.Fill;
                    b.Text = reservation.ToString();
                    b.Name = reservation.Id.ToString();
                    b.Margin = new Padding(0,0,0,0);
                    b.Click += new EventHandler(resViewButton_Click);


                    //Find the row number which has the current rooms number
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
                    //Add the button to the table at the given column start and spanning at given amount of columns
                    tableLayoutPanel4.Controls.Add(b, startColoumn, row);

                    //something is completely fucking wrong with this bit. If the value of endColumn - startColumn + is less than 2 it just wont fucking react and the result ends up being nothing.
                    //which leads to a button with a span of 0. In other words - you cant see the button of any reservation that starts and ends on the same day.
                    //also whenever something spans from ex. Monday-Monday the week after, you cant see the 1-day span in the last week.
                    int span = (endColoumn - startColoumn) + 1;                    
                    tableLayoutPanel4.SetColumnSpan(b, span);              
                    i++;
                }   
            }
        }

        //Print / Update the room numbers in the reservation grid
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

        //Open a window showing the information of the clicked reservation
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

        //Decrease the week number, date labels and print out the relevant reservations for the new week
        private void decreaseWeekBtn_Click(object sender, EventArgs e)
        {        
            WeekShownStart = WeekShownStart.AddDays(-7);
            WeekShownEnd = WeekShownEnd.AddDays(-7);
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

        //Increase the week number, date labels and print out the relevant reservations for the new week
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

        //Get the week number of the current week
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

        //Clear all reservations from the grid
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

        //Clear all room numbers from the grid
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

        //Update the relevant reservations list to contain the reservations that are relevan to the current week shown
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

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

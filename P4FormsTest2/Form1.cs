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
    public partial class Form1 : Form
    {
        public List<Reservation> reservations;
        

        public Form1()
        {
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            reservations = JsonConvert.DeserializeObject<List<Reservation>>(File.ReadAllText(@"C:\Users\rasmu\source\repos\P4-Project\reservations.json"));
            printReservations();
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
            NewResForm newResForm = new NewResForm(this);
            newResForm.Show();
        }

        public void printReservations()
        {
            int i = 0;
            foreach (Reservation reservation in reservations)
            {
                Button b = new Button();
                b.Dock = DockStyle.Fill;
                b.Text = reservation.Name;
                b.Name = reservation.Id.ToString();
                b.Click += new EventHandler(resViewButton_Click);
                tableLayoutPanel4.Controls.Add(b, 1, i);
                tableLayoutPanel4.SetColumnSpan(b, 4);
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
        }

    }
}

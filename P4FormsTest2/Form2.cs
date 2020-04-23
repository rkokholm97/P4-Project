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
    public partial class NewResForm : Form
    {
        public Form1 form1;
        public NewResForm(Form1 callingForm)
        {
            form1 = callingForm;
            InitializeComponent();
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


                string name = newResNameField.Text;
                string email = newResEmailField.Text;
                string phone = newResPhoneField.Text;
                DateTime start = newResStartField.SelectionStart;
                DateTime end = newResEndField.SelectionStart;
                int adults = Convert.ToInt32(Math.Round(newResAdultsField.Value, 0));
                int children = Convert.ToInt32(Math.Round(newResChildrenField.Value, 0));
                Room availableRoom = null;

                foreach (Room room in form1.rooms)
                {
                    if (room.IsAvailable == true)
                    {
                        availableRoom = room;
                        break;
                    }
                }

                if (form1.reservations == null)
                {
                    form1.reservations = new List<Reservation>();
                }

                Reservation r = new Reservation(name, availableRoom, start, end, phone, email, adults, children);
                form1.reservations.Add(r);
                availableRoom.IsAvailable = false;
                int i = form1.reservations.Count() - 1;

                Button b = new Button();
                b.Dock = DockStyle.Fill;
                b.Text = name;
                b.Name = r.Id.ToString();
                b.Click += new EventHandler(form1.resViewButton_Click);
                form1.tableLayoutPanel4.Controls.Add(b, 1, i);
                form1.tableLayoutPanel4.SetColumnSpan(b, 4);

                File.WriteAllText(@"C:\Users\rasmu\source\repos\P4-Project\reservations.json", JsonConvert.SerializeObject(form1.reservations, Formatting.Indented));
                File.WriteAllText(@"C:\Users\rasmu\source\repos\P4-Project\rooms.json", JsonConvert.SerializeObject(form1.rooms, Formatting.Indented));

                this.Close();
            }
                 
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

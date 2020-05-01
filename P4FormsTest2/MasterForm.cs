using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Globalization;

namespace P4FormsTest2
{
    public partial class MasterForm : Form
    {
        public List<Reservation> Reservations { get; set; }
        public List<Guest> Guests { get; set; }
        public List<Room> Rooms { get; set; }

        public MasterForm()
        {
            InitializeComponent();

            Reservations = JsonConvert.DeserializeObject<List<Reservation>>(File.ReadAllText(@"..\..\..\reservations.json"));
            Rooms = JsonConvert.DeserializeObject<List<Room>>(File.ReadAllText(@"..\..\..\rooms.json"));
        }


    }
}

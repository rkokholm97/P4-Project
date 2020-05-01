using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P4FormsTest2
{
    public partial class LoginForm : Form
    {
        public List<User> users = new List<User>();

        public Timer holder = new Timer();
        public LoginForm()
        {
            InitializeComponent();
            holder = new Timer { Interval = 5000 };
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            errorLabel.Text = "";

            User u = new User("rasmus18", "test123", "Rasmus", "Møller");
            users.Add(u);

        }

        private void button1_Click(object sender, EventArgs e)
        {

            string username = usernameTextbox.Text;
            usernameTextbox.Clear();

            string password = passwordTextbox.Text;
            passwordTextbox.Clear();

            bool off = true;

            foreach (User user in users)
            {
                if((user.Username == username && user.Password == password) || off == true)
                {
                    this.Hide();
                    ReservationsForm reservationsform = new ReservationsForm();
                    reservationsform.Closed += (s, args) => this.Close();
                    reservationsform.Show();
                    break;
                } else
                {
                    errorLabel.Text = "Wrong username or password";
                    
                    holder.Tick += RemoveError;
                    holder.Enabled = true;
                    
                    break;
                }
            }
            
        }

        private void RemoveError(object sender, EventArgs e)
        {
            errorLabel.Text = "";
            holder.Enabled = false;
        }

        private void errorLabel_Click(object sender, EventArgs e)
        {

        }
    }
}

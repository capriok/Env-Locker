using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Env_Locker
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        readonly string PIN_DOT = "•";

        List<int> password = new List<int>(4) { 1, 2, 3, 4 };
        List<int> userInput = new List<int>(4) { 1, 2, 3, 4 };

        List<string> pinDots = new List<string>(4);

        private void Auth_Load(object sender, EventArgs e)
        {
            
        }

        private void PinPad_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int btnNumber = Convert.ToInt32(btn.Text);

            TextPass.Text = "";
            TextError.Text = "";

            if (pinDots.Count < 4)
            {
                userInput.Add(btnNumber);
                pinDots.Add(PIN_DOT);
            }

            TextPin.Text = string.Join(" ", pinDots);
        }

        private void Button_Submit_Click(object sender, EventArgs e)
        {
            if (userInput.Count != 4) return;

            bool match = true;
            for (int i = 0; i < 4; i++)
            {
                if (password[i] != userInput[i]) match = false;
            }

            pinDots.Clear();
            userInput.Clear();
            TextPin.Text = "";
            
            if (!match)
            {
                TextPin.Text = "";
                TextError.Text = "Invalid Pin";
            }
            else
            {
                TextPass.Text = "Passed";
                this.Hide();
                Locker Locker = new Locker();
                Locker.Show();
            }
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            pinDots.Clear();
            userInput.Clear();
            TextPin.Text = string.Join(" ", pinDots);
            TextPin.Text = "";
            TextPass.Text = "";
            TextError.Text = "";
        }
    }
}

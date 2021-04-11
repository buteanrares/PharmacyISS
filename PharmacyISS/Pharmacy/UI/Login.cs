using Pharmacy.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            positionControls();
        }

        private void positionControls()
        {
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '•';
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            /**
                IF Login credentials.....
                This form disable & hide
             */
            var Menu = new Menu();
            Menu.Show();
            this.Hide();
        }
    }
}

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
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '•';
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            /*
                IF Login credentials.....
                IF unit / pharmacy employee...
            */


            var UnitMenu = new UnitMenu();
            UnitMenu.FormClosed += UnitMenu_FormClosed;
            UnitMenu.Show();

            //var PharmacyMenu = new PharmacyMenu();
            //PharmacyMenu.FormClosed += PharmacyMenu_FormClosed;
            //PharmacyMenu.Show();

            this.Hide();
        }

        private void UnitMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void PharmacyMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
    }
}
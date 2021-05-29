using Pharmacy.Domain;
using Pharmacy.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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
            connectToDatabase();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            passwordTextBox.PasswordChar = '•';
        }

        private void connectToDatabase()
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Rares\Projects\CSharp\Pharmacy\PharmacyISS\Pharmacy\Database\PharmacyDB.mdf;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
            }
            catch (Exception)
            {
                this.errorLabel.Text += "Cannot connect to database. Please contact an administrator. ";
            }
        }

        private void LoginButtonPictureBox_Click(object sender, EventArgs e)
        {
            // Account logInAccount = this.Service.ReadAccount("username","password");

            #region REMOVE THIS
            UnitEmployee unitEmployee = new UnitEmployee(0, "UE_Surname", "UE_Forename", DateTime.Today, WorkingUnit.ICU);
            Account unitAccount = new Account(0, "unit", "", "", unitEmployee);

            PharmacyEmployee pharmacyEmployee = new PharmacyEmployee(1, "PH_Surname", "PH_Forename", DateTime.Today);
            Account pharmacyAccount = new Account(0, "pharm", "", "", pharmacyEmployee);
            #endregion

            if (usernameTextBox.Text.Equals("unit"))
            {
                var UnitMenu = new UnitMenu(unitAccount);
                UnitMenu.FormClosed += UnitMenu_FormClosed;
                UnitMenu.Show();
                this.Hide();
            }
            else if (usernameTextBox.Text.Equals("pharm"))
            {
                var PharmacyMenu = new PharmacyMenu(pharmacyAccount);
                PharmacyMenu.FormClosed += PharmacyMenu_FormClosed;
                PharmacyMenu.Show();
                this.Hide();
            }
            else
            {
                this.errorLabel.Text += "Invalid credentials. ";
            }
        }

        private void UnitMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void PharmacyMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void exitPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
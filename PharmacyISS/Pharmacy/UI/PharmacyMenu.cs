using Pharmacy.Domain;
using Pharmacy.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pharmacy.UI
{
    public partial class PharmacyMenu : Form
    {
        private readonly MedicineService MedicineService = new MedicineService();
        private readonly OrderService OrderService = new OrderService();
        private Account Account;

        public PharmacyMenu(Account account)
        {
            InitializeComponent();
            this.Account = account;
            tabControl.DrawItem += new DrawItemEventHandler(tabControl_DrawItem);
            this.logoutPictureBox.BackColor = Color.FromArgb(240,240,240);
            this.homePictureBox.BackColor = Color.LightGray;
            this.usernameLabel.Text = this.Account.Username;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    this.homePictureBox.BackColor = Color.LightGray;
                    this.storagePictureBox.BackColor = Color.White;
                    this.orderPictureBox.BackColor = Color.White;
                    this.historyPictureBox.BackColor = Color.White;
                    this.AddMedicinePictureBox.BackColor = Color.White;
                    break;

                case 1:
                    this.homePictureBox.BackColor = Color.White;
                    this.storagePictureBox.BackColor = Color.LightGray;
                    this.orderPictureBox.BackColor = Color.White;
                    this.historyPictureBox.BackColor = Color.White;
                    this.AddMedicinePictureBox.BackColor = Color.White;
                    break;

                case 2:
                    this.homePictureBox.BackColor = Color.White;
                    this.storagePictureBox.BackColor = Color.White;
                    this.orderPictureBox.BackColor = Color.LightGray;
                    this.historyPictureBox.BackColor = Color.White; 
                    this.AddMedicinePictureBox.BackColor = Color.White;
                    break;

                case 3:
                    this.homePictureBox.BackColor = Color.White;
                    this.storagePictureBox.BackColor = Color.White;
                    this.orderPictureBox.BackColor = Color.White;
                    this.historyPictureBox.BackColor = Color.LightGray;
                    this.AddMedicinePictureBox.BackColor = Color.White;
                    break;

                case 4:
                    this.homePictureBox.BackColor = Color.White;
                    this.storagePictureBox.BackColor = Color.White;
                    this.orderPictureBox.BackColor = Color.White;
                    this.historyPictureBox.BackColor = Color.White;
                    this.AddMedicinePictureBox.BackColor = Color.LightGray;
                    this.AddMedicineLabel.Text = "Add medicine";
                    this.NameTextBox.Text = "";
                    this.ExpirationDateTimePicker.Value = DateTime.Today;
                    this.PackSizeNumericUpDown.Value = 0;
                    this.QuantityNumericUpDown.Value = 0;
                    this.AddPictureBox.Image = Pharmacy.Properties.Resources.ADD;
                    break;

                default:
                    break;
            }
        }


        private void tabControl_DrawItem(Object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;
            TabPage _tabPage = tabControl.TabPages[e.Index];
            Rectangle _tabBounds = tabControl.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {
                g.FillRectangle(Brushes.LightGray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(Color.DarkGray);
                e.DrawBackground();
            }
        }


        private void homePictureBox_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectedTab = tabControl.TabPages[0];
            this.homePictureBox.BackColor = Color.LightGray;
            this.storagePictureBox.BackColor = Color.White;
            this.orderPictureBox.BackColor = Color.White;
            this.historyPictureBox.BackColor = Color.White;
            this.AddMedicinePictureBox.BackColor = Color.White;

        }


        private void storagePictureBox_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectedTab = tabControl.TabPages[1];
            this.homePictureBox.BackColor = Color.White;
            this.storagePictureBox.BackColor = Color.LightGray;
            this.orderPictureBox.BackColor = Color.White;
            this.historyPictureBox.BackColor = Color.White;
            this.AddMedicinePictureBox.BackColor = Color.White;

        }


        private void orderPictureBox_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabControl.TabPages[2];
            this.homePictureBox.BackColor = Color.White;
            this.storagePictureBox.BackColor = Color.White;
            this.orderPictureBox.BackColor = Color.LightGray;
            this.historyPictureBox.BackColor = Color.White;
            this.AddMedicinePictureBox.BackColor = Color.White;
        }


        private void historyPictureBox_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabControl.TabPages[3];
            this.homePictureBox.BackColor = Color.White;
            this.storagePictureBox.BackColor = Color.White;
            this.orderPictureBox.BackColor = Color.White;
            this.historyPictureBox.BackColor = Color.LightGray;
            this.AddMedicinePictureBox.BackColor = Color.White;
        }


        private void AddMedicinePictureBox_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabControl.TabPages[4];
            this.homePictureBox.BackColor = Color.White;
            this.storagePictureBox.BackColor = Color.White;
            this.orderPictureBox.BackColor = Color.White;
            this.historyPictureBox.BackColor = Color.White;
            this.AddMedicinePictureBox.BackColor = Color.LightGray;
            this.AddMedicineLabel.Text = "Add medicine";
            this.NameTextBox.Text = "";
            this.ExpirationDateTimePicker.Value = DateTime.Today;
            this.PackSizeNumericUpDown.Value = 0;
            this.QuantityNumericUpDown.Value = 0;
            this.AddPictureBox.Image = Pharmacy.Properties.Resources.ADD;
        }


        private void LoadStorage(string searchString = "")
        {
            IEnumerable<Medicine> medicines = (IEnumerable<Medicine>)this.MedicineService.ReadAll();
            foreach (Medicine med in medicines)
            {
                if (med.Name.Contains(searchString))
                {
                    string availability = "Low";
                    if (med.Quantity >= 100)
                        availability = "Normal";
                    if (med.Quantity >= 500)
                        availability = "High";
                    this.storageDGV.Rows.Add(med.Name, med.PackSize, availability, med.ExpirationDate.ToString(), med.ID);
                }
            }
        }


        private void LoadOrders(string searchString = "")
        {
            IEnumerable<Order> orders = (IEnumerable<Order>)this.OrderService.ReadAll();
            foreach (Order order in orders)
            {
                if (order.Destination.ToString().Contains(searchString) ||
                    order.Issuer.Contains(searchString) ||
                    order.Priority.ToString().Contains(searchString))
                {
                    int totalQuantity = order.Medicines.Sum(medicine => medicine.Quantity);
                    this.ordersDGV.Rows.Add(order.Destination, order.Issuer, order.Priority, totalQuantity);
                }
            }
        }

        private void LoadOrderDetails()
        {

        }


        private void LoadHistory(string searchString = "")
        {
            IEnumerable<Order> orders = (IEnumerable<Order>)this.OrderService.ReadAll();
            foreach(Order order in orders)
            {
                if (order.DispatchedDate != null && (order.ID.ToString().Contains(searchString) ||
                    order.Status.ToString().Contains(searchString)))
                {
                    if (order.ConfirmationDate != null)
                    {
                        this.orderDetailsDGV.Rows.Add(order.ID, order.DispatchedDate.ToString(), order.Status.ToString(), order.ConfirmationDate.ToString());
                    }
                    else
                    {
                        this.orderDetailsDGV.Rows.Add(order.ID, order.DispatchedDate.ToString(), order.Status.ToString(), "");
                    }
                }
            }
        }


        private void logoutPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadStorage(SearchTextBox.Text);
        }


        private void O_searchTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadOrders(O_searchTextBox.Text);
        }


        private void H_searchTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadHistory(H_searchTextBox.Text);
        }


        private async void declinePictureBox_Click(object sender, EventArgs e)
        {
            int id = Int32.Parse(this.ordersDGV.SelectedRows[0].Cells[0].Value.ToString());
            await this.OrderService.Delete(id);
            LoadOrders();
        }


        private async void confirmPictureBox_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.orderDetailsDGV.SelectedRows[0].Cells[0].Value.ToString());
            Order clone = await this.OrderService.Read(id);
            clone.DispatchedDate = DateTime.Now;
            clone.Status = Status.Pending;
            await this.OrderService.Update(clone.ID, (DateTime)clone.ETA, clone.Medicines, clone.Destination, clone.Issuer,
                clone.Priority, clone.DispatchedDate, clone.Dispatcher, clone.Status);
        }


        private async void UpdatePictureBox_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.storageDGV.SelectedRows[0].Cells[4].Value.ToString());
            Medicine updateMedicine = await this.MedicineService.Read(id);
            this.tabControl.SelectedIndex = 4;
            this.AddMedicineLabel.Text = "Update medicine";
            this.NameTextBox.Text = updateMedicine.Name;
            this.ExpirationDateTimePicker.Value = updateMedicine.ExpirationDate;
            this.PackSizeNumericUpDown.Value = updateMedicine.PackSize;
            this.QuantityNumericUpDown.Value = updateMedicine.Quantity;
            this.AddPictureBox.Image = Pharmacy.Properties.Resources.UPDATE1;
        }


        private async void AddPictureBox_Click(object sender, EventArgs e)
        {
            int id = new Random().Next(1, 2147483647);
            string name = NameTextBox.Text;
            DateTime expirationdate = ExpirationDateTimePicker.Value;
            int packsize = (int)PackSizeNumericUpDown.Value;
            int quantity = (int)QuantityNumericUpDown.Value;
            await this.MedicineService.Create(id, name, packsize, quantity, expirationdate);
        }

        private async void RemovePictureBox_Click(object sender, EventArgs e)
        {
            int id = (int)this.storageDGV.SelectedRows[0].Cells[4].Value;
            await this.MedicineService.Delete(id);
            LoadStorage();
        }
    }
}

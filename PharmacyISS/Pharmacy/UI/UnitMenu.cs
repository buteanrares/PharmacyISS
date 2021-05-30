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
    public partial class UnitMenu : Form
    {
        private readonly MedicineService MedicineService = new MedicineService();
        private readonly OrderService OrderService = new OrderService();
        private Account Account { get; }


        public UnitMenu(Account account)
        {
            InitializeComponent();
            this.Account = account;
            tabControl.DrawItem += new DrawItemEventHandler(tabControl_DrawItem);
            this.logoutPictureBox.BackColor = Color.FromArgb(240, 240, 240);
            this.homePictureBox.BackColor = Color.LightGray;
            this.usernameLabel.Text = this.Account.Username;
            this.WorkingUnitLabel.Text = this.Account.Employee.WorkingUnit.ToString();
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


        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControl.SelectedIndex)
            {
                case 0:
                    this.homePictureBox.BackColor = Color.LightGray;
                    this.storagePictureBox.BackColor = Color.White;
                    this.orderPictureBox.BackColor = Color.White;
                    this.confirmationsPictureBox.BackColor = Color.White;
                    break;

                case 1:
                    this.homePictureBox.BackColor = Color.White;
                    this.storagePictureBox.BackColor = Color.LightGray;
                    this.orderPictureBox.BackColor = Color.White;
                    this.confirmationsPictureBox.BackColor = Color.White;
                    LoadStorage();
                    break;

                case 2:
                    this.homePictureBox.BackColor = Color.White;
                    this.storagePictureBox.BackColor = Color.White;
                    this.orderPictureBox.BackColor = Color.LightGray;
                    this.confirmationsPictureBox.BackColor = Color.White;
                    break;

                case 3:
                    this.homePictureBox.BackColor = Color.White;
                    this.storagePictureBox.BackColor = Color.White;
                    this.orderPictureBox.BackColor = Color.White;
                    this.confirmationsPictureBox.BackColor = Color.LightGray;
                    LoadConfirmations();
                    break;

                default:
                    break;
            }
        }

        private void homePictureBox_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectedTab = tabControl.TabPages[0];
        }

        private void storagePictureBox_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectedTab = tabControl.TabPages[1];
        }

        private void orderPictureBox_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabControl.TabPages[2];
        }

        private void ConfirmOrdersPictureBox_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabControl.TabPages[3];
        }

        private async void LoadStorage(string searchString="")
        {
            this.StorageDGV.Rows.Clear();
            IEnumerable<Medicine> medicines = await this.MedicineService.ReadAll();
            foreach (Medicine medicine in medicines)
            {
                if (medicine.Name.Contains(searchString))
                {
                    string availability = "Low";
                    if (medicine.Quantity >= 100)
                        availability = "Normal";
                    if (medicine.Quantity >= 500)
                        availability = "High";
                    if (medicine.Quantity >= 100)
                        this.StorageDGV.Rows.Add(medicine.Name, medicine.PackSize, medicine.ExpirationDate, availability, medicine.ID);
                }
            }
        }

        private async void LoadConfirmations(string searchString = "")
        {
            this.ConfirmationsDGV.Rows.Clear();
            IEnumerable<Order> orders = await this.OrderService.ReadAll();
            foreach(Order order in orders)
            {
                if (order.DispatchedDate != null && order.ID.ToString().Contains(searchString)){
                    if (order.Status == Domain.Status.Accepted || order.Status == Domain.Status.Refused)
                        this.ConfirmationsDGV.Rows.Add(order.ID, order.Status, order.Dispatcher, order.DispatchedDate);
                    else if (order.Status == Domain.Status.Pending)
                        this.ConfirmationsDGV.Rows.Add(order.ID, order.Status, "", "");
                }
            }
        }

        private void logoutPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void ConfirmOrderArrivalPictureBox_Click(object sender, EventArgs e)
        {
            int id = (int)this.ConfirmationsDGV.SelectedRows[0].Cells[0].Value;
            Order confirmedOrder = await this.OrderService.Read(id);
            await this.OrderService.Update(confirmedOrder.ID, (DateTime)confirmedOrder.ETA, confirmedOrder.Medicines, (int)confirmedOrder.Destination, confirmedOrder.Issuer, (int)confirmedOrder.Priority, confirmedOrder.DispatchedDate, confirmedOrder.Dispatcher, (int)Domain.Status.Confirmed, DateTime.Today);
            
        }

        private void OrderSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            // TODO
        }

        private void removeMedicinePictureBox_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow item in this.OrderDGV.SelectedRows)
            {
                this.OrderDGV.Rows.RemoveAt(item.Index);
            }
        }

        private async void confirmOrderPictureBox_Click(object sender, EventArgs e)
        {
            int id = new Random().Next(1, 2147483647);
            Dictionary<Medicine,int> orderedMedicines = new();
            
            foreach(DataGridViewRow row in this.OrderDGV.Rows)
            {
                orderedMedicines.Add(await this.MedicineService.Read((int)row.Cells[2].Value), int.Parse(row.Cells[1].Value.ToString()));
            }

            await this.OrderService.Create(id, null, orderedMedicines, (int)this.Account.Employee.WorkingUnit, this.Account.Username, this.PriorityComboBox.SelectedIndex+1, null, null, (int)Domain.Status.Pending, null);
            this.OrderDGV.Rows.Clear();
            MessageBox.Show($"Order number {id} has been placed.", "Order placed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void H_searchTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadConfirmations(H_searchTextBox.Text);
        }

        private async void StorageAddPictureBox_Click(object sender, EventArgs e)
        {
            if (this.StorageDGV.SelectedRows.Count > 0)
            {
                int id = (int)this.StorageDGV.SelectedRows[0].Cells[4].Value;
                Medicine medicine = await this.MedicineService.Read(id);
                this.OrderDGV.Rows.Add(medicine.Name, 1, id);
            }
        }

        private void StorageSearchTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadStorage(StorageSearchTextBox.Text);
        }
    }
}

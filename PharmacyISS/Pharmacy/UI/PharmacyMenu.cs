using Pharmacy.Domain;
using Pharmacy.Repository;
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

        private Image Add = Properties.Resources.ADD;
        private Image Update = Properties.Resources.UPDATE1;

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
                    LoadStorage();
                    break;

                case 2:
                    this.homePictureBox.BackColor = Color.White;
                    this.storagePictureBox.BackColor = Color.White;
                    this.orderPictureBox.BackColor = Color.LightGray;
                    this.historyPictureBox.BackColor = Color.White; 
                    this.AddMedicinePictureBox.BackColor = Color.White;
                    LoadOrders();
                    break;

                case 3:
                    this.homePictureBox.BackColor = Color.White;
                    this.storagePictureBox.BackColor = Color.White;
                    this.orderPictureBox.BackColor = Color.White;
                    this.historyPictureBox.BackColor = Color.LightGray;
                    this.AddMedicinePictureBox.BackColor = Color.White;
                    LoadHistory();
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
                    this.AddPictureBox.Image = Add;
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
        }


        private void storagePictureBox_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectedTab = tabControl.TabPages[1];

        }


        private void orderPictureBox_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabControl.TabPages[2];
        }


        private void historyPictureBox_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabControl.TabPages[3];
        }


        private void AddMedicinePictureBox_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabControl.TabPages[4];
        }


        private async void LoadStorage(string searchString = "")
        {
            this.storageDGV.Rows.Clear();
            IEnumerable<Medicine> medicines = await this.MedicineService.ReadAll();
            foreach (Medicine med in medicines)
            {
                if (med.Name.ToLower().Contains(searchString.ToLower()))
                {
                    string availability = "Low";
                    if (med.Quantity >= 100)
                        availability = "Normal";
                    if (med.Quantity >= 500)
                        availability = "High";
                    this.storageDGV.Rows.Add(med.Name, med.PackSize, availability, med.ExpirationDate.ToShortDateString(), med.ID);
                }
            }
        }


        private async void LoadOrders(string searchString = "")
        {
            this.ordersDGV.Rows.Clear();
            IEnumerable<Order> orders = await this.OrderService.ReadAll();
            searchString = searchString.ToLower();
            foreach (Order order in orders)
            {
                if ((order.Destination.ToString().ToLower().Contains(searchString) ||
                    order.Issuer.ToLower().Contains(searchString) ||
                    order.Priority.ToString().ToLower().Contains(searchString)) &&
                    order.Status==Status.Pending)
                {
                    IEnumerable<OrderMedicine> orderMedicines = await this.OrderService.ReadAllOrderMedicine();
                    int totalQuantity = (from orderedMedicine in orderMedicines where orderedMedicine.OrderID == order.ID select orderedMedicine.Quantity).Sum();
                    this.ordersDGV.Rows.Add(order.ID, order.Destination, order.Issuer, order.Priority, totalQuantity);
                }
            }
        }

        private async void LoadOrderDetails(object sender, EventArgs e)
        {
            this.orderDetailsDGV.Rows.Clear();
            if (this.ordersDGV.SelectedRows.Count > 0)
            {
                int id = (int)this.ordersDGV.SelectedRows[0].Cells[0].Value;
                Order selectedOrder = await this.OrderService.Read(id);
                IEnumerable<OrderMedicine> orderedMedicineList = await this.OrderService.ReadAllOrderMedicine();
                foreach (OrderMedicine orderedMedicine in orderedMedicineList)
                {
                    if (orderedMedicine.OrderID == selectedOrder.ID)
                    {
                        Medicine medicine = await this.MedicineService.Read(orderedMedicine.MedicineID);
                        int medicineQuantity = orderedMedicine.Quantity;
                        this.orderDetailsDGV.Rows.Add(medicine.Name, medicineQuantity);
                    }
                }
            }
        }


        private async void LoadHistory(string searchString = "")
        {
            this.historyDGV.Rows.Clear();
            IEnumerable<Order> orders = await this.OrderService.ReadAll();
            searchString = searchString.ToLower();
            foreach(Order order in orders)
            {
                if (order.Status != Status.Pending && (order.ID.ToString().ToLower().Contains(searchString) ||
                    order.Status.ToString().ToLower().Contains(searchString)))
                {
                    if (order.ConfirmationDate != null)
                    {
                        this.historyDGV.Rows.Add(order.ID, order.DispatchedDate.ToString(), order.Status.ToString(), order.ConfirmationDate.ToString());
                    }
                    else
                    {
                        this.historyDGV.Rows.Add(order.ID, order.DispatchedDate.ToString(), order.Status.ToString(), "");
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
            int id = int.Parse(this.ordersDGV.SelectedRows[0].Cells[0].Value.ToString());
            //await this.OrderService.Delete(id); Instead of deleting, update the order with Refused status
            Order declinedOrder = await this.OrderService.Read(id);
            declinedOrder.Status = Status.Refused;
            await this.OrderService.Update(declinedOrder.ID, null, (int)declinedOrder.Destination, declinedOrder.Issuer, (int)declinedOrder.Priority, null, this.Account.Username, (int)declinedOrder.Status, null);
            LoadOrders();
            MessageBox.Show($"Order number {id} has been declined.", "Order declined", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private async void confirmPictureBox_Click(object sender, EventArgs e)
        {
            int id = int.Parse(this.ordersDGV.SelectedRows[0].Cells[0].Value.ToString());
            Order clone = await this.OrderService.Read(id);
            clone.DispatchedDate = DateTime.Now;
            clone.Status = Status.Accepted;
            clone.ETA = this.ETADateTimePicker.Value;
            IEnumerable<OrderMedicine> orderedMedicineList = await this.OrderService.ReadAllOrderMedicine();
            foreach (OrderMedicine orderMedicine in orderedMedicineList)
            {
                if (orderMedicine.OrderID == clone.ID)
                {
                    Medicine medicine = await this.MedicineService.Read(orderMedicine.MedicineID);
                    medicine.Quantity -= orderMedicine.Quantity;
                    await this.MedicineService.Update(medicine.ID, medicine.Name, medicine.PackSize, medicine.Quantity, medicine.ExpirationDate);
                }
            }
            await this.OrderService.Update(clone.ID, (DateTime)clone.ETA, (int)clone.Destination, clone.Issuer,
                (int)clone.Priority, clone.DispatchedDate, this.Account.Username, (int)clone.Status, null);
            LoadOrders();
            MessageBox.Show($"Order number {id} has been accepted.", "Order accepted", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            this.hiddenMedicineIDLabel.Text = updateMedicine.ID.ToString();
            this.AddPictureBox.Image = Update;
        }


        private async void AddPictureBox_ClickAsync(object sender, EventArgs e)
        {
            if (AddPictureBox.Image == Add)
            {
                int id = new Random().Next(1, 2147483647);
                string name = NameTextBox.Text;
                DateTime expirationdate = ExpirationDateTimePicker.Value;
                int packsize = (int)PackSizeNumericUpDown.Value;
                int quantity = (int)QuantityNumericUpDown.Value;
                await this.MedicineService.Create(id, name, packsize, quantity, expirationdate);
            }
            else if (AddPictureBox.Image == Update)
            {
                Medicine updateMedicine = await this.MedicineService.Read(int.Parse(hiddenMedicineIDLabel.Text));
                string name = NameTextBox.Text;
                DateTime expirationdate = ExpirationDateTimePicker.Value;
                int packsize = (int)PackSizeNumericUpDown.Value;
                int quantity = (int)QuantityNumericUpDown.Value;
                await this.MedicineService.Update(updateMedicine.ID, name, packsize, quantity, expirationdate);
            }
        }

        private async void RemovePictureBox_Click(object sender, EventArgs e)
        {
            int id = (int)this.storageDGV.SelectedRows[0].Cells[4].Value;
            await this.MedicineService.Delete(id);
            LoadStorage();
        }
    }
}

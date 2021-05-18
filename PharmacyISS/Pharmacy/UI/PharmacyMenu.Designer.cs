
namespace Pharmacy.UI
{
    partial class PharmacyMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.home = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.unitLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.notificationsInfoLabel = new System.Windows.Forms.Label();
            this.unitInfoLabel = new System.Windows.Forms.Label();
            this.loggedInInfoLabel = new System.Windows.Forms.Label();
            this.homeLabel = new System.Windows.Forms.Label();
            this.stock = new System.Windows.Forms.TabPage();
            this.S_searchTextBox = new System.Windows.Forms.TextBox();
            this.S_searchLabel = new System.Windows.Forms.Label();
            this.storageDGV = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storageLabel = new System.Windows.Forms.Label();
            this.order = new System.Windows.Forms.TabPage();
            this.declinePictureBox = new System.Windows.Forms.PictureBox();
            this.confirmPictureBox = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.orderDetailsDGV = new System.Windows.Forms.DataGridView();
            this.orderMedicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.O_searchTextBox = new System.Windows.Forms.TextBox();
            this.O_searchLabel = new System.Windows.Forms.Label();
            this.ordersDGV = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priority = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersLabel = new System.Windows.Forms.Label();
            this.history = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.H_searchTextBox = new System.Windows.Forms.TextBox();
            this.H_searchLabel = new System.Windows.Forms.Label();
            this.historyDGV = new System.Windows.Forms.DataGridView();
            this.orderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispatched = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historyLabel = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.logoutPictureBox = new System.Windows.Forms.PictureBox();
            this.homePictureBox = new System.Windows.Forms.PictureBox();
            this.storagePictureBox = new System.Windows.Forms.PictureBox();
            this.orderPictureBox = new System.Windows.Forms.PictureBox();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.historyPictureBox = new System.Windows.Forms.PictureBox();
            this.AddMedicinePictureBox = new System.Windows.Forms.PictureBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl.SuspendLayout();
            this.home.SuspendLayout();
            this.stock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storageDGV)).BeginInit();
            this.order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.declinePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDGV)).BeginInit();
            this.history.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddMedicinePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl.Controls.Add(this.home);
            this.tabControl.Controls.Add(this.stock);
            this.tabControl.Controls.Add(this.order);
            this.tabControl.Controls.Add(this.history);
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.ImageList = this.imageList;
            this.tabControl.ItemSize = new System.Drawing.Size(75, 75);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(874, 560);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // home
            // 
            this.home.Controls.Add(this.label7);
            this.home.Controls.Add(this.label4);
            this.home.Controls.Add(this.label3);
            this.home.Controls.Add(this.label2);
            this.home.Controls.Add(this.unitLabel);
            this.home.Controls.Add(this.usernameLabel);
            this.home.Controls.Add(this.notificationsInfoLabel);
            this.home.Controls.Add(this.unitInfoLabel);
            this.home.Controls.Add(this.loggedInInfoLabel);
            this.home.Controls.Add(this.homeLabel);
            this.home.Location = new System.Drawing.Point(79, 4);
            this.home.Name = "home";
            this.home.Padding = new System.Windows.Forms.Padding(3);
            this.home.Size = new System.Drawing.Size(791, 552);
            this.home.TabIndex = 3;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(81, 433);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(482, 19);
            this.label7.TabIndex = 9;
            this.label7.Text = "New order received from -workingUnit- flagged with high priority.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(81, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(297, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "New order received from -workingUnit-.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(81, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(507, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Order number 26970 is being delivered and waiting for confirmation.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(81, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(459, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Order number 19231 has been confirmed by the -workingUnit-.";
            // 
            // unitLabel
            // 
            this.unitLabel.AutoSize = true;
            this.unitLabel.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.unitLabel.Location = new System.Drawing.Point(203, 198);
            this.unitLabel.Name = "unitLabel";
            this.unitLabel.Size = new System.Drawing.Size(81, 19);
            this.unitLabel.TabIndex = 5;
            this.unitLabel.Text = "Pharmacy";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameLabel.Location = new System.Drawing.Point(203, 161);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(81, 19);
            this.usernameLabel.TabIndex = 4;
            this.usernameLabel.Text = "username";
            // 
            // notificationsInfoLabel
            // 
            this.notificationsInfoLabel.AutoSize = true;
            this.notificationsInfoLabel.Font = new System.Drawing.Font("Fira Sans", 17.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.notificationsInfoLabel.Location = new System.Drawing.Point(29, 293);
            this.notificationsInfoLabel.Name = "notificationsInfoLabel";
            this.notificationsInfoLabel.Size = new System.Drawing.Size(149, 28);
            this.notificationsInfoLabel.TabIndex = 3;
            this.notificationsInfoLabel.Text = "Notifications:";
            // 
            // unitInfoLabel
            // 
            this.unitInfoLabel.AutoSize = true;
            this.unitInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.unitInfoLabel.Location = new System.Drawing.Point(143, 195);
            this.unitInfoLabel.Name = "unitInfoLabel";
            this.unitInfoLabel.Size = new System.Drawing.Size(42, 24);
            this.unitInfoLabel.TabIndex = 2;
            this.unitInfoLabel.Text = "Unit";
            // 
            // loggedInInfoLabel
            // 
            this.loggedInInfoLabel.AutoSize = true;
            this.loggedInInfoLabel.Font = new System.Drawing.Font("Fira Sans", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.loggedInInfoLabel.Location = new System.Drawing.Point(81, 158);
            this.loggedInInfoLabel.Name = "loggedInInfoLabel";
            this.loggedInInfoLabel.Size = new System.Drawing.Size(116, 23);
            this.loggedInInfoLabel.TabIndex = 1;
            this.loggedInInfoLabel.Text = "Logged in as";
            // 
            // homeLabel
            // 
            this.homeLabel.AutoSize = true;
            this.homeLabel.Font = new System.Drawing.Font("Fira Sans", 39.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.homeLabel.Location = new System.Drawing.Point(29, 30);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(168, 64);
            this.homeLabel.TabIndex = 0;
            this.homeLabel.Text = "Home";
            // 
            // stock
            // 
            this.stock.Controls.Add(this.S_searchTextBox);
            this.stock.Controls.Add(this.S_searchLabel);
            this.stock.Controls.Add(this.storageDGV);
            this.stock.Controls.Add(this.storageLabel);
            this.stock.Location = new System.Drawing.Point(79, 4);
            this.stock.Name = "stock";
            this.stock.Padding = new System.Windows.Forms.Padding(3);
            this.stock.Size = new System.Drawing.Size(793, 552);
            this.stock.TabIndex = 1;
            this.stock.Text = "Stock";
            this.stock.UseVisualStyleBackColor = true;
            // 
            // S_searchTextBox
            // 
            this.S_searchTextBox.Location = new System.Drawing.Point(132, 133);
            this.S_searchTextBox.Name = "S_searchTextBox";
            this.S_searchTextBox.Size = new System.Drawing.Size(146, 23);
            this.S_searchTextBox.TabIndex = 4;
            // 
            // S_searchLabel
            // 
            this.S_searchLabel.AutoSize = true;
            this.S_searchLabel.Font = new System.Drawing.Font("Fira Sans", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.S_searchLabel.Location = new System.Drawing.Point(59, 133);
            this.S_searchLabel.Name = "S_searchLabel";
            this.S_searchLabel.Size = new System.Drawing.Size(67, 23);
            this.S_searchLabel.TabIndex = 3;
            this.S_searchLabel.Text = "Search";
            // 
            // storageDGV
            // 
            this.storageDGV.AllowUserToAddRows = false;
            this.storageDGV.AllowUserToDeleteRows = false;
            this.storageDGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.storageDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storageDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.packSize,
            this.stockState});
            this.storageDGV.Location = new System.Drawing.Point(59, 168);
            this.storageDGV.Name = "storageDGV";
            this.storageDGV.ReadOnly = true;
            this.storageDGV.RowTemplate.Height = 25;
            this.storageDGV.Size = new System.Drawing.Size(462, 302);
            this.storageDGV.TabIndex = 2;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.HeaderText = "Medicine";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // packSize
            // 
            this.packSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.packSize.HeaderText = "Pack size";
            this.packSize.Name = "packSize";
            this.packSize.ReadOnly = true;
            // 
            // stockState
            // 
            this.stockState.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.stockState.HeaderText = "Stock state";
            this.stockState.Name = "stockState";
            this.stockState.ReadOnly = true;
            // 
            // storageLabel
            // 
            this.storageLabel.AutoSize = true;
            this.storageLabel.Font = new System.Drawing.Font("Fira Sans", 39.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.storageLabel.Location = new System.Drawing.Point(29, 30);
            this.storageLabel.Name = "storageLabel";
            this.storageLabel.Size = new System.Drawing.Size(209, 64);
            this.storageLabel.TabIndex = 1;
            this.storageLabel.Text = "Storage";
            // 
            // order
            // 
            this.order.Controls.Add(this.declinePictureBox);
            this.order.Controls.Add(this.confirmPictureBox);
            this.order.Controls.Add(this.label10);
            this.order.Controls.Add(this.orderDetailsDGV);
            this.order.Controls.Add(this.O_searchTextBox);
            this.order.Controls.Add(this.O_searchLabel);
            this.order.Controls.Add(this.ordersDGV);
            this.order.Controls.Add(this.ordersLabel);
            this.order.Location = new System.Drawing.Point(79, 4);
            this.order.Name = "order";
            this.order.Padding = new System.Windows.Forms.Padding(3);
            this.order.Size = new System.Drawing.Size(793, 552);
            this.order.TabIndex = 2;
            this.order.Text = "Order";
            this.order.UseVisualStyleBackColor = true;
            // 
            // declinePictureBox
            // 
            this.declinePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.declinePictureBox.Image = global::Pharmacy.Properties.Resources.DECLINE;
            this.declinePictureBox.Location = new System.Drawing.Point(548, 490);
            this.declinePictureBox.Name = "declinePictureBox";
            this.declinePictureBox.Size = new System.Drawing.Size(100, 36);
            this.declinePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.declinePictureBox.TabIndex = 10;
            this.declinePictureBox.TabStop = false;
            // 
            // confirmPictureBox
            // 
            this.confirmPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.confirmPictureBox.Image = global::Pharmacy.Properties.Resources.CONFIRM;
            this.confirmPictureBox.Location = new System.Drawing.Point(664, 490);
            this.confirmPictureBox.Name = "confirmPictureBox";
            this.confirmPictureBox.Size = new System.Drawing.Size(100, 36);
            this.confirmPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.confirmPictureBox.TabIndex = 9;
            this.confirmPictureBox.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Fira Sans", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(59, 353);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 23);
            this.label10.TabIndex = 8;
            this.label10.Text = "Order details";
            // 
            // orderDetailsDGV
            // 
            this.orderDetailsDGV.AllowUserToAddRows = false;
            this.orderDetailsDGV.AllowUserToDeleteRows = false;
            this.orderDetailsDGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.orderDetailsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDetailsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderMedicine,
            this.quantity});
            this.orderDetailsDGV.Location = new System.Drawing.Point(59, 388);
            this.orderDetailsDGV.Name = "orderDetailsDGV";
            this.orderDetailsDGV.ReadOnly = true;
            this.orderDetailsDGV.RowTemplate.Height = 25;
            this.orderDetailsDGV.Size = new System.Drawing.Size(458, 150);
            this.orderDetailsDGV.TabIndex = 7;
            // 
            // orderMedicine
            // 
            this.orderMedicine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderMedicine.HeaderText = "Medicine";
            this.orderMedicine.Name = "orderMedicine";
            this.orderMedicine.ReadOnly = true;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.ReadOnly = true;
            this.quantity.Width = 110;
            // 
            // O_searchTextBox
            // 
            this.O_searchTextBox.Location = new System.Drawing.Point(132, 133);
            this.O_searchTextBox.Name = "O_searchTextBox";
            this.O_searchTextBox.Size = new System.Drawing.Size(146, 23);
            this.O_searchTextBox.TabIndex = 6;
            // 
            // O_searchLabel
            // 
            this.O_searchLabel.AutoSize = true;
            this.O_searchLabel.Font = new System.Drawing.Font("Fira Sans", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.O_searchLabel.Location = new System.Drawing.Point(59, 133);
            this.O_searchLabel.Name = "O_searchLabel";
            this.O_searchLabel.Size = new System.Drawing.Size(67, 23);
            this.O_searchLabel.TabIndex = 5;
            this.O_searchLabel.Text = "Search";
            // 
            // ordersDGV
            // 
            this.ordersDGV.AllowUserToAddRows = false;
            this.ordersDGV.AllowUserToDeleteRows = false;
            this.ordersDGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ordersDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.issuedBy,
            this.priority,
            this.totalQuantity});
            this.ordersDGV.Location = new System.Drawing.Point(59, 168);
            this.ordersDGV.Name = "ordersDGV";
            this.ordersDGV.ReadOnly = true;
            this.ordersDGV.RowTemplate.Height = 25;
            this.ordersDGV.Size = new System.Drawing.Size(458, 150);
            this.ordersDGV.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Unit";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // issuedBy
            // 
            this.issuedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.issuedBy.HeaderText = "Issued by";
            this.issuedBy.Name = "issuedBy";
            this.issuedBy.ReadOnly = true;
            // 
            // priority
            // 
            this.priority.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.priority.HeaderText = "Priority";
            this.priority.Name = "priority";
            this.priority.ReadOnly = true;
            this.priority.Width = 80;
            // 
            // totalQuantity
            // 
            this.totalQuantity.HeaderText = "Total quantity";
            this.totalQuantity.Name = "totalQuantity";
            this.totalQuantity.ReadOnly = true;
            this.totalQuantity.Width = 110;
            // 
            // ordersLabel
            // 
            this.ordersLabel.AutoSize = true;
            this.ordersLabel.Font = new System.Drawing.Font("Fira Sans", 39.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.ordersLabel.Location = new System.Drawing.Point(32, 30);
            this.ordersLabel.Name = "ordersLabel";
            this.ordersLabel.Size = new System.Drawing.Size(188, 64);
            this.ordersLabel.TabIndex = 1;
            this.ordersLabel.Text = "Orders";
            // 
            // history
            // 
            this.history.Controls.Add(this.pictureBox1);
            this.history.Controls.Add(this.H_searchTextBox);
            this.history.Controls.Add(this.H_searchLabel);
            this.history.Controls.Add(this.historyDGV);
            this.history.Controls.Add(this.historyLabel);
            this.history.Location = new System.Drawing.Point(79, 4);
            this.history.Name = "history";
            this.history.Size = new System.Drawing.Size(791, 552);
            this.history.TabIndex = 4;
            this.history.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Pharmacy.Properties.Resources.VIEWNOTE;
            this.pictureBox1.Location = new System.Drawing.Point(619, 490);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // H_searchTextBox
            // 
            this.H_searchTextBox.Location = new System.Drawing.Point(132, 133);
            this.H_searchTextBox.Name = "H_searchTextBox";
            this.H_searchTextBox.Size = new System.Drawing.Size(146, 23);
            this.H_searchTextBox.TabIndex = 8;
            // 
            // H_searchLabel
            // 
            this.H_searchLabel.AutoSize = true;
            this.H_searchLabel.Font = new System.Drawing.Font("Fira Sans", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.H_searchLabel.Location = new System.Drawing.Point(59, 133);
            this.H_searchLabel.Name = "H_searchLabel";
            this.H_searchLabel.Size = new System.Drawing.Size(67, 23);
            this.H_searchLabel.TabIndex = 7;
            this.H_searchLabel.Text = "Search";
            // 
            // historyDGV
            // 
            this.historyDGV.AllowUserToAddRows = false;
            this.historyDGV.AllowUserToDeleteRows = false;
            this.historyDGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.historyDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumber,
            this.dispatched,
            this.status,
            this.confirmed});
            this.historyDGV.Location = new System.Drawing.Point(59, 168);
            this.historyDGV.Name = "historyDGV";
            this.historyDGV.ReadOnly = true;
            this.historyDGV.RowTemplate.Height = 25;
            this.historyDGV.Size = new System.Drawing.Size(462, 302);
            this.historyDGV.TabIndex = 6;
            // 
            // orderNumber
            // 
            this.orderNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.orderNumber.HeaderText = "Number";
            this.orderNumber.Name = "orderNumber";
            this.orderNumber.ReadOnly = true;
            this.orderNumber.Width = 70;
            // 
            // dispatched
            // 
            this.dispatched.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dispatched.HeaderText = "Dispatched at";
            this.dispatched.Name = "dispatched";
            this.dispatched.ReadOnly = true;
            this.dispatched.Width = 135;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // confirmed
            // 
            this.confirmed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.confirmed.HeaderText = "Confirmed at";
            this.confirmed.Name = "confirmed";
            this.confirmed.ReadOnly = true;
            this.confirmed.Width = 135;
            // 
            // historyLabel
            // 
            this.historyLabel.AutoSize = true;
            this.historyLabel.Font = new System.Drawing.Font("Fira Sans", 39.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.historyLabel.Location = new System.Drawing.Point(29, 30);
            this.historyLabel.Name = "historyLabel";
            this.historyLabel.Size = new System.Drawing.Size(199, 64);
            this.historyLabel.TabIndex = 5;
            this.historyLabel.Text = "History";
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // logoutPictureBox
            // 
            this.logoutPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.logoutPictureBox.Image = global::Pharmacy.Properties.Resources.exit;
            this.logoutPictureBox.Location = new System.Drawing.Point(12, 494);
            this.logoutPictureBox.Name = "logoutPictureBox";
            this.logoutPictureBox.Size = new System.Drawing.Size(54, 54);
            this.logoutPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoutPictureBox.TabIndex = 1;
            this.logoutPictureBox.TabStop = false;
            this.logoutPictureBox.Click += new System.EventHandler(this.logoutPictureBox_Click);
            // 
            // homePictureBox
            // 
            this.homePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.homePictureBox.Image = global::Pharmacy.Properties.Resources.home;
            this.homePictureBox.Location = new System.Drawing.Point(12, 12);
            this.homePictureBox.Name = "homePictureBox";
            this.homePictureBox.Size = new System.Drawing.Size(54, 54);
            this.homePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homePictureBox.TabIndex = 2;
            this.homePictureBox.TabStop = false;
            this.homePictureBox.Click += new System.EventHandler(this.homePictureBox_Click);
            // 
            // storagePictureBox
            // 
            this.storagePictureBox.BackColor = System.Drawing.Color.Transparent;
            this.storagePictureBox.Image = global::Pharmacy.Properties.Resources.unitStorage;
            this.storagePictureBox.Location = new System.Drawing.Point(12, 88);
            this.storagePictureBox.Name = "storagePictureBox";
            this.storagePictureBox.Size = new System.Drawing.Size(54, 54);
            this.storagePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.storagePictureBox.TabIndex = 3;
            this.storagePictureBox.TabStop = false;
            this.storagePictureBox.Click += new System.EventHandler(this.storagePictureBox_Click);
            // 
            // orderPictureBox
            // 
            this.orderPictureBox.Image = global::Pharmacy.Properties.Resources.pharmOrder;
            this.orderPictureBox.Location = new System.Drawing.Point(12, 163);
            this.orderPictureBox.Name = "orderPictureBox";
            this.orderPictureBox.Size = new System.Drawing.Size(54, 54);
            this.orderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.orderPictureBox.TabIndex = 4;
            this.orderPictureBox.TabStop = false;
            this.orderPictureBox.Click += new System.EventHandler(this.orderPictureBox_Click);
            // 
            // Unit
            // 
            this.Unit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            // 
            // historyPictureBox
            // 
            this.historyPictureBox.Image = global::Pharmacy.Properties.Resources.history;
            this.historyPictureBox.Location = new System.Drawing.Point(12, 238);
            this.historyPictureBox.Name = "historyPictureBox";
            this.historyPictureBox.Size = new System.Drawing.Size(54, 54);
            this.historyPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.historyPictureBox.TabIndex = 5;
            this.historyPictureBox.TabStop = false;
            this.historyPictureBox.Click += new System.EventHandler(this.historyPictureBox_Click);
            // 
            // AddMedicinePictureBox
            // 
            this.AddMedicinePictureBox.BackColor = System.Drawing.Color.RoyalBlue;
            this.AddMedicinePictureBox.Location = new System.Drawing.Point(12, 309);
            this.AddMedicinePictureBox.Name = "AddMedicinePictureBox";
            this.AddMedicinePictureBox.Size = new System.Drawing.Size(54, 54);
            this.AddMedicinePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AddMedicinePictureBox.TabIndex = 6;
            this.AddMedicinePictureBox.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(79, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(791, 552);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // PharmacyMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(873, 560);
            this.Controls.Add(this.AddMedicinePictureBox);
            this.Controls.Add(this.historyPictureBox);
            this.Controls.Add(this.orderPictureBox);
            this.Controls.Add(this.storagePictureBox);
            this.Controls.Add(this.homePictureBox);
            this.Controls.Add(this.logoutPictureBox);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PharmacyMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.tabControl.ResumeLayout(false);
            this.home.ResumeLayout(false);
            this.home.PerformLayout();
            this.stock.ResumeLayout(false);
            this.stock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.storageDGV)).EndInit();
            this.order.ResumeLayout(false);
            this.order.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.declinePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderDetailsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDGV)).EndInit();
            this.history.ResumeLayout(false);
            this.history.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AddMedicinePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage stock;
        private System.Windows.Forms.TabPage order;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.TabPage home;
        private System.Windows.Forms.PictureBox logoutPictureBox;
        private System.Windows.Forms.PictureBox homePictureBox;
        private System.Windows.Forms.PictureBox storagePictureBox;
        private System.Windows.Forms.PictureBox orderPictureBox;
        private System.Windows.Forms.Label notificationsInfoLabel;
        private System.Windows.Forms.Label unitInfoLabel;
        private System.Windows.Forms.Label loggedInInfoLabel;
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label unitLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label storageLabel;
        private System.Windows.Forms.DataGridView storageDGV;
        private System.Windows.Forms.TextBox S_searchTextBox;
        private System.Windows.Forms.Label S_searchLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn packSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockState;
        private System.Windows.Forms.DataGridView ordersDGV;
        private System.Windows.Forms.Label ordersLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView orderDetailsDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderMedicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.TextBox O_searchTextBox;
        private System.Windows.Forms.Label O_searchLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn priority;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalQuantity;
        private System.Windows.Forms.PictureBox declinePictureBox;
        private System.Windows.Forms.PictureBox confirmPictureBox;
        private System.Windows.Forms.TabPage history;
        private System.Windows.Forms.PictureBox historyPictureBox;
        private System.Windows.Forms.TextBox H_searchTextBox;
        private System.Windows.Forms.Label H_searchLabel;
        private System.Windows.Forms.DataGridView historyDGV;
        private System.Windows.Forms.Label historyLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispatched;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn confirmed;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox AddMedicinePictureBox;
        private System.Windows.Forms.TabPage tabPage1;
    }
}
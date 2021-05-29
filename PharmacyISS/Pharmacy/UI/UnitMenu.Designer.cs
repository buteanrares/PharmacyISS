
namespace Pharmacy.UI
{
    partial class UnitMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UnitMenu));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.home = new System.Windows.Forms.TabPage();
            this.NotificationLabel3 = new System.Windows.Forms.Label();
            this.HomeLabel = new System.Windows.Forms.Label();
            this.NotificationLabel2 = new System.Windows.Forms.Label();
            this.loggedInInfoLabel = new System.Windows.Forms.Label();
            this.NotificationLabel1 = new System.Windows.Forms.Label();
            this.unitInfoLabel = new System.Windows.Forms.Label();
            this.WorkingUnitLabel = new System.Windows.Forms.Label();
            this.notificationsInfoLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.stock = new System.Windows.Forms.TabPage();
            this.StorageAddPictureBox = new System.Windows.Forms.PictureBox();
            this.StorageSearchTextBox = new System.Windows.Forms.TextBox();
            this.StorageSearchLabel = new System.Windows.Forms.Label();
            this.StorageDGV = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ExpirationDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availability = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PharmacyStorageLabel = new System.Windows.Forms.Label();
            this.order = new System.Windows.Forms.TabPage();
            this.removeMedicinePictureBox = new System.Windows.Forms.PictureBox();
            this.confirmOrderPictureBox = new System.Windows.Forms.PictureBox();
            this.PriorityComboBox = new System.Windows.Forms.ComboBox();
            this.PriorityLabel = new System.Windows.Forms.Label();
            this.OrderDGV = new System.Windows.Forms.DataGridView();
            this.orderMedicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrderSearchTextBox = new System.Windows.Forms.TextBox();
            this.OrderSearchLabel = new System.Windows.Forms.Label();
            this.OrderLabel = new System.Windows.Forms.Label();
            this.confirmations = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ConfirmOrderArrivalPictureBox = new System.Windows.Forms.PictureBox();
            this.H_searchTextBox = new System.Windows.Forms.TextBox();
            this.H_searchLabel = new System.Windows.Forms.Label();
            this.ConfirmationsDGV = new System.Windows.Forms.DataGridView();
            this.confirmationsLabel = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.logoutPictureBox = new System.Windows.Forms.PictureBox();
            this.homePictureBox = new System.Windows.Forms.PictureBox();
            this.storagePictureBox = new System.Windows.Forms.PictureBox();
            this.orderPictureBox = new System.Windows.Forms.PictureBox();
            this.confirmationsPictureBox = new System.Windows.Forms.PictureBox();
            this.orderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispatchedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispatchedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl.SuspendLayout();
            this.home.SuspendLayout();
            this.stock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StorageAddPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StorageDGV)).BeginInit();
            this.order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.removeMedicinePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmOrderPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDGV)).BeginInit();
            this.confirmations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmOrderArrivalPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmationsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmationsPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl.Controls.Add(this.home);
            this.tabControl.Controls.Add(this.stock);
            this.tabControl.Controls.Add(this.order);
            this.tabControl.Controls.Add(this.confirmations);
            this.tabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl.ImageList = this.imageList;
            this.tabControl.ItemSize = new System.Drawing.Size(75, 75);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Multiline = true;
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(865, 560);
            this.tabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // home
            // 
            this.home.Controls.Add(this.NotificationLabel3);
            this.home.Controls.Add(this.HomeLabel);
            this.home.Controls.Add(this.NotificationLabel2);
            this.home.Controls.Add(this.loggedInInfoLabel);
            this.home.Controls.Add(this.NotificationLabel1);
            this.home.Controls.Add(this.unitInfoLabel);
            this.home.Controls.Add(this.WorkingUnitLabel);
            this.home.Controls.Add(this.notificationsInfoLabel);
            this.home.Controls.Add(this.usernameLabel);
            this.home.Location = new System.Drawing.Point(79, 4);
            this.home.Name = "home";
            this.home.Padding = new System.Windows.Forms.Padding(3);
            this.home.Size = new System.Drawing.Size(782, 552);
            this.home.TabIndex = 3;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            // 
            // NotificationLabel3
            // 
            this.NotificationLabel3.AutoSize = true;
            this.NotificationLabel3.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NotificationLabel3.Location = new System.Drawing.Point(75, 397);
            this.NotificationLabel3.Name = "NotificationLabel3";
            this.NotificationLabel3.Size = new System.Drawing.Size(642, 19);
            this.NotificationLabel3.TabIndex = 17;
            this.NotificationLabel3.Text = "Order number 82362 has been accepted by the pharmacy and waiting for confirmation" +
    ".";
            // 
            // HomeLabel
            // 
            this.HomeLabel.AutoSize = true;
            this.HomeLabel.Font = new System.Drawing.Font("Fira Sans", 39.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.HomeLabel.Location = new System.Drawing.Point(29, 30);
            this.HomeLabel.Name = "HomeLabel";
            this.HomeLabel.Size = new System.Drawing.Size(168, 64);
            this.HomeLabel.TabIndex = 9;
            this.HomeLabel.Text = "Home";
            // 
            // NotificationLabel2
            // 
            this.NotificationLabel2.AutoSize = true;
            this.NotificationLabel2.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NotificationLabel2.Location = new System.Drawing.Point(75, 369);
            this.NotificationLabel2.Name = "NotificationLabel2";
            this.NotificationLabel2.Size = new System.Drawing.Size(641, 19);
            this.NotificationLabel2.TabIndex = 16;
            this.NotificationLabel2.Text = "Order number 26970 has been accepted by the pharmacy and waiting for confirmation" +
    ".";
            // 
            // loggedInInfoLabel
            // 
            this.loggedInInfoLabel.AutoSize = true;
            this.loggedInInfoLabel.Font = new System.Drawing.Font("Fira Sans", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.loggedInInfoLabel.Location = new System.Drawing.Point(75, 150);
            this.loggedInInfoLabel.Name = "loggedInInfoLabel";
            this.loggedInInfoLabel.Size = new System.Drawing.Size(116, 23);
            this.loggedInInfoLabel.TabIndex = 10;
            this.loggedInInfoLabel.Text = "Logged in as";
            // 
            // NotificationLabel1
            // 
            this.NotificationLabel1.AutoSize = true;
            this.NotificationLabel1.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NotificationLabel1.Location = new System.Drawing.Point(75, 341);
            this.NotificationLabel1.Name = "NotificationLabel1";
            this.NotificationLabel1.Size = new System.Drawing.Size(609, 19);
            this.NotificationLabel1.TabIndex = 15;
            this.NotificationLabel1.Text = "Order number 19231 has been refused by the pharmacy. (optional: due to -reason-)";
            // 
            // unitInfoLabel
            // 
            this.unitInfoLabel.AutoSize = true;
            this.unitInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.unitInfoLabel.Location = new System.Drawing.Point(144, 186);
            this.unitInfoLabel.Name = "unitInfoLabel";
            this.unitInfoLabel.Size = new System.Drawing.Size(47, 24);
            this.unitInfoLabel.TabIndex = 11;
            this.unitInfoLabel.Text = "Unit ";
            // 
            // WorkingUnitLabel
            // 
            this.WorkingUnitLabel.AutoSize = true;
            this.WorkingUnitLabel.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WorkingUnitLabel.Location = new System.Drawing.Point(197, 190);
            this.WorkingUnitLabel.Name = "WorkingUnitLabel";
            this.WorkingUnitLabel.Size = new System.Drawing.Size(129, 19);
            this.WorkingUnitLabel.TabIndex = 14;
            this.WorkingUnitLabel.Text = "userWorkingUnit";
            // 
            // notificationsInfoLabel
            // 
            this.notificationsInfoLabel.AutoSize = true;
            this.notificationsInfoLabel.Font = new System.Drawing.Font("Fira Sans", 17.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.notificationsInfoLabel.Location = new System.Drawing.Point(23, 285);
            this.notificationsInfoLabel.Name = "notificationsInfoLabel";
            this.notificationsInfoLabel.Size = new System.Drawing.Size(149, 28);
            this.notificationsInfoLabel.TabIndex = 12;
            this.notificationsInfoLabel.Text = "Notifications:";
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameLabel.Location = new System.Drawing.Point(197, 153);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(81, 19);
            this.usernameLabel.TabIndex = 13;
            this.usernameLabel.Text = "username";
            // 
            // stock
            // 
            this.stock.Controls.Add(this.StorageAddPictureBox);
            this.stock.Controls.Add(this.StorageSearchTextBox);
            this.stock.Controls.Add(this.StorageSearchLabel);
            this.stock.Controls.Add(this.StorageDGV);
            this.stock.Controls.Add(this.PharmacyStorageLabel);
            this.stock.Location = new System.Drawing.Point(79, 4);
            this.stock.Name = "stock";
            this.stock.Padding = new System.Windows.Forms.Padding(3);
            this.stock.Size = new System.Drawing.Size(782, 552);
            this.stock.TabIndex = 1;
            this.stock.Text = "Stock";
            this.stock.UseVisualStyleBackColor = true;
            // 
            // StorageAddPictureBox
            // 
            this.StorageAddPictureBox.Image = global::Pharmacy.Properties.Resources.ADD;
            this.StorageAddPictureBox.Location = new System.Drawing.Point(433, 131);
            this.StorageAddPictureBox.Name = "StorageAddPictureBox";
            this.StorageAddPictureBox.Size = new System.Drawing.Size(100, 31);
            this.StorageAddPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.StorageAddPictureBox.TabIndex = 15;
            this.StorageAddPictureBox.TabStop = false;
            this.StorageAddPictureBox.Click += new System.EventHandler(this.StorageAddPictureBox_Click);
            // 
            // StorageSearchTextBox
            // 
            this.StorageSearchTextBox.Location = new System.Drawing.Point(132, 133);
            this.StorageSearchTextBox.Name = "StorageSearchTextBox";
            this.StorageSearchTextBox.Size = new System.Drawing.Size(146, 23);
            this.StorageSearchTextBox.TabIndex = 8;
            this.StorageSearchTextBox.TextChanged += new System.EventHandler(this.StorageSearchTextBox_TextChanged);
            // 
            // StorageSearchLabel
            // 
            this.StorageSearchLabel.AutoSize = true;
            this.StorageSearchLabel.Font = new System.Drawing.Font("Fira Sans", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.StorageSearchLabel.Location = new System.Drawing.Point(59, 133);
            this.StorageSearchLabel.Name = "StorageSearchLabel";
            this.StorageSearchLabel.Size = new System.Drawing.Size(67, 23);
            this.StorageSearchLabel.TabIndex = 7;
            this.StorageSearchLabel.Text = "Search";
            // 
            // StorageDGV
            // 
            this.StorageDGV.AllowUserToAddRows = false;
            this.StorageDGV.AllowUserToDeleteRows = false;
            this.StorageDGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.StorageDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StorageDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.packSize,
            this.ExpirationDate,
            this.availability,
            this.ID});
            this.StorageDGV.Location = new System.Drawing.Point(59, 168);
            this.StorageDGV.Name = "StorageDGV";
            this.StorageDGV.ReadOnly = true;
            this.StorageDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.StorageDGV.RowTemplate.Height = 25;
            this.StorageDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StorageDGV.Size = new System.Drawing.Size(474, 284);
            this.StorageDGV.TabIndex = 6;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.name.HeaderText = "Medicine";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.name.Width = 140;
            // 
            // packSize
            // 
            this.packSize.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.packSize.HeaderText = "Pack size";
            this.packSize.Name = "packSize";
            this.packSize.ReadOnly = true;
            this.packSize.Width = 80;
            // 
            // ExpirationDate
            // 
            this.ExpirationDate.HeaderText = "Expiration date";
            this.ExpirationDate.Name = "ExpirationDate";
            this.ExpirationDate.ReadOnly = true;
            this.ExpirationDate.Width = 116;
            // 
            // availability
            // 
            this.availability.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.availability.HeaderText = "Availability";
            this.availability.Name = "availability";
            this.availability.ReadOnly = true;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // PharmacyStorageLabel
            // 
            this.PharmacyStorageLabel.AutoSize = true;
            this.PharmacyStorageLabel.Font = new System.Drawing.Font("Fira Sans", 39.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.PharmacyStorageLabel.Location = new System.Drawing.Point(29, 30);
            this.PharmacyStorageLabel.Name = "PharmacyStorageLabel";
            this.PharmacyStorageLabel.Size = new System.Drawing.Size(455, 64);
            this.PharmacyStorageLabel.TabIndex = 5;
            this.PharmacyStorageLabel.Text = "Pharmacy storage";
            // 
            // order
            // 
            this.order.Controls.Add(this.removeMedicinePictureBox);
            this.order.Controls.Add(this.confirmOrderPictureBox);
            this.order.Controls.Add(this.PriorityComboBox);
            this.order.Controls.Add(this.PriorityLabel);
            this.order.Controls.Add(this.OrderDGV);
            this.order.Controls.Add(this.OrderSearchTextBox);
            this.order.Controls.Add(this.OrderSearchLabel);
            this.order.Controls.Add(this.OrderLabel);
            this.order.Location = new System.Drawing.Point(79, 4);
            this.order.Name = "order";
            this.order.Padding = new System.Windows.Forms.Padding(3);
            this.order.Size = new System.Drawing.Size(782, 552);
            this.order.TabIndex = 2;
            this.order.Text = "Order";
            this.order.UseVisualStyleBackColor = true;
            // 
            // removeMedicinePictureBox
            // 
            this.removeMedicinePictureBox.Image = global::Pharmacy.Properties.Resources.REMOVE;
            this.removeMedicinePictureBox.Location = new System.Drawing.Point(415, 131);
            this.removeMedicinePictureBox.Name = "removeMedicinePictureBox";
            this.removeMedicinePictureBox.Size = new System.Drawing.Size(100, 31);
            this.removeMedicinePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.removeMedicinePictureBox.TabIndex = 14;
            this.removeMedicinePictureBox.TabStop = false;
            this.removeMedicinePictureBox.Click += new System.EventHandler(this.removeMedicinePictureBox_Click);
            // 
            // confirmOrderPictureBox
            // 
            this.confirmOrderPictureBox.Image = global::Pharmacy.Properties.Resources.CONFIRM;
            this.confirmOrderPictureBox.Location = new System.Drawing.Point(643, 475);
            this.confirmOrderPictureBox.Name = "confirmOrderPictureBox";
            this.confirmOrderPictureBox.Size = new System.Drawing.Size(100, 30);
            this.confirmOrderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.confirmOrderPictureBox.TabIndex = 13;
            this.confirmOrderPictureBox.TabStop = false;
            this.confirmOrderPictureBox.Click += new System.EventHandler(this.confirmOrderPictureBox_Click);
            // 
            // PriorityComboBox
            // 
            this.PriorityComboBox.Font = new System.Drawing.Font("Fira Sans", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PriorityComboBox.FormattingEnabled = true;
            this.PriorityComboBox.Items.AddRange(new object[] {
            "Low",
            "Normal",
            "High"});
            this.PriorityComboBox.Location = new System.Drawing.Point(137, 475);
            this.PriorityComboBox.Name = "PriorityComboBox";
            this.PriorityComboBox.Size = new System.Drawing.Size(121, 22);
            this.PriorityComboBox.TabIndex = 12;
            // 
            // PriorityLabel
            // 
            this.PriorityLabel.AutoSize = true;
            this.PriorityLabel.Font = new System.Drawing.Font("Fira Sans", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.PriorityLabel.Location = new System.Drawing.Point(59, 475);
            this.PriorityLabel.Name = "PriorityLabel";
            this.PriorityLabel.Size = new System.Drawing.Size(72, 23);
            this.PriorityLabel.TabIndex = 11;
            this.PriorityLabel.Text = "Priority";
            // 
            // OrderDGV
            // 
            this.OrderDGV.AllowUserToAddRows = false;
            this.OrderDGV.AllowUserToDeleteRows = false;
            this.OrderDGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.OrderDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderMedicine,
            this.quantity,
            this.dataGridViewTextBoxColumn1});
            this.OrderDGV.Location = new System.Drawing.Point(59, 168);
            this.OrderDGV.Name = "OrderDGV";
            this.OrderDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.OrderDGV.RowTemplate.Height = 25;
            this.OrderDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderDGV.Size = new System.Drawing.Size(456, 284);
            this.OrderDGV.TabIndex = 10;
            // 
            // orderMedicine
            // 
            this.orderMedicine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderMedicine.HeaderText = "Medicine";
            this.orderMedicine.Name = "orderMedicine";
            this.orderMedicine.ReadOnly = true;
            this.orderMedicine.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.quantity.Width = 110;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // OrderSearchTextBox
            // 
            this.OrderSearchTextBox.Location = new System.Drawing.Point(132, 133);
            this.OrderSearchTextBox.Name = "OrderSearchTextBox";
            this.OrderSearchTextBox.Size = new System.Drawing.Size(146, 23);
            this.OrderSearchTextBox.TabIndex = 9;
            this.OrderSearchTextBox.TextChanged += new System.EventHandler(this.OrderSearchTextBox_TextChanged);
            // 
            // OrderSearchLabel
            // 
            this.OrderSearchLabel.AutoSize = true;
            this.OrderSearchLabel.Font = new System.Drawing.Font("Fira Sans", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.OrderSearchLabel.Location = new System.Drawing.Point(59, 133);
            this.OrderSearchLabel.Name = "OrderSearchLabel";
            this.OrderSearchLabel.Size = new System.Drawing.Size(67, 23);
            this.OrderSearchLabel.TabIndex = 8;
            this.OrderSearchLabel.Text = "Search";
            // 
            // OrderLabel
            // 
            this.OrderLabel.AutoSize = true;
            this.OrderLabel.Font = new System.Drawing.Font("Fira Sans", 39.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.OrderLabel.Location = new System.Drawing.Point(29, 30);
            this.OrderLabel.Name = "OrderLabel";
            this.OrderLabel.Size = new System.Drawing.Size(164, 64);
            this.OrderLabel.TabIndex = 6;
            this.OrderLabel.Text = "Order";
            // 
            // confirmations
            // 
            this.confirmations.Controls.Add(this.pictureBox3);
            this.confirmations.Controls.Add(this.ConfirmOrderArrivalPictureBox);
            this.confirmations.Controls.Add(this.H_searchTextBox);
            this.confirmations.Controls.Add(this.H_searchLabel);
            this.confirmations.Controls.Add(this.ConfirmationsDGV);
            this.confirmations.Controls.Add(this.confirmationsLabel);
            this.confirmations.Location = new System.Drawing.Point(79, 4);
            this.confirmations.Name = "confirmations";
            this.confirmations.Size = new System.Drawing.Size(782, 552);
            this.confirmations.TabIndex = 4;
            this.confirmations.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Pharmacy.Properties.Resources.ADDNOTE;
            this.pictureBox3.Location = new System.Drawing.Point(548, 490);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 33);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // ConfirmOrderArrivalPictureBox
            // 
            this.ConfirmOrderArrivalPictureBox.Image = global::Pharmacy.Properties.Resources.CONFIRM;
            this.ConfirmOrderArrivalPictureBox.Location = new System.Drawing.Point(664, 490);
            this.ConfirmOrderArrivalPictureBox.Name = "ConfirmOrderArrivalPictureBox";
            this.ConfirmOrderArrivalPictureBox.Size = new System.Drawing.Size(100, 32);
            this.ConfirmOrderArrivalPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ConfirmOrderArrivalPictureBox.TabIndex = 11;
            this.ConfirmOrderArrivalPictureBox.TabStop = false;
            this.ConfirmOrderArrivalPictureBox.Click += new System.EventHandler(this.ConfirmOrderArrivalPictureBox_Click);
            // 
            // H_searchTextBox
            // 
            this.H_searchTextBox.Location = new System.Drawing.Point(132, 133);
            this.H_searchTextBox.Name = "H_searchTextBox";
            this.H_searchTextBox.Size = new System.Drawing.Size(146, 23);
            this.H_searchTextBox.TabIndex = 10;
            this.H_searchTextBox.TextChanged += new System.EventHandler(this.H_searchTextBox_TextChanged);
            // 
            // H_searchLabel
            // 
            this.H_searchLabel.AutoSize = true;
            this.H_searchLabel.Font = new System.Drawing.Font("Fira Sans", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.H_searchLabel.Location = new System.Drawing.Point(59, 133);
            this.H_searchLabel.Name = "H_searchLabel";
            this.H_searchLabel.Size = new System.Drawing.Size(67, 23);
            this.H_searchLabel.TabIndex = 9;
            this.H_searchLabel.Text = "Search";
            // 
            // ConfirmationsDGV
            // 
            this.ConfirmationsDGV.AllowUserToAddRows = false;
            this.ConfirmationsDGV.AllowUserToDeleteRows = false;
            this.ConfirmationsDGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ConfirmationsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConfirmationsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumber,
            this.Status,
            this.dispatchedBy,
            this.dispatchedAt});
            this.ConfirmationsDGV.Location = new System.Drawing.Point(59, 168);
            this.ConfirmationsDGV.Name = "ConfirmationsDGV";
            this.ConfirmationsDGV.ReadOnly = true;
            this.ConfirmationsDGV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.ConfirmationsDGV.RowTemplate.Height = 25;
            this.ConfirmationsDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ConfirmationsDGV.Size = new System.Drawing.Size(456, 284);
            this.ConfirmationsDGV.TabIndex = 8;
            // 
            // confirmationsLabel
            // 
            this.confirmationsLabel.AutoSize = true;
            this.confirmationsLabel.Font = new System.Drawing.Font("Fira Sans", 39.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.confirmationsLabel.Location = new System.Drawing.Point(29, 30);
            this.confirmationsLabel.Name = "confirmationsLabel";
            this.confirmationsLabel.Size = new System.Drawing.Size(363, 64);
            this.confirmationsLabel.TabIndex = 7;
            this.confirmationsLabel.Text = "Confirmations";
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "tr.jpg");
            this.imageList.Images.SetKeyName(1, "exit.png");
            this.imageList.Images.SetKeyName(2, "home.png");
            this.imageList.Images.SetKeyName(3, "pharmOrder.png");
            this.imageList.Images.SetKeyName(4, "pharmStorage.png");
            this.imageList.Images.SetKeyName(5, "unitOrder.png");
            this.imageList.Images.SetKeyName(6, "unitStorage.png");
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
            this.storagePictureBox.Image = global::Pharmacy.Properties.Resources.pharmStorage;
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
            this.orderPictureBox.Image = global::Pharmacy.Properties.Resources.unitOrder;
            this.orderPictureBox.Location = new System.Drawing.Point(12, 163);
            this.orderPictureBox.Name = "orderPictureBox";
            this.orderPictureBox.Size = new System.Drawing.Size(54, 54);
            this.orderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.orderPictureBox.TabIndex = 4;
            this.orderPictureBox.TabStop = false;
            this.orderPictureBox.Click += new System.EventHandler(this.orderPictureBox_Click);
            // 
            // confirmationsPictureBox
            // 
            this.confirmationsPictureBox.Image = global::Pharmacy.Properties.Resources.confirmOrder;
            this.confirmationsPictureBox.Location = new System.Drawing.Point(12, 238);
            this.confirmationsPictureBox.Name = "confirmationsPictureBox";
            this.confirmationsPictureBox.Size = new System.Drawing.Size(54, 54);
            this.confirmationsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.confirmationsPictureBox.TabIndex = 5;
            this.confirmationsPictureBox.TabStop = false;
            this.confirmationsPictureBox.Click += new System.EventHandler(this.ConfirmOrdersPictureBox_Click);
            // 
            // orderNumber
            // 
            this.orderNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.orderNumber.HeaderText = "Number";
            this.orderNumber.Name = "orderNumber";
            this.orderNumber.ReadOnly = true;
            this.orderNumber.Width = 70;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Status.Width = 75;
            // 
            // dispatchedBy
            // 
            this.dispatchedBy.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dispatchedBy.HeaderText = "Dispatched by";
            this.dispatchedBy.Name = "dispatchedBy";
            this.dispatchedBy.ReadOnly = true;
            // 
            // dispatchedAt
            // 
            this.dispatchedAt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dispatchedAt.HeaderText = "Dispatched at";
            this.dispatchedAt.Name = "dispatchedAt";
            this.dispatchedAt.ReadOnly = true;
            // 
            // UnitMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(864, 560);
            this.Controls.Add(this.confirmationsPictureBox);
            this.Controls.Add(this.orderPictureBox);
            this.Controls.Add(this.storagePictureBox);
            this.Controls.Add(this.homePictureBox);
            this.Controls.Add(this.logoutPictureBox);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UnitMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.tabControl.ResumeLayout(false);
            this.home.ResumeLayout(false);
            this.home.PerformLayout();
            this.stock.ResumeLayout(false);
            this.stock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StorageAddPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StorageDGV)).EndInit();
            this.order.ResumeLayout(false);
            this.order.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.removeMedicinePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmOrderPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrderDGV)).EndInit();
            this.confirmations.ResumeLayout(false);
            this.confirmations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmOrderArrivalPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmationsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoutPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmationsPictureBox)).EndInit();
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
        private System.Windows.Forms.Label NotificationLabel3;
        private System.Windows.Forms.Label HomeLabel;
        private System.Windows.Forms.Label NotificationLabel2;
        private System.Windows.Forms.Label loggedInInfoLabel;
        private System.Windows.Forms.Label NotificationLabel1;
        private System.Windows.Forms.Label unitInfoLabel;
        private System.Windows.Forms.Label WorkingUnitLabel;
        private System.Windows.Forms.Label notificationsInfoLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox StorageSearchTextBox;
        private System.Windows.Forms.Label StorageSearchLabel;
        private System.Windows.Forms.DataGridView StorageDGV;
        private System.Windows.Forms.Label PharmacyStorageLabel;
        private System.Windows.Forms.Label OrderLabel;
        private System.Windows.Forms.TextBox OrderSearchTextBox;
        private System.Windows.Forms.Label OrderSearchLabel;
        private System.Windows.Forms.DataGridView OrderDGV;
        private System.Windows.Forms.ComboBox PriorityComboBox;
        private System.Windows.Forms.Label PriorityLabel;
        private System.Windows.Forms.PictureBox removeMedicinePictureBox;
        private System.Windows.Forms.PictureBox confirmOrderPictureBox;
        private System.Windows.Forms.PictureBox confirmationsPictureBox;
        private System.Windows.Forms.TabPage confirmations;
        private System.Windows.Forms.Label confirmationsLabel;
        private System.Windows.Forms.DataGridView ConfirmationsDGV;
        private System.Windows.Forms.TextBox H_searchTextBox;
        private System.Windows.Forms.Label H_searchLabel;
        private System.Windows.Forms.PictureBox ConfirmOrderArrivalPictureBox;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox StorageAddPictureBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn packSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn ExpirationDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn availability;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderMedicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispatchedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispatchedAt;
    }
}
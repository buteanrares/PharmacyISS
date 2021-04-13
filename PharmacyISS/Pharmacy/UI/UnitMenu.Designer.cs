
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
            this.label4 = new System.Windows.Forms.Label();
            this.homeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.loggedInInfoLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.unitInfoLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.notificationsInfoLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.stock = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.packSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockState = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.order = new System.Windows.Forms.TabPage();
            this.removeMedicinePictureBox = new System.Windows.Forms.PictureBox();
            this.confirmOrderPictureBox = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.orderMedicine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.confirmations = new System.Windows.Forms.TabPage();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.H_searchTextBox = new System.Windows.Forms.TextBox();
            this.H_searchLabel = new System.Windows.Forms.Label();
            this.historyDGV = new System.Windows.Forms.DataGridView();
            this.orderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispatchedBy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispatchedAt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmationsLabel = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.logoutPictureBox = new System.Windows.Forms.PictureBox();
            this.homePictureBox = new System.Windows.Forms.PictureBox();
            this.storagePictureBox = new System.Windows.Forms.PictureBox();
            this.orderPictureBox = new System.Windows.Forms.PictureBox();
            this.confirmationsPictureBox = new System.Windows.Forms.PictureBox();
            this.tabControl.SuspendLayout();
            this.home.SuspendLayout();
            this.stock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.order.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.removeMedicinePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmOrderPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.confirmations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyDGV)).BeginInit();
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
            this.home.Controls.Add(this.label4);
            this.home.Controls.Add(this.homeLabel);
            this.home.Controls.Add(this.label3);
            this.home.Controls.Add(this.loggedInInfoLabel);
            this.home.Controls.Add(this.label2);
            this.home.Controls.Add(this.unitInfoLabel);
            this.home.Controls.Add(this.label1);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(75, 397);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(642, 19);
            this.label4.TabIndex = 17;
            this.label4.Text = "Order number 82362 has been accepted by the pharmacy and waiting for confirmation" +
    ".";
            // 
            // homeLabel
            // 
            this.homeLabel.AutoSize = true;
            this.homeLabel.Font = new System.Drawing.Font("Fira Sans", 39.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.homeLabel.Location = new System.Drawing.Point(29, 30);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(168, 64);
            this.homeLabel.TabIndex = 9;
            this.homeLabel.Text = "Home";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(75, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(641, 19);
            this.label3.TabIndex = 16;
            this.label3.Text = "Order number 26970 has been accepted by the pharmacy and waiting for confirmation" +
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(75, 341);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(609, 19);
            this.label2.TabIndex = 15;
            this.label2.Text = "Order number 19231 has been refused by the pharmacy. (optional: due to -reason-)";
            // 
            // unitInfoLabel
            // 
            this.unitInfoLabel.AutoSize = true;
            this.unitInfoLabel.Font = new System.Drawing.Font("Fira Mono", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.unitInfoLabel.Location = new System.Drawing.Point(137, 187);
            this.unitInfoLabel.Name = "unitInfoLabel";
            this.unitInfoLabel.Size = new System.Drawing.Size(54, 23);
            this.unitInfoLabel.TabIndex = 11;
            this.unitInfoLabel.Text = "Unit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fira Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(197, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "userWorkingUnit";
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
            this.stock.Controls.Add(this.textBox1);
            this.stock.Controls.Add(this.label6);
            this.stock.Controls.Add(this.dataGridView1);
            this.stock.Controls.Add(this.label5);
            this.stock.Location = new System.Drawing.Point(79, 4);
            this.stock.Name = "stock";
            this.stock.Padding = new System.Windows.Forms.Padding(3);
            this.stock.Size = new System.Drawing.Size(782, 552);
            this.stock.TabIndex = 1;
            this.stock.Text = "Stock";
            this.stock.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 133);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(146, 23);
            this.textBox1.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Fira Sans", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(59, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Search";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.packSize,
            this.stockState});
            this.dataGridView1.Location = new System.Drawing.Point(59, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(462, 302);
            this.dataGridView1.TabIndex = 6;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Fira Sans", 39.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(29, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(455, 64);
            this.label5.TabIndex = 5;
            this.label5.Text = "Pharmacy storage";
            // 
            // order
            // 
            this.order.Controls.Add(this.removeMedicinePictureBox);
            this.order.Controls.Add(this.confirmOrderPictureBox);
            this.order.Controls.Add(this.comboBox1);
            this.order.Controls.Add(this.label9);
            this.order.Controls.Add(this.dataGridView3);
            this.order.Controls.Add(this.textBox2);
            this.order.Controls.Add(this.label8);
            this.order.Controls.Add(this.label7);
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
            this.removeMedicinePictureBox.Location = new System.Drawing.Point(417, 131);
            this.removeMedicinePictureBox.Name = "removeMedicinePictureBox";
            this.removeMedicinePictureBox.Size = new System.Drawing.Size(100, 31);
            this.removeMedicinePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.removeMedicinePictureBox.TabIndex = 14;
            this.removeMedicinePictureBox.TabStop = false;
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
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Fira Sans", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Low",
            "Normal",
            "High"});
            this.comboBox1.Location = new System.Drawing.Point(137, 475);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 22);
            this.comboBox1.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Fira Sans", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(59, 475);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 23);
            this.label9.TabIndex = 11;
            this.label9.Text = "Priority";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderMedicine,
            this.quantity});
            this.dataGridView3.Location = new System.Drawing.Point(59, 168);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowTemplate.Height = 25;
            this.dataGridView3.Size = new System.Drawing.Size(458, 270);
            this.dataGridView3.TabIndex = 10;
            // 
            // orderMedicine
            // 
            this.orderMedicine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.orderMedicine.HeaderText = "Medicine";
            this.orderMedicine.Name = "orderMedicine";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "Quantity";
            this.quantity.Name = "quantity";
            this.quantity.Width = 110;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(132, 133);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(146, 23);
            this.textBox2.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Fira Sans", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(59, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 23);
            this.label8.TabIndex = 8;
            this.label8.Text = "Search";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Fira Sans", 39.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(29, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 64);
            this.label7.TabIndex = 6;
            this.label7.Text = "Order";
            // 
            // confirmations
            // 
            this.confirmations.Controls.Add(this.pictureBox3);
            this.confirmations.Controls.Add(this.pictureBox2);
            this.confirmations.Controls.Add(this.H_searchTextBox);
            this.confirmations.Controls.Add(this.H_searchLabel);
            this.confirmations.Controls.Add(this.historyDGV);
            this.confirmations.Controls.Add(this.confirmationsLabel);
            this.confirmations.Location = new System.Drawing.Point(79, 4);
            this.confirmations.Name = "confirmations";
            this.confirmations.Size = new System.Drawing.Size(656, 552);
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
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Pharmacy.Properties.Resources.CONFIRM;
            this.pictureBox2.Location = new System.Drawing.Point(664, 490);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 32);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // H_searchTextBox
            // 
            this.H_searchTextBox.Location = new System.Drawing.Point(132, 133);
            this.H_searchTextBox.Name = "H_searchTextBox";
            this.H_searchTextBox.Size = new System.Drawing.Size(146, 23);
            this.H_searchTextBox.TabIndex = 10;
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
            // historyDGV
            // 
            this.historyDGV.AllowUserToAddRows = false;
            this.historyDGV.AllowUserToDeleteRows = false;
            this.historyDGV.BackgroundColor = System.Drawing.SystemColors.Window;
            this.historyDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.orderNumber,
            this.dispatchedBy,
            this.dispatchedAt});
            this.historyDGV.Location = new System.Drawing.Point(59, 168);
            this.historyDGV.Name = "historyDGV";
            this.historyDGV.ReadOnly = true;
            this.historyDGV.RowTemplate.Height = 25;
            this.historyDGV.Size = new System.Drawing.Size(411, 302);
            this.historyDGV.TabIndex = 8;
            // 
            // orderNumber
            // 
            this.orderNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.orderNumber.HeaderText = "Number";
            this.orderNumber.Name = "orderNumber";
            this.orderNumber.ReadOnly = true;
            this.orderNumber.Width = 70;
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
            this.confirmationsPictureBox.Click += new System.EventHandler(this.ConfirmOrdersictureBox_Click);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.order.ResumeLayout(false);
            this.order.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.removeMedicinePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.confirmOrderPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.confirmations.ResumeLayout(false);
            this.confirmations.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyDGV)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label homeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label loggedInInfoLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label unitInfoLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label notificationsInfoLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn packSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn stockState;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderMedicine;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.PictureBox removeMedicinePictureBox;
        private System.Windows.Forms.PictureBox confirmOrderPictureBox;
        private System.Windows.Forms.PictureBox confirmationsPictureBox;
        private System.Windows.Forms.TabPage confirmations;
        private System.Windows.Forms.Label confirmationsLabel;
        private System.Windows.Forms.DataGridView historyDGV;
        private System.Windows.Forms.TextBox H_searchTextBox;
        private System.Windows.Forms.Label H_searchLabel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispatchedBy;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispatchedAt;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}
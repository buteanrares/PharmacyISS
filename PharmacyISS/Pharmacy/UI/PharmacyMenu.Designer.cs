
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
            this.stock = new System.Windows.Forms.TabPage();
            this.order = new System.Windows.Forms.TabPage();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.logoutPictureBox = new System.Windows.Forms.PictureBox();
            this.homePictureBox = new System.Windows.Forms.PictureBox();
            this.storagePictureBox = new System.Windows.Forms.PictureBox();
            this.orderPictureBox = new System.Windows.Forms.PictureBox();
            this.homeLabel = new System.Windows.Forms.Label();
            this.loggedInInfoLabel = new System.Windows.Forms.Label();
            this.unitInfoLabel = new System.Windows.Forms.Label();
            this.notificationsInfoLabel = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoutPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.storagePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl.Controls.Add(this.home);
            this.tabControl.Controls.Add(this.stock);
            this.tabControl.Controls.Add(this.order);
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
            // 
            // home
            // 
            this.home.Controls.Add(this.notificationsInfoLabel);
            this.home.Controls.Add(this.unitInfoLabel);
            this.home.Controls.Add(this.loggedInInfoLabel);
            this.home.Controls.Add(this.homeLabel);
            this.home.Location = new System.Drawing.Point(79, 4);
            this.home.Name = "home";
            this.home.Padding = new System.Windows.Forms.Padding(3);
            this.home.Size = new System.Drawing.Size(782, 552);
            this.home.TabIndex = 3;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            // 
            // stock
            // 
            this.stock.Location = new System.Drawing.Point(79, 4);
            this.stock.Name = "stock";
            this.stock.Padding = new System.Windows.Forms.Padding(3);
            this.stock.Size = new System.Drawing.Size(782, 552);
            this.stock.TabIndex = 1;
            this.stock.Text = "Stock";
            this.stock.UseVisualStyleBackColor = true;
            // 
            // order
            // 
            this.order.Location = new System.Drawing.Point(79, 4);
            this.order.Name = "order";
            this.order.Padding = new System.Windows.Forms.Padding(3);
            this.order.Size = new System.Drawing.Size(782, 552);
            this.order.TabIndex = 2;
            this.order.Text = "Order";
            this.order.UseVisualStyleBackColor = true;
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
            this.orderPictureBox.Image = global::Pharmacy.Properties.Resources.pharmOrder;
            this.orderPictureBox.Location = new System.Drawing.Point(12, 163);
            this.orderPictureBox.Name = "orderPictureBox";
            this.orderPictureBox.Size = new System.Drawing.Size(54, 54);
            this.orderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.orderPictureBox.TabIndex = 4;
            this.orderPictureBox.TabStop = false;
            this.orderPictureBox.Click += new System.EventHandler(this.orderPictureBox_Click);
            // 
            // homeLabel
            // 
            this.homeLabel.AutoSize = true;
            this.homeLabel.Font = new System.Drawing.Font("Fira Sans", 39.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.homeLabel.Location = new System.Drawing.Point(44, 30);
            this.homeLabel.Name = "homeLabel";
            this.homeLabel.Size = new System.Drawing.Size(168, 64);
            this.homeLabel.TabIndex = 0;
            this.homeLabel.Text = "Home";
            // 
            // loggedInInfoLabel
            // 
            this.loggedInInfoLabel.AutoSize = true;
            this.loggedInInfoLabel.Font = new System.Drawing.Font("Fira Sans", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.loggedInInfoLabel.Location = new System.Drawing.Point(96, 158);
            this.loggedInInfoLabel.Name = "loggedInInfoLabel";
            this.loggedInInfoLabel.Size = new System.Drawing.Size(116, 23);
            this.loggedInInfoLabel.TabIndex = 1;
            this.loggedInInfoLabel.Text = "Logged in as";
            // 
            // unitInfoLabel
            // 
            this.unitInfoLabel.AutoSize = true;
            this.unitInfoLabel.Font = new System.Drawing.Font("Fira Mono", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.unitInfoLabel.Location = new System.Drawing.Point(158, 195);
            this.unitInfoLabel.Name = "unitInfoLabel";
            this.unitInfoLabel.Size = new System.Drawing.Size(54, 23);
            this.unitInfoLabel.TabIndex = 2;
            this.unitInfoLabel.Text = "Unit";
            // 
            // notificationsInfoLabel
            // 
            this.notificationsInfoLabel.AutoSize = true;
            this.notificationsInfoLabel.Font = new System.Drawing.Font("Fira Sans", 17.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.notificationsInfoLabel.Location = new System.Drawing.Point(44, 293);
            this.notificationsInfoLabel.Name = "notificationsInfoLabel";
            this.notificationsInfoLabel.Size = new System.Drawing.Size(149, 28);
            this.notificationsInfoLabel.TabIndex = 3;
            this.notificationsInfoLabel.Text = "Notifications:";
            // 
            // PharmacyMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(864, 560);
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
            ((System.ComponentModel.ISupportInitialize)(this.logoutPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.storagePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderPictureBox)).EndInit();
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
    }
}
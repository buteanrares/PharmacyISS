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
        public UnitMenu()
        {
            InitializeComponent();
            tabControl.DrawItem += new DrawItemEventHandler(tabControl_DrawItem);
            this.logoutPictureBox.BackColor = Color.FromArgb(240, 240, 240);
            this.homePictureBox.BackColor = Color.LightGray;
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
                    this.confirmationsPictureBox.BackColor = Color.LightGray;
                    break;

                case 1:
                    this.homePictureBox.BackColor = Color.White;
                    this.storagePictureBox.BackColor = Color.LightGray;
                    this.orderPictureBox.BackColor = Color.White;
                    this.confirmationsPictureBox.BackColor = Color.LightGray;
                    break;

                case 2:
                    this.homePictureBox.BackColor = Color.White;
                    this.storagePictureBox.BackColor = Color.White;
                    this.orderPictureBox.BackColor = Color.LightGray;
                    this.confirmationsPictureBox.BackColor = Color.LightGray;
                    break;

                case 3:
                    this.homePictureBox.BackColor = Color.White;
                    this.storagePictureBox.BackColor = Color.White;
                    this.orderPictureBox.BackColor = Color.White;
                    this.confirmationsPictureBox.BackColor = Color.White;
                    break;

                default:
                    break;
            }
        }

        private void homePictureBox_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectedTab = tabControl.TabPages[0];
            this.homePictureBox.BackColor = Color.LightGray;
            this.storagePictureBox.BackColor = Color.White;
            this.orderPictureBox.BackColor = Color.White;
            this.confirmationsPictureBox.BackColor = Color.White;
        }

        private void storagePictureBox_Click(object sender, EventArgs e)
        {
            this.tabControl.SelectedTab = tabControl.TabPages[1];
            this.homePictureBox.BackColor = Color.White;
            this.storagePictureBox.BackColor = Color.LightGray;
            this.orderPictureBox.BackColor = Color.White;
            this.confirmationsPictureBox.BackColor = Color.White;
        }

        private void orderPictureBox_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabControl.TabPages[2];
            this.homePictureBox.BackColor = Color.White;
            this.storagePictureBox.BackColor = Color.White;
            this.orderPictureBox.BackColor = Color.LightGray;
            this.confirmationsPictureBox.BackColor = Color.White;
        }


        private void logoutPictureBox_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmOrdersictureBox_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = tabControl.TabPages[3];
            this.homePictureBox.BackColor = Color.White;
            this.storagePictureBox.BackColor = Color.White;
            this.orderPictureBox.BackColor = Color.White;
            this.confirmationsPictureBox.BackColor = Color.LightGray;
        }
    }
}

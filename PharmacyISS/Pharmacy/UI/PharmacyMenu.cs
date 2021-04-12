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
        public PharmacyMenu()
        {
            InitializeComponent();
            tabControl.DrawItem += new DrawItemEventHandler(tabControl1_DrawItem);
        }

        private void tabControl1_DrawItem(Object sender, System.Windows.Forms.DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush;

            // Get the item from the collection.
            TabPage _tabPage = tabControl.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = tabControl.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {
                // Draw a different background color, and don't paint a focus rectangle.
                g.FillRectangle(Brushes.LightGray, e.Bounds);
            }
            else
            {
                _textBrush = new System.Drawing.SolidBrush(e.ForeColor);
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
    }
}

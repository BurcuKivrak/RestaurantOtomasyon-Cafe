using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantOtomasyonCafe
{
    public partial class CiroUserControl : UserControl
    {
        public CiroUserControl()
        {
            InitializeComponent();
        }
        public void YenidenBoyutlandir()
        {
            int Width = flowLayoutPanel1.Width;
            gunlukCiroPanel.Size = new Size(Width - 25, gunlukCiroPanel.Height);
            toplamCiroPanel.Size = new Size(Width - 25, toplamCiroPanel.Height);
            toplamSiparisSayisiPanel.Size = new Size(Width - 25, toplamSiparisSayisiPanel.Height);
            toplamMasaSayisiPanel.Size = new Size(Width / 2 - 15, toplamMasaSayisiPanel.Height);
            doluMasaSayisiPanel.Size = new Size(Width / 2 - 15, doluMasaSayisiPanel.Height);
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

    }
}

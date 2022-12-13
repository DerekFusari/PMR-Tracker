using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMR_Tracker
{
    public partial class frmTracker : Form
    {
        public frmTracker()
        {
            InitializeComponent();
        }

        private void picEldstar_Click(object sender, EventArgs e)
        {
            PictureBox picEldstar = sender as PictureBox;

            if(picEldstar != null)
            {
                picEldstar.Image = Image.FromFile("C:\\Users\\derek\\source\\repos\\PMR Tracker\\Resources\\Eldstar.png");
            }
        }

        private void picEldstar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            PictureBox picEldstar = sender as PictureBox;

            if (picEldstar != null)
            {
                picEldstar.Image = Image.FromFile("C:\\Users\\derek\\source\\repos\\PMR Tracker\\Resources\\EldstarGray.png");
            }
        }
    }
}

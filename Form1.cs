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
            //If Eldstar picture is clicked, change the image to the colour version to indicate it was collected
            if(picEldstar != null)
            {
                picEldstar.Image = Image.FromFile("C:\\Users\\derek\\source\\repos\\PMR Tracker\\Resources\\Eldstar.png");
            }
        }

        private void picEldstar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //If Eldstar picture is double clicked, change the image back to the gray version

            if (picEldstar != null)
            {
                picEldstar.Image = Image.FromFile("C:\\Users\\derek\\source\\repos\\PMR Tracker\\Resources\\EldstarGray.png");
            }
        }

        private void picFortressKey_Click(object sender, EventArgs e)
        {

            this.Controls.Add(lblFortressKeyCount);

            if(picFortressKey != null )
            {
                picFortressKey.Image = Image.FromFile("C:\\Users\\derek\\source\\repos\\PMR Tracker\\Resources\\FortressKey.png");
            }

            if(lblFortressKeyCount.Text == "4/4")
            {

            }
            else if(lblFortressKeyCount.Text == "3/4")
            {
                lblFortressKeyCount.Text = ("4/4");
            }
            else if (lblFortressKeyCount.Text == "2/4")
            {
                lblFortressKeyCount.Text = ("3/4");
            }
            else if (lblFortressKeyCount.Text == "1/4")
            {
                lblFortressKeyCount.Text = ("2/4");
            }
            else if (lblFortressKeyCount.Text == "0/4")
            {
                lblFortressKeyCount.Text = ("1/4");
            }

        }

        private void picFortressKey_DoubleClick(object sender, EventArgs e)
        {
            this.Controls.Add(lblFortressKeyCount);

            if (picFortressKey != null)
            {
                picFortressKey.Image = Image.FromFile("C:\\Users\\derek\\source\\repos\\PMR Tracker\\Resources\\FortressKeyGray.png");
            }

            lblFortressKeyCount.Text = ("0/4");

        }
    }
}

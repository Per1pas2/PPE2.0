using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PPE_2
{
    public partial class FRM_STARTED : Form
    {
        public FRM_STARTED()
        {
            InitializeComponent();
        }

        private void BTN_PERSONNEL_Click(object sender, EventArgs e)
        {
            FRM_LOGIN frm_login = new FRM_LOGIN();
            frm_login.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            FRM_STARTED frm_Started = new FRM_STARTED();
            frm_Started.MinimizeBox = true;
            WindowState = FormWindowState.Minimized;
        }

        private void FRM_STARTED_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}

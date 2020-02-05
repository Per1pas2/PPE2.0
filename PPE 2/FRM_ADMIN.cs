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
    public partial class FRM_ADMIN : Form
    {
        public FRM_ADMIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FRM_SECRETAIRE frm_SECRETAIRE = new FRM_SECRETAIRE();
            frm_SECRETAIRE.ShowDialog();
        }

        private void BTN_CHEF_Click(object sender, EventArgs e)
        {
            FRM_ANNIMATEUR frm_annimateur = new FRM_ANNIMATEUR();
            frm_annimateur.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            FRM_TECHNICIEN frm_technicien = new FRM_TECHNICIEN();
            frm_technicien.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

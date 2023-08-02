using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using yehuditGames.BLL;

namespace yehuditGames.GUI
{
    public partial class FrmStart : Form
    {
        public FrmStart()
        {
            InitializeComponent();
            groupBox1.Enabled = false;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            MishtamshimTable mt = new MishtamshimTable();
            DataRow dr= mt.Find(txtId.Text);
            if (dr["pass"].ToString()==txtPass.Text)
            {
                bool level = Convert.ToBoolean(dr["mylevel"]); // 1/0
                FrmMain FrmMain = new FrmMain(true);
                FrmMain.Show();
            }                                                                                                                                       
        }
        private void FrmStart_Load(object sender, EventArgs e)
        {

        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLakoach_Click(object sender, EventArgs e)
        {
            FrmMain FrmMain = new FrmMain(false);
            FrmMain.Show();
        }

        private void btnMocher_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
        }
    }
}

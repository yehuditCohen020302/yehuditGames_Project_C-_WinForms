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
    public partial class frmHazagatChavatDaatOnUser : Form
    {
        public frmHazagatChavatDaatOnUser()
        {
            InitializeComponent();
           dgvChavotDaat.DataSource = new ChavotDaatTable().GetTable();
        
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            ChavotDaatTable chavotDaat = new ChavotDaatTable();
            dgvChavotDaat.DataSource = new ChavotDaatTable().GetTableByIdFor(txtIdUser.Text);
      }
        public void LoadDgvChavotDaat()
        {
        }

        private void frmHazagatChavatDaatOnUser_Load(object sender, EventArgs e)
        {
            dgvChavotDaat.Columns[0].Width = 75;
            dgvChavotDaat.Columns[1].Width = 75;
            dgvChavotDaat.Columns[2].Width = 75;
            dgvChavotDaat.Columns[3].Width = 320;
            dgvChavotDaat.Columns[4].Width = 130;
            dgvChavotDaat.Columns[0].HeaderText ="קוד חוות דעת";
            dgvChavotDaat.Columns[1].HeaderText = "קוד פריט";
            dgvChavotDaat.Columns[2].HeaderText = "שביעות רצון";
            dgvChavotDaat.Columns[3].HeaderText = "תיאור חוות דעת";
            dgvChavotDaat.Columns[4].HeaderText = "ת.ז משתמש";
        }

        private void dgvChavotDaat_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            dgvChavotDaat.DataSource = new ChavotDaatTable().GetTable();
            txtIdUser.Text = null;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

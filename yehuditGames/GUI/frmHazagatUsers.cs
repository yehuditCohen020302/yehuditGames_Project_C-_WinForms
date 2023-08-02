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
    public partial class frmHazagatUsers : Form
    {
        public frmHazagatUsers()
        {
            InitializeComponent();
            MishtamshimTable mishtamshim = new MishtamshimTable();
            dgvHazagatUsers.DataSource = new MishtamshimTable().GetTable();
        }
        
        public void LoadDgvHazagatUsers()
        {
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmHazagatUsers_Load(object sender, EventArgs e)
        {
            dgvHazagatUsers.Columns[0].Width = 80;
            dgvHazagatUsers.Columns[1].Width = 60;
            dgvHazagatUsers.Columns[2].Width = 60;
            dgvHazagatUsers.Columns[3].Width = 100;
            dgvHazagatUsers.Columns[4].Width = 70;
            dgvHazagatUsers.Columns[5].Width = 70;
            dgvHazagatUsers.Columns[6].Width = 35;
            dgvHazagatUsers.Columns[7].Width = 80;
            dgvHazagatUsers.Columns[8].Width =35;
            dgvHazagatUsers.Columns[9].Width = 40;
            dgvHazagatUsers.Columns[10].Width = 35;
            dgvHazagatUsers.Columns[0].HeaderText = "ת.ז משתמש";
            dgvHazagatUsers.Columns[1].HeaderText = "שם פרטי";
            dgvHazagatUsers.Columns[2].HeaderText = "שם משפחה";
            dgvHazagatUsers.Columns[3].HeaderText = "תאריך לידה";
            dgvHazagatUsers.Columns[4].HeaderText = "עיר";
            dgvHazagatUsers.Columns[5].HeaderText = "רחוב";
            dgvHazagatUsers.Columns[6].HeaderText = "מס' בית";
            dgvHazagatUsers.Columns[7].HeaderText = "מס' נייד";
            dgvHazagatUsers.Columns[8].HeaderText = "סטטוס";
            dgvHazagatUsers.Columns[9].HeaderText = "סיסמת משתמש";
            dgvHazagatUsers.Columns[10].HeaderText = "דרגה";
        }

        private void btnFindId_Click(object sender, EventArgs e)
        {

            MishtamshimTable mishtamshim = new MishtamshimTable();
            dgvHazagatUsers.DataSource = new MishtamshimTable().GetTableById(txtIdUser.Text);
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void txtIdUser_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < '0' || e.KeyChar > '9') && (e.KeyChar != '\b'))
                e.Handled = true;
        }

        private void btnFindName_Click(object sender, EventArgs e)
        {
            MishtamshimTable mishtamshim = new MishtamshimTable();
            dgvHazagatUsers.DataSource = new MishtamshimTable().GetTableByName(txtName.Text);
        }

        private void btnFindCity_Click(object sender, EventArgs e)
        {
            MishtamshimTable mishtamshim = new MishtamshimTable();
            dgvHazagatUsers.DataSource = new MishtamshimTable().GetTableByCity(txtCity.Text);
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'א' || e.KeyChar > 'ת') && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
        }

        private void txtCity_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'א' || e.KeyChar > 'ת') && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvHazagatUsers.DataSource = new MishtamshimTable().GetTable();
            txtCity.Text = null;
            txtIdUser.Text = null;
            txtName.Text = null;
        }
    }
}

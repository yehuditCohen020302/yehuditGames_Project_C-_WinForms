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
    public partial class frmHachagatGames : Form
    {
        public frmHachagatGames(int nmudMinPrice, int nmudMaxPrice, int nameChevra, int nmudMegil, int nmudAdgil, int nmudMin, int nmudMax)
        {
            InitializeComponent();
            PritimTable pritim = new PritimTable();
            dgvGames.DataSource = new PritimTable().GetResultFromSearch(nmudMinPrice, nmudMaxPrice, nameChevra, nmudMegil, nmudAdgil, nmudMin, nmudMax);
        }
        public frmHachagatGames(int nmudMinPrice, int nmudMaxPrice, int nmudMegil, int nmudAdgil, int nmudMin, int nmudMax)
        {
            InitializeComponent();
            PritimTable pritim = new PritimTable();
            dgvGames.DataSource = new PritimTable().GetResultFromSearch(nmudMinPrice, nmudMaxPrice, nmudMegil, nmudAdgil, nmudMin, nmudMax);
        }

        private void dgvGames_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmHachagatGames_Load(object sender, EventArgs e)
        {
            dgvGames.Columns[0].Width = 52;
            dgvGames.Columns[2].Width = 52;
            dgvGames.Columns[3].Width = 55;
            dgvGames.Columns[4].Width = 65;
            dgvGames.Columns[5].Width = 65;
            dgvGames.Columns[6].Width = 65;
            dgvGames.Columns[7].Width = 52;
            dgvGames.Columns[0].HeaderText = "קוד פריט";
            dgvGames.Columns[1].HeaderText = "שם פריט";
            dgvGames.Columns[2].HeaderText = "מחיר";
            dgvGames.Columns[3].HeaderText = "מתאים מגיל";
            dgvGames.Columns[4].HeaderText = "מתאים עד גיל";
            dgvGames.Columns[5].HeaderText = "מינימום משתתפים";
            dgvGames.Columns[6].HeaderText = "מקסימום משתתפים";
            dgvGames.Columns[7].HeaderText = "סטטוס";
        }

    }
}

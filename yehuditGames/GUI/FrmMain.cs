using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yehuditGames.GUI
{
    public partial class FrmMain : Form
    {
        public FrmMain(bool myleve)
        {
            InitializeComponent();
            if (myleve == false) // לקוח
            {
                לקוחותToolStripMenuItem.Enabled = false;
                חברותToolStripMenuItem.Enabled = false;
                הוספהToolStripMenuItem1.Enabled = false;
                עידכוןToolStripMenuItem.Enabled = false;
                מחיקהToolStripMenuItem1.Enabled = false;
                מחיקהToolStripMenuItem2.Enabled = false;
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
        }

        private void הוספהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUser f = new FrmUser(StatusKind.add);
            f.Show();
        }

        private void לקוחותToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void עדכוןToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUser f = new FrmUser(StatusKind.update);
            f.Show();
        }

        private void מחיקהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUser f = new FrmUser(StatusKind.delete);
            f.Show();
        }

        private void להוספתמוכרToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void משחקיםToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void מחיקהToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmGames f = new frmGames(StatusKind.delete);
            f.Show();
        }

        private void הוספהToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmGames f = new frmGames(StatusKind.add);
            f.Show();
        }

        private void עידכוןToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGames f = new frmGames(StatusKind.update);
            f.Show();
        }

        private void הוספהToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmChavotDaat f = new frmChavotDaat(StatusKind.add);
            f.Show();
        }

        private void מחיקהToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmChavotDaat f = new frmChavotDaat(StatusKind.delete);
            f.Show();
        }

        private void חברותToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void הוספהToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmChevrot f = new frmChevrot(StatusKind.add);
            f.Show();
        }

        private void מחיקהToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmChevrot f = new frmChevrot(StatusKind.delete);
            f.Show();
        }

        private void הצגהToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmGamesForLakoch f = new frmGamesForLakoch();
            f.Show();
        }

        private void הצגהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHazagatUsers f = new frmHazagatUsers();
            f.Show();
        }

        private void הצגתחוותדעתשלמשתמשToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHazagatChavatDaatOnUser f = new frmHazagatChavatDaatOnUser();
            f.Show();
        }
    }
}

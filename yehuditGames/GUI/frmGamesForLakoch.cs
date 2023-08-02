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
    public partial class frmGamesForLakoch : Form
    {
        private Pritim myParit;
        private PritimTable allMyTable;
        public frmGamesForLakoch()
        {
            InitializeComponent();
            cmbNameChevra.DataSource = new ChevrotTable().Dt;
            cmbNameChevra.DisplayMember = "nameChevra";
            cmbNameChevra.ValueMember = "kodChevra";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmGamesForLakoch_Load(object sender, EventArgs e)
        {
            cmbNameChevra.Text = "-בחר חברה-";

        }
        public void FillFields()
        {
            nmudMinPrice.Text = Convert.ToString(this.myParit.Price);
            nmudMaxPrice.Text = Convert.ToString(this.myParit.Price);
            cmbNameChevra.Text = Convert.ToString(this.myParit.NameChevra);
            nmudMegil.Text = Convert.ToString(this.myParit.MatimMegil);
            nmudAdgil.Text = Convert.ToString(this.myParit.MatimAdGil);
            nmudMin.Text = Convert.ToString(this.myParit.MinMistatfim);
            nmudMax.Text = Convert.ToString(this.myParit.MaxMistatfim);
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            bool degel = true;
            if (nmudMegil.Value > nmudAdgil.Value)
            {
                MessageBox.Show("אי אפשר להכניס ערך עד גיל, שקטן מהערך מגיל");
                degel = false;
            }
            if (nmudMinPrice.Value > nmudMaxPrice.Value)
            {
                MessageBox.Show("אי אפשר להכניס ערך עד מחיר, שקטן מהערך ממחיר");
                degel = false;
            }
            if (nmudMin.Value > nmudMax.Value)
            {
                MessageBox.Show("אי אפשר להכניס ערך מקסימום מספר משתתפים , שקטן מהערך מינימום מספר משתתפים");
                degel = false;
            }
            if (degel == true)
            {
                frmHachagatGames f;
                if (cmbNameChevra.SelectedIndex != 0)
                {
                    f = new frmHachagatGames(Convert.ToInt32(nmudMinPrice.Value), Convert.ToInt32(nmudMaxPrice.Value), Convert.ToInt32(cmbNameChevra.SelectedValue), Convert.ToInt32(nmudMegil.Value), Convert.ToInt32(nmudAdgil.Value), Convert.ToInt32(nmudMin.Value), Convert.ToInt32(nmudMax.Value));
                    f.Show();
                }
                 if (cmbNameChevra.SelectedIndex == 0)
                {
                    f = new frmHachagatGames(Convert.ToInt32(nmudMinPrice.Value), Convert.ToInt32(nmudMaxPrice.Value), Convert.ToInt32(nmudMegil.Value), Convert.ToInt32(nmudAdgil.Value), Convert.ToInt32(nmudMin.Value), Convert.ToInt32(nmudMax.Value));
                   f.Show();
                }
                
            }
        }

        private void cmbNameChevra_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string nameChevra = Convert.ToString(cmbNameChevra.SelectedValue);
            /*
            allMyTable = new PritimTable();
            DataRow dr = allMyTable.Find(nameChevra);
            this.myParit = new Pritim(dr);
            FillFields();
            */
        }
        private void cmbNameChevra_SelectedValueChanged(object sender, EventArgs e)
        {

        }
        private void cmbNameChevra_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class frmChevrot : Form
    {
        private StatusKind MyStaus;
        private Chevrot myChevra;
        private ChevrotTable allMyChevrot = new ChevrotTable();
        public void MathcToStatus()
        {
            if (this.MyStaus == StatusKind.add)
            {
                txtKodChevra.Text = Convert.ToString(allMyChevrot.GetNextKod().ToString());
                btnDelete.Visible = true;
                cmbKodChevra.Visible = false;
            }
            if (this.MyStaus == StatusKind.delete)
            {
                btnAdd.Visible = false;
                cmbKodChevra.DataSource = new ChevrotTable().GetTable();
                cmbKodChevra.DisplayMember = "nameChevra";
                cmbKodChevra.ValueMember = "kodChevra";
                
            }
        }
        public frmChevrot(StatusKind MyStaus)
        {
            InitializeComponent();
            this.MyStaus = MyStaus;
            MathcToStatus();
        }
        private void frmChevrot_Load(object sender, EventArgs e)
        {
            /// :) התאמה של המסך לסטטוסים
            if (this.MyStaus == StatusKind.add)
            {
                txtKodChevra.Text = new ChevrotTable().GetNextKod().ToString();
                txtKodChevra.Enabled = false;
                btnDelete.Visible = false;
            }
            if (this.MyStaus == StatusKind.delete)
            {
                txtKodChevra.Enabled = false;
                btnAdd.Visible = false;
                groupBox1.Enabled = false;
                cmbKodChevra.Text = "-בחר חברה-";
            }
        }
        public Boolean BuildObjectByFields()
        {
            errorProvider1.Clear();

            this.myChevra = new Chevrot();
            bool ok = true;
            try
            {
                this.myChevra.KodChevra = Convert.ToInt32(txtKodChevra.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtKodChevra, ex.Message);
                ok = false;
            }
            try
            {
                this.myChevra.NameChevra = txtNameOfChevra.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtNameOfChevra, ex.Message);
                ok = false;
            }
            return ok;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.BuildObjectByFields() == true)
            {
                DataRow dr = this.myChevra.ToDataRow();

                if (this.MyStaus == StatusKind.add)
                {
                    this.allMyChevrot = new ChevrotTable();
                    if (this.allMyChevrot.Add(dr) == true)
                        MessageBox.Show("החברה התווספה בהצלחה");
                    else
                        MessageBox.Show("החברה קיימת במאגר");
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.BuildObjectByFields() == true)
            {
                DataRow dr = this.myChevra.ToDataRow();

                if (this.MyStaus == StatusKind.delete)
                {
                    //this.allMyChevrot = new ChevrotTable();
                    if (this.allMyChevrot.Delete(dr) == true)
                        MessageBox.Show("החברה נמחקה בהצלחה");

                }

            }
        }
        private void cmbKodChevra_SelectionChangeCommitted(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            string codeParit = Convert.ToString(cmbKodChevra.SelectedValue);
            allMyChevrot = new ChevrotTable();
            DataRow dr = allMyChevrot.Find(codeParit);
            this.myChevra = new Chevrot(dr);
            FillFields();
        }
        public void FillFields()
        {
            txtKodChevra.Text = Convert.ToString(this.myChevra.KodChevra);
            txtNameOfChevra.Text = Convert.ToString(this.myChevra.NameChevra);
        }

        private void txtNameOfChevra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'א' || e.KeyChar > 'ת') && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
        }
    }
}
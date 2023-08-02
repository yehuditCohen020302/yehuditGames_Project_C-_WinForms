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
    public partial class frmChavotDaat : Form
    {
        private StatusKind MyStaus;
        private ChavotDaat myChavotDaat;
        private ChavotDaatTable allMyTable = new ChavotDaatTable();

        public frmChavotDaat(StatusKind MyStaus)
        {
            InitializeComponent();
            this.MyStaus = MyStaus;
            MathcToStatus();
        }
        private void frmChavotDaat_Load(object sender, EventArgs e)
        {
            
            /// :) התאמה של המסך לסטטוסים
            if (this.MyStaus == StatusKind.add)
            {
                txtKodChavatDaat.Text = new ChavotDaatTable().GetNextKod().ToString();
                txtKodChavatDaat.Text = Convert.ToString(allMyTable.GetNextKod());
                txtKodChavatDaat.Enabled = false;
                btnDelete.Visible = false;
            }
            if (this.MyStaus == StatusKind.delete)
            {
                txtKodChavatDaat.Enabled = false;
                btnAdd.Visible = false;
                btnAdd.Enabled = true;
                txtKodChavatDaat.Visible = false;
                cmbKodChavatDaat.Text = "-בחר חוות דעת-";
            }
            cmbKodParit.DataSource = new PritimTable().GetTable();
            cmbKodParit.DisplayMember = "nameParit";
            cmbKodParit.ValueMember = "KodParit";
            cmbKodParit.Text = "-בחר מוצר-";

           
        }
        public void MathcToStatus()
        {
            if (this.MyStaus == StatusKind.add)
            {
                btnDelete.Visible = true;
                cmbKodChavatDaat.Visible = false;
            }
            if (this.MyStaus == StatusKind.delete)
            {
                btnAdd.Visible = true;
                cmbKodChavatDaat.DataSource = new ChavotDaatTable().GetTable();
                cmbKodChavatDaat.DisplayMember = "kodChavatDaat";
                cmbKodChavatDaat.ValueMember = "kodChavatDaat";
                groupBox1.Enabled = false;
            }
            if (this.MyStaus == StatusKind.update)
            {
                btnAdd.Visible = true;
                cmbKodChavatDaat.DataSource = new ChavotDaatTable().GetTable();
                cmbKodChavatDaat.DisplayMember = "kodChavatDaat";
                cmbKodChavatDaat.ValueMember = "kodChavatDaat";
                groupBox1.Enabled = false;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.BuildObjectByFields() == true)
            {
                DataRow dr = this.myChavotDaat.ToDataRow();

                if (this.MyStaus == StatusKind.add)
                {
                    this.allMyTable = new ChavotDaatTable();
                    if (this.allMyTable.Add(dr) == true)
                        MessageBox.Show("חוות הדעת התווספה בהצלחה");
                    else
                        MessageBox.Show("חוות הדעת קיימת במאגר");
                }
            }
        }
        public Boolean BuildObjectByFields()
        {
            errorProvider1.Clear();

            this.allMyTable = new ChavotDaatTable();
            this.myChavotDaat = new ChavotDaat();
            bool ok = true;
            try
            {
                this.myChavotDaat.KodChavatDaat = Convert.ToInt32(txtKodChavatDaat.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtKodChavatDaat, ex.Message);
                ok = false;
            }
            try
            {
                this.myChavotDaat.KodParit = Convert.ToInt32(cmbKodParit.SelectedValue);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cmbKodParit, ex.Message);
                ok = false;
            }
            try
            {
                this.myChavotDaat.SviutRatzon = Convert.ToInt32(nmbrSviutRazon.Value);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(nmbrSviutRazon, ex.Message);
                ok = false;
            }
            try
            {
                this.myChavotDaat.Description = txtDescribe.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtDescribe, ex.Message);
                ok = false;
            }
            try
            {
                this.myChavotDaat.IdMishtamesh = txtIdMishtamesh.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtIdMishtamesh, ex.Message);
                ok = false;
            }
            return ok;
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.BuildObjectByFields() == true)
            {
                DataRow dr = this.myChavotDaat.ToDataRow();

                if (this.MyStaus == StatusKind.delete)
                {
                    this.allMyTable = new ChavotDaatTable();
                    if (this.allMyTable.Delete(dr) == true)
                        MessageBox.Show("חוות הדעת נמחקה בהצלחה");
                    else
                        MessageBox.Show("חוות הדעת קיימת במאגר");
                }
            }
        }
        //FillFields();
        public void FillFields()
        {
            txtKodChavatDaat.Text = Convert.ToString(this.myChavotDaat.KodChavatDaat);
            cmbKodParit.Text = Convert.ToString(this.myChavotDaat.KodParit);
            txtIdMishtamesh.Text = Convert.ToString(this.myChavotDaat.SviutRatzon);
            txtDescribe.Text = Convert.ToString(this.myChavotDaat.Description);
            txtIdMishtamesh.Text = Convert.ToString(this.myChavotDaat.IdMishtamesh);
        }
        private void cmbKodChavatDaat_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string kodChavatDaat = Convert.ToString(cmbKodChavatDaat.SelectedValue);
            DataRow dr = allMyTable.Find(kodChavatDaat);
            this.myChavotDaat = new ChavotDaat(dr);
            FillFields();
            groupBox1.Enabled = false;
        }
        private void cmbKodChavatDaat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (this.BuildObjectByFields() == true)
            {
                DataRow dr = this.myChavotDaat.ToDataRow();

                if (this.MyStaus == StatusKind.delete)
                {
                    this.allMyTable = new ChavotDaatTable();
                    if (this.allMyTable.Delete(dr) == true)
                        MessageBox.Show("חוות הדעת נמחקה בהצלחה");
                    else
                        MessageBox.Show("חוות הדעת קיימת במאגר");
                }
            }
        }
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (this.BuildObjectByFields() == true)
            {
                DataRow dr = this.myChavotDaat.ToDataRow();

                if (this.MyStaus == StatusKind.add)
                {
                    this.allMyTable = new ChavotDaatTable();
                    if (this.allMyTable.Add(dr) == true)
                        MessageBox.Show("חוות הדעת התווספה בהצלחה");
                    else
                        MessageBox.Show("חוות הדעת קיימת במאגר");
                }
            }
        }
        private void lblKodChavatDaat_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dr = new MishtamshimTable().Find(txtIdMishtamesh.Text);
            if (dr == null)
            {
                DialogResult d = MessageBox.Show("המשתמש לא קיים במאגר, האם ברצונך להוסיף אותו?", "הודעה", MessageBoxButtons.OKCancel);
                if (d == DialogResult.OK)
                {
                    FrmUser f = new FrmUser(StatusKind.add,txtIdMishtamesh.Text);
                    f.Show();
                }
            }
            else
            {
                MessageBox.Show("שלום ל:"+dr["lastName"] + " " + dr["firstName"]);
            }        
        }

        private void nmbrSviutRazon_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmbKodParit_SelectionChangeCommitted(object sender, EventArgs e)
        {
           // int kodParit = Convert.ToInt32(cmbKodParit.SelectedValue);
           // DataRow dr = allMyTable.Find(kodParit);
           // this.myChavotDaat = new ChavotDaat(dr);
            //FillFields();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void cmbKodParit_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtIdMishtamesh_KeyPress(object sender, KeyPressEventArgs e)
        {
           /*
            if ((e.KeyChar < 'א' || e.KeyChar > 'ת') && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
             */
        }

        private void txtIdMishtamesh_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

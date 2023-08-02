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
    public partial class frmGames : Form
    {
        private StatusKind MyStaus;
        private Pritim myParit;
        private PritimTable allMyTable;

        private void frmGames_Load(object sender, EventArgs e)
        {
            /// :) התאמה של המסך לסטטוסים
            if (this.MyStaus == StatusKind.add)
            {
                txtKodParit.Text = new PritimTable().GetNextKod().ToString();
                txtKodParit.Enabled = false;
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
                cmbKodChevra.DataSource = new ChevrotTable().Dt;
                cmbKodChevra.DisplayMember = "nameChevra";
                cmbKodChevra.ValueMember = "kodChevra";
                cmbKodChevra.Text = "-בחר חברה-";
            }
            if (this.MyStaus == StatusKind.delete)
            {
                txtKodParit.Enabled = false;
                btnAdd.Visible = false;
                btnUpdate.Visible = false;
                label1.Enabled = false;
                cmbKodParit.DataSource = new PritimTable().GetTable();
                cmbKodParit.DisplayMember = "nameParit";
                cmbKodParit.ValueMember = "kodParit";
                cmbKodParit.Text = "בחר משחק-";
                txtKodParit.Enabled = false;
            }
            if (this.MyStaus == StatusKind.update)
            {
                txtKodParit.Enabled = false;
                btnDelete.Visible = false;
                btnAdd.Visible = false;
                cmbKodParit.DataSource = new PritimTable().GetTable();
                cmbKodParit.DisplayMember = "nameParit";
                cmbKodParit.ValueMember = "kodParit";
                cmbKodParit.Text = "-בחר משחק-";
            }
        }
        public frmGames(StatusKind MyStaus)
        {
            InitializeComponent();
            this.MyStaus = MyStaus;
            MathcToStatus();
        }
        public void MathcToStatus()
        {
            if (this.MyStaus == StatusKind.add)
            {
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
                cmbKodParit.Visible = false;
                
            }
            if (this.MyStaus == StatusKind.update)
            {
                btnAdd.Visible = true;
                btnDelete.Visible = true;
                groupBox1.Enabled = false;
            }
            if (this.MyStaus == StatusKind.delete)
            {
                btnUpdate.Visible = true;
                btnAdd.Visible = true;
                groupBox1.Enabled = false;
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.allMyTable = new PritimTable();
            this.myParit = new Pritim();
            if (this.BuildObjectByFields() == true)
            {
                DataRow dr = this.myParit.ToDataRow();

                if (this.MyStaus == StatusKind.add)
                {
                    this.allMyTable = new PritimTable();
                    if (this.allMyTable.Add(dr) == true)
                    {
                        MessageBox.Show("המשחק התווסף בהצלחה");
                        this.Close();
                    }
                    else
                        MessageBox.Show("המשחק קיים במאגר");
                    this.Close();
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (this.BuildObjectByFields() == true)
            {

                DataRow dr = this.myParit.ToDataRow();
                if (this.MyStaus == StatusKind.delete)
                {
                    if (this.allMyTable.Delete(dr) == true)
                    {
                        MessageBox.Show("המשחק נמחק בהצלחה");
                        this.Close();
                    }
                    else
                        MessageBox.Show("המשחק קיים במאגר");
                    this.Close();
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (this.BuildObjectByFields() == true)
            {
                DataRow dr = this.myParit.ToDataRow();
                if (this.MyStaus == StatusKind.update)
                {

                    if (this.allMyTable.Update(dr) == true)
                    {
                        MessageBox.Show("המשחק עודכן בהצלחה");
                        this.Close();
                    }
                    else
                        MessageBox.Show("המשחק קיים במאגר");
                    this.Close();
                }
            }
        }
        public Boolean BuildObjectByFields()
        {
            errorProvider1.Clear();

            this.myParit = new Pritim();
            bool ok = true;
            try
            {
                this.myParit.KodParit = Convert.ToInt32(txtKodParit.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtKodParit, ex.Message);
                ok = false;
            }
            try
            {
                this.myParit.NameParit = txtNameParit.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtNameParit, ex.Message);
                ok = false;
            }
            try
            {
                this.myParit.Price = Convert.ToInt32(txtPrice.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtPrice, ex.Message);
                ok = false;
            }
            try
            {
                this.myParit.MinAmount = Convert.ToInt32(txtMinAmount.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtMinAmount, ex.Message);
                ok = false;
            }
            try
            {
                this.myParit.MaxAmount = Convert.ToInt32(txtMaxAmount.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtMaxAmount, ex.Message);
                ok = false;
            }
            try
            {
                this.myParit.NowAmount = Convert.ToInt32(txtNowAmount.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtNowAmount, ex.Message);
                ok = false;
            }
            try
            {
                this.myParit.NameChevra = Convert.ToString(cmbKodChevra.SelectedValue);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(cmbKodChevra, ex.Message);
                ok = false;
            }
            try
            {
                this.myParit.MatimMegil = Convert.ToInt32(txtMatimMegil.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtMatimMegil, ex.Message);
                ok = false;
            }
            try
            {
                this.myParit.MatimAdGil = Convert.ToInt32(txtMatimAdGil.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtMatimAdGil, ex.Message);
                ok = false;
            }
            try
            {
                this.myParit.MinMistatfim = Convert.ToInt32(txtMinMistatfim.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtMinMistatfim, ex.Message);
                ok = false;
            }
            try
            {
                this.myParit.MaxMistatfim = Convert.ToInt32(txtMaxMistatfim.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtMaxMistatfim, ex.Message);
                ok = false;
            }
            try
            {
                this.myParit.KodSugeiGames = Convert.ToInt32(txtKodSugeiGames.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtKodSugeiGames, ex.Message);
                ok = false;
            }

            if (this.MyStaus == StatusKind.add)
                this.myParit.Status = true;
            return ok;
        }

        //FillFields();
        public void FillFields()
        {
            txtKodParit.Text = Convert.ToString(this.myParit.KodParit);
            txtNameParit.Text = Convert.ToString(this.myParit.NameParit);
            txtPrice.Text = Convert.ToString(this.myParit.Price);
            txtMinAmount.Text = Convert.ToString(this.myParit.MinAmount);
            txtMaxAmount.Text = Convert.ToString(this.myParit.MaxAmount);
            txtNowAmount.Text = Convert.ToString(this.myParit.NowAmount);
            cmbKodChevra.Text = Convert.ToString(this.myParit.NameChevra);
            txtMatimMegil.Text = Convert.ToString(this.myParit.MatimMegil);
            txtMatimAdGil.Text = Convert.ToString(this.myParit.MatimAdGil);
            txtMinMistatfim.Text = Convert.ToString(this.myParit.MinMistatfim);
            txtMaxMistatfim.Text = Convert.ToString(this.myParit.MaxMistatfim);
            ckbStatus.Text = Convert.ToString(this.myParit.Status);
            txtKodSugeiGames.Text = Convert.ToString(this.myParit.KodSugeiGames);
        }
        
        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (this.BuildObjectByFields() == true)
            {
                DataRow dr = this.myParit.ToDataRow();

                if (this.MyStaus == StatusKind.add)
                {
                    this.allMyTable = new PritimTable();
                    if (this.allMyTable.Add(dr) == true)
                        MessageBox.Show("המשחק התווסף בהצלחה");
                    else
                        MessageBox.Show("המשחק קיים במאגר");
                }
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (this.BuildObjectByFields() == true)
            {
                DataRow dr = this.myParit.ToDataRow();
                if (this.MyStaus == StatusKind.update)
                {
                    if (this.allMyTable.Update(dr) == true)
                        MessageBox.Show("המשחק עודכן בהצלחה");
                    else
                        MessageBox.Show("המשחק קיים במאגר");
                }
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (this.BuildObjectByFields() == true)
            {

                DataRow dr = this.myParit.ToDataRow();
                if (this.MyStaus == StatusKind.delete)
                {
                    if (this.allMyTable.Delete(dr) == true)
                        MessageBox.Show("המשחק נמחק בהצלחה");
                    else
                        MessageBox.Show("המשחק קיים במאגר");
                }
            }
        }
        
        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void cmbKodParit_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
        }

        private void cmbKodParit_SelectionChangeCommitted(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            FillFields();
        }
        private void cmbKodParit_SelectionChangeCommitted_1(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            string codeParit = Convert.ToString(cmbKodParit.SelectedValue);
            allMyTable = new PritimTable();
            DataRow dr = allMyTable.Find(codeParit);
            this.myParit = new Pritim(dr);
            FillFields();
        }
        private void txtKodParit_TextChanged(object sender, EventArgs e)
        {
        }

        private void cmbKodChevra_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string nameChevra = Convert.ToString(cmbKodChevra.SelectedValue);
            allMyTable = new PritimTable();
            DataRow dr = allMyTable.Find(nameChevra);
            this.myParit = new Pritim(dr);
            FillFields();
        }

        private void cmbKodChevra_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void txtNameParit_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar < 'א' || e.KeyChar > 'ת') && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
        }
    }
    }






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
    public partial class FrmUser : Form
    {
        private StatusKind MyStaus;
        private Mishtamshim myMishtamesh;
        private MishtamshimTable allMyTable;

        public FrmUser(StatusKind MyStaus)
        {
            InitializeComponent();
            this.MyStaus = MyStaus;
            MathcToStatus();
        }
        public FrmUser(StatusKind MyStaus, string id)
        {
            InitializeComponent();
            this.MyStaus = MyStaus;
            MathcToStatus();
            txtId.Text = id;
        }
        public void MathcToStatus()
        {
            allMyTable = new MishtamshimTable();
            if (this.MyStaus == StatusKind.add)
            {
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
                cmbId.Visible = false;
                btnDelete.Visible = false;
                btnUpdate.Visible = false;
            }
            if (this.MyStaus == StatusKind.update)
            {
                txtId.Enabled = true;
                txtId.Visible = false;
                cmbId.DataSource = new MishtamshimTable().GetTableForComboBox("firstName", "lastName");
                cmbId.DisplayMember = "fullName";
                cmbId.ValueMember = "idMishtamesh";

                cmbId.Visible = true;
                groupBox1.Enabled = false;
                txtId.Enabled = false;
                btnAdd.Visible = false;
                btnDelete.Visible = false;
            }
            if (this.MyStaus == StatusKind.delete)
            {
                txtId.Enabled = true;
                txtId.Visible = false;
                cmbId.DataSource = new MishtamshimTable().GetTableForComboBox("firstName", "lastName");
                cmbId.DisplayMember = "fullName";
                cmbId.ValueMember = "idMishtamesh";

                cmbId.Visible = true;
                groupBox1.Enabled = false;
                txtId.Enabled = false;
                btnAdd.Visible = false;
                btnUpdate.Visible = false;
            }
        }
        private void FrmUser_Load(object sender, EventArgs e)
        {
            /// :) התאמה של המסך לסטטוסים


            if (this.MyStaus == StatusKind.delete)
            {
                cmbId.Text = "-בחר משתמש-";
            }
            if (this.MyStaus == StatusKind.update)
            {
                cmbId.Text = "-בחר משתמש-";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.BuildObjectByFields() == true)
            {
                DataRow dr = this.myMishtamesh.ToDataRow();

                if (this.MyStaus == StatusKind.add)
                {
                    this.allMyTable = new MishtamshimTable();
                    if (this.allMyTable.Add(dr) == true)
                        MessageBox.Show("המשתמש התווסף בהצלחה");
                    else
                        MessageBox.Show("המשתמש קיים במאגר");
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (this.BuildObjectByFields() == true)
            {

                DataRow dr = this.myMishtamesh.ToDataRow();
                if (this.MyStaus == StatusKind.delete)
                {
                    if (this.allMyTable.Delete(dr) == true)
                        MessageBox.Show("המשתמש נמחק בהצלחה");
                    else
                        MessageBox.Show("המשתמש קיים במאגר");
                }
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (this.BuildObjectByFields() == true)
            {
                DataRow dr = this.myMishtamesh.ToDataRow();
                if (this.MyStaus == StatusKind.update)
                {

                    if (this.allMyTable.Update(dr) == true)
                        MessageBox.Show("המשתמש עודכן בהצלחה");
                    else
                        MessageBox.Show("המשתמש קיים במאגר");
                }
            }
        }
        public Boolean BuildObjectByFields()
        {
            errorProvider1.Clear();

            this.myMishtamesh = new Mishtamshim();
            bool ok = true;
            try
            {
                this.myMishtamesh.IdMishtamesh = txtId.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtId, ex.Message);
                ok = false;
            }
            try
            {
                this.myMishtamesh.FirstName = txtFirstName.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtFirstName, ex.Message);
                ok = false;
            }
            try
            {
                this.myMishtamesh.LastName = txtLastName.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtLastName, ex.Message);
                ok = false;
            }
            try
            {
                this.myMishtamesh.BirthDate = dateTimePicker1.Value;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(dateTimePicker1, ex.Message);
                ok = false;
            }
            try
            {
                this.myMishtamesh.City = txtCity.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtCity, ex.Message);
                ok = false;
            }
            try
            {
                this.myMishtamesh.Street = txtStreet.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtStreet, ex.Message);
                ok = false;
            }
            try
            {
                this.myMishtamesh.NumberOfHouse = Convert.ToInt32(txtNumberHouse.Text);
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtNumberHouse, ex.Message);
                ok = false;
            }
            try
            {
                this.myMishtamesh.Phone = txtFhone.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtFhone, ex.Message);
                ok = false;
            }
            try
            {
                this.myMishtamesh.Pass = txtPass.Text;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(txtPass, ex.Message);
                ok = false;
            }
            try
            {
                this.myMishtamesh.Mylevel = ckbLevel.Checked;
            }
            catch (Exception ex)
            {
                errorProvider1.SetError(ckbLevel, ex.Message);
                ok = false;
            }
            if (this.MyStaus == StatusKind.add)
                this.myMishtamesh.Status = true;
            return ok;
        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void cmbId_SelectionChangeCommitted(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            DataRow dr = new MishtamshimTable().Find(cmbId.SelectedValue);
            this.myMishtamesh = new Mishtamshim(dr);
            FillFields();
        }
        public void FillFields()
        {
            txtId.Text = Convert.ToString(this.myMishtamesh.IdMishtamesh);
            txtFirstName.Text = Convert.ToString(this.myMishtamesh.FirstName);
            txtLastName.Text = Convert.ToString(this.myMishtamesh.LastName);
            dateTimePicker1.Value = Convert.ToDateTime(this.myMishtamesh.BirthDate);
            txtCity.Text = Convert.ToString(this.myMishtamesh.City);
            txtStreet.Text = Convert.ToString(this.myMishtamesh.Street);
            txtNumberHouse.Text = Convert.ToString(this.myMishtamesh.NumberOfHouse);
            txtFhone.Text = Convert.ToString(this.myMishtamesh.Phone);
            txtPass.Text = Convert.ToString(this.myMishtamesh.Pass);
            ckbLevel.Text = Convert.ToString(this.myMishtamesh.Mylevel);
        }
        private void cmbId_SelectedIndexChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            string idMishtamesh = Convert.ToString(cmbId.SelectedValue);
            DataRow dr = allMyTable.Find(cmbId);
            this.myMishtamesh = new Mishtamshim(dr);
            FillFields();
        }
        private void cmbId_SelectedIndexChanged_1(object sender, EventArgs e)
        {
        }

        private void txtFirstName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 'א' || e.KeyChar > 'ת') && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
        }

        private void txtLastName_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtStreet_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((e.KeyChar < 'א' || e.KeyChar > 'ת') && (e.KeyChar != '\b'))
            {
                e.Handled = true;
            }
        }
    }
}


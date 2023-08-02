namespace yehuditGames.GUI
{
    partial class frmChavotDaat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtIdMishtamesh = new System.Windows.Forms.TextBox();
            this.txtDescribe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.nmbrSviutRazon = new System.Windows.Forms.NumericUpDown();
            this.cmbKodParit = new System.Windows.Forms.ComboBox();
            this.cmbKodChavatDaat = new System.Windows.Forms.ComboBox();
            this.txtKodChavatDaat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrSviutRazon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAdd.Location = new System.Drawing.Point(460, 356);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(116, 71);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "להוספה";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click_1);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnDelete.Location = new System.Drawing.Point(328, 356);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(116, 71);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "למחיקה";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click_1);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // txtIdMishtamesh
            // 
            this.txtIdMishtamesh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtIdMishtamesh.Location = new System.Drawing.Point(105, 207);
            this.txtIdMishtamesh.Name = "txtIdMishtamesh";
            this.txtIdMishtamesh.Size = new System.Drawing.Size(127, 26);
            this.txtIdMishtamesh.TabIndex = 3;
            this.txtIdMishtamesh.TextChanged += new System.EventHandler(this.txtIdMishtamesh_TextChanged);
            this.txtIdMishtamesh.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdMishtamesh_KeyPress);
            // 
            // txtDescribe
            // 
            this.txtDescribe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtDescribe.Location = new System.Drawing.Point(105, 115);
            this.txtDescribe.Multiline = true;
            this.txtDescribe.Name = "txtDescribe";
            this.txtDescribe.Size = new System.Drawing.Size(127, 74);
            this.txtDescribe.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(241, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "פריט";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(241, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "שביעות רצון ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(241, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "תיאור הדעה";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(241, 210);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "ת\"ז משתמש";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(597, 88);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "קוד חוות דעת";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.nmbrSviutRazon);
            this.groupBox1.Controls.Add(this.txtDescribe);
            this.groupBox1.Controls.Add(this.txtIdMishtamesh);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbKodParit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.Location = new System.Drawing.Point(40, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 302);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "מה דעתך???";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.button1.Location = new System.Drawing.Point(17, 205);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 28);
            this.button1.TabIndex = 16;
            this.button1.Text = "לאיתור";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // nmbrSviutRazon
            // 
            this.nmbrSviutRazon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.nmbrSviutRazon.Location = new System.Drawing.Point(112, 77);
            this.nmbrSviutRazon.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nmbrSviutRazon.Name = "nmbrSviutRazon";
            this.nmbrSviutRazon.Size = new System.Drawing.Size(120, 26);
            this.nmbrSviutRazon.TabIndex = 15;
            this.nmbrSviutRazon.ValueChanged += new System.EventHandler(this.nmbrSviutRazon_ValueChanged);
            // 
            // cmbKodParit
            // 
            this.cmbKodParit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbKodParit.FormattingEnabled = true;
            this.cmbKodParit.Location = new System.Drawing.Point(112, 36);
            this.cmbKodParit.Name = "cmbKodParit";
            this.cmbKodParit.Size = new System.Drawing.Size(112, 28);
            this.cmbKodParit.TabIndex = 15;
            this.cmbKodParit.Text = "-בחר מוצר-";
            this.cmbKodParit.SelectedIndexChanged += new System.EventHandler(this.cmbKodParit_SelectedIndexChanged);
            this.cmbKodParit.SelectionChangeCommitted += new System.EventHandler(this.cmbKodParit_SelectionChangeCommitted);
            // 
            // cmbKodChavatDaat
            // 
            this.cmbKodChavatDaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.cmbKodChavatDaat.FormattingEnabled = true;
            this.cmbKodChavatDaat.Location = new System.Drawing.Point(513, 134);
            this.cmbKodChavatDaat.Name = "cmbKodChavatDaat";
            this.cmbKodChavatDaat.Size = new System.Drawing.Size(150, 28);
            this.cmbKodChavatDaat.TabIndex = 13;
            this.cmbKodChavatDaat.Text = "-בחר חוות דעת-";
            this.cmbKodChavatDaat.SelectedIndexChanged += new System.EventHandler(this.cmbKodChavatDaat_SelectedIndexChanged);
            this.cmbKodChavatDaat.SelectionChangeCommitted += new System.EventHandler(this.cmbKodChavatDaat_SelectionChangeCommitted);
            // 
            // txtKodChavatDaat
            // 
            this.txtKodChavatDaat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtKodChavatDaat.Location = new System.Drawing.Point(513, 85);
            this.txtKodChavatDaat.Name = "txtKodChavatDaat";
            this.txtKodChavatDaat.Size = new System.Drawing.Size(75, 26);
            this.txtKodChavatDaat.TabIndex = 14;
            // 
            // frmChavotDaat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::yehuditGames.Properties.Resources.חוגים1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtKodChavatDaat);
            this.Controls.Add(this.cmbKodChavatDaat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Name = "frmChavotDaat";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "חוות דעת";
            this.Load += new System.EventHandler(this.frmChavotDaat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrSviutRazon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescribe;
        private System.Windows.Forms.TextBox txtIdMishtamesh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbKodChavatDaat;
        private System.Windows.Forms.TextBox txtKodChavatDaat;
        private System.Windows.Forms.ComboBox cmbKodParit;
        private System.Windows.Forms.NumericUpDown nmbrSviutRazon;
        private System.Windows.Forms.Button button1;
    }
}
namespace yehuditGames.GUI
{
    partial class frmHazagatChavatDaatOnUser
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
            this.dgvChavotDaat = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.txtIdUser = new System.Windows.Forms.TextBox();
            this.btnUndo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChavotDaat)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvChavotDaat
            // 
            this.dgvChavotDaat.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dgvChavotDaat.AllowDrop = true;
            this.dgvChavotDaat.AllowUserToAddRows = false;
            this.dgvChavotDaat.AllowUserToDeleteRows = false;
            this.dgvChavotDaat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChavotDaat.Location = new System.Drawing.Point(29, 111);
            this.dgvChavotDaat.Name = "dgvChavotDaat";
            this.dgvChavotDaat.ReadOnly = true;
            this.dgvChavotDaat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvChavotDaat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvChavotDaat.Size = new System.Drawing.Size(726, 228);
            this.dgvChavotDaat.StandardTab = true;
            this.dgvChavotDaat.TabIndex = 0;
            this.dgvChavotDaat.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChavotDaat_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(203, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "הקש מספר ת\"ז להצגת חוות דעת של המשתמש";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnEnter.ForeColor = System.Drawing.Color.Red;
            this.btnEnter.Location = new System.Drawing.Point(329, 78);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(126, 27);
            this.btnEnter.TabIndex = 2;
            this.btnEnter.Text = "לאישור";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // txtIdUser
            // 
            this.txtIdUser.ForeColor = System.Drawing.Color.Red;
            this.txtIdUser.Location = new System.Drawing.Point(309, 52);
            this.txtIdUser.Name = "txtIdUser";
            this.txtIdUser.Size = new System.Drawing.Size(162, 20);
            this.txtIdUser.TabIndex = 3;
            // 
            // btnUndo
            // 
            this.btnUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnUndo.ForeColor = System.Drawing.Color.Red;
            this.btnUndo.Location = new System.Drawing.Point(245, 424);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(287, 37);
            this.btnUndo.TabIndex = 4;
            this.btnUndo.Text = "לחזרה לצפייה בכל חוות הדעת";
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // frmHazagatChavatDaatOnUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::yehuditGames.Properties.Resources.חוגים3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(787, 484);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.txtIdUser);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvChavotDaat);
            this.Name = "frmHazagatChavatDaatOnUser";
            this.Text = "frmHazagatChavatDaatOnUser";
            this.Load += new System.EventHandler(this.frmHazagatChavatDaatOnUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChavotDaat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvChavotDaat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtIdUser;
        private System.Windows.Forms.Button btnUndo;
    }
}
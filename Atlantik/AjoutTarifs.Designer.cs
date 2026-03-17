namespace Atlantik
{
    partial class AjoutTarifs
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
            this.lbxsect = new System.Windows.Forms.ListBox();
            this.lblsecteur = new System.Windows.Forms.Label();
            this.lblliaison = new System.Windows.Forms.Label();
            this.cmblaision = new System.Windows.Forms.ComboBox();
            this.lblperiode = new System.Windows.Forms.Label();
            this.cmbpériode = new System.Windows.Forms.ComboBox();
            this.btnajout = new System.Windows.Forms.Button();
            this.gbxtarif = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lbxsect
            // 
            this.lbxsect.FormattingEnabled = true;
            this.lbxsect.Location = new System.Drawing.Point(11, 60);
            this.lbxsect.Name = "lbxsect";
            this.lbxsect.Size = new System.Drawing.Size(120, 199);
            this.lbxsect.TabIndex = 0;
            this.lbxsect.SelectedIndexChanged += new System.EventHandler(this.LstsectAjTar_SelectedIndexChanged);
            // 
            // lblsecteur
            // 
            this.lblsecteur.AutoSize = true;
            this.lblsecteur.Location = new System.Drawing.Point(8, 44);
            this.lblsecteur.Name = "lblsecteur";
            this.lblsecteur.Size = new System.Drawing.Size(55, 13);
            this.lblsecteur.TabIndex = 1;
            this.lblsecteur.Text = "Secteurs :";
            // 
            // lblliaison
            // 
            this.lblliaison.AutoSize = true;
            this.lblliaison.Location = new System.Drawing.Point(8, 272);
            this.lblliaison.Name = "lblliaison";
            this.lblliaison.Size = new System.Drawing.Size(46, 13);
            this.lblliaison.TabIndex = 2;
            this.lblliaison.Text = "Liaison :";
            // 
            // cmblaision
            // 
            this.cmblaision.FormattingEnabled = true;
            this.cmblaision.Location = new System.Drawing.Point(12, 288);
            this.cmblaision.Name = "cmblaision";
            this.cmblaision.Size = new System.Drawing.Size(121, 21);
            this.cmblaision.TabIndex = 3;
            // 
            // lblperiode
            // 
            this.lblperiode.AutoSize = true;
            this.lblperiode.Location = new System.Drawing.Point(8, 346);
            this.lblperiode.Name = "lblperiode";
            this.lblperiode.Size = new System.Drawing.Size(49, 13);
            this.lblperiode.TabIndex = 4;
            this.lblperiode.Text = "Période :";
            // 
            // cmbpériode
            // 
            this.cmbpériode.FormattingEnabled = true;
            this.cmbpériode.Location = new System.Drawing.Point(75, 343);
            this.cmbpériode.Name = "cmbpériode";
            this.cmbpériode.Size = new System.Drawing.Size(219, 21);
            this.cmbpériode.TabIndex = 5;
            // 
            // btnajout
            // 
            this.btnajout.Location = new System.Drawing.Point(324, 341);
            this.btnajout.Name = "btnajout";
            this.btnajout.Size = new System.Drawing.Size(121, 23);
            this.btnajout.TabIndex = 6;
            this.btnajout.Text = "Ajouter";
            this.btnajout.UseVisualStyleBackColor = true;
            this.btnajout.Click += new System.EventHandler(this.BtnAjout_Click);
            // 
            // gbxtarif
            // 
            this.gbxtarif.Location = new System.Drawing.Point(227, 44);
            this.gbxtarif.Name = "gbxtarif";
            this.gbxtarif.Size = new System.Drawing.Size(244, 265);
            this.gbxtarif.TabIndex = 7;
            this.gbxtarif.TabStop = false;
            this.gbxtarif.Text = "Tarifs par Catégorie-Type";
            this.gbxtarif.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // AjoutTarifs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.gbxtarif);
            this.Controls.Add(this.btnajout);
            this.Controls.Add(this.cmbpériode);
            this.Controls.Add(this.lblperiode);
            this.Controls.Add(this.cmblaision);
            this.Controls.Add(this.lblliaison);
            this.Controls.Add(this.lblsecteur);
            this.Controls.Add(this.lbxsect);
            this.Name = "AjoutTarifs";
            this.Text = "AjoutTarifs";
            this.Load += new System.EventHandler(this.AjoutTarifs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbxsect;
        private System.Windows.Forms.Label lblsecteur;
        private System.Windows.Forms.Label lblliaison;
        private System.Windows.Forms.ComboBox cmblaision;
        private System.Windows.Forms.Label lblperiode;
        private System.Windows.Forms.ComboBox cmbpériode;
        private System.Windows.Forms.Button btnajout;
        private System.Windows.Forms.GroupBox gbxtarif;
    }
}
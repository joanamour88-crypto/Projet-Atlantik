namespace Atlantik
{
    partial class AjoutLiaison
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
            this.lblsect = new System.Windows.Forms.Label();
            this.lbldepart = new System.Windows.Forms.Label();
            this.lblarrivee = new System.Windows.Forms.Label();
            this.lbldistance = new System.Windows.Forms.Label();
            this.cmbdepart = new System.Windows.Forms.ComboBox();
            this.cmbarrivee = new System.Windows.Forms.ComboBox();
            this.tbxdist = new System.Windows.Forms.TextBox();
            this.lbxsect = new System.Windows.Forms.ListBox();
            this.BtnAjout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblsect
            // 
            this.lblsect.AutoSize = true;
            this.lblsect.Location = new System.Drawing.Point(41, 46);
            this.lblsect.Name = "lblsect";
            this.lblsect.Size = new System.Drawing.Size(55, 13);
            this.lblsect.TabIndex = 0;
            this.lblsect.Text = "Secteurs :";
            // 
            // lbldepart
            // 
            this.lbldepart.AutoSize = true;
            this.lbldepart.Location = new System.Drawing.Point(186, 46);
            this.lbldepart.Name = "lbldepart";
            this.lbldepart.Size = new System.Drawing.Size(45, 13);
            this.lbldepart.TabIndex = 1;
            this.lbldepart.Text = "Départ :";
            // 
            // lblarrivee
            // 
            this.lblarrivee.AutoSize = true;
            this.lblarrivee.Location = new System.Drawing.Point(400, 46);
            this.lblarrivee.Name = "lblarrivee";
            this.lblarrivee.Size = new System.Drawing.Size(46, 13);
            this.lblarrivee.TabIndex = 2;
            this.lblarrivee.Text = "Arrivée :";
            // 
            // lbldistance
            // 
            this.lbldistance.AutoSize = true;
            this.lbldistance.Location = new System.Drawing.Point(391, 151);
            this.lbldistance.Name = "lbldistance";
            this.lbldistance.Size = new System.Drawing.Size(55, 13);
            this.lbldistance.TabIndex = 3;
            this.lbldistance.Text = "Distance :";
            this.lbldistance.Click += new System.EventHandler(this.label4_Click);
            // 
            // cmbdepart
            // 
            this.cmbdepart.FormattingEnabled = true;
            this.cmbdepart.Location = new System.Drawing.Point(237, 43);
            this.cmbdepart.Name = "cmbdepart";
            this.cmbdepart.Size = new System.Drawing.Size(121, 21);
            this.cmbdepart.TabIndex = 4;
            this.cmbdepart.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cmbarrivee
            // 
            this.cmbarrivee.FormattingEnabled = true;
            this.cmbarrivee.Location = new System.Drawing.Point(452, 43);
            this.cmbarrivee.Name = "cmbarrivee";
            this.cmbarrivee.Size = new System.Drawing.Size(121, 21);
            this.cmbarrivee.TabIndex = 5;
            this.cmbarrivee.SelectedIndexChanged += new System.EventHandler(this.CbxArrive_SelectedIndexChanged);
            // 
            // tbxdist
            // 
            this.tbxdist.Location = new System.Drawing.Point(452, 148);
            this.tbxdist.Name = "tbxdist";
            this.tbxdist.Size = new System.Drawing.Size(121, 20);
            this.tbxdist.TabIndex = 7;
            this.tbxdist.TextChanged += new System.EventHandler(this.tbxdist_TextChanged);
            this.tbxdist.Validating += new System.ComponentModel.CancelEventHandler(this.TbxDist_Validating);
            // 
            // lbxsect
            // 
            this.lbxsect.FormattingEnabled = true;
            this.lbxsect.Location = new System.Drawing.Point(44, 73);
            this.lbxsect.Name = "lbxsect";
            this.lbxsect.Size = new System.Drawing.Size(120, 186);
            this.lbxsect.TabIndex = 8;
            this.lbxsect.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // BtnAjout
            // 
            this.BtnAjout.Location = new System.Drawing.Point(452, 211);
            this.BtnAjout.Name = "BtnAjout";
            this.BtnAjout.Size = new System.Drawing.Size(121, 23);
            this.BtnAjout.TabIndex = 9;
            this.BtnAjout.Text = "Ajouter";
            this.BtnAjout.UseVisualStyleBackColor = true;
            this.BtnAjout.Click += new System.EventHandler(this.BtnAjout_Click);
            // 
            // AjoutLiaison
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 310);
            this.Controls.Add(this.BtnAjout);
            this.Controls.Add(this.lbxsect);
            this.Controls.Add(this.tbxdist);
            this.Controls.Add(this.cmbarrivee);
            this.Controls.Add(this.cmbdepart);
            this.Controls.Add(this.lbldistance);
            this.Controls.Add(this.lblarrivee);
            this.Controls.Add(this.lbldepart);
            this.Controls.Add(this.lblsect);
            this.Name = "AjoutLiaison";
            this.Text = "AjoutLiaison";
            this.Load += new System.EventHandler(this.AjoutLiaison_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblsect;
        private System.Windows.Forms.Label lbldepart;
        private System.Windows.Forms.Label lblarrivee;
        private System.Windows.Forms.Label lbldistance;
        private System.Windows.Forms.ComboBox cmbdepart;
        private System.Windows.Forms.ComboBox cmbarrivee;
        private System.Windows.Forms.TextBox tbxdist;
        private System.Windows.Forms.ListBox lbxsect;
        private System.Windows.Forms.Button BtnAjout;
    }
}
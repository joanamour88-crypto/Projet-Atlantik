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
            this.LstsectAjTar = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cbxlaision = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Cbxpériode = new System.Windows.Forms.ComboBox();
            this.BtnAjout = new System.Windows.Forms.Button();
            this.GbxTarif = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // LstsectAjTar
            // 
            this.LstsectAjTar.FormattingEnabled = true;
            this.LstsectAjTar.Location = new System.Drawing.Point(11, 60);
            this.LstsectAjTar.Name = "LstsectAjTar";
            this.LstsectAjTar.Size = new System.Drawing.Size(120, 199);
            this.LstsectAjTar.TabIndex = 0;
            this.LstsectAjTar.SelectedIndexChanged += new System.EventHandler(this.LstsectAjTar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Secteurs :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Liaison :";
            // 
            // Cbxlaision
            // 
            this.Cbxlaision.FormattingEnabled = true;
            this.Cbxlaision.Location = new System.Drawing.Point(12, 288);
            this.Cbxlaision.Name = "Cbxlaision";
            this.Cbxlaision.Size = new System.Drawing.Size(121, 21);
            this.Cbxlaision.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 346);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Période :";
            // 
            // Cbxpériode
            // 
            this.Cbxpériode.FormattingEnabled = true;
            this.Cbxpériode.Location = new System.Drawing.Point(75, 343);
            this.Cbxpériode.Name = "Cbxpériode";
            this.Cbxpériode.Size = new System.Drawing.Size(219, 21);
            this.Cbxpériode.TabIndex = 5;
            // 
            // BtnAjout
            // 
            this.BtnAjout.Location = new System.Drawing.Point(324, 341);
            this.BtnAjout.Name = "BtnAjout";
            this.BtnAjout.Size = new System.Drawing.Size(121, 23);
            this.BtnAjout.TabIndex = 6;
            this.BtnAjout.Text = "Ajouter";
            this.BtnAjout.UseVisualStyleBackColor = true;
            this.BtnAjout.Click += new System.EventHandler(this.BtnAjout_Click);
            // 
            // GbxTarif
            // 
            this.GbxTarif.Location = new System.Drawing.Point(227, 44);
            this.GbxTarif.Name = "GbxTarif";
            this.GbxTarif.Size = new System.Drawing.Size(244, 265);
            this.GbxTarif.TabIndex = 7;
            this.GbxTarif.TabStop = false;
            this.GbxTarif.Text = "Tarifs par Catégorie-Type";
            this.GbxTarif.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // AjoutTarifs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 450);
            this.Controls.Add(this.GbxTarif);
            this.Controls.Add(this.BtnAjout);
            this.Controls.Add(this.Cbxpériode);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Cbxlaision);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LstsectAjTar);
            this.Name = "AjoutTarifs";
            this.Text = "AjoutTarifs";
            this.Load += new System.EventHandler(this.AjoutTarifs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstsectAjTar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Cbxlaision;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cbxpériode;
        private System.Windows.Forms.Button BtnAjout;
        private System.Windows.Forms.GroupBox GbxTarif;
    }
}
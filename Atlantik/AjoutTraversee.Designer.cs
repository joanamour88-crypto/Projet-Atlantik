namespace Atlantik
{
    partial class AjoutTraversee
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
            this.Btnajout = new System.Windows.Forms.Button();
            this.Cbxnombateau = new System.Windows.Forms.ComboBox();
            this.LblLiaison = new System.Windows.Forms.Label();
            this.Lbldatarrivee = new System.Windows.Forms.Label();
            this.Lbldatdep = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Lstsect = new System.Windows.Forms.ListBox();
            this.Lblsect = new System.Windows.Forms.Label();
            this.Cbxliaison = new System.Windows.Forms.ComboBox();
            this.Dtpdepart = new System.Windows.Forms.DateTimePicker();
            this.Dtparrivee = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // Btnajout
            // 
            this.Btnajout.BackColor = System.Drawing.Color.NavajoWhite;
            this.Btnajout.Location = new System.Drawing.Point(201, 299);
            this.Btnajout.Name = "Btnajout";
            this.Btnajout.Size = new System.Drawing.Size(297, 51);
            this.Btnajout.TabIndex = 0;
            this.Btnajout.Text = "Ajouter";
            this.Btnajout.UseVisualStyleBackColor = false;
            this.Btnajout.Click += new System.EventHandler(this.Btnajout_Click);
            // 
            // Cbxnombateau
            // 
            this.Cbxnombateau.FormattingEnabled = true;
            this.Cbxnombateau.Location = new System.Drawing.Point(252, 64);
            this.Cbxnombateau.Name = "Cbxnombateau";
            this.Cbxnombateau.Size = new System.Drawing.Size(121, 21);
            this.Cbxnombateau.TabIndex = 1;
            // 
            // LblLiaison
            // 
            this.LblLiaison.AutoSize = true;
            this.LblLiaison.Location = new System.Drawing.Point(40, 283);
            this.LblLiaison.Name = "LblLiaison";
            this.LblLiaison.Size = new System.Drawing.Size(46, 13);
            this.LblLiaison.TabIndex = 2;
            this.LblLiaison.Text = "Liaison :";
            // 
            // Lbldatarrivee
            // 
            this.Lbldatarrivee.AutoSize = true;
            this.Lbldatarrivee.Location = new System.Drawing.Point(180, 238);
            this.Lbldatarrivee.Name = "Lbldatarrivee";
            this.Lbldatarrivee.Size = new System.Drawing.Size(121, 13);
            this.Lbldatarrivee.TabIndex = 3;
            this.Lbldatarrivee.Text = "Date et heure d\'arrivée :";
            // 
            // Lbldatdep
            // 
            this.Lbldatdep.AutoSize = true;
            this.Lbldatdep.Location = new System.Drawing.Point(175, 198);
            this.Lbldatdep.Name = "Lbldatdep";
            this.Lbldatdep.Size = new System.Drawing.Size(126, 13);
            this.Lbldatdep.TabIndex = 4;
            this.Lbldatdep.Text = "Date et heure de départ :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(175, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Nom bâteau :";
            // 
            // Lstsect
            // 
            this.Lstsect.FormattingEnabled = true;
            this.Lstsect.Location = new System.Drawing.Point(43, 83);
            this.Lstsect.Name = "Lstsect";
            this.Lstsect.Size = new System.Drawing.Size(120, 186);
            this.Lstsect.TabIndex = 6;
            this.Lstsect.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Lblsect
            // 
            this.Lblsect.AutoSize = true;
            this.Lblsect.Location = new System.Drawing.Point(40, 67);
            this.Lblsect.Name = "Lblsect";
            this.Lblsect.Size = new System.Drawing.Size(50, 13);
            this.Lblsect.TabIndex = 7;
            this.Lblsect.Text = "Secteur :";
            // 
            // Cbxliaison
            // 
            this.Cbxliaison.FormattingEnabled = true;
            this.Cbxliaison.Location = new System.Drawing.Point(42, 299);
            this.Cbxliaison.Name = "Cbxliaison";
            this.Cbxliaison.Size = new System.Drawing.Size(121, 21);
            this.Cbxliaison.TabIndex = 8;
            // 
            // Dtpdepart
            // 
            this.Dtpdepart.Location = new System.Drawing.Point(298, 192);
            this.Dtpdepart.Name = "Dtpdepart";
            this.Dtpdepart.Size = new System.Drawing.Size(200, 20);
            this.Dtpdepart.TabIndex = 9;
            this.Dtpdepart.ValueChanged += new System.EventHandler(this.Dtpdepart_ValueChanged);
            // 
            // Dtparrivee
            // 
            this.Dtparrivee.Location = new System.Drawing.Point(298, 238);
            this.Dtparrivee.Name = "Dtparrivee";
            this.Dtparrivee.Size = new System.Drawing.Size(200, 20);
            this.Dtparrivee.TabIndex = 10;
            // 
            // AjoutTraversee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 375);
            this.Controls.Add(this.Dtparrivee);
            this.Controls.Add(this.Dtpdepart);
            this.Controls.Add(this.Cbxliaison);
            this.Controls.Add(this.Lblsect);
            this.Controls.Add(this.Lstsect);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lbldatdep);
            this.Controls.Add(this.Lbldatarrivee);
            this.Controls.Add(this.LblLiaison);
            this.Controls.Add(this.Cbxnombateau);
            this.Controls.Add(this.Btnajout);
            this.Name = "AjoutTraversee";
            this.Text = "AjoutTraversee";
            this.Load += new System.EventHandler(this.AjoutTraversee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btnajout;
        private System.Windows.Forms.ComboBox Cbxnombateau;
        private System.Windows.Forms.Label LblLiaison;
        private System.Windows.Forms.Label Lbldatarrivee;
        private System.Windows.Forms.Label Lbldatdep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox Lstsect;
        private System.Windows.Forms.Label Lblsect;
        private System.Windows.Forms.ComboBox Cbxliaison;
        private System.Windows.Forms.DateTimePicker Dtpdepart;
        private System.Windows.Forms.DateTimePicker Dtparrivee;
    }
}
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
            this.btnajouter = new System.Windows.Forms.Button();
            this.cmbnombateau = new System.Windows.Forms.ComboBox();
            this.lblliaison = new System.Windows.Forms.Label();
            this.lbldatarrivee = new System.Windows.Forms.Label();
            this.lbldatdep = new System.Windows.Forms.Label();
            this.lblnombateau = new System.Windows.Forms.Label();
            this.lbxsecteurs = new System.Windows.Forms.ListBox();
            this.lblsecteur = new System.Windows.Forms.Label();
            this.cmbliaison = new System.Windows.Forms.ComboBox();
            this.datedepart = new System.Windows.Forms.DateTimePicker();
            this.dateparrivee = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnajouter
            // 
            this.btnajouter.BackColor = System.Drawing.Color.NavajoWhite;
            this.btnajouter.Location = new System.Drawing.Point(201, 299);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(297, 51);
            this.btnajouter.TabIndex = 0;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = false;
            this.btnajouter.Click += new System.EventHandler(this.Btnajout_Click);
            // 
            // cmbnombateau
            // 
            this.cmbnombateau.FormattingEnabled = true;
            this.cmbnombateau.Location = new System.Drawing.Point(252, 64);
            this.cmbnombateau.Name = "cmbnombateau";
            this.cmbnombateau.Size = new System.Drawing.Size(121, 21);
            this.cmbnombateau.TabIndex = 1;
            // 
            // lblliaison
            // 
            this.lblliaison.AutoSize = true;
            this.lblliaison.Location = new System.Drawing.Point(40, 283);
            this.lblliaison.Name = "lblliaison";
            this.lblliaison.Size = new System.Drawing.Size(46, 13);
            this.lblliaison.TabIndex = 2;
            this.lblliaison.Text = "Liaison :";
            // 
            // lbldatarrivee
            // 
            this.lbldatarrivee.AutoSize = true;
            this.lbldatarrivee.Location = new System.Drawing.Point(180, 238);
            this.lbldatarrivee.Name = "lbldatarrivee";
            this.lbldatarrivee.Size = new System.Drawing.Size(121, 13);
            this.lbldatarrivee.TabIndex = 3;
            this.lbldatarrivee.Text = "Date et heure d\'arrivée :";
            // 
            // lbldatdep
            // 
            this.lbldatdep.AutoSize = true;
            this.lbldatdep.Location = new System.Drawing.Point(175, 198);
            this.lbldatdep.Name = "lbldatdep";
            this.lbldatdep.Size = new System.Drawing.Size(126, 13);
            this.lbldatdep.TabIndex = 4;
            this.lbldatdep.Text = "Date et heure de départ :";
            // 
            // lblnombateau
            // 
            this.lblnombateau.AutoSize = true;
            this.lblnombateau.Location = new System.Drawing.Point(175, 67);
            this.lblnombateau.Name = "lblnombateau";
            this.lblnombateau.Size = new System.Drawing.Size(71, 13);
            this.lblnombateau.TabIndex = 5;
            this.lblnombateau.Text = "Nom bâteau :";
            // 
            // lbxsecteurs
            // 
            this.lbxsecteurs.FormattingEnabled = true;
            this.lbxsecteurs.Location = new System.Drawing.Point(43, 83);
            this.lbxsecteurs.Name = "lbxsecteurs";
            this.lbxsecteurs.Size = new System.Drawing.Size(120, 186);
            this.lbxsecteurs.TabIndex = 6;
            this.lbxsecteurs.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // lblsecteur
            // 
            this.lblsecteur.AutoSize = true;
            this.lblsecteur.Location = new System.Drawing.Point(40, 67);
            this.lblsecteur.Name = "lblsecteur";
            this.lblsecteur.Size = new System.Drawing.Size(55, 13);
            this.lblsecteur.TabIndex = 7;
            this.lblsecteur.Text = "Secteurs :";
            // 
            // cmbliaison
            // 
            this.cmbliaison.FormattingEnabled = true;
            this.cmbliaison.Location = new System.Drawing.Point(42, 299);
            this.cmbliaison.Name = "cmbliaison";
            this.cmbliaison.Size = new System.Drawing.Size(121, 21);
            this.cmbliaison.TabIndex = 8;
            // 
            // datedepart
            // 
            this.datedepart.Location = new System.Drawing.Point(298, 192);
            this.datedepart.Name = "datedepart";
            this.datedepart.Size = new System.Drawing.Size(200, 20);
            this.datedepart.TabIndex = 9;
            this.datedepart.ValueChanged += new System.EventHandler(this.Dtpdepart_ValueChanged);
            // 
            // dateparrivee
            // 
            this.dateparrivee.Location = new System.Drawing.Point(298, 238);
            this.dateparrivee.Name = "dateparrivee";
            this.dateparrivee.Size = new System.Drawing.Size(200, 20);
            this.dateparrivee.TabIndex = 10;
            // 
            // AjoutTraversee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 375);
            this.Controls.Add(this.dateparrivee);
            this.Controls.Add(this.datedepart);
            this.Controls.Add(this.cmbliaison);
            this.Controls.Add(this.lblsecteur);
            this.Controls.Add(this.lbxsecteurs);
            this.Controls.Add(this.lblnombateau);
            this.Controls.Add(this.lbldatdep);
            this.Controls.Add(this.lbldatarrivee);
            this.Controls.Add(this.lblliaison);
            this.Controls.Add(this.cmbnombateau);
            this.Controls.Add(this.btnajouter);
            this.Name = "AjoutTraversee";
            this.Text = "AjoutTraversee";
            this.Load += new System.EventHandler(this.AjoutTraversee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.ComboBox cmbnombateau;
        private System.Windows.Forms.Label lblliaison;
        private System.Windows.Forms.Label lbldatarrivee;
        private System.Windows.Forms.Label lbldatdep;
        private System.Windows.Forms.Label lblnombateau;
        private System.Windows.Forms.ListBox lbxsecteurs;
        private System.Windows.Forms.Label lblsecteur;
        private System.Windows.Forms.ComboBox cmbliaison;
        private System.Windows.Forms.DateTimePicker datedepart;
        private System.Windows.Forms.DateTimePicker dateparrivee;
    }
}
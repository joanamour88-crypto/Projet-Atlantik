namespace Atlantik
{
    partial class AfficheTraversee
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
            this.cmbliaison = new System.Windows.Forms.ComboBox();
            this.btnafftraverse = new System.Windows.Forms.Button();
            this.lbxsecteurs = new System.Windows.Forms.ListBox();
            this.date_date = new System.Windows.Forms.DateTimePicker();
            this.lblsecteurs = new System.Windows.Forms.Label();
            this.lblliaison = new System.Windows.Forms.Label();
            this.lvtraversee = new System.Windows.Forms.ListView();
            this.lbldate = new System.Windows.Forms.Label();
            this.lbltraversee = new System.Windows.Forms.Label();
            this.lblplacedispo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbliaison
            // 
            this.cmbliaison.FormattingEnabled = true;
            this.cmbliaison.Location = new System.Drawing.Point(52, 262);
            this.cmbliaison.Name = "cmbliaison";
            this.cmbliaison.Size = new System.Drawing.Size(121, 21);
            this.cmbliaison.TabIndex = 0;
            // 
            // btnafftraverse
            // 
            this.btnafftraverse.Location = new System.Drawing.Point(226, 103);
            this.btnafftraverse.Name = "btnafftraverse";
            this.btnafftraverse.Size = new System.Drawing.Size(448, 23);
            this.btnafftraverse.TabIndex = 1;
            this.btnafftraverse.Text = "Afficher les traversées";
            this.btnafftraverse.UseVisualStyleBackColor = true;
            this.btnafftraverse.Click += new System.EventHandler(this.Btnafftraverse_Click);
            // 
            // lbxsecteurs
            // 
            this.lbxsecteurs.FormattingEnabled = true;
            this.lbxsecteurs.Location = new System.Drawing.Point(53, 60);
            this.lbxsecteurs.Name = "lbxsecteurs";
            this.lbxsecteurs.Size = new System.Drawing.Size(120, 173);
            this.lbxsecteurs.TabIndex = 2;
            this.lbxsecteurs.SelectedIndexChanged += new System.EventHandler(this.Lstsect_SelectedIndexChanged);
            // 
            // date_date
            // 
            this.date_date.CustomFormat = "yyyy-MM-dd";
            this.date_date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_date.Location = new System.Drawing.Point(474, 60);
            this.date_date.MinDate = new System.DateTime(1834, 7, 24, 0, 0, 0, 0);
            this.date_date.Name = "date_date";
            this.date_date.Size = new System.Drawing.Size(97, 20);
            this.date_date.TabIndex = 3;
            this.date_date.Value = new System.DateTime(2021, 7, 10, 0, 0, 0, 0);
            // 
            // lblsecteurs
            // 
            this.lblsecteurs.AutoSize = true;
            this.lblsecteurs.Location = new System.Drawing.Point(49, 44);
            this.lblsecteurs.Name = "lblsecteurs";
            this.lblsecteurs.Size = new System.Drawing.Size(55, 13);
            this.lblsecteurs.TabIndex = 4;
            this.lblsecteurs.Text = "Secteurs :";
            // 
            // lblliaison
            // 
            this.lblliaison.AutoSize = true;
            this.lblliaison.Location = new System.Drawing.Point(50, 246);
            this.lblliaison.Name = "lblliaison";
            this.lblliaison.Size = new System.Drawing.Size(46, 13);
            this.lblliaison.TabIndex = 5;
            this.lblliaison.Text = "Liaison :";
            // 
            // lvtraversee
            // 
            this.lvtraversee.HideSelection = false;
            this.lvtraversee.Location = new System.Drawing.Point(226, 162);
            this.lvtraversee.Name = "lvtraversee";
            this.lvtraversee.Size = new System.Drawing.Size(448, 214);
            this.lvtraversee.TabIndex = 6;
            this.lvtraversee.UseCompatibleStateImageBehavior = false;
            this.lvtraversee.SelectedIndexChanged += new System.EventHandler(this.LvTraversee_SelectedIndexChanged);
            // 
            // lbldate
            // 
            this.lbldate.AutoSize = true;
            this.lbldate.Location = new System.Drawing.Point(301, 66);
            this.lbldate.Name = "lbldate";
            this.lbldate.Size = new System.Drawing.Size(154, 13);
            this.lbldate.TabIndex = 7;
            this.lbldate.Text = "Date (par défault date du jour) :";
            // 
            // lbltraversee
            // 
            this.lbltraversee.AutoSize = true;
            this.lbltraversee.Location = new System.Drawing.Point(223, 146);
            this.lbltraversee.Name = "lbltraversee";
            this.lbltraversee.Size = new System.Drawing.Size(55, 13);
            this.lbltraversee.TabIndex = 8;
            this.lbltraversee.Text = "Traversée";
            // 
            // lblplacedispo
            // 
            this.lblplacedispo.AutoSize = true;
            this.lblplacedispo.Location = new System.Drawing.Point(515, 146);
            this.lblplacedispo.Name = "lblplacedispo";
            this.lblplacedispo.Size = new System.Drawing.Size(159, 13);
            this.lblplacedispo.TabIndex = 9;
            this.lblplacedispo.Text = "Places disponibles par catégorie";
            // 
            // AfficheTraversee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblplacedispo);
            this.Controls.Add(this.lbltraversee);
            this.Controls.Add(this.lbldate);
            this.Controls.Add(this.lvtraversee);
            this.Controls.Add(this.lblliaison);
            this.Controls.Add(this.lblsecteurs);
            this.Controls.Add(this.date_date);
            this.Controls.Add(this.lbxsecteurs);
            this.Controls.Add(this.btnafftraverse);
            this.Controls.Add(this.cmbliaison);
            this.Name = "AfficheTraversee";
            this.Text = "AfficheTraversee";
            this.Load += new System.EventHandler(this.AfficheTraversee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbliaison;
        private System.Windows.Forms.Button btnafftraverse;
        private System.Windows.Forms.ListBox lbxsecteurs;
        private System.Windows.Forms.DateTimePicker date_date;
        private System.Windows.Forms.Label lblsecteurs;
        private System.Windows.Forms.Label lblliaison;
        private System.Windows.Forms.ListView lvtraversee;
        private System.Windows.Forms.Label lbldate;
        private System.Windows.Forms.Label lbltraversee;
        private System.Windows.Forms.Label lblplacedispo;
    }
}
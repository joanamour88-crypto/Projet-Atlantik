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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CbxDepart = new System.Windows.Forms.ComboBox();
            this.CbxArrive = new System.Windows.Forms.ComboBox();
            this.TbxDist = new System.Windows.Forms.TextBox();
            this.LstSect = new System.Windows.Forms.ListBox();
            this.BtnAjout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Secteurs :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Départ :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Arrivée :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(391, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Distance :";
            // 
            // CbxDepart
            // 
            this.CbxDepart.FormattingEnabled = true;
            this.CbxDepart.Location = new System.Drawing.Point(237, 43);
            this.CbxDepart.Name = "CbxDepart";
            this.CbxDepart.Size = new System.Drawing.Size(121, 21);
            this.CbxDepart.TabIndex = 4;
            this.CbxDepart.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // CbxArrive
            // 
            this.CbxArrive.FormattingEnabled = true;
            this.CbxArrive.Location = new System.Drawing.Point(452, 43);
            this.CbxArrive.Name = "CbxArrive";
            this.CbxArrive.Size = new System.Drawing.Size(121, 21);
            this.CbxArrive.TabIndex = 5;
            this.CbxArrive.SelectedIndexChanged += new System.EventHandler(this.CbxArrive_SelectedIndexChanged);
            // 
            // TbxDist
            // 
            this.TbxDist.Location = new System.Drawing.Point(452, 148);
            this.TbxDist.Name = "TbxDist";
            this.TbxDist.Size = new System.Drawing.Size(121, 20);
            this.TbxDist.TabIndex = 7;
            // 
            // LstSect
            // 
            this.LstSect.FormattingEnabled = true;
            this.LstSect.Location = new System.Drawing.Point(44, 73);
            this.LstSect.Name = "LstSect";
            this.LstSect.Size = new System.Drawing.Size(120, 186);
            this.LstSect.TabIndex = 8;
            this.LstSect.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // BtnAjout
            // 
            this.BtnAjout.Location = new System.Drawing.Point(462, 210);
            this.BtnAjout.Name = "BtnAjout";
            this.BtnAjout.Size = new System.Drawing.Size(75, 23);
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
            this.Controls.Add(this.LstSect);
            this.Controls.Add(this.TbxDist);
            this.Controls.Add(this.CbxArrive);
            this.Controls.Add(this.CbxDepart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AjoutLiaison";
            this.Text = "AjoutLiaison";
            this.Load += new System.EventHandler(this.AjoutLiaison_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CbxDepart;
        private System.Windows.Forms.ComboBox CbxArrive;
        private System.Windows.Forms.TextBox TbxDist;
        private System.Windows.Forms.ListBox LstSect;
        private System.Windows.Forms.Button BtnAjout;
    }
}
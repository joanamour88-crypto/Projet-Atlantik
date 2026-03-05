namespace Atlantik
{
    partial class AjoutSecteur
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
            this.BtnAjoutSect = new System.Windows.Forms.Button();
            this.LblNomSect = new System.Windows.Forms.Label();
            this.TbxNomsect = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnAjoutSect
            // 
            this.BtnAjoutSect.Location = new System.Drawing.Point(233, 124);
            this.BtnAjoutSect.Name = "BtnAjoutSect";
            this.BtnAjoutSect.Size = new System.Drawing.Size(75, 23);
            this.BtnAjoutSect.TabIndex = 0;
            this.BtnAjoutSect.Text = "Ajouter";
            this.BtnAjoutSect.UseVisualStyleBackColor = true;
            this.BtnAjoutSect.Click += new System.EventHandler(this.BtnAjoutSect_Click);
            // 
            // LblNomSect
            // 
            this.LblNomSect.AutoSize = true;
            this.LblNomSect.Location = new System.Drawing.Point(116, 84);
            this.LblNomSect.Name = "LblNomSect";
            this.LblNomSect.Size = new System.Drawing.Size(73, 13);
            this.LblNomSect.TabIndex = 1;
            this.LblNomSect.Text = "Nom secteur :";
            // 
            // TbxNomsect
            // 
            this.TbxNomsect.Location = new System.Drawing.Point(222, 81);
            this.TbxNomsect.Name = "TbxNomsect";
            this.TbxNomsect.Size = new System.Drawing.Size(100, 20);
            this.TbxNomsect.TabIndex = 2;
            // 
            // AjoutSecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 241);
            this.Controls.Add(this.TbxNomsect);
            this.Controls.Add(this.LblNomSect);
            this.Controls.Add(this.BtnAjoutSect);
            this.Name = "AjoutSecteur";
            this.Text = "AjoutSecteur";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAjoutSect;
        private System.Windows.Forms.Label LblNomSect;
        private System.Windows.Forms.TextBox TbxNomsect;
    }
}
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
            this.Tbxnomsect = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnAjoutSect
            // 
            this.BtnAjoutSect.Location = new System.Drawing.Point(103, 89);
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
            this.LblNomSect.Location = new System.Drawing.Point(12, 56);
            this.LblNomSect.Name = "LblNomSect";
            this.LblNomSect.Size = new System.Drawing.Size(73, 13);
            this.LblNomSect.TabIndex = 1;
            this.LblNomSect.Text = "Nom secteur :";
            // 
            // Tbxnomsect
            // 
            this.Tbxnomsect.Location = new System.Drawing.Point(91, 53);
            this.Tbxnomsect.Name = "Tbxnomsect";
            this.Tbxnomsect.Size = new System.Drawing.Size(100, 20);
            this.Tbxnomsect.TabIndex = 2;
            this.Tbxnomsect.Validating += new System.ComponentModel.CancelEventHandler(this.Tbxnomsect_Validating);
            // 
            // AjoutSecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 159);
            this.Controls.Add(this.Tbxnomsect);
            this.Controls.Add(this.LblNomSect);
            this.Controls.Add(this.BtnAjoutSect);
            this.Name = "AjoutSecteur";
            this.Text = "AjoutSecteur";
            this.Load += new System.EventHandler(this.AjoutSecteur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAjoutSect;
        private System.Windows.Forms.Label LblNomSect;
        private System.Windows.Forms.TextBox Tbxnomsect;
    }
}
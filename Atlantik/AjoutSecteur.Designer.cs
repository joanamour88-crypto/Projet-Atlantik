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
            this.btnajoutsect = new System.Windows.Forms.Button();
            this.lblnomsect = new System.Windows.Forms.Label();
            this.tbxnomsect = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnajoutsect
            // 
            this.btnajoutsect.Location = new System.Drawing.Point(103, 89);
            this.btnajoutsect.Name = "btnajoutsect";
            this.btnajoutsect.Size = new System.Drawing.Size(75, 23);
            this.btnajoutsect.TabIndex = 0;
            this.btnajoutsect.Text = "Ajouter";
            this.btnajoutsect.UseVisualStyleBackColor = true;
            this.btnajoutsect.Click += new System.EventHandler(this.BtnAjoutSect_Click);
            // 
            // lblnomsect
            // 
            this.lblnomsect.AutoSize = true;
            this.lblnomsect.Location = new System.Drawing.Point(12, 56);
            this.lblnomsect.Name = "lblnomsect";
            this.lblnomsect.Size = new System.Drawing.Size(73, 13);
            this.lblnomsect.TabIndex = 1;
            this.lblnomsect.Text = "Nom secteur :";
            // 
            // tbxnomsect
            // 
            this.tbxnomsect.Location = new System.Drawing.Point(91, 53);
            this.tbxnomsect.Name = "tbxnomsect";
            this.tbxnomsect.Size = new System.Drawing.Size(100, 20);
            this.tbxnomsect.TabIndex = 2;
            this.tbxnomsect.TextChanged += new System.EventHandler(this.tbxnomsect_TextChanged);
            this.tbxnomsect.Validating += new System.ComponentModel.CancelEventHandler(this.Tbxnomsect_Validating);
            // 
            // AjoutSecteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 159);
            this.Controls.Add(this.tbxnomsect);
            this.Controls.Add(this.lblnomsect);
            this.Controls.Add(this.btnajoutsect);
            this.Name = "AjoutSecteur";
            this.Text = "AjoutSecteur";
            this.Load += new System.EventHandler(this.AjoutSecteur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnajoutsect;
        private System.Windows.Forms.Label lblnomsect;
        private System.Windows.Forms.TextBox tbxnomsect;
    }
}
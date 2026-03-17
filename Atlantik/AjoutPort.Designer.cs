namespace Atlantik
{
    partial class AjoutPort
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
            this.btnAjoutPort = new System.Windows.Forms.Button();
            this.lblnomport = new System.Windows.Forms.Label();
            this.tbxajoutport = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAjoutPort
            // 
            this.btnAjoutPort.Location = new System.Drawing.Point(88, 71);
            this.btnAjoutPort.Name = "btnAjoutPort";
            this.btnAjoutPort.Size = new System.Drawing.Size(75, 23);
            this.btnAjoutPort.TabIndex = 0;
            this.btnAjoutPort.Text = "Ajouter";
            this.btnAjoutPort.UseVisualStyleBackColor = true;
            this.btnAjoutPort.Click += new System.EventHandler(this.BtnAjoutPort_Click);
            // 
            // lblnomport
            // 
            this.lblnomport.AutoSize = true;
            this.lblnomport.Location = new System.Drawing.Point(12, 39);
            this.lblnomport.Name = "lblnomport";
            this.lblnomport.Size = new System.Drawing.Size(56, 13);
            this.lblnomport.TabIndex = 1;
            this.lblnomport.Text = "Nom port :";
            // 
            // tbxajoutport
            // 
            this.tbxajoutport.Location = new System.Drawing.Point(74, 36);
            this.tbxajoutport.Name = "tbxajoutport";
            this.tbxajoutport.Size = new System.Drawing.Size(100, 20);
            this.tbxajoutport.TabIndex = 2;
            this.tbxajoutport.TextChanged += new System.EventHandler(this.tbxajoutport_TextChanged);
            this.tbxajoutport.Validating += new System.ComponentModel.CancelEventHandler(this.TbxAjoutPort_Validating);
            // 
            // AjoutPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 168);
            this.Controls.Add(this.tbxajoutport);
            this.Controls.Add(this.lblnomport);
            this.Controls.Add(this.btnAjoutPort);
            this.Name = "AjoutPort";
            this.Text = "AjoutPort";
            this.Load += new System.EventHandler(this.AjoutPort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAjoutPort;
        private System.Windows.Forms.Label lblnomport;
        private System.Windows.Forms.TextBox tbxajoutport;
    }
}
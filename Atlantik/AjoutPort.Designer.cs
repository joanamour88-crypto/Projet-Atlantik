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
            this.BtnAjoutPort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TbxAjoutPort = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BtnAjoutPort
            // 
            this.BtnAjoutPort.Location = new System.Drawing.Point(88, 71);
            this.BtnAjoutPort.Name = "BtnAjoutPort";
            this.BtnAjoutPort.Size = new System.Drawing.Size(75, 23);
            this.BtnAjoutPort.TabIndex = 0;
            this.BtnAjoutPort.Text = "Ajouter";
            this.BtnAjoutPort.UseVisualStyleBackColor = true;
            this.BtnAjoutPort.Click += new System.EventHandler(this.BtnAjoutPort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom port :";
            // 
            // TbxAjoutPort
            // 
            this.TbxAjoutPort.Location = new System.Drawing.Point(74, 36);
            this.TbxAjoutPort.Name = "TbxAjoutPort";
            this.TbxAjoutPort.Size = new System.Drawing.Size(100, 20);
            this.TbxAjoutPort.TabIndex = 2;
            this.TbxAjoutPort.Validating += new System.ComponentModel.CancelEventHandler(this.TbxAjoutPort_Validating);
            // 
            // AjoutPort
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 168);
            this.Controls.Add(this.TbxAjoutPort);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnAjoutPort);
            this.Name = "AjoutPort";
            this.Text = "AjoutPort";
            this.Load += new System.EventHandler(this.AjoutPort_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnAjoutPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbxAjoutPort;
    }
}
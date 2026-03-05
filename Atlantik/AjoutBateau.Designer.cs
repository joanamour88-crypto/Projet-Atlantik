namespace Atlantik
{
    partial class AjoutBateau
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GbxCapMax = new System.Windows.Forms.GroupBox();
            this.BtnAjBateau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom bateau :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(89, 40);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // GbxCapMax
            // 
            this.GbxCapMax.Location = new System.Drawing.Point(224, 37);
            this.GbxCapMax.Name = "GbxCapMax";
            this.GbxCapMax.Size = new System.Drawing.Size(200, 211);
            this.GbxCapMax.TabIndex = 2;
            this.GbxCapMax.TabStop = false;
            this.GbxCapMax.Text = "Capacité Maximales";
            // 
            // BtnAjBateau
            // 
            this.BtnAjBateau.Location = new System.Drawing.Point(89, 225);
            this.BtnAjBateau.Name = "BtnAjBateau";
            this.BtnAjBateau.Size = new System.Drawing.Size(100, 23);
            this.BtnAjBateau.TabIndex = 0;
            this.BtnAjBateau.Text = "Ajouter";
            this.BtnAjBateau.UseVisualStyleBackColor = true;
            // 
            // AjoutBateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 260);
            this.Controls.Add(this.BtnAjBateau);
            this.Controls.Add(this.GbxCapMax);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "AjoutBateau";
            this.Text = "AjoutBateau";
            this.Load += new System.EventHandler(this.AjoutBateau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox GbxCapMax;
        private System.Windows.Forms.Button BtnAjBateau;
    }
}
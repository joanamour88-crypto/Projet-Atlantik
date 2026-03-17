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
            this.lblnombateau = new System.Windows.Forms.Label();
            this.tbxnombateau = new System.Windows.Forms.TextBox();
            this.gbxcapmax = new System.Windows.Forms.GroupBox();
            this.btnajbateau = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblnombateau
            // 
            this.lblnombateau.AutoSize = true;
            this.lblnombateau.Location = new System.Drawing.Point(12, 40);
            this.lblnombateau.Name = "lblnombateau";
            this.lblnombateau.Size = new System.Drawing.Size(71, 13);
            this.lblnombateau.TabIndex = 0;
            this.lblnombateau.Text = "Nom bateau :";
            // 
            // tbxnombateau
            // 
            this.tbxnombateau.Location = new System.Drawing.Point(89, 33);
            this.tbxnombateau.Name = "tbxnombateau";
            this.tbxnombateau.Size = new System.Drawing.Size(100, 20);
            this.tbxnombateau.TabIndex = 1;
            this.tbxnombateau.TextChanged += new System.EventHandler(this.tbxnombateau_TextChanged);
            // 
            // gbxcapmax
            // 
            this.gbxcapmax.Location = new System.Drawing.Point(224, 37);
            this.gbxcapmax.Name = "gbxcapmax";
            this.gbxcapmax.Size = new System.Drawing.Size(227, 162);
            this.gbxcapmax.TabIndex = 2;
            this.gbxcapmax.TabStop = false;
            this.gbxcapmax.Text = "Capacité Maximales";
            // 
            // btnajbateau
            // 
            this.btnajbateau.Location = new System.Drawing.Point(89, 176);
            this.btnajbateau.Name = "btnajbateau";
            this.btnajbateau.Size = new System.Drawing.Size(100, 23);
            this.btnajbateau.TabIndex = 0;
            this.btnajbateau.Text = "Ajouter";
            this.btnajbateau.UseVisualStyleBackColor = true;
            this.btnajbateau.Click += new System.EventHandler(this.BtnAjBateau_Click);
            // 
            // AjoutBateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 214);
            this.Controls.Add(this.btnajbateau);
            this.Controls.Add(this.gbxcapmax);
            this.Controls.Add(this.tbxnombateau);
            this.Controls.Add(this.lblnombateau);
            this.Name = "AjoutBateau";
            this.Text = "AjoutBateau";
            this.Load += new System.EventHandler(this.AjoutBateau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblnombateau;
        private System.Windows.Forms.TextBox tbxnombateau;
        private System.Windows.Forms.GroupBox gbxcapmax;
        private System.Windows.Forms.Button btnajbateau;
    }
}
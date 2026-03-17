namespace Atlantik
{
    partial class ModifBateau
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
            this.btnmodifier = new System.Windows.Forms.Button();
            this.cbxnombateau = new System.Windows.Forms.ComboBox();
            this.GbxCapMax = new System.Windows.Forms.GroupBox();
            this.lblnombateau = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnmodifier
            // 
            this.btnmodifier.Location = new System.Drawing.Point(156, 190);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(75, 23);
            this.btnmodifier.TabIndex = 0;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = true;
            this.btnmodifier.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxnombateau
            // 
            this.cbxnombateau.FormattingEnabled = true;
            this.cbxnombateau.Location = new System.Drawing.Point(124, 28);
            this.cbxnombateau.Name = "cbxnombateau";
            this.cbxnombateau.Size = new System.Drawing.Size(121, 21);
            this.cbxnombateau.TabIndex = 1;
            this.cbxnombateau.SelectedIndexChanged += new System.EventHandler(this.Cbxnombateau_SelectedIndexChanged);
            // 
            // GbxCapMax
            // 
            this.GbxCapMax.Location = new System.Drawing.Point(273, 28);
            this.GbxCapMax.Name = "GbxCapMax";
            this.GbxCapMax.Size = new System.Drawing.Size(221, 185);
            this.GbxCapMax.TabIndex = 2;
            this.GbxCapMax.TabStop = false;
            this.GbxCapMax.Text = "Capacités Maximales";
            // 
            // lblnombateau
            // 
            this.lblnombateau.AutoSize = true;
            this.lblnombateau.Location = new System.Drawing.Point(34, 31);
            this.lblnombateau.Name = "lblnombateau";
            this.lblnombateau.Size = new System.Drawing.Size(71, 13);
            this.lblnombateau.TabIndex = 0;
            this.lblnombateau.Text = "Nom bateau :";
            // 
            // ModifBateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 254);
            this.Controls.Add(this.lblnombateau);
            this.Controls.Add(this.GbxCapMax);
            this.Controls.Add(this.cbxnombateau);
            this.Controls.Add(this.btnmodifier);
            this.Name = "ModifBateau";
            this.Text = "ModifBateau";
            this.Load += new System.EventHandler(this.ModifBateau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.ComboBox cbxnombateau;
        private System.Windows.Forms.GroupBox GbxCapMax;
        private System.Windows.Forms.Label lblnombateau;
    }
}
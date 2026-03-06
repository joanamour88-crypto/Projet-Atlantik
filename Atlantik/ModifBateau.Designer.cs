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
            this.button1 = new System.Windows.Forms.Button();
            this.Cbxnombateau = new System.Windows.Forms.ComboBox();
            this.GbxCapMax = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Cbxnombateau
            // 
            this.Cbxnombateau.FormattingEnabled = true;
            this.Cbxnombateau.Location = new System.Drawing.Point(124, 28);
            this.Cbxnombateau.Name = "Cbxnombateau";
            this.Cbxnombateau.Size = new System.Drawing.Size(121, 21);
            this.Cbxnombateau.TabIndex = 1;
            this.Cbxnombateau.SelectedIndexChanged += new System.EventHandler(this.Cbxnombateau_SelectedIndexChanged);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom bateau :";
            // 
            // ModifBateau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 254);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GbxCapMax);
            this.Controls.Add(this.Cbxnombateau);
            this.Controls.Add(this.button1);
            this.Name = "ModifBateau";
            this.Text = "ModifBateau";
            this.Load += new System.EventHandler(this.ModifBateau_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox Cbxnombateau;
        private System.Windows.Forms.GroupBox GbxCapMax;
        private System.Windows.Forms.Label label1;
    }
}
namespace Atlantik
{
    partial class ModifParametre
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TbxMail = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Cbxenrpod = new System.Windows.Forms.CheckBox();
            this.TbxIdentifiant = new System.Windows.Forms.TextBox();
            this.TbxRang = new System.Windows.Forms.TextBox();
            this.TbxSite = new System.Windows.Forms.TextBox();
            this.TbxCleHMAC = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TbxIdentifiant);
            this.groupBox1.Controls.Add(this.TbxRang);
            this.groupBox1.Controls.Add(this.TbxSite);
            this.groupBox1.Controls.Add(this.TbxCleHMAC);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(284, 254);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Identifiants PayBox";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(93, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mail site :";
            // 
            // TbxMail
            // 
            this.TbxMail.Location = new System.Drawing.Point(150, 321);
            this.TbxMail.Name = "TbxMail";
            this.TbxMail.Size = new System.Drawing.Size(146, 20);
            this.TbxMail.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 362);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(146, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Modifier";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Cbxenrpod
            // 
            this.Cbxenrpod.AutoSize = true;
            this.Cbxenrpod.Location = new System.Drawing.Point(204, 287);
            this.Cbxenrpod.Name = "Cbxenrpod";
            this.Cbxenrpod.Size = new System.Drawing.Size(92, 17);
            this.Cbxenrpod.TabIndex = 3;
            this.Cbxenrpod.Text = "En production";
            this.Cbxenrpod.UseVisualStyleBackColor = true;
            // 
            // TbxIdentifiant
            // 
            this.TbxIdentifiant.Location = new System.Drawing.Point(99, 90);
            this.TbxIdentifiant.Name = "TbxIdentifiant";
            this.TbxIdentifiant.Size = new System.Drawing.Size(100, 20);
            this.TbxIdentifiant.TabIndex = 4;
            // 
            // TbxRang
            // 
            this.TbxRang.Location = new System.Drawing.Point(99, 64);
            this.TbxRang.Name = "TbxRang";
            this.TbxRang.Size = new System.Drawing.Size(100, 20);
            this.TbxRang.TabIndex = 5;
            // 
            // TbxSite
            // 
            this.TbxSite.Location = new System.Drawing.Point(99, 38);
            this.TbxSite.Name = "TbxSite";
            this.TbxSite.Size = new System.Drawing.Size(100, 20);
            this.TbxSite.TabIndex = 6;
            // 
            // TbxCleHMAC
            // 
            this.TbxCleHMAC.Location = new System.Drawing.Point(99, 116);
            this.TbxCleHMAC.Multiline = true;
            this.TbxCleHMAC.Name = "TbxCleHMAC";
            this.TbxCleHMAC.Size = new System.Drawing.Size(100, 107);
            this.TbxCleHMAC.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Clé HMAC :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Identifiant :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Rang :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Site :";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // ModifParametre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 450);
            this.Controls.Add(this.Cbxenrpod);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxMail);
            this.Controls.Add(this.groupBox1);
            this.Name = "ModifParametre";
            this.Text = "ModifParametre";
            this.Load += new System.EventHandler(this.ModifParametre_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbxMail;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox Cbxenrpod;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TbxIdentifiant;
        private System.Windows.Forms.TextBox TbxRang;
        private System.Windows.Forms.TextBox TbxSite;
        private System.Windows.Forms.TextBox TbxCleHMAC;
    }
}
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
            this.gbxidpaybox = new System.Windows.Forms.GroupBox();
            this.lblsite = new System.Windows.Forms.Label();
            this.lblrang = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.lblclehmac = new System.Windows.Forms.Label();
            this.tbxidentifiant = new System.Windows.Forms.TextBox();
            this.tbxrang = new System.Windows.Forms.TextBox();
            this.tbxsite = new System.Windows.Forms.TextBox();
            this.tbxclehmac = new System.Windows.Forms.TextBox();
            this.lblmailsite = new System.Windows.Forms.Label();
            this.tbxmail = new System.Windows.Forms.TextBox();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.cbxenrpod = new System.Windows.Forms.CheckBox();
            this.gbxidpaybox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbxidpaybox
            // 
            this.gbxidpaybox.Controls.Add(this.lblsite);
            this.gbxidpaybox.Controls.Add(this.lblrang);
            this.gbxidpaybox.Controls.Add(this.lblid);
            this.gbxidpaybox.Controls.Add(this.lblclehmac);
            this.gbxidpaybox.Controls.Add(this.tbxidentifiant);
            this.gbxidpaybox.Controls.Add(this.tbxrang);
            this.gbxidpaybox.Controls.Add(this.tbxsite);
            this.gbxidpaybox.Controls.Add(this.tbxclehmac);
            this.gbxidpaybox.Location = new System.Drawing.Point(12, 12);
            this.gbxidpaybox.Name = "gbxidpaybox";
            this.gbxidpaybox.Size = new System.Drawing.Size(284, 254);
            this.gbxidpaybox.TabIndex = 0;
            this.gbxidpaybox.TabStop = false;
            this.gbxidpaybox.Text = "Identifiants PayBox";
            // 
            // lblsite
            // 
            this.lblsite.AutoSize = true;
            this.lblsite.Location = new System.Drawing.Point(6, 41);
            this.lblsite.Name = "lblsite";
            this.lblsite.Size = new System.Drawing.Size(31, 13);
            this.lblsite.TabIndex = 11;
            this.lblsite.Text = "Site :";
            this.lblsite.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblrang
            // 
            this.lblrang.AutoSize = true;
            this.lblrang.Location = new System.Drawing.Point(6, 67);
            this.lblrang.Name = "lblrang";
            this.lblrang.Size = new System.Drawing.Size(39, 13);
            this.lblrang.TabIndex = 10;
            this.lblrang.Text = "Rang :";
            // 
            // lblid
            // 
            this.lblid.AutoSize = true;
            this.lblid.Location = new System.Drawing.Point(6, 93);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(59, 13);
            this.lblid.TabIndex = 9;
            this.lblid.Text = "Identifiant :";
            // 
            // lblclehmac
            // 
            this.lblclehmac.AutoSize = true;
            this.lblclehmac.Location = new System.Drawing.Point(6, 119);
            this.lblclehmac.Name = "lblclehmac";
            this.lblclehmac.Size = new System.Drawing.Size(62, 13);
            this.lblclehmac.TabIndex = 8;
            this.lblclehmac.Text = "Clé HMAC :";
            // 
            // tbxidentifiant
            // 
            this.tbxidentifiant.Location = new System.Drawing.Point(99, 90);
            this.tbxidentifiant.Name = "tbxidentifiant";
            this.tbxidentifiant.Size = new System.Drawing.Size(100, 20);
            this.tbxidentifiant.TabIndex = 4;
            this.tbxidentifiant.TextChanged += new System.EventHandler(this.tbxidentifiant_TextChanged);
            // 
            // tbxrang
            // 
            this.tbxrang.Location = new System.Drawing.Point(99, 64);
            this.tbxrang.Name = "tbxrang";
            this.tbxrang.Size = new System.Drawing.Size(100, 20);
            this.tbxrang.TabIndex = 5;
            this.tbxrang.TextChanged += new System.EventHandler(this.tbxrang_TextChanged);
            // 
            // tbxsite
            // 
            this.tbxsite.Location = new System.Drawing.Point(99, 38);
            this.tbxsite.Name = "tbxsite";
            this.tbxsite.Size = new System.Drawing.Size(100, 20);
            this.tbxsite.TabIndex = 6;
            this.tbxsite.TextChanged += new System.EventHandler(this.tbxsite_TextChanged);
            this.tbxsite.Validating += new System.ComponentModel.CancelEventHandler(this.tbxsite_Validating);
            // 
            // tbxclehmac
            // 
            this.tbxclehmac.Location = new System.Drawing.Point(99, 116);
            this.tbxclehmac.Multiline = true;
            this.tbxclehmac.Name = "tbxclehmac";
            this.tbxclehmac.Size = new System.Drawing.Size(100, 107);
            this.tbxclehmac.TabIndex = 7;
            // 
            // lblmailsite
            // 
            this.lblmailsite.AutoSize = true;
            this.lblmailsite.Location = new System.Drawing.Point(93, 324);
            this.lblmailsite.Name = "lblmailsite";
            this.lblmailsite.Size = new System.Drawing.Size(51, 13);
            this.lblmailsite.TabIndex = 0;
            this.lblmailsite.Text = "Mail site :";
            // 
            // tbxmail
            // 
            this.tbxmail.Location = new System.Drawing.Point(150, 321);
            this.tbxmail.Name = "tbxmail";
            this.tbxmail.Size = new System.Drawing.Size(146, 20);
            this.tbxmail.TabIndex = 1;
            // 
            // btnmodifier
            // 
            this.btnmodifier.Location = new System.Drawing.Point(150, 362);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(146, 23);
            this.btnmodifier.TabIndex = 2;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = true;
            this.btnmodifier.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbxenrpod
            // 
            this.cbxenrpod.AutoSize = true;
            this.cbxenrpod.Location = new System.Drawing.Point(204, 287);
            this.cbxenrpod.Name = "cbxenrpod";
            this.cbxenrpod.Size = new System.Drawing.Size(92, 17);
            this.cbxenrpod.TabIndex = 3;
            this.cbxenrpod.Text = "En production";
            this.cbxenrpod.UseVisualStyleBackColor = true;
            // 
            // ModifParametre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 450);
            this.Controls.Add(this.cbxenrpod);
            this.Controls.Add(this.btnmodifier);
            this.Controls.Add(this.lblmailsite);
            this.Controls.Add(this.tbxmail);
            this.Controls.Add(this.gbxidpaybox);
            this.Name = "ModifParametre";
            this.Text = "ModifParametre";
            this.Load += new System.EventHandler(this.ModifParametre_Load);
            this.gbxidpaybox.ResumeLayout(false);
            this.gbxidpaybox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxidpaybox;
        private System.Windows.Forms.Label lblmailsite;
        private System.Windows.Forms.TextBox tbxmail;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.CheckBox cbxenrpod;
        private System.Windows.Forms.Label lblsite;
        private System.Windows.Forms.Label lblrang;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.Label lblclehmac;
        private System.Windows.Forms.TextBox tbxidentifiant;
        private System.Windows.Forms.TextBox tbxrang;
        private System.Windows.Forms.TextBox tbxsite;
        private System.Windows.Forms.TextBox tbxclehmac;
    }
}
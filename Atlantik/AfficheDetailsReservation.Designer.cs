namespace Atlantik
{
    partial class AfficheDetailsReservation
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
            this.cmbnomclient = new System.Windows.Forms.ComboBox();
            this.lblnomprenom = new System.Windows.Forms.Label();
            this.gbxreservation = new System.Windows.Forms.GroupBox();
            this.lvdetailreserv = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // cmbnomclient
            // 
            this.cmbnomclient.FormattingEnabled = true;
            this.cmbnomclient.Location = new System.Drawing.Point(117, 44);
            this.cmbnomclient.Name = "cmbnomclient";
            this.cmbnomclient.Size = new System.Drawing.Size(121, 21);
            this.cmbnomclient.TabIndex = 0;
            this.cmbnomclient.SelectedIndexChanged += new System.EventHandler(this.Cbxnomclient_SelectedIndexChanged);
            // 
            // lblnomprenom
            // 
            this.lblnomprenom.AutoSize = true;
            this.lblnomprenom.Location = new System.Drawing.Point(34, 47);
            this.lblnomprenom.Name = "lblnomprenom";
            this.lblnomprenom.Size = new System.Drawing.Size(77, 13);
            this.lblnomprenom.TabIndex = 1;
            this.lblnomprenom.Text = "Nom, Prénom :";
            // 
            // gbxreservation
            // 
            this.gbxreservation.Location = new System.Drawing.Point(254, 191);
            this.gbxreservation.Name = "gbxreservation";
            this.gbxreservation.Size = new System.Drawing.Size(242, 174);
            this.gbxreservation.TabIndex = 3;
            this.gbxreservation.TabStop = false;
            this.gbxreservation.Text = "Réservation";
            // 
            // lvdetailreserv
            // 
            this.lvdetailreserv.HideSelection = false;
            this.lvdetailreserv.Location = new System.Drawing.Point(254, 44);
            this.lvdetailreserv.Name = "lvdetailreserv";
            this.lvdetailreserv.Size = new System.Drawing.Size(390, 130);
            this.lvdetailreserv.TabIndex = 4;
            this.lvdetailreserv.UseCompatibleStateImageBehavior = false;
            this.lvdetailreserv.SelectedIndexChanged += new System.EventHandler(this.Lvdetailreserv_SelectedIndexChanged);
            // 
            // AfficheDetailsReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lvdetailreserv);
            this.Controls.Add(this.gbxreservation);
            this.Controls.Add(this.lblnomprenom);
            this.Controls.Add(this.cmbnomclient);
            this.Name = "AfficheDetailsReservation";
            this.Text = "Affichedetailsreservation";
            this.Load += new System.EventHandler(this.Affichedetailsreservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbnomclient;
        private System.Windows.Forms.Label lblnomprenom;
        private System.Windows.Forms.GroupBox gbxreservation;
        private System.Windows.Forms.ListView lvdetailreserv;
    }
}
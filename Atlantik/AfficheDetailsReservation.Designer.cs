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
            this.Cbxnomclient = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Gbxreservation = new System.Windows.Forms.GroupBox();
            this.Lvdetailreserv = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // Cbxnomclient
            // 
            this.Cbxnomclient.FormattingEnabled = true;
            this.Cbxnomclient.Location = new System.Drawing.Point(117, 44);
            this.Cbxnomclient.Name = "Cbxnomclient";
            this.Cbxnomclient.Size = new System.Drawing.Size(121, 21);
            this.Cbxnomclient.TabIndex = 0;
            this.Cbxnomclient.SelectedIndexChanged += new System.EventHandler(this.Cbxnomclient_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nom, Prénom :";
            // 
            // Gbxreservation
            // 
            this.Gbxreservation.Location = new System.Drawing.Point(254, 191);
            this.Gbxreservation.Name = "Gbxreservation";
            this.Gbxreservation.Size = new System.Drawing.Size(242, 174);
            this.Gbxreservation.TabIndex = 3;
            this.Gbxreservation.TabStop = false;
            this.Gbxreservation.Text = "Réservation";
            // 
            // Lvdetailreserv
            // 
            this.Lvdetailreserv.HideSelection = false;
            this.Lvdetailreserv.Location = new System.Drawing.Point(254, 44);
            this.Lvdetailreserv.Name = "Lvdetailreserv";
            this.Lvdetailreserv.Size = new System.Drawing.Size(390, 130);
            this.Lvdetailreserv.TabIndex = 4;
            this.Lvdetailreserv.UseCompatibleStateImageBehavior = false;
            this.Lvdetailreserv.SelectedIndexChanged += new System.EventHandler(this.Lvdetailreserv_SelectedIndexChanged);
            // 
            // AfficheDetailsReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Lvdetailreserv);
            this.Controls.Add(this.Gbxreservation);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cbxnomclient);
            this.Name = "AfficheDetailsReservation";
            this.Text = "Affichedetailsreservation";
            this.Load += new System.EventHandler(this.Affichedetailsreservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cbxnomclient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Gbxreservation;
        private System.Windows.Forms.ListView Lvdetailreserv;
    }
}
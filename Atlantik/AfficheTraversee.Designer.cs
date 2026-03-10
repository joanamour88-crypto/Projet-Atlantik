namespace Atlantik
{
    partial class AfficheTraversee
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
            this.Cbxliaison = new System.Windows.Forms.ComboBox();
            this.Btnafftraverse = new System.Windows.Forms.Button();
            this.Lstsect = new System.Windows.Forms.ListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LvTraversee = new System.Windows.Forms.ListView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Cbxliaison
            // 
            this.Cbxliaison.FormattingEnabled = true;
            this.Cbxliaison.Location = new System.Drawing.Point(52, 262);
            this.Cbxliaison.Name = "Cbxliaison";
            this.Cbxliaison.Size = new System.Drawing.Size(121, 21);
            this.Cbxliaison.TabIndex = 0;
            // 
            // Btnafftraverse
            // 
            this.Btnafftraverse.Location = new System.Drawing.Point(226, 103);
            this.Btnafftraverse.Name = "Btnafftraverse";
            this.Btnafftraverse.Size = new System.Drawing.Size(448, 23);
            this.Btnafftraverse.TabIndex = 1;
            this.Btnafftraverse.Text = "Afficher les traversées";
            this.Btnafftraverse.UseVisualStyleBackColor = true;
            this.Btnafftraverse.Click += new System.EventHandler(this.Btnafftraverse_Click);
            // 
            // Lstsect
            // 
            this.Lstsect.FormattingEnabled = true;
            this.Lstsect.Location = new System.Drawing.Point(53, 60);
            this.Lstsect.Name = "Lstsect";
            this.Lstsect.Size = new System.Drawing.Size(120, 173);
            this.Lstsect.TabIndex = 2;
            this.Lstsect.SelectedIndexChanged += new System.EventHandler(this.Lstsect_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(474, 60);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Secteurs :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Liaison :";
            // 
            // LvTraversee
            // 
            this.LvTraversee.HideSelection = false;
            this.LvTraversee.Location = new System.Drawing.Point(226, 162);
            this.LvTraversee.Name = "LvTraversee";
            this.LvTraversee.Size = new System.Drawing.Size(448, 214);
            this.LvTraversee.TabIndex = 6;
            this.LvTraversee.UseCompatibleStateImageBehavior = false;
            this.LvTraversee.SelectedIndexChanged += new System.EventHandler(this.LvTraversee_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(301, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Date (par défault date du jour) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(223, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Traversée";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(515, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Places disponibles par catégorie";
            // 
            // AfficheTraversee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LvTraversee);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.Lstsect);
            this.Controls.Add(this.Btnafftraverse);
            this.Controls.Add(this.Cbxliaison);
            this.Name = "AfficheTraversee";
            this.Text = "AfficheTraversee";
            this.Load += new System.EventHandler(this.AfficheTraversee_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Cbxliaison;
        private System.Windows.Forms.Button Btnafftraverse;
        private System.Windows.Forms.ListBox Lstsect;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView LvTraversee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
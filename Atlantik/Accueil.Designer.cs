namespace Atlantik
{
    partial class Accueil
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Accueil));
            this.Titre = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajouterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unSecteurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unPortToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uneLiaisonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesTarifsPourUneLiaisonEtUnePeriodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unBateauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uneTraverserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modifierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unBateauToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lesParamètresDuSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afficherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégorieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lesDétailsDuneRéservationPourUnClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aProposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Titre
            // 
            this.Titre.AutoSize = true;
            this.Titre.Location = new System.Drawing.Point(437, 63);
            this.Titre.Name = "Titre";
            this.Titre.Size = new System.Drawing.Size(42, 13);
            this.Titre.TabIndex = 0;
            this.Titre.Text = "Atlantik";
            this.Titre.Click += new System.EventHandler(this.Titre_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterToolStripMenuItem,
            this.modifierToolStripMenuItem,
            this.afficherToolStripMenuItem,
            this.aProposToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(998, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ajouterToolStripMenuItem
            // 
            this.ajouterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unSecteurToolStripMenuItem,
            this.unPortToolStripMenuItem,
            this.uneLiaisonToolStripMenuItem,
            this.lesTarifsPourUneLiaisonEtUnePeriodeToolStripMenuItem,
            this.unBateauToolStripMenuItem,
            this.uneTraverserToolStripMenuItem});
            this.ajouterToolStripMenuItem.Name = "ajouterToolStripMenuItem";
            this.ajouterToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.ajouterToolStripMenuItem.Text = "Ajouter";
            this.ajouterToolStripMenuItem.Click += new System.EventHandler(this.ajouterToolStripMenuItem_Click);
            // 
            // unSecteurToolStripMenuItem
            // 
            this.unSecteurToolStripMenuItem.Name = "unSecteurToolStripMenuItem";
            this.unSecteurToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.unSecteurToolStripMenuItem.Text = "Un secteur";
            this.unSecteurToolStripMenuItem.Click += new System.EventHandler(this.unSecteurToolStripMenuItem_Click);
            // 
            // unPortToolStripMenuItem
            // 
            this.unPortToolStripMenuItem.Name = "unPortToolStripMenuItem";
            this.unPortToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.unPortToolStripMenuItem.Text = "Un port";
            this.unPortToolStripMenuItem.Click += new System.EventHandler(this.unPortToolStripMenuItem_Click);
            // 
            // uneLiaisonToolStripMenuItem
            // 
            this.uneLiaisonToolStripMenuItem.Name = "uneLiaisonToolStripMenuItem";
            this.uneLiaisonToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.uneLiaisonToolStripMenuItem.Text = "Une liaison";
            this.uneLiaisonToolStripMenuItem.Click += new System.EventHandler(this.uneLiaisonToolStripMenuItem_Click);
            // 
            // lesTarifsPourUneLiaisonEtUnePeriodeToolStripMenuItem
            // 
            this.lesTarifsPourUneLiaisonEtUnePeriodeToolStripMenuItem.Name = "lesTarifsPourUneLiaisonEtUnePeriodeToolStripMenuItem";
            this.lesTarifsPourUneLiaisonEtUnePeriodeToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.lesTarifsPourUneLiaisonEtUnePeriodeToolStripMenuItem.Text = "Les tarifs pour une liaison et une periode";
            this.lesTarifsPourUneLiaisonEtUnePeriodeToolStripMenuItem.Click += new System.EventHandler(this.lesTarifsPourUneLiaisonEtUnePeriodeToolStripMenuItem_Click);
            // 
            // unBateauToolStripMenuItem
            // 
            this.unBateauToolStripMenuItem.Name = "unBateauToolStripMenuItem";
            this.unBateauToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.unBateauToolStripMenuItem.Text = "Un bateau";
            this.unBateauToolStripMenuItem.Click += new System.EventHandler(this.unBateauToolStripMenuItem_Click);
            // 
            // uneTraverserToolStripMenuItem
            // 
            this.uneTraverserToolStripMenuItem.Name = "uneTraverserToolStripMenuItem";
            this.uneTraverserToolStripMenuItem.Size = new System.Drawing.Size(287, 22);
            this.uneTraverserToolStripMenuItem.Text = "Une traversée";
            this.uneTraverserToolStripMenuItem.Click += new System.EventHandler(this.uneTraverserToolStripMenuItem_Click);
            // 
            // modifierToolStripMenuItem
            // 
            this.modifierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.unBateauToolStripMenuItem1,
            this.lesParamètresDuSiteToolStripMenuItem});
            this.modifierToolStripMenuItem.Name = "modifierToolStripMenuItem";
            this.modifierToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.modifierToolStripMenuItem.Text = "Modifier";
            // 
            // unBateauToolStripMenuItem1
            // 
            this.unBateauToolStripMenuItem1.Name = "unBateauToolStripMenuItem1";
            this.unBateauToolStripMenuItem1.Size = new System.Drawing.Size(191, 22);
            this.unBateauToolStripMenuItem1.Text = "Un bateau";
            this.unBateauToolStripMenuItem1.Click += new System.EventHandler(this.unBateauToolStripMenuItem1_Click);
            // 
            // lesParamètresDuSiteToolStripMenuItem
            // 
            this.lesParamètresDuSiteToolStripMenuItem.Name = "lesParamètresDuSiteToolStripMenuItem";
            this.lesParamètresDuSiteToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.lesParamètresDuSiteToolStripMenuItem.Text = "Les paramètres du site";
            this.lesParamètresDuSiteToolStripMenuItem.Click += new System.EventHandler(this.lesParamètresDuSiteToolStripMenuItem_Click);
            // 
            // afficherToolStripMenuItem
            // 
            this.afficherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégorieToolStripMenuItem,
            this.lesDétailsDuneRéservationPourUnClientToolStripMenuItem});
            this.afficherToolStripMenuItem.Name = "afficherToolStripMenuItem";
            this.afficherToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.afficherToolStripMenuItem.Text = "Afficher";
            // 
            // lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégorieToolStripMenuItem
            // 
            this.lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégorieToolStripMenuItem.Name = "lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégorieToolStri" +
    "pMenuItem";
            this.lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégorieToolStripMenuItem.Size = new System.Drawing.Size(524, 22);
            this.lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégorieToolStripMenuItem.Text = "Les traversées pour une liaison et une date donnée avec places restantes par caté" +
    "gorie";
            this.lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégorieToolStripMenuItem.Click += new System.EventHandler(this.lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégorieToolStripMenuItem_Click);
            // 
            // lesDétailsDuneRéservationPourUnClientToolStripMenuItem
            // 
            this.lesDétailsDuneRéservationPourUnClientToolStripMenuItem.Name = "lesDétailsDuneRéservationPourUnClientToolStripMenuItem";
            this.lesDétailsDuneRéservationPourUnClientToolStripMenuItem.Size = new System.Drawing.Size(524, 22);
            this.lesDétailsDuneRéservationPourUnClientToolStripMenuItem.Text = "Les détails d\'une réservation pour un client";
            this.lesDétailsDuneRéservationPourUnClientToolStripMenuItem.Click += new System.EventHandler(this.lesDétailsDuneRéservationPourUnClientToolStripMenuItem_Click);
            // 
            // aProposToolStripMenuItem
            // 
            this.aProposToolStripMenuItem.Name = "aProposToolStripMenuItem";
            this.aProposToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.aProposToolStripMenuItem.Text = "A Propos";
            // 
            // Accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(998, 482);
            this.Controls.Add(this.Titre);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Accueil";
            this.Text = "Atlantik";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Titre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajouterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modifierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aProposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unSecteurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unPortToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uneLiaisonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesTarifsPourUneLiaisonEtUnePeriodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unBateauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uneTraverserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unBateauToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lesParamètresDuSiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesTraverséesPourUneLiaisonEtUneDateDonnéeAvecPlacesRestantesParCatégorieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lesDétailsDuneRéservationPourUnClientToolStripMenuItem;
    }
}


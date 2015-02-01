namespace ProjetDesignPattern
{
    partial class FenPrincipale
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bChargement = new System.Windows.Forms.Button();
            this.cheminXML = new System.Windows.Forms.TextBox();
            this.bLancer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 43);
            this.button1.TabIndex = 0;
            this.button1.Text = "Defence Tower";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(104, 206);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(86, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Jeu d\'échecs 2.0";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(195, 206);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(86, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "Simu Traffic";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Meta-Simulateur";
            // 
            // bChargement
            // 
            this.bChargement.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bChargement.Location = new System.Drawing.Point(60, 58);
            this.bChargement.Name = "bChargement";
            this.bChargement.Size = new System.Drawing.Size(184, 31);
            this.bChargement.TabIndex = 4;
            this.bChargement.Text = "Charger un jeu";
            this.bChargement.UseVisualStyleBackColor = true;
            this.bChargement.Click += new System.EventHandler(this.bChargement_Click);
            // 
            // cheminXML
            // 
            this.cheminXML.Location = new System.Drawing.Point(12, 95);
            this.cheminXML.Name = "cheminXML";
            this.cheminXML.ReadOnly = true;
            this.cheminXML.Size = new System.Drawing.Size(267, 20);
            this.cheminXML.TabIndex = 5;
            // 
            // bLancer
            // 
            this.bLancer.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLancer.Location = new System.Drawing.Point(60, 133);
            this.bLancer.Name = "bLancer";
            this.bLancer.Size = new System.Drawing.Size(184, 46);
            this.bLancer.TabIndex = 6;
            this.bLancer.Text = "Lancer";
            this.bLancer.UseVisualStyleBackColor = true;
            this.bLancer.Click += new System.EventHandler(this.bLancer_Click);
            // 
            // FenPrincipale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 258);
            this.Controls.Add(this.bLancer);
            this.Controls.Add(this.cheminXML);
            this.Controls.Add(this.bChargement);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FenPrincipale";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bChargement;
        private System.Windows.Forms.TextBox cheminXML;
        private System.Windows.Forms.Button bLancer;
    }
}


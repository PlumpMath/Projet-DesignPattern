namespace ProjetDesignPattern.JeuEchecs
{
	partial class IHM_Echecs
	{

		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox[] cases;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}


		private void InitializeComponent(Simulation jeu)
		{
			if (jeu != null) {
				int len = jeu.listeZones.Count, maxX = 0, maxY = 0;
				int size = 30;
				cases = new System.Windows.Forms.PictureBox[len];
				for(int i = 0 ; i < len ; i++){
					cases[i] = new System.Windows.Forms.PictureBox();
					((System.ComponentModel.ISupportInitialize)(cases[i])).BeginInit();
					this.SuspendLayout();
					cases[i].Location = new System.Drawing.Point(size * jeu.listeZones[i].positionX, size * jeu.listeZones[i].positionY);
					cases[i].Name = jeu.listeZones[i].positionX + "," + jeu.listeZones[i].positionY;
					cases[i].Size = new System.Drawing.Size(size, size);
					cases[i].TabIndex = i;
					cases[i].TabStop = false;
					cases[i].Click += new System.EventHandler(this.imageClick);
					cases[i].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
					if (jeu.listeZones [i].positionX % 2 == 0) {
						if (jeu.listeZones [i].positionY % 2 == 0) {
							cases [i].BackColor = System.Drawing.Color.DarkGray;
						} else {
							cases [i].BackColor = System.Drawing.Color.WhiteSmoke;
						}
					} else {
						if (jeu.listeZones [i].positionY % 2 == 0) {
							cases [i].BackColor = System.Drawing.Color.WhiteSmoke;
						} else {
							cases [i].BackColor = System.Drawing.Color.DarkGray;
						}
					}

					if (jeu.listeZones [i].listePersonnages.Count > 0) {
						PersonnageAbstrait p = jeu.listeZones [i].listePersonnages [0];
						 if (p.Nom == "BB") {
							cases [i].BackgroundImage = ProjetDesignPattern.Properties.Resources.BB;
						} else if (p.Nom == "BC") {
							cases [i].BackgroundImage = ProjetDesignPattern.Properties.Resources.BC;
						} else if (p.Nom == "BK") {
							cases [i].BackgroundImage = ProjetDesignPattern.Properties.Resources.BK;
						} else if (p.Nom == "BP") {
							cases [i].BackgroundImage = ProjetDesignPattern.Properties.Resources.BP;
						} else if (p.Nom == "BQ") {
							cases [i].BackgroundImage = ProjetDesignPattern.Properties.Resources.BQ;
						} else if (p.Nom == "BR") {
							cases [i].BackgroundImage = ProjetDesignPattern.Properties.Resources.BR;
						} else if (p.Nom == "WB") {
							cases [i].BackgroundImage = ProjetDesignPattern.Properties.Resources.WB;
						} else if (p.Nom == "WC") {
							cases [i].BackgroundImage = ProjetDesignPattern.Properties.Resources.WC;
						} else if (p.Nom == "WK") {
							cases [i].BackgroundImage = ProjetDesignPattern.Properties.Resources.WK;
						} else if (p.Nom == "WP") {
							cases [i].BackgroundImage = ProjetDesignPattern.Properties.Resources.WP;
						} else if (p.Nom == "WQ") {
							cases [i].BackgroundImage = ProjetDesignPattern.Properties.Resources.WQ;
						} else if (p.Nom == "WR") {
							cases [i].BackgroundImage = ProjetDesignPattern.Properties.Resources.WR;
						} 
					}

					((System.ComponentModel.ISupportInitialize)(cases[i])).EndInit();

					this.Controls.Add(cases[i]);
					if (maxX < jeu.listeZones [i].positionX)
						maxX = jeu.listeZones [i].positionX;
					if (maxY < jeu.listeZones [i].positionY)
						maxY = jeu.listeZones [i].positionY;
				}
	
				this.AutoScaleDimensions = new System.Drawing.SizeF(1F, 1F);
				this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
				this.ClientSize = new System.Drawing.Size(size * ++maxX, size * ++maxY);
				this.ResumeLayout(false);
			}

		}

	}
}
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
						cases [i].BackgroundImage = getImage (p.Nom);						 
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

		public System.Drawing.Image getImage(string name){
			if (name == "BB") {
				return ProjetDesignPattern.Properties.Resources.BB;
			} else if (name == "BC") {
				return ProjetDesignPattern.Properties.Resources.BC;
			} else if (name == "BK") {
				return ProjetDesignPattern.Properties.Resources.BK;
			} else if (name == "BP") {
				return ProjetDesignPattern.Properties.Resources.BP;
			} else if (name == "BQ") {
				return ProjetDesignPattern.Properties.Resources.BQ;
			} else if (name == "BR") {
				return ProjetDesignPattern.Properties.Resources.BR;
			} else if (name == "WB") {
				return ProjetDesignPattern.Properties.Resources.WB;
			} else if (name == "WC") {
				return ProjetDesignPattern.Properties.Resources.WC;
			} else if (name == "WK") {
				return ProjetDesignPattern.Properties.Resources.WK;
			} else if (name == "WP") {
				return ProjetDesignPattern.Properties.Resources.WP;
			} else if (name == "WQ") {
				return ProjetDesignPattern.Properties.Resources.WQ;
			} else if (name == "WR") {
				return ProjetDesignPattern.Properties.Resources.WR;
			} 
			return null;
		}

		public void setCaseImage(Location l, string imageName){
			for (int i = 0; i < cases.Length; i++) {
				if (cases [i].Name == l.name) {
					if (imageName == null) {
						cases [i].BackgroundImage = null;
					} else {
						cases [i].BackgroundImage = getImage (imageName);
					}
				}
			}
		}
	}
}
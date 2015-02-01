namespace ProjetDesignPattern.JeuEchecs
{
	partial class IHM_Echecs
	{

		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox[] cases;
		private System.Windows.Forms.Label indicateur;
		private System.Windows.Forms.Button abort;

		private int boxSize, maxX, maxY;

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
				initBoxSize ();
				int len = jeu.listeZones.Count;

				cases = new System.Windows.Forms.PictureBox[len];
				for(int i = 0 ; i < len ; i++){
					cases[i] = new System.Windows.Forms.PictureBox();
					((System.ComponentModel.ISupportInitialize)(cases[i])).BeginInit();
					this.SuspendLayout();
					cases[i].Location = new System.Drawing.Point(boxSize * jeu.listeZones[i].positionX, boxSize * jeu.listeZones[i].positionY);
					cases[i].Name = jeu.listeZones[i].positionX + "," + jeu.listeZones[i].positionY;
					cases[i].Size = new System.Drawing.Size(boxSize, boxSize);
					cases[i].TabIndex = i;
					cases[i].TabStop = false;
					cases[i].Click += new System.EventHandler(this.imageClick);
					cases[i].BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
					resetCaseColor (i, jeu.listeZones [i].positionX, jeu.listeZones [i].positionY);

					if (jeu.listeZones [i].listePersonnages.Count > 0) {
						PersonnageAbstrait p = jeu.listeZones [i].listePersonnages [0];
						cases [i].BackgroundImage = getImage (p.Nom);						 
					}

					((System.ComponentModel.ISupportInitialize)(cases[i])).EndInit();

					this.Controls.Add(cases[i]);
				}
				initFenetre ();
			}

		}

		public void initBoxSize(){
			int len = jeu.listeZones.Count, a, b;
			for(int i = 0 ; i < len ; i++){
				if (maxX < jeu.listeZones [i].positionX)
					maxX = jeu.listeZones [i].positionX ;
				if (maxY < jeu.listeZones [i].positionY)
					maxY = jeu.listeZones [i].positionY;
			}
			System.Drawing.Rectangle resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
			a = ((maxX+3) > (maxY + 3))?(maxX+3):(maxY + 3);
			b = (resolution.Height < resolution.Width) ? resolution.Height : resolution.Width;
			b = System.Convert.ToInt32 (b * 0.9);
			boxSize = b / a;
		}

		public void initFenetre(){
			this.indicateur = new System.Windows.Forms.Label ();
			this.indicateur.Size = new System.Drawing.Size(boxSize * ++maxX, boxSize);
			this.indicateur.Location = new System.Drawing.Point(0, boxSize * ++maxY);
			this.indicateur.Text = "Tour blanc";
			this.indicateur.AutoSize = true;
			this.indicateur.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Controls.Add (this.indicateur);

			this.abort = new System.Windows.Forms.Button ();
			this.abort.Size  = new System.Drawing.Size(boxSize * (maxX-2), boxSize);
			this.abort.Location = new System.Drawing.Point(boxSize, boxSize * ++maxY);
			this.abort.Text = "Abandonner";
			this.abort.AutoSize = true;
			this.abort.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.abort.Click += new System.EventHandler(this.fin);

			this.Controls.Add (this.abort);

			this.AutoScaleDimensions = new System.Drawing.SizeF(1F, 1F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(boxSize * maxX, boxSize * ++maxY);
			this.AutoSize = false;
			this.ResumeLayout(false);

			System.Drawing.Rectangle resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds;
			this.Location = new System.Drawing.Point ((resolution.Width /2) - ((boxSize * maxX) /2), (resolution.Height /2) - ((boxSize * maxY) /2));
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

		public void colorCase(int caseIndex, System.Drawing.Color color){
			cases [caseIndex].BackColor = color;
		}
		private void colorCase(Location caseLocation, System.Drawing.Color color){
			for (int i = 0; i < cases.Length; i++) {
				if (cases [i].Name == caseLocation.name) {
					colorCase (i, color);
					break;
				}
			}
		}

		public void resetCaseColor(int i, Location l){
			if (l.x % 2 == 0) {
				if (l.y % 2 == 0) {
					cases [i].BackColor = System.Drawing.Color.DarkGray;
				} else {
					cases [i].BackColor = System.Drawing.Color.WhiteSmoke;
				}
			} else {
				if (l.y % 2 == 0) {
					cases [i].BackColor = System.Drawing.Color.WhiteSmoke;
				} else {
					cases [i].BackColor = System.Drawing.Color.DarkGray;
				}
			}
		}

		private void resetCaseColor(int i, int x, int y){
			resetCaseColor (i, new ProjetDesignPattern.Location (x, y));
		}
	}
}
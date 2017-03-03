namespace SuperAdventure
{
	partial class SuperAdventure
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
			this.label1 = new System.Windows.Forms.Label();
			this.lblHitPoints = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.lblGold = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.lblExperience = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.lblLevel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(18, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Hit Points:";
			// 
			// lblHitPoints
			// 
			this.lblHitPoints.AutoSize = true;
			this.lblHitPoints.Location = new System.Drawing.Point(110, 19);
			this.lblHitPoints.Name = "lblHitPoints";
			this.lblHitPoints.Size = new System.Drawing.Size(35, 13);
			this.lblHitPoints.TabIndex = 1;
			this.lblHitPoints.Text = "label2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(18, 46);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Gold:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblGold
			// 
			this.lblGold.AutoSize = true;
			this.lblGold.Location = new System.Drawing.Point(110, 45);
			this.lblGold.Name = "lblGold";
			this.lblGold.Size = new System.Drawing.Size(35, 13);
			this.lblGold.TabIndex = 3;
			this.lblGold.Text = "label4";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(18, 74);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(63, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Experience:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lblExperience
			// 
			this.lblExperience.AutoSize = true;
			this.lblExperience.Location = new System.Drawing.Point(110, 73);
			this.lblExperience.Name = "lblExperience";
			this.lblExperience.Size = new System.Drawing.Size(35, 13);
			this.lblExperience.TabIndex = 5;
			this.lblExperience.Text = "label6";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(18, 100);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(36, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "Level:";
			// 
			// lblLevel
			// 
			this.lblLevel.AutoSize = true;
			this.lblLevel.Location = new System.Drawing.Point(110, 99);
			this.lblLevel.Name = "lblLevel";
			this.lblLevel.Size = new System.Drawing.Size(35, 13);
			this.lblLevel.TabIndex = 7;
			this.lblLevel.Text = "label8";
			// 
			// SuperAdventure
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(719, 651);
			this.Controls.Add(this.lblLevel);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.lblExperience);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.lblGold);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lblHitPoints);
			this.Controls.Add(this.label1);
			this.Name = "SuperAdventure";
			this.Text = "My Game";
			this.Load += new System.EventHandler(this.SuperAdventure_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblHitPoints;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lblGold;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label lblExperience;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label lblLevel;
	}
}


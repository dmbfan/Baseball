namespace Baseball_Statistics
{
    partial class Search
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
            this.boxLeague = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTeam = new System.Windows.Forms.Label();
            this.boxTeam = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // boxLeague
            // 
            this.boxLeague.FormattingEnabled = true;
            this.boxLeague.Items.AddRange(new object[] {
            "American",
            "National"});
            this.boxLeague.Location = new System.Drawing.Point(50, 101);
            this.boxLeague.Name = "boxLeague";
            this.boxLeague.Size = new System.Drawing.Size(121, 21);
            this.boxLeague.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select A League";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Location = new System.Drawing.Point(62, 153);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(34, 13);
            this.lblTeam.TabIndex = 2;
            this.lblTeam.Text = "Team";
            // 
            // boxTeam
            // 
            this.boxTeam.FormattingEnabled = true;
            this.boxTeam.Items.AddRange(new object[] {
            "Baltimore Orioles",
            "Boston Red Sox",
            "Tampa Bay Rays",
            "Toronto Blue Jays",
            "New York Yankees",
            "Chicago White Sox",
            "Detroit Tigers",
            "Kansas City Royals",
            "Cleveland Indians",
            "Minnesota Twins",
            "Texas Rangers",
            "Seattle Mariners",
            "Los Angelas Anehiem Angels",
            "Houston Astros",
            "Washington Nationals",
            "New York Mets",
            "Phillidelphia Phillies",
            "Atlanta Braves",
            "Chicago Cubs",
            "Pittsburgh Pirates",
            "St. Louis Cardinals",
            "Cincinatti Reds",
            "Milwaukee Brewers",
            "San Fransisco Giants",
            "Los Angels Dodgers",
            "Colorado Rockies",
            "Arizona Diamondbacks",
            "San Diego Padres"});
            this.boxTeam.Location = new System.Drawing.Point(50, 188);
            this.boxTeam.Name = "boxTeam";
            this.boxTeam.Size = new System.Drawing.Size(121, 21);
            this.boxTeam.TabIndex = 3;
            // 
            // Search
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 482);
            this.Controls.Add(this.boxTeam);
            this.Controls.Add(this.lblTeam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxLeague);
            this.Name = "Search";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.Search_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox boxLeague;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.ComboBox boxTeam;
    }
}


namespace Course
{
    partial class fShowPoster
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lTitle = new System.Windows.Forms.Label();
            this.lDate = new System.Windows.Forms.Label();
            this.lTime = new System.Windows.Forms.Label();
            this.lLocation = new System.Windows.Forms.Label();
            this.lPrise = new System.Windows.Forms.Label();
            this.lArt = new System.Windows.Forms.Label();
            this.lPr = new System.Windows.Forms.Label();
            this.lScreen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Segoe Print", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTitle.ForeColor = System.Drawing.Color.Red;
            this.lTitle.Location = new System.Drawing.Point(85, 32);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(93, 54);
            this.lTitle.TabIndex = 0;
            this.lTitle.Text = "Title";
            // 
            // lDate
            // 
            this.lDate.AutoSize = true;
            this.lDate.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lDate.ForeColor = System.Drawing.Color.Blue;
            this.lDate.Location = new System.Drawing.Point(47, 112);
            this.lDate.Name = "lDate";
            this.lDate.Size = new System.Drawing.Size(60, 33);
            this.lDate.TabIndex = 1;
            this.lDate.Text = "Date";
            // 
            // lTime
            // 
            this.lTime.AutoSize = true;
            this.lTime.Font = new System.Drawing.Font("Segoe Print", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lTime.ForeColor = System.Drawing.Color.Blue;
            this.lTime.Location = new System.Drawing.Point(308, 101);
            this.lTime.Name = "lTime";
            this.lTime.Size = new System.Drawing.Size(64, 33);
            this.lTime.TabIndex = 2;
            this.lTime.Text = "Time";
            // 
            // lLocation
            // 
            this.lLocation.AutoSize = true;
            this.lLocation.ForeColor = System.Drawing.Color.ForestGreen;
            this.lLocation.Location = new System.Drawing.Point(33, 191);
            this.lLocation.Name = "lLocation";
            this.lLocation.Size = new System.Drawing.Size(81, 28);
            this.lLocation.TabIndex = 3;
            this.lLocation.Text = "Location";
            // 
            // lPrise
            // 
            this.lPrise.AutoSize = true;
            this.lPrise.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lPrise.Location = new System.Drawing.Point(362, 9);
            this.lPrise.Name = "lPrise";
            this.lPrise.Size = new System.Drawing.Size(37, 19);
            this.lPrise.TabIndex = 4;
            this.lPrise.Text = "Prise";
            // 
            // lArt
            // 
            this.lArt.AutoSize = true;
            this.lArt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lArt.Location = new System.Drawing.Point(40, 286);
            this.lArt.Name = "lArt";
            this.lArt.Size = new System.Drawing.Size(67, 28);
            this.lArt.TabIndex = 5;
            this.lArt.Text = "Artists";
            this.lArt.Visible = false;
            // 
            // lPr
            // 
            this.lPr.AutoSize = true;
            this.lPr.Location = new System.Drawing.Point(323, 286);
            this.lPr.Name = "lPr";
            this.lPr.Size = new System.Drawing.Size(85, 28);
            this.lPr.TabIndex = 6;
            this.lPr.Text = "Producer";
            this.lPr.Visible = false;
            // 
            // lScreen
            // 
            this.lScreen.AutoSize = true;
            this.lScreen.Location = new System.Drawing.Point(309, 364);
            this.lScreen.Name = "lScreen";
            this.lScreen.Size = new System.Drawing.Size(65, 28);
            this.lScreen.TabIndex = 7;
            this.lScreen.Text = "Screen";
            this.lScreen.Visible = false;
            // 
            // fShowPoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 556);
            this.Controls.Add(this.lScreen);
            this.Controls.Add(this.lPr);
            this.Controls.Add(this.lArt);
            this.Controls.Add(this.lPrise);
            this.Controls.Add(this.lLocation);
            this.Controls.Add(this.lTime);
            this.Controls.Add(this.lDate);
            this.Controls.Add(this.lTitle);
            this.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "fShowPoster";
            this.Text = "fShowPoster";
            this.Shown += new System.EventHandler(this.fShowPoster_Shown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fShowPoster_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Label lDate;
        private System.Windows.Forms.Label lTime;
        private System.Windows.Forms.Label lLocation;
        private System.Windows.Forms.Label lPrise;
        private System.Windows.Forms.Label lArt;
        private System.Windows.Forms.Label lPr;
        private System.Windows.Forms.Label lScreen;
    }
}
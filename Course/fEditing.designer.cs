namespace Course
{
    partial class fEditing
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
            this.tabPoster = new System.Windows.Forms.TabControl();
            this.tabCCP = new System.Windows.Forms.TabPage();
            this.tabTCP = new System.Windows.Forms.TabPage();
            this.tabCMP = new System.Windows.Forms.TabPage();
            this.tabDMP = new System.Windows.Forms.TabPage();
            this.tabPoster.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPoster
            // 
            this.tabPoster.Controls.Add(this.tabCCP);
            this.tabPoster.Controls.Add(this.tabTCP);
            this.tabPoster.Controls.Add(this.tabCMP);
            this.tabPoster.Controls.Add(this.tabDMP);
            this.tabPoster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPoster.Location = new System.Drawing.Point(0, 0);
            this.tabPoster.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabPoster.Name = "tabPoster";
            this.tabPoster.SelectedIndex = 0;
            this.tabPoster.Size = new System.Drawing.Size(779, 396);
            this.tabPoster.TabIndex = 0;
            // 
            // tabCCP
            // 
            this.tabCCP.AutoScroll = true;
            this.tabCCP.Location = new System.Drawing.Point(4, 32);
            this.tabCCP.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabCCP.Name = "tabCCP";
            this.tabCCP.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabCCP.Size = new System.Drawing.Size(771, 360);
            this.tabCCP.TabIndex = 0;
            this.tabCCP.Text = "Кіноафіша";
            this.tabCCP.UseVisualStyleBackColor = true;
            this.tabCCP.Click += new System.EventHandler(this.tabCCP_Click);
            // 
            // tabTCP
            // 
            this.tabTCP.Location = new System.Drawing.Point(4, 32);
            this.tabTCP.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabTCP.Name = "tabTCP";
            this.tabTCP.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.tabTCP.Size = new System.Drawing.Size(771, 360);
            this.tabTCP.TabIndex = 1;
            this.tabTCP.Text = "Театральна афіша";
            this.tabTCP.UseVisualStyleBackColor = true;
            this.tabTCP.Click += new System.EventHandler(this.tabTCP_Click);
            // 
            // tabCMP
            // 
            this.tabCMP.Location = new System.Drawing.Point(4, 32);
            this.tabCMP.Name = "tabCMP";
            this.tabCMP.Size = new System.Drawing.Size(771, 360);
            this.tabCMP.TabIndex = 2;
            this.tabCMP.Text = "Kонцертна афіша";
            this.tabCMP.UseVisualStyleBackColor = true;
            this.tabCMP.Click += new System.EventHandler(this.tabCMP_Click);
            // 
            // tabDMP
            // 
            this.tabDMP.Location = new System.Drawing.Point(4, 32);
            this.tabDMP.Name = "tabDMP";
            this.tabDMP.Size = new System.Drawing.Size(771, 360);
            this.tabDMP.TabIndex = 3;
            this.tabDMP.Text = "Дискотека";
            this.tabDMP.UseVisualStyleBackColor = true;
            this.tabDMP.Click += new System.EventHandler(this.tabDMP_Click);
            // 
            // fEditing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 396);
            this.Controls.Add(this.tabPoster);
            this.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "fEditing";
            this.Text = "Редагування афіш";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.fEditing_FormClosed);
            this.Load += new System.EventHandler(this.fEditing_Load);
            this.Shown += new System.EventHandler(this.fEditing_Shown);
            this.tabPoster.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabPoster;
        private System.Windows.Forms.TabPage tabCCP;
        private System.Windows.Forms.TabPage tabTCP;
        private System.Windows.Forms.TabPage tabCMP;
        private System.Windows.Forms.TabPage tabDMP;
    }
}
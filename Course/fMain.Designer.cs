namespace Course
{
    partial class fMain
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lMaket = new System.Windows.Forms.Label();
            this.lFind = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lMaket
            // 
            this.lMaket.AutoSize = true;
            this.lMaket.BackColor = System.Drawing.Color.Transparent;
            this.lMaket.Location = new System.Drawing.Point(307, 81);
            this.lMaket.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lMaket.Name = "lMaket";
            this.lMaket.Size = new System.Drawing.Size(213, 43);
            this.lMaket.TabIndex = 0;
            this.lMaket.Text = "Дизайнер афіш";
            this.lMaket.Click += new System.EventHandler(this.lMaket_Click);
            // 
            // lFind
            // 
            this.lFind.AutoSize = true;
            this.lFind.BackColor = System.Drawing.Color.Transparent;
            this.lFind.Location = new System.Drawing.Point(74, 263);
            this.lFind.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.lFind.Name = "lFind";
            this.lFind.Size = new System.Drawing.Size(467, 43);
            this.lFind.TabIndex = 1;
            this.lFind.Text = "Пошук культурно-масових заходів ";
            this.lFind.Click += new System.EventHandler(this.lFind_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 20000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 43F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Course.Properties.Resources.white_brick_wall;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(562, 443);
            this.Controls.Add(this.lFind);
            this.Controls.Add(this.lMaket);
            this.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(7, 9, 7, 9);
            this.Name = "fMain";
            this.Text = "Електронна афіша";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lMaket;
        private System.Windows.Forms.Label lFind;
        private System.Windows.Forms.Timer timer1;
    }
}


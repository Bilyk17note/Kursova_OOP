namespace Course
{
    partial class fFind
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
            this.label2 = new System.Windows.Forms.Label();
            this.mCData1 = new System.Windows.Forms.MonthCalendar();
            this.mCData2 = new System.Windows.Forms.MonthCalendar();
            this.chBMessage = new System.Windows.Forms.CheckBox();
            this.bFind = new System.Windows.Forms.Button();
            this.cBLocation = new System.Windows.Forms.ComboBox();
            this.cBType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cBTime = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Початкова дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(262, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Кінцева дата";
            // 
            // mCData1
            // 
            this.mCData1.Enabled = false;
            this.mCData1.Location = new System.Drawing.Point(43, 96);
            this.mCData1.Name = "mCData1";
            this.mCData1.TabIndex = 2;
            this.mCData1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mCData1_DateChanged);
            // 
            // mCData2
            // 
            this.mCData2.Enabled = false;
            this.mCData2.Location = new System.Drawing.Point(233, 96);
            this.mCData2.Name = "mCData2";
            this.mCData2.TabIndex = 3;
            this.mCData2.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.mCData2_DateChanged);
            // 
            // chBMessage
            // 
            this.chBMessage.AutoSize = true;
            this.chBMessage.Location = new System.Drawing.Point(111, 270);
            this.chBMessage.Name = "chBMessage";
            this.chBMessage.Size = new System.Drawing.Size(274, 28);
            this.chBMessage.TabIndex = 4;
            this.chBMessage.Text = "Повідомлення про поточні заходи";
            this.chBMessage.UseVisualStyleBackColor = true;
            this.chBMessage.Click += new System.EventHandler(this.chBMessage_Click);
            // 
            // bFind
            // 
            this.bFind.Location = new System.Drawing.Point(161, 387);
            this.bFind.Name = "bFind";
            this.bFind.Size = new System.Drawing.Size(123, 36);
            this.bFind.TabIndex = 5;
            this.bFind.Text = "Пошук";
            this.bFind.UseVisualStyleBackColor = true;
            this.bFind.Click += new System.EventHandler(this.bFind_Click);
            // 
            // cBLocation
            // 
            this.cBLocation.FormattingEnabled = true;
            this.cBLocation.Location = new System.Drawing.Point(43, 334);
            this.cBLocation.Name = "cBLocation";
            this.cBLocation.Size = new System.Drawing.Size(164, 31);
            this.cBLocation.Sorted = true;
            this.cBLocation.TabIndex = 6;
            this.cBLocation.SelectedIndexChanged += new System.EventHandler(this.cBLocation_SelectedIndexChanged);
            // 
            // cBType
            // 
            this.cBType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBType.FormattingEnabled = true;
            this.cBType.Items.AddRange(new object[] {
            "Bсі заходи",
            "Кіно",
            "Театральна вистава",
            "Концерт",
            "Дискотека"});
            this.cBType.Location = new System.Drawing.Point(233, 334);
            this.cBType.Name = "cBType";
            this.cBType.Size = new System.Drawing.Size(164, 31);
            this.cBType.TabIndex = 7;
            this.cBType.SelectedIndexChanged += new System.EventHandler(this.cBType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 301);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "Місце проведення";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(262, 301);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Тип заходу";
            // 
            // cBTime
            // 
            this.cBTime.AutoSize = true;
            this.cBTime.Location = new System.Drawing.Point(96, 21);
            this.cBTime.Name = "cBTime";
            this.cBTime.Size = new System.Drawing.Size(171, 28);
            this.cBTime.TabIndex = 10;
            this.cBTime.Text = "Задати період часу";
            this.cBTime.UseVisualStyleBackColor = true;
            this.cBTime.Click += new System.EventHandler(this.cBTime_Click);
            // 
            // fFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 440);
            this.Controls.Add(this.cBTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBType);
            this.Controls.Add(this.cBLocation);
            this.Controls.Add(this.bFind);
            this.Controls.Add(this.chBMessage);
            this.Controls.Add(this.mCData2);
            this.Controls.Add(this.mCData1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe Print", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "fFind";
            this.Text = "Оберіть критерії пошуку";
            this.Shown += new System.EventHandler(this.fFind_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar mCData1;
        private System.Windows.Forms.MonthCalendar mCData2;
        private System.Windows.Forms.CheckBox chBMessage;
        private System.Windows.Forms.Button bFind;
        private System.Windows.Forms.ComboBox cBLocation;
        private System.Windows.Forms.ComboBox cBType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cBTime;
    }
}
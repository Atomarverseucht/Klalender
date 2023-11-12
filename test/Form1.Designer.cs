namespace test
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.mcCalendar = new System.Windows.Forms.MonthCalendar();
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.btSave = new System.Windows.Forms.Button();
            this.cbCathegory = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mcCalendar
            // 
            this.mcCalendar.CalendarDimensions = new System.Drawing.Size(4, 2);
            this.mcCalendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mcCalendar.Location = new System.Drawing.Point(0, 0);
            this.mcCalendar.Margin = new System.Windows.Forms.Padding(8, 10, 8, 10);
            this.mcCalendar.Name = "mcCalendar";
            this.mcCalendar.TabIndex = 0;
            this.mcCalendar.TodayDate = new System.DateTime(2023, 11, 6, 0, 0, 0, 0);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(224, 487);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(59, 25);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Title:";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(224, 588);
            this.lbDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(80, 25);
            this.lbDate.TabIndex = 2;
            this.lbDate.Text = "Datum:";
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(230, 529);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(380, 31);
            this.tbTitle.TabIndex = 3;
            // 
            // dtbDate
            // 
            this.dtpDate.CausesValidation = false;
            this.dtpDate.CustomFormat = "";
            this.dtpDate.Location = new System.Drawing.Point(230, 617);
            this.dtpDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpDate.Name = "dtbDate";
            this.dtpDate.Size = new System.Drawing.Size(592, 31);
            this.dtpDate.TabIndex = 4;
            // 
            // btSave
            // 
            this.btSave.Location = new System.Drawing.Point(200, 767);
            this.btSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(472, 77);
            this.btSave.TabIndex = 5;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // cbCathegory
            // 
            this.cbCathegory.FormattingEnabled = true;
            this.cbCathegory.Location = new System.Drawing.Point(230, 713);
            this.cbCathegory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbCathegory.Name = "cbCathegory";
            this.cbCathegory.Size = new System.Drawing.Size(380, 33);
            this.cbCathegory.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 677);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cathegory";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 869);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbCathegory);
            this.Controls.Add(this.btSave);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.mcCalendar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar mcCalendar;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.ComboBox cbCathegory;
        private System.Windows.Forms.Label label3;
    }
}


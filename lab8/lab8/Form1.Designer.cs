namespace lab8
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
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
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Report = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Month = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BuyFillialBtn = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.FilialsLbl = new System.Windows.Forms.Label();
            this.CarsLbl = new System.Windows.Forms.Label();
            this.StuffLbl = new System.Windows.Forms.Label();
            this.PocketLbl = new System.Windows.Forms.Label();
            this.NotEnoughMoneyLbl = new System.Windows.Forms.Label();
            this.OrderBtn = new System.Windows.Forms.Button();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.ApproveBtn = new System.Windows.Forms.Button();
            this.DismissBtn = new System.Windows.Forms.Button();
            this.ValueLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Report
            // 
            this.Report.Location = new System.Drawing.Point(22, 397);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(95, 41);
            this.Report.TabIndex = 1;
            this.Report.Text = "Report";
            this.Report.UseVisualStyleBackColor = true;
            this.Report.Click += new System.EventHandler(this.ExpensesBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(37, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Автосалон";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date.Location = new System.Drawing.Point(388, 15);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(18, 20);
            this.Date.TabIndex = 3;
            this.Date.Text = "0";
            // 
            // Month
            // 
            this.Month.AutoSize = true;
            this.Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Month.Location = new System.Drawing.Point(438, 15);
            this.Month.Name = "Month";
            this.Month.Size = new System.Drawing.Size(18, 20);
            this.Month.TabIndex = 4;
            this.Month.Text = "0";
            // 
            // Year
            // 
            this.Year.AutoSize = true;
            this.Year.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Year.Location = new System.Drawing.Point(498, 15);
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(18, 20);
            this.Year.TabIndex = 5;
            this.Year.Text = "0";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl.Location = new System.Drawing.Point(332, 395);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(66, 20);
            this.lbl.TabIndex = 6;
            this.lbl.Text = "Pocket: ";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label7.Location = new System.Drawing.Point(14, 60);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(59, 20);
            this.Label7.TabIndex = 8;
            this.Label7.Text = "Fillials: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(14, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 20);
            this.label8.TabIndex = 9;
            this.label8.Text = "Cars in garage\'s: ";
            // 
            // BuyFillialBtn
            // 
            this.BuyFillialBtn.Location = new System.Drawing.Point(429, 153);
            this.BuyFillialBtn.Name = "BuyFillialBtn";
            this.BuyFillialBtn.Size = new System.Drawing.Size(87, 36);
            this.BuyFillialBtn.TabIndex = 10;
            this.BuyFillialBtn.Text = "Buy Fillial";
            this.BuyFillialBtn.UseVisualStyleBackColor = true;
            this.BuyFillialBtn.Click += new System.EventHandler(this.BuyFillialBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(15, 160);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "Stuff: ";
            // 
            // FilialsLbl
            // 
            this.FilialsLbl.AutoSize = true;
            this.FilialsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FilialsLbl.Location = new System.Drawing.Point(79, 60);
            this.FilialsLbl.Name = "FilialsLbl";
            this.FilialsLbl.Size = new System.Drawing.Size(18, 20);
            this.FilialsLbl.TabIndex = 13;
            this.FilialsLbl.Text = "0";
            // 
            // CarsLbl
            // 
            this.CarsLbl.AutoSize = true;
            this.CarsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CarsLbl.Location = new System.Drawing.Point(151, 111);
            this.CarsLbl.Name = "CarsLbl";
            this.CarsLbl.Size = new System.Drawing.Size(18, 20);
            this.CarsLbl.TabIndex = 14;
            this.CarsLbl.Text = "0";
            // 
            // StuffLbl
            // 
            this.StuffLbl.AutoSize = true;
            this.StuffLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StuffLbl.Location = new System.Drawing.Point(73, 160);
            this.StuffLbl.Name = "StuffLbl";
            this.StuffLbl.Size = new System.Drawing.Size(18, 20);
            this.StuffLbl.TabIndex = 15;
            this.StuffLbl.Text = "0";
            // 
            // PocketLbl
            // 
            this.PocketLbl.AutoSize = true;
            this.PocketLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PocketLbl.Location = new System.Drawing.Point(404, 396);
            this.PocketLbl.Name = "PocketLbl";
            this.PocketLbl.Size = new System.Drawing.Size(18, 20);
            this.PocketLbl.TabIndex = 16;
            this.PocketLbl.Text = "0";
            // 
            // NotEnoughMoneyLbl
            // 
            this.NotEnoughMoneyLbl.AutoSize = true;
            this.NotEnoughMoneyLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotEnoughMoneyLbl.ForeColor = System.Drawing.Color.Red;
            this.NotEnoughMoneyLbl.Location = new System.Drawing.Point(280, 88);
            this.NotEnoughMoneyLbl.Name = "NotEnoughMoneyLbl";
            this.NotEnoughMoneyLbl.Size = new System.Drawing.Size(212, 25);
            this.NotEnoughMoneyLbl.TabIndex = 17;
            this.NotEnoughMoneyLbl.Text = "Not Enough Money";
            this.NotEnoughMoneyLbl.Visible = false;
            // 
            // OrderBtn
            // 
            this.OrderBtn.Location = new System.Drawing.Point(207, 190);
            this.OrderBtn.Name = "OrderBtn";
            this.OrderBtn.Size = new System.Drawing.Size(87, 36);
            this.OrderBtn.TabIndex = 18;
            this.OrderBtn.Text = "Order cars";
            this.OrderBtn.UseVisualStyleBackColor = true;
            this.OrderBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(156, 274);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(184, 45);
            this.trackBar1.TabIndex = 20;
            this.trackBar1.Visible = false;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // ApproveBtn
            // 
            this.ApproveBtn.Location = new System.Drawing.Point(156, 325);
            this.ApproveBtn.Name = "ApproveBtn";
            this.ApproveBtn.Size = new System.Drawing.Size(75, 23);
            this.ApproveBtn.TabIndex = 21;
            this.ApproveBtn.Text = "Approve";
            this.ApproveBtn.UseVisualStyleBackColor = true;
            this.ApproveBtn.Visible = false;
            this.ApproveBtn.Click += new System.EventHandler(this.ApproveBtn_Click);
            // 
            // DismissBtn
            // 
            this.DismissBtn.Location = new System.Drawing.Point(275, 325);
            this.DismissBtn.Name = "DismissBtn";
            this.DismissBtn.Size = new System.Drawing.Size(75, 23);
            this.DismissBtn.TabIndex = 22;
            this.DismissBtn.Text = "Dismiss";
            this.DismissBtn.UseVisualStyleBackColor = true;
            this.DismissBtn.Visible = false;
            this.DismissBtn.Click += new System.EventHandler(this.DismissBtn_Click);
            // 
            // ValueLbl
            // 
            this.ValueLbl.AutoSize = true;
            this.ValueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ValueLbl.Location = new System.Drawing.Point(227, 239);
            this.ValueLbl.Name = "ValueLbl";
            this.ValueLbl.Size = new System.Drawing.Size(50, 20);
            this.ValueLbl.TabIndex = 23;
            this.ValueLbl.Text = "Value";
            this.ValueLbl.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(285, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "D/M/Y: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ValueLbl);
            this.Controls.Add(this.DismissBtn);
            this.Controls.Add(this.ApproveBtn);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.OrderBtn);
            this.Controls.Add(this.NotEnoughMoneyLbl);
            this.Controls.Add(this.PocketLbl);
            this.Controls.Add(this.StuffLbl);
            this.Controls.Add(this.CarsLbl);
            this.Controls.Add(this.FilialsLbl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BuyFillialBtn);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Report);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Report;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Month;
        private System.Windows.Forms.Label Year;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label Label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BuyFillialBtn;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label FilialsLbl;
        private System.Windows.Forms.Label CarsLbl;
        private System.Windows.Forms.Label StuffLbl;
        private System.Windows.Forms.Label PocketLbl;
        private System.Windows.Forms.Label NotEnoughMoneyLbl;
        private System.Windows.Forms.Button OrderBtn;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button ApproveBtn;
        private System.Windows.Forms.Button DismissBtn;
        private System.Windows.Forms.Label ValueLbl;
        private System.Windows.Forms.Label label2;
    }
}


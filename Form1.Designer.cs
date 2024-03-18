namespace LeapYearSelector
{
    partial class Form1
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
            this.lblYear = new System.Windows.Forms.Label();
            this.lblLeapYear = new System.Windows.Forms.Label();
            this.lstYear = new System.Windows.Forms.ListBox();
            this.lstLeap = new System.Windows.Forms.ListBox();
            this.btnAddLeapYears = new System.Windows.Forms.Button();
            this.txtLstYear = new System.Windows.Forms.TextBox();
            this.lblSelectedYear = new System.Windows.Forms.Label();
            this.lblSelectedLeap = new System.Windows.Forms.Label();
            this.txtLstLeap = new System.Windows.Forms.TextBox();
            this.lblAddToYear = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAddToYear = new System.Windows.Forms.TextBox();
            this.lblClear = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.lblRemove = new System.Windows.Forms.Label();
            this.lblSum = new System.Windows.Forms.Label();
            this.txtSum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblAverage = new System.Windows.Forms.Label();
            this.btnAverage = new System.Windows.Forms.Button();
            this.txtAverage = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lblDecide = new System.Windows.Forms.Label();
            this.txtDecision = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(85, 20);
            this.lblYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 0;
            this.lblYear.Text = "Year";
            // 
            // lblLeapYear
            // 
            this.lblLeapYear.AutoSize = true;
            this.lblLeapYear.Location = new System.Drawing.Point(337, 20);
            this.lblLeapYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLeapYear.Name = "lblLeapYear";
            this.lblLeapYear.Size = new System.Drawing.Size(56, 13);
            this.lblLeapYear.TabIndex = 1;
            this.lblLeapYear.Text = "Leap Year";
            // 
            // lstYear
            // 
            this.lstYear.FormattingEnabled = true;
            this.lstYear.Items.AddRange(new object[] {
            "1999",
            "2000",
            "2001",
            "2002",
            "2003",
            "2004",
            "2005",
            "2006",
            "2007",
            "2008",
            "2009",
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022"});
            this.lstYear.Location = new System.Drawing.Point(81, 36);
            this.lstYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstYear.Name = "lstYear";
            this.lstYear.Size = new System.Drawing.Size(114, 121);
            this.lstYear.TabIndex = 2;
            this.lstYear.SelectedIndexChanged += new System.EventHandler(this.lstYear_SelectedIndexChanged);
            // 
            // lstLeap
            // 
            this.lstLeap.FormattingEnabled = true;
            this.lstLeap.Location = new System.Drawing.Point(332, 36);
            this.lstLeap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstLeap.Name = "lstLeap";
            this.lstLeap.Size = new System.Drawing.Size(115, 121);
            this.lstLeap.TabIndex = 3;
            this.lstLeap.SelectedIndexChanged += new System.EventHandler(this.lstLeap_SelectedIndexChanged);
            // 
            // btnAddLeapYears
            // 
            this.btnAddLeapYears.Location = new System.Drawing.Point(183, 390);
            this.btnAddLeapYears.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddLeapYears.Name = "btnAddLeapYears";
            this.btnAddLeapYears.Size = new System.Drawing.Size(171, 25);
            this.btnAddLeapYears.TabIndex = 4;
            this.btnAddLeapYears.Text = "Add Leap Years to List";
            this.btnAddLeapYears.UseVisualStyleBackColor = true;
            this.btnAddLeapYears.Click += new System.EventHandler(this.btnAddLeapYears_Click);
            // 
            // txtLstYear
            // 
            this.txtLstYear.Location = new System.Drawing.Point(233, 36);
            this.txtLstYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLstYear.Name = "txtLstYear";
            this.txtLstYear.ReadOnly = true;
            this.txtLstYear.Size = new System.Drawing.Size(68, 20);
            this.txtLstYear.TabIndex = 5;
            // 
            // lblSelectedYear
            // 
            this.lblSelectedYear.AutoSize = true;
            this.lblSelectedYear.Location = new System.Drawing.Point(204, 20);
            this.lblSelectedYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectedYear.Name = "lblSelectedYear";
            this.lblSelectedYear.Size = new System.Drawing.Size(122, 13);
            this.lblSelectedYear.TabIndex = 6;
            this.lblSelectedYear.Text = "Selected From Year List:";
            // 
            // lblSelectedLeap
            // 
            this.lblSelectedLeap.AutoSize = true;
            this.lblSelectedLeap.Location = new System.Drawing.Point(204, 63);
            this.lblSelectedLeap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSelectedLeap.Name = "lblSelectedLeap";
            this.lblSelectedLeap.Size = new System.Drawing.Size(124, 13);
            this.lblSelectedLeap.TabIndex = 7;
            this.lblSelectedLeap.Text = "Selected From Leap List:";
            // 
            // txtLstLeap
            // 
            this.txtLstLeap.Location = new System.Drawing.Point(233, 78);
            this.txtLstLeap.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLstLeap.Name = "txtLstLeap";
            this.txtLstLeap.ReadOnly = true;
            this.txtLstLeap.Size = new System.Drawing.Size(68, 20);
            this.txtLstLeap.TabIndex = 8;
            // 
            // lblAddToYear
            // 
            this.lblAddToYear.AutoSize = true;
            this.lblAddToYear.Location = new System.Drawing.Point(225, 105);
            this.lblAddToYear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddToYear.Name = "lblAddToYear";
            this.lblAddToYear.Size = new System.Drawing.Size(85, 13);
            this.lblAddToYear.TabIndex = 9;
            this.lblAddToYear.Text = "Add to Year List:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(233, 141);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(67, 20);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtAddToYear
            // 
            this.txtAddToYear.Location = new System.Drawing.Point(233, 120);
            this.txtAddToYear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAddToYear.Name = "txtAddToYear";
            this.txtAddToYear.Size = new System.Drawing.Size(68, 20);
            this.txtAddToYear.TabIndex = 11;
            // 
            // lblClear
            // 
            this.lblClear.AutoSize = true;
            this.lblClear.Location = new System.Drawing.Point(8, 80);
            this.lblClear.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClear.Name = "lblClear";
            this.lblClear.Size = new System.Drawing.Size(62, 13);
            this.lblClear.TabIndex = 12;
            this.lblClear.Text = "Clear Items:";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(8, 95);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(67, 20);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(233, 196);
            this.btnRemove.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(67, 20);
            this.btnRemove.TabIndex = 14;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // lblRemove
            // 
            this.lblRemove.AutoSize = true;
            this.lblRemove.Location = new System.Drawing.Point(159, 182);
            this.lblRemove.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRemove.Name = "lblRemove";
            this.lblRemove.Size = new System.Drawing.Size(225, 13);
            this.lblRemove.TabIndex = 15;
            this.lblRemove.Text = "Press to Remove Selected Item From Year list:";
            // 
            // lblSum
            // 
            this.lblSum.AutoSize = true;
            this.lblSum.Location = new System.Drawing.Point(147, 235);
            this.lblSum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSum.Name = "lblSum";
            this.lblSum.Size = new System.Drawing.Size(247, 13);
            this.lblSum.TabIndex = 16;
            this.lblSum.Text = "Press to Calculate the Sum of all values in Year list:";
            // 
            // txtSum
            // 
            this.txtSum.Location = new System.Drawing.Point(233, 274);
            this.txtSum.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSum.Name = "txtSum";
            this.txtSum.ReadOnly = true;
            this.txtSum.Size = new System.Drawing.Size(68, 20);
            this.txtSum.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(233, 250);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(67, 20);
            this.button1.TabIndex = 18;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(147, 311);
            this.lblAverage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(256, 13);
            this.lblAverage.TabIndex = 19;
            this.lblAverage.Text = "Press to Calculate the average of values in Year List:";
            // 
            // btnAverage
            // 
            this.btnAverage.Location = new System.Drawing.Point(233, 325);
            this.btnAverage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAverage.Name = "btnAverage";
            this.btnAverage.Size = new System.Drawing.Size(67, 20);
            this.btnAverage.TabIndex = 20;
            this.btnAverage.Text = "Calculate";
            this.btnAverage.UseVisualStyleBackColor = true;
            this.btnAverage.Click += new System.EventHandler(this.btnAverage_Click);
            // 
            // txtAverage
            // 
            this.txtAverage.Location = new System.Drawing.Point(233, 349);
            this.txtAverage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtAverage.Name = "txtAverage";
            this.txtAverage.ReadOnly = true;
            this.txtAverage.Size = new System.Drawing.Size(68, 20);
            this.txtAverage.TabIndex = 21;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(161, 450);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 22;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // lblDecide
            // 
            this.lblDecide.AutoSize = true;
            this.lblDecide.Location = new System.Drawing.Point(147, 433);
            this.lblDecide.Name = "lblDecide";
            this.lblDecide.Size = new System.Drawing.Size(229, 13);
            this.lblDecide.TabIndex = 24;
            this.lblDecide.Text = "Select a Date to Tell if the Year is a Leap Year:";
            // 
            // txtDecision
            // 
            this.txtDecision.Location = new System.Drawing.Point(234, 476);
            this.txtDecision.Name = "txtDecision";
            this.txtDecision.ReadOnly = true;
            this.txtDecision.Size = new System.Drawing.Size(67, 20);
            this.txtDecision.TabIndex = 25;
            this.txtDecision.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 519);
            this.Controls.Add(this.txtDecision);
            this.Controls.Add(this.lblDecide);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtAverage);
            this.Controls.Add(this.btnAverage);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtSum);
            this.Controls.Add(this.lblSum);
            this.Controls.Add(this.lblRemove);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.lblClear);
            this.Controls.Add(this.txtAddToYear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblAddToYear);
            this.Controls.Add(this.txtLstLeap);
            this.Controls.Add(this.lblSelectedLeap);
            this.Controls.Add(this.lblSelectedYear);
            this.Controls.Add(this.txtLstYear);
            this.Controls.Add(this.btnAddLeapYears);
            this.Controls.Add(this.lstLeap);
            this.Controls.Add(this.lstYear);
            this.Controls.Add(this.lblLeapYear);
            this.Controls.Add(this.lblYear);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label lblLeapYear;
        private System.Windows.Forms.ListBox lstYear;
        private System.Windows.Forms.ListBox lstLeap;
        private System.Windows.Forms.Button btnAddLeapYears;
        private System.Windows.Forms.TextBox txtLstYear;
        private System.Windows.Forms.Label lblSelectedYear;
        private System.Windows.Forms.Label lblSelectedLeap;
        private System.Windows.Forms.TextBox txtLstLeap;
        private System.Windows.Forms.Label lblAddToYear;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAddToYear;
        private System.Windows.Forms.Label lblClear;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label lblRemove;
        private System.Windows.Forms.Label lblSum;
        private System.Windows.Forms.TextBox txtSum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Button btnAverage;
        private System.Windows.Forms.TextBox txtAverage;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lblDecide;
        private System.Windows.Forms.TextBox txtDecision;
    }
}


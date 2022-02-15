namespace Assignment1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCapture = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.nudWind = new System.Windows.Forms.NumericUpDown();
            this.nudHum = new System.Windows.Forms.NumericUpDown();
            this.nudPre = new System.Windows.Forms.NumericUpDown();
            this.nudMaxTemp = new System.Windows.Forms.NumericUpDown();
            this.nudMinTemp = new System.Windows.Forms.NumericUpDown();
            this.btnCapture = new System.Windows.Forms.Button();
            this.tbCity = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.tpSearch = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpSearchMulti = new System.Windows.Forms.TabPage();
            this.label15 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label13 = new System.Windows.Forms.Label();
            this.dtEnd = new System.Windows.Forms.DateTimePicker();
            this.dtStart = new System.Windows.Forms.DateTimePicker();
            this.btnMultSearch = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tpCapture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxTemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinTemp)).BeginInit();
            this.tpSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tpSearchMulti.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpCapture);
            this.tabControl1.Controls.Add(this.tpSearch);
            this.tabControl1.Controls.Add(this.tpSearchMulti);
            this.tabControl1.Location = new System.Drawing.Point(229, 39);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1140, 542);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabPage2_Click);
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tpCapture
            // 
            this.tpCapture.BackColor = System.Drawing.Color.White;
            this.tpCapture.Controls.Add(this.label12);
            this.tpCapture.Controls.Add(this.nudWind);
            this.tpCapture.Controls.Add(this.nudHum);
            this.tpCapture.Controls.Add(this.nudPre);
            this.tpCapture.Controls.Add(this.nudMaxTemp);
            this.tpCapture.Controls.Add(this.nudMinTemp);
            this.tpCapture.Controls.Add(this.btnCapture);
            this.tpCapture.Controls.Add(this.tbCity);
            this.tpCapture.Controls.Add(this.label7);
            this.tpCapture.Controls.Add(this.label3);
            this.tpCapture.Controls.Add(this.label6);
            this.tpCapture.Controls.Add(this.label5);
            this.tpCapture.Controls.Add(this.label4);
            this.tpCapture.Controls.Add(this.lblCity);
            this.tpCapture.Controls.Add(this.label2);
            this.tpCapture.Controls.Add(this.dateTimePicker1);
            this.tpCapture.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpCapture.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tpCapture.Location = new System.Drawing.Point(4, 22);
            this.tpCapture.Name = "tpCapture";
            this.tpCapture.Padding = new System.Windows.Forms.Padding(3);
            this.tpCapture.Size = new System.Drawing.Size(1132, 516);
            this.tpCapture.TabIndex = 0;
            this.tpCapture.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(292, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 19);
            this.label12.TabIndex = 20;
            this.label12.Text = "Input forecast";
            // 
            // nudWind
            // 
            this.nudWind.Location = new System.Drawing.Point(404, 320);
            this.nudWind.Name = "nudWind";
            this.nudWind.Size = new System.Drawing.Size(120, 20);
            this.nudWind.TabIndex = 19;
            // 
            // nudHum
            // 
            this.nudHum.Location = new System.Drawing.Point(404, 280);
            this.nudHum.Name = "nudHum";
            this.nudHum.Size = new System.Drawing.Size(120, 20);
            this.nudHum.TabIndex = 18;
            // 
            // nudPre
            // 
            this.nudPre.Location = new System.Drawing.Point(404, 239);
            this.nudPre.Name = "nudPre";
            this.nudPre.Size = new System.Drawing.Size(120, 20);
            this.nudPre.TabIndex = 17;
            // 
            // nudMaxTemp
            // 
            this.nudMaxTemp.Location = new System.Drawing.Point(404, 204);
            this.nudMaxTemp.Name = "nudMaxTemp";
            this.nudMaxTemp.Size = new System.Drawing.Size(120, 20);
            this.nudMaxTemp.TabIndex = 16;
            // 
            // nudMinTemp
            // 
            this.nudMinTemp.Location = new System.Drawing.Point(404, 163);
            this.nudMinTemp.Name = "nudMinTemp";
            this.nudMinTemp.Size = new System.Drawing.Size(120, 20);
            this.nudMinTemp.TabIndex = 15;
            // 
            // btnCapture
            // 
            this.btnCapture.Location = new System.Drawing.Point(296, 389);
            this.btnCapture.Name = "btnCapture";
            this.btnCapture.Size = new System.Drawing.Size(75, 23);
            this.btnCapture.TabIndex = 14;
            this.btnCapture.Text = "Add";
            this.btnCapture.UseVisualStyleBackColor = true;
            this.btnCapture.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbCity
            // 
            this.tbCity.Location = new System.Drawing.Point(404, 82);
            this.tbCity.Name = "tbCity";
            this.tbCity.Size = new System.Drawing.Size(100, 20);
            this.tbCity.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 320);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Wind speed";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(293, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Humidity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(290, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Precipitation ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(290, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Maximum temperature";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Minimum temperature";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(293, 89);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(24, 13);
            this.lblCity.TabIndex = 2;
            this.lblCity.Text = "City";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(293, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(404, 120);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // tpSearch
            // 
            this.tpSearch.Controls.Add(this.label14);
            this.tpSearch.Controls.Add(this.dataGridView2);
            this.tpSearch.Controls.Add(this.cmbCity);
            this.tpSearch.Controls.Add(this.dtpEndDate);
            this.tpSearch.Controls.Add(this.dtpStartDate);
            this.tpSearch.Controls.Add(this.btnSearch);
            this.tpSearch.Controls.Add(this.label9);
            this.tpSearch.Controls.Add(this.label8);
            this.tpSearch.Controls.Add(this.label1);
            this.tpSearch.Location = new System.Drawing.Point(4, 22);
            this.tpSearch.Name = "tpSearch";
            this.tpSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tpSearch.Size = new System.Drawing.Size(1132, 516);
            this.tpSearch.TabIndex = 1;
            this.tpSearch.UseVisualStyleBackColor = true;
            this.tpSearch.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(18, 23);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(189, 19);
            this.label14.TabIndex = 13;
            this.label14.Text = "Search for city forecasts";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(353, 70);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(744, 398);
            this.dataGridView2.TabIndex = 12;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // cmbCity
            // 
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(133, 70);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(121, 21);
            this.cmbCity.TabIndex = 11;
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Location = new System.Drawing.Point(133, 153);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 20);
            this.dtpEndDate.TabIndex = 9;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Location = new System.Drawing.Point(133, 108);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 20);
            this.dtpStartDate.TabIndex = 8;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(133, 208);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button5_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "end date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "start date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose a city";
            // 
            // tpSearchMulti
            // 
            this.tpSearchMulti.Controls.Add(this.label15);
            this.tpSearchMulti.Controls.Add(this.dataGridView1);
            this.tpSearchMulti.Controls.Add(this.checkedListBox1);
            this.tpSearchMulti.Controls.Add(this.label13);
            this.tpSearchMulti.Controls.Add(this.dtEnd);
            this.tpSearchMulti.Controls.Add(this.dtStart);
            this.tpSearchMulti.Controls.Add(this.btnMultSearch);
            this.tpSearchMulti.Controls.Add(this.label10);
            this.tpSearchMulti.Controls.Add(this.label11);
            this.tpSearchMulti.Location = new System.Drawing.Point(4, 22);
            this.tpSearchMulti.Name = "tpSearchMulti";
            this.tpSearchMulti.Padding = new System.Windows.Forms.Padding(3);
            this.tpSearchMulti.Size = new System.Drawing.Size(1132, 516);
            this.tpSearchMulti.TabIndex = 2;
            this.tpSearchMulti.UseVisualStyleBackColor = true;
            this.tpSearchMulti.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(20, 19);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(163, 19);
            this.label15.TabIndex = 22;
            this.label15.Text = "Search city forecasts";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(377, 82);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 398);
            this.dataGridView1.TabIndex = 21;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Test"});
            this.checkedListBox1.Location = new System.Drawing.Point(152, 87);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 94);
            this.checkedListBox1.TabIndex = 20;
            this.checkedListBox1.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(17, 82);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "Choose a city";
            // 
            // dtEnd
            // 
            this.dtEnd.Location = new System.Drawing.Point(152, 241);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(200, 20);
            this.dtEnd.TabIndex = 16;
            // 
            // dtStart
            // 
            this.dtStart.Location = new System.Drawing.Point(152, 187);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(200, 20);
            this.dtStart.TabIndex = 15;
            // 
            // btnMultSearch
            // 
            this.btnMultSearch.Location = new System.Drawing.Point(152, 314);
            this.btnMultSearch.Name = "btnMultSearch";
            this.btnMultSearch.Size = new System.Drawing.Size(75, 23);
            this.btnMultSearch.TabIndex = 14;
            this.btnMultSearch.Text = "Search";
            this.btnMultSearch.UseVisualStyleBackColor = true;
            this.btnMultSearch.Click += new System.EventHandler(this.button6_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 241);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "end date";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(17, 187);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 13);
            this.label11.TabIndex = 11;
            this.label11.Text = "start date";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 103);
            this.button1.TabIndex = 1;
            this.button1.Text = "Add forecast";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 143);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 99);
            this.button2.TabIndex = 2;
            this.button2.Text = "Search forecasts for a city";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(193, 103);
            this.button3.TabIndex = 4;
            this.button3.Text = "Search cities forcasts";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1452, 606);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpCapture.ResumeLayout(false);
            this.tpCapture.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMaxTemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinTemp)).EndInit();
            this.tpSearch.ResumeLayout(false);
            this.tpSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tpSearchMulti.ResumeLayout(false);
            this.tpSearchMulti.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpCapture;
        private System.Windows.Forms.TabPage tpSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tpSearchMulti;
        private System.Windows.Forms.TextBox tbCity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btnCapture;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtEnd;
        private System.Windows.Forms.DateTimePicker dtStart;
        private System.Windows.Forms.Button btnMultSearch;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.NumericUpDown nudMinTemp;
        private System.Windows.Forms.NumericUpDown nudWind;
        private System.Windows.Forms.NumericUpDown nudHum;
        private System.Windows.Forms.NumericUpDown nudPre;
        private System.Windows.Forms.NumericUpDown nudMaxTemp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
    }
}


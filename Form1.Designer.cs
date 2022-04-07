
namespace TimeReport
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.EmployeesComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WeekComboBox = new System.Windows.Forms.ComboBox();
            this.ProjectComboBox = new System.Windows.Forms.ComboBox();
            this.HoursInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.employeeTableAdapter1 = new TimeReport.TimeReportDataSet1TableAdapters.EmployeeTableAdapter();
            this.timeReportDataSet1 = new TimeReport.TimeReportDataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.timeReportDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(42, 182);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(440, 108);
            this.listBox1.TabIndex = 0;
            // 
            // EmployeesComboBox
            // 
            this.EmployeesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EmployeesComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeesComboBox.FormattingEnabled = true;
            this.EmployeesComboBox.Location = new System.Drawing.Point(207, 47);
            this.EmployeesComboBox.Name = "EmployeesComboBox";
            this.EmployeesComboBox.Size = new System.Drawing.Size(190, 28);
            this.EmployeesComboBox.TabIndex = 2;
            this.EmployeesComboBox.SelectedIndexChanged += new System.EventHandler(this.GetTimeReport);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(109, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Employee:";
            // 
            // WeekComboBox
            // 
            this.WeekComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.WeekComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeekComboBox.FormattingEnabled = true;
            this.WeekComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52"});
            this.WeekComboBox.Location = new System.Drawing.Point(388, 114);
            this.WeekComboBox.MaxLength = 2;
            this.WeekComboBox.Name = "WeekComboBox";
            this.WeekComboBox.Size = new System.Drawing.Size(65, 23);
            this.WeekComboBox.TabIndex = 4;
            this.WeekComboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            // 
            // ProjectComboBox
            // 
            this.ProjectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ProjectComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProjectComboBox.FormattingEnabled = true;
            this.ProjectComboBox.Location = new System.Drawing.Point(160, 114);
            this.ProjectComboBox.Name = "ProjectComboBox";
            this.ProjectComboBox.Size = new System.Drawing.Size(187, 23);
            this.ProjectComboBox.TabIndex = 5;
            // 
            // HoursInput
            // 
            this.HoursInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursInput.Location = new System.Drawing.Point(60, 116);
            this.HoursInput.MaxLength = 2;
            this.HoursInput.Name = "HoursInput";
            this.HoursInput.Size = new System.Drawing.Size(51, 21);
            this.HoursInput.TabIndex = 6;
            this.HoursInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OnlyNumbers);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(157, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Project:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(385, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Week:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Worked Hours:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(122, 296);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(275, 51);
            this.button2.TabIndex = 10;
            this.button2.Text = "Submit Report";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SaveTimeReportToDB);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(365, 353);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 34);
            this.button3.TabIndex = 11;
            this.button3.Text = "Exit Program";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ExitProgram);
            // 
            // employeeTableAdapter1
            // 
            this.employeeTableAdapter1.ClearBeforeFill = true;
            // 
            // timeReportDataSet1
            // 
            this.timeReportDataSet1.DataSetName = "TimeReportDataSet1";
            this.timeReportDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(519, 399);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HoursInput);
            this.Controls.Add(this.ProjectComboBox);
            this.Controls.Add(this.WeekComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmployeesComboBox);
            this.Controls.Add(this.listBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rasmus Databas-Labb";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timeReportDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        public System.Windows.Forms.ComboBox EmployeesComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox WeekComboBox;
        private System.Windows.Forms.ComboBox ProjectComboBox;
        private System.Windows.Forms.TextBox HoursInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private TimeReportDataSet1TableAdapters.EmployeeTableAdapter employeeTableAdapter1;
        private TimeReportDataSet1 timeReportDataSet1;
    }
}


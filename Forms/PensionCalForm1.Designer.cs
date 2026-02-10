namespace Govt.BDPension.Forms
{
    partial class PensionCalForm1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPensionCalculator = new System.Windows.Forms.Label();
            this.lblSearchEmployee = new System.Windows.Forms.Label();
            this.pnlPensionCal = new System.Windows.Forms.Panel();
            this.pnlLumpSum = new System.Windows.Forms.Panel();
            this.lblLumpSumNum = new System.Windows.Forms.Label();
            this.lblLumpSum = new System.Windows.Forms.Label();
            this.lblMonthPension = new System.Windows.Forms.Label();
            this.pnlMonthPension = new System.Windows.Forms.Panel();
            this.lblMonthPensionNum = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblEmpDetail = new System.Windows.Forms.Label();
            this.lblBasicSal = new System.Windows.Forms.Label();
            this.btnCalPension = new System.Windows.Forms.Button();
            this.txtBasicSal = new System.Windows.Forms.TextBox();
            this.lblEmployeeRank = new System.Windows.Forms.Label();
            this.dateTimeJoin = new System.Windows.Forms.DateTimePicker();
            this.cmbEmpRank = new System.Windows.Forms.ComboBox();
            this.lblDateBirth = new System.Windows.Forms.Label();
            this.lblDateJoin = new System.Windows.Forms.Label();
            this.dateTimeBirth = new System.Windows.Forms.DateTimePicker();
            this.pnlPensionCal.SuspendLayout();
            this.pnlLumpSum.SuspendLayout();
            this.pnlMonthPension.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPensionCalculator
            // 
            this.lblPensionCalculator.AutoSize = true;
            this.lblPensionCalculator.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPensionCalculator.Location = new System.Drawing.Point(3, 11);
            this.lblPensionCalculator.Name = "lblPensionCalculator";
            this.lblPensionCalculator.Size = new System.Drawing.Size(301, 38);
            this.lblPensionCalculator.TabIndex = 21;
            this.lblPensionCalculator.Text = "Pension Calculator";
            // 
            // lblSearchEmployee
            // 
            this.lblSearchEmployee.AutoSize = true;
            this.lblSearchEmployee.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchEmployee.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSearchEmployee.Location = new System.Drawing.Point(18, 49);
            this.lblSearchEmployee.Name = "lblSearchEmployee";
            this.lblSearchEmployee.Size = new System.Drawing.Size(602, 25);
            this.lblSearchEmployee.TabIndex = 22;
            this.lblSearchEmployee.Text = "Enter employee service details below generate pension estimates.\r\n";
            // 
            // pnlPensionCal
            // 
            this.pnlPensionCal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlPensionCal.Controls.Add(this.pnlLumpSum);
            this.pnlPensionCal.Controls.Add(this.pnlMonthPension);
            this.pnlPensionCal.Controls.Add(this.btnReset);
            this.pnlPensionCal.Controls.Add(this.label1);
            this.pnlPensionCal.Controls.Add(this.lblEmpDetail);
            this.pnlPensionCal.Controls.Add(this.lblBasicSal);
            this.pnlPensionCal.Controls.Add(this.btnCalPension);
            this.pnlPensionCal.Controls.Add(this.txtBasicSal);
            this.pnlPensionCal.Controls.Add(this.lblEmployeeRank);
            this.pnlPensionCal.Controls.Add(this.dateTimeJoin);
            this.pnlPensionCal.Controls.Add(this.cmbEmpRank);
            this.pnlPensionCal.Controls.Add(this.lblDateBirth);
            this.pnlPensionCal.Controls.Add(this.lblDateJoin);
            this.pnlPensionCal.Controls.Add(this.dateTimeBirth);
            this.pnlPensionCal.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPensionCal.Location = new System.Drawing.Point(23, 89);
            this.pnlPensionCal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlPensionCal.Name = "pnlPensionCal";
            this.pnlPensionCal.Size = new System.Drawing.Size(798, 637);
            this.pnlPensionCal.TabIndex = 25;
            // 
            // pnlLumpSum
            // 
            this.pnlLumpSum.BackColor = System.Drawing.Color.White;
            this.pnlLumpSum.Controls.Add(this.lblLumpSumNum);
            this.pnlLumpSum.Controls.Add(this.lblLumpSum);
            this.pnlLumpSum.Location = new System.Drawing.Point(531, 263);
            this.pnlLumpSum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlLumpSum.Name = "pnlLumpSum";
            this.pnlLumpSum.Size = new System.Drawing.Size(227, 125);
            this.pnlLumpSum.TabIndex = 3;
            // 
            // lblLumpSumNum
            // 
            this.lblLumpSumNum.AutoSize = true;
            this.lblLumpSumNum.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLumpSumNum.Location = new System.Drawing.Point(10, 61);
            this.lblLumpSumNum.Name = "lblLumpSumNum";
            this.lblLumpSumNum.Size = new System.Drawing.Size(101, 47);
            this.lblLumpSumNum.TabIndex = 16;
            this.lblLumpSumNum.Text = "0.00";
            // 
            // lblLumpSum
            // 
            this.lblLumpSum.AutoSize = true;
            this.lblLumpSum.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLumpSum.Location = new System.Drawing.Point(15, 19);
            this.lblLumpSum.Name = "lblLumpSum";
            this.lblLumpSum.Size = new System.Drawing.Size(173, 21);
            this.lblLumpSum.TabIndex = 1;
            this.lblLumpSum.Text = "Lump Sum Gratuity";
            // 
            // lblMonthPension
            // 
            this.lblMonthPension.AutoSize = true;
            this.lblMonthPension.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthPension.Location = new System.Drawing.Point(15, 10);
            this.lblMonthPension.Name = "lblMonthPension";
            this.lblMonthPension.Size = new System.Drawing.Size(151, 21);
            this.lblMonthPension.TabIndex = 0;
            this.lblMonthPension.Text = "Monthly Pension";
            // 
            // pnlMonthPension
            // 
            this.pnlMonthPension.BackColor = System.Drawing.Color.White;
            this.pnlMonthPension.Controls.Add(this.lblMonthPensionNum);
            this.pnlMonthPension.Controls.Add(this.lblMonthPension);
            this.pnlMonthPension.Location = new System.Drawing.Point(531, 67);
            this.pnlMonthPension.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnlMonthPension.Name = "pnlMonthPension";
            this.pnlMonthPension.Size = new System.Drawing.Size(217, 131);
            this.pnlMonthPension.TabIndex = 2;
            // 
            // lblMonthPensionNum
            // 
            this.lblMonthPensionNum.AutoSize = true;
            this.lblMonthPensionNum.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthPensionNum.Location = new System.Drawing.Point(3, 59);
            this.lblMonthPensionNum.Name = "lblMonthPensionNum";
            this.lblMonthPensionNum.Size = new System.Drawing.Size(101, 47);
            this.lblMonthPensionNum.TabIndex = 16;
            this.lblMonthPensionNum.Text = "0.00";
            this.lblMonthPensionNum.Click += new System.EventHandler(this.lblMonthPensionNum_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Goldenrod;
            this.btnReset.Location = new System.Drawing.Point(531, 459);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(129, 42);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(502, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calculation Summary";
            // 
            // lblEmpDetail
            // 
            this.lblEmpDetail.AutoSize = true;
            this.lblEmpDetail.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpDetail.Location = new System.Drawing.Point(3, 0);
            this.lblEmpDetail.Name = "lblEmpDetail";
            this.lblEmpDetail.Size = new System.Drawing.Size(202, 28);
            this.lblEmpDetail.TabIndex = 0;
            this.lblEmpDetail.Text = "Employee Details";
            // 
            // lblBasicSal
            // 
            this.lblBasicSal.AutoSize = true;
            this.lblBasicSal.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasicSal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBasicSal.Location = new System.Drawing.Point(3, 38);
            this.lblBasicSal.Name = "lblBasicSal";
            this.lblBasicSal.Size = new System.Drawing.Size(175, 25);
            this.lblBasicSal.TabIndex = 11;
            this.lblBasicSal.Text = "Basic Salary(BDT)";
            // 
            // btnCalPension
            // 
            this.btnCalPension.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCalPension.Location = new System.Drawing.Point(17, 459);
            this.btnCalPension.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCalPension.Name = "btnCalPension";
            this.btnCalPension.Size = new System.Drawing.Size(198, 42);
            this.btnCalPension.TabIndex = 19;
            this.btnCalPension.Text = "Calculate pension";
            this.btnCalPension.UseVisualStyleBackColor = false;
            this.btnCalPension.Click += new System.EventHandler(this.btnCalPension_Click);
            // 
            // txtBasicSal
            // 
            this.txtBasicSal.Location = new System.Drawing.Point(8, 67);
            this.txtBasicSal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBasicSal.Name = "txtBasicSal";
            this.txtBasicSal.Size = new System.Drawing.Size(197, 31);
            this.txtBasicSal.TabIndex = 1;
            // 
            // lblEmployeeRank
            // 
            this.lblEmployeeRank.AutoSize = true;
            this.lblEmployeeRank.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeRank.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmployeeRank.Location = new System.Drawing.Point(3, 113);
            this.lblEmployeeRank.Name = "lblEmployeeRank";
            this.lblEmployeeRank.Size = new System.Drawing.Size(152, 25);
            this.lblEmployeeRank.TabIndex = 13;
            this.lblEmployeeRank.Text = "Employee Rank";
            // 
            // dateTimeJoin
            // 
            this.dateTimeJoin.Location = new System.Drawing.Point(8, 340);
            this.dateTimeJoin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimeJoin.Name = "dateTimeJoin";
            this.dateTimeJoin.Size = new System.Drawing.Size(350, 31);
            this.dateTimeJoin.TabIndex = 18;
            // 
            // cmbEmpRank
            // 
            this.cmbEmpRank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmpRank.FormattingEnabled = true;
            this.cmbEmpRank.Items.AddRange(new object[] {
            "Manager",
            "Team Lead",
            "Senior Employee",
            "Junior Employee"});
            this.cmbEmpRank.Location = new System.Drawing.Point(8, 142);
            this.cmbEmpRank.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbEmpRank.Name = "cmbEmpRank";
            this.cmbEmpRank.Size = new System.Drawing.Size(147, 31);
            this.cmbEmpRank.TabIndex = 14;
            // 
            // lblDateBirth
            // 
            this.lblDateBirth.AutoSize = true;
            this.lblDateBirth.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateBirth.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDateBirth.Location = new System.Drawing.Point(3, 187);
            this.lblDateBirth.Name = "lblDateBirth";
            this.lblDateBirth.Size = new System.Drawing.Size(127, 25);
            this.lblDateBirth.TabIndex = 15;
            this.lblDateBirth.Text = "Date of Birth";
            // 
            // lblDateJoin
            // 
            this.lblDateJoin.AutoSize = true;
            this.lblDateJoin.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateJoin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDateJoin.Location = new System.Drawing.Point(12, 311);
            this.lblDateJoin.Name = "lblDateJoin";
            this.lblDateJoin.Size = new System.Drawing.Size(115, 25);
            this.lblDateJoin.TabIndex = 17;
            this.lblDateJoin.Text = "Date of Join";
            // 
            // dateTimeBirth
            // 
            this.dateTimeBirth.Location = new System.Drawing.Point(8, 216);
            this.dateTimeBirth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimeBirth.Name = "dateTimeBirth";
            this.dateTimeBirth.Size = new System.Drawing.Size(350, 31);
            this.dateTimeBirth.TabIndex = 16;
            // 
            // PensionCalForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlPensionCal);
            this.Controls.Add(this.lblSearchEmployee);
            this.Controls.Add(this.lblPensionCalculator);
            this.Name = "PensionCalForm1";
            this.Size = new System.Drawing.Size(840, 784);
            this.pnlPensionCal.ResumeLayout(false);
            this.pnlPensionCal.PerformLayout();
            this.pnlLumpSum.ResumeLayout(false);
            this.pnlLumpSum.PerformLayout();
            this.pnlMonthPension.ResumeLayout(false);
            this.pnlMonthPension.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPensionCalculator;
        private System.Windows.Forms.Label lblSearchEmployee;
        private System.Windows.Forms.Panel pnlPensionCal;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalPension;
        private System.Windows.Forms.DateTimePicker dateTimeJoin;
        private System.Windows.Forms.Label lblDateJoin;
        private System.Windows.Forms.DateTimePicker dateTimeBirth;
        private System.Windows.Forms.Label lblDateBirth;
        private System.Windows.Forms.ComboBox cmbEmpRank;
        private System.Windows.Forms.Label lblEmployeeRank;
        private System.Windows.Forms.Label lblBasicSal;
        private System.Windows.Forms.TextBox txtBasicSal;
        private System.Windows.Forms.Label lblEmpDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMonthPension;
        private System.Windows.Forms.Panel pnlLumpSum;
        private System.Windows.Forms.Label lblLumpSumNum;
        private System.Windows.Forms.Label lblLumpSum;
        private System.Windows.Forms.Panel pnlMonthPension;
        private System.Windows.Forms.Label lblMonthPensionNum;
    }
}

namespace Govt.BDPension.Forms
{
    partial class PensionCalForm
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
            this.lblBDTSign = new System.Windows.Forms.Label();
            this.lblMonthPensionNum = new System.Windows.Forms.Label();
            this.pnlMonthPension = new System.Windows.Forms.Panel();
            this.lblMonthPension = new System.Windows.Forms.Label();
            this.lblLumpSum = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalPension = new System.Windows.Forms.Button();
            this.dateTimeJoin = new System.Windows.Forms.DateTimePicker();
            this.lblDateJoin = new System.Windows.Forms.Label();
            this.dateTimeBirth = new System.Windows.Forms.DateTimePicker();
            this.lblDateBirth = new System.Windows.Forms.Label();
            this.cmbEmpRank = new System.Windows.Forms.ComboBox();
            this.lblBDTSign2 = new System.Windows.Forms.Label();
            this.lblLumpSumNum = new System.Windows.Forms.Label();
            this.pnlLumpSum = new System.Windows.Forms.Panel();
            this.pnlCalSummary = new System.Windows.Forms.Panel();
            this.lblEmployeeRank = new System.Windows.Forms.Label();
            this.lblBasicSal = new System.Windows.Forms.Label();
            this.txtBasicSal = new System.Windows.Forms.TextBox();
            this.pnlPensionCal = new System.Windows.Forms.Panel();
            this.lblEmpDetail = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblSearchEmployee = new System.Windows.Forms.Label();
            this.lblPensionCalculator = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.pnlMonthPension.SuspendLayout();
            this.pnlLumpSum.SuspendLayout();
            this.pnlCalSummary.SuspendLayout();
            this.pnlPensionCal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calculation Summary";
            // 
            // lblBDTSign
            // 
            this.lblBDTSign.AutoSize = true;
            this.lblBDTSign.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBDTSign.Location = new System.Drawing.Point(9, 45);
            this.lblBDTSign.Name = "lblBDTSign";
            this.lblBDTSign.Size = new System.Drawing.Size(81, 38);
            this.lblBDTSign.TabIndex = 17;
            this.lblBDTSign.Text = "BDT";
            // 
            // lblMonthPensionNum
            // 
            this.lblMonthPensionNum.AutoSize = true;
            this.lblMonthPensionNum.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthPensionNum.Location = new System.Drawing.Point(99, 45);
            this.lblMonthPensionNum.Name = "lblMonthPensionNum";
            this.lblMonthPensionNum.Size = new System.Drawing.Size(85, 38);
            this.lblMonthPensionNum.TabIndex = 16;
            this.lblMonthPensionNum.Text = "0.00";
            // 
            // pnlMonthPension
            // 
            this.pnlMonthPension.BackColor = System.Drawing.Color.White;
            this.pnlMonthPension.Controls.Add(this.lblBDTSign);
            this.pnlMonthPension.Controls.Add(this.lblMonthPensionNum);
            this.pnlMonthPension.Controls.Add(this.lblMonthPension);
            this.pnlMonthPension.Location = new System.Drawing.Point(21, 65);
            this.pnlMonthPension.Name = "pnlMonthPension";
            this.pnlMonthPension.Size = new System.Drawing.Size(284, 100);
            this.pnlMonthPension.TabIndex = 2;
            // 
            // lblMonthPension
            // 
            this.lblMonthPension.AutoSize = true;
            this.lblMonthPension.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthPension.Location = new System.Drawing.Point(13, 11);
            this.lblMonthPension.Name = "lblMonthPension";
            this.lblMonthPension.Size = new System.Drawing.Size(125, 17);
            this.lblMonthPension.TabIndex = 0;
            this.lblMonthPension.Text = "Monthly Pension";
            // 
            // lblLumpSum
            // 
            this.lblLumpSum.AutoSize = true;
            this.lblLumpSum.Font = new System.Drawing.Font("Cambria", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLumpSum.Location = new System.Drawing.Point(13, 15);
            this.lblLumpSum.Name = "lblLumpSum";
            this.lblLumpSum.Size = new System.Drawing.Size(140, 17);
            this.lblLumpSum.TabIndex = 1;
            this.lblLumpSum.Text = "Lump Sum Gratuity";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Goldenrod;
            this.btnReset.Location = new System.Drawing.Point(434, 343);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(115, 34);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnCalPension
            // 
            this.btnCalPension.BackColor = System.Drawing.Color.PaleGreen;
            this.btnCalPension.Location = new System.Drawing.Point(108, 343);
            this.btnCalPension.Name = "btnCalPension";
            this.btnCalPension.Size = new System.Drawing.Size(176, 34);
            this.btnCalPension.TabIndex = 19;
            this.btnCalPension.Text = "Calculate pension";
            this.btnCalPension.UseVisualStyleBackColor = false;
            this.btnCalPension.Click += new System.EventHandler(this.btnCalPension_Click);
            // 
            // dateTimeJoin
            // 
            this.dateTimeJoin.Location = new System.Drawing.Point(355, 282);
            this.dateTimeJoin.Name = "dateTimeJoin";
            this.dateTimeJoin.Size = new System.Drawing.Size(310, 27);
            this.dateTimeJoin.TabIndex = 18;
            // 
            // lblDateJoin
            // 
            this.lblDateJoin.AutoSize = true;
            this.lblDateJoin.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateJoin.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDateJoin.Location = new System.Drawing.Point(351, 259);
            this.lblDateJoin.Name = "lblDateJoin";
            this.lblDateJoin.Size = new System.Drawing.Size(92, 20);
            this.lblDateJoin.TabIndex = 17;
            this.lblDateJoin.Text = "Date of Join";
            // 
            // dateTimeBirth
            // 
            this.dateTimeBirth.Location = new System.Drawing.Point(28, 282);
            this.dateTimeBirth.Name = "dateTimeBirth";
            this.dateTimeBirth.Size = new System.Drawing.Size(299, 27);
            this.dateTimeBirth.TabIndex = 16;
            // 
            // lblDateBirth
            // 
            this.lblDateBirth.AutoSize = true;
            this.lblDateBirth.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateBirth.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblDateBirth.Location = new System.Drawing.Point(24, 259);
            this.lblDateBirth.Name = "lblDateBirth";
            this.lblDateBirth.Size = new System.Drawing.Size(101, 20);
            this.lblDateBirth.TabIndex = 15;
            this.lblDateBirth.Text = "Date of Birth";
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
            this.cmbEmpRank.Location = new System.Drawing.Point(28, 183);
            this.cmbEmpRank.Name = "cmbEmpRank";
            this.cmbEmpRank.Size = new System.Drawing.Size(335, 28);
            this.cmbEmpRank.TabIndex = 14;
            // 
            // lblBDTSign2
            // 
            this.lblBDTSign2.AutoSize = true;
            this.lblBDTSign2.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBDTSign2.Location = new System.Drawing.Point(9, 50);
            this.lblBDTSign2.Name = "lblBDTSign2";
            this.lblBDTSign2.Size = new System.Drawing.Size(81, 38);
            this.lblBDTSign2.TabIndex = 17;
            this.lblBDTSign2.Text = "BDT";
            // 
            // lblLumpSumNum
            // 
            this.lblLumpSumNum.AutoSize = true;
            this.lblLumpSumNum.Font = new System.Drawing.Font("Cambria", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLumpSumNum.Location = new System.Drawing.Point(99, 50);
            this.lblLumpSumNum.Name = "lblLumpSumNum";
            this.lblLumpSumNum.Size = new System.Drawing.Size(85, 38);
            this.lblLumpSumNum.TabIndex = 16;
            this.lblLumpSumNum.Text = "0.00";
            // 
            // pnlLumpSum
            // 
            this.pnlLumpSum.BackColor = System.Drawing.Color.White;
            this.pnlLumpSum.Controls.Add(this.lblBDTSign2);
            this.pnlLumpSum.Controls.Add(this.lblLumpSumNum);
            this.pnlLumpSum.Controls.Add(this.lblLumpSum);
            this.pnlLumpSum.Location = new System.Drawing.Point(21, 209);
            this.pnlLumpSum.Name = "pnlLumpSum";
            this.pnlLumpSum.Size = new System.Drawing.Size(284, 100);
            this.pnlLumpSum.TabIndex = 3;
            // 
            // pnlCalSummary
            // 
            this.pnlCalSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlCalSummary.Controls.Add(this.pnlLumpSum);
            this.pnlCalSummary.Controls.Add(this.pnlMonthPension);
            this.pnlCalSummary.Controls.Add(this.label1);
            this.pnlCalSummary.Location = new System.Drawing.Point(779, 106);
            this.pnlCalSummary.Name = "pnlCalSummary";
            this.pnlCalSummary.Size = new System.Drawing.Size(323, 349);
            this.pnlCalSummary.TabIndex = 25;
            // 
            // lblEmployeeRank
            // 
            this.lblEmployeeRank.AutoSize = true;
            this.lblEmployeeRank.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeRank.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmployeeRank.Location = new System.Drawing.Point(24, 160);
            this.lblEmployeeRank.Name = "lblEmployeeRank";
            this.lblEmployeeRank.Size = new System.Drawing.Size(122, 20);
            this.lblEmployeeRank.TabIndex = 13;
            this.lblEmployeeRank.Text = "Employee Rank";
            // 
            // lblBasicSal
            // 
            this.lblBasicSal.AutoSize = true;
            this.lblBasicSal.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasicSal.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBasicSal.Location = new System.Drawing.Point(24, 74);
            this.lblBasicSal.Name = "lblBasicSal";
            this.lblBasicSal.Size = new System.Drawing.Size(139, 20);
            this.lblBasicSal.TabIndex = 11;
            this.lblBasicSal.Text = "Basic Salary(BDT)";
            // 
            // txtBasicSal
            // 
            this.txtBasicSal.Location = new System.Drawing.Point(28, 100);
            this.txtBasicSal.Name = "txtBasicSal";
            this.txtBasicSal.Size = new System.Drawing.Size(332, 27);
            this.txtBasicSal.TabIndex = 1;
            // 
            // pnlPensionCal
            // 
            this.pnlPensionCal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlPensionCal.Controls.Add(this.btnReset);
            this.pnlPensionCal.Controls.Add(this.btnCalPension);
            this.pnlPensionCal.Controls.Add(this.dateTimeJoin);
            this.pnlPensionCal.Controls.Add(this.lblDateJoin);
            this.pnlPensionCal.Controls.Add(this.dateTimeBirth);
            this.pnlPensionCal.Controls.Add(this.lblDateBirth);
            this.pnlPensionCal.Controls.Add(this.cmbEmpRank);
            this.pnlPensionCal.Controls.Add(this.lblEmployeeRank);
            this.pnlPensionCal.Controls.Add(this.lblBasicSal);
            this.pnlPensionCal.Controls.Add(this.txtBasicSal);
            this.pnlPensionCal.Controls.Add(this.lblEmpDetail);
            this.pnlPensionCal.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlPensionCal.Location = new System.Drawing.Point(31, 106);
            this.pnlPensionCal.Name = "pnlPensionCal";
            this.pnlPensionCal.Size = new System.Drawing.Size(682, 407);
            this.pnlPensionCal.TabIndex = 24;
            // 
            // lblEmpDetail
            // 
            this.lblEmpDetail.AutoSize = true;
            this.lblEmpDetail.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmpDetail.Location = new System.Drawing.Point(24, 27);
            this.lblEmpDetail.Name = "lblEmpDetail";
            this.lblEmpDetail.Size = new System.Drawing.Size(169, 23);
            this.lblEmpDetail.TabIndex = 0;
            this.lblEmpDetail.Text = "Employee Details";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Yellow;
            this.btnLogout.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(984, 529);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(118, 34);
            this.btnLogout.TabIndex = 23;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Yellow;
            this.btnBack.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 529);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 34);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblSearchEmployee
            // 
            this.lblSearchEmployee.AutoSize = true;
            this.lblSearchEmployee.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchEmployee.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSearchEmployee.Location = new System.Drawing.Point(27, 57);
            this.lblSearchEmployee.Name = "lblSearchEmployee";
            this.lblSearchEmployee.Size = new System.Drawing.Size(481, 20);
            this.lblSearchEmployee.TabIndex = 21;
            this.lblSearchEmployee.Text = "Enter employee service details below generate pension estimates.\r\n";
            // 
            // lblPensionCalculator
            // 
            this.lblPensionCalculator.AutoSize = true;
            this.lblPensionCalculator.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPensionCalculator.Location = new System.Drawing.Point(25, 24);
            this.lblPensionCalculator.Name = "lblPensionCalculator";
            this.lblPensionCalculator.Size = new System.Drawing.Size(257, 33);
            this.lblPensionCalculator.TabIndex = 20;
            this.lblPensionCalculator.Text = "Pension Calculator";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblRole.Location = new System.Drawing.Point(461, 535);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(48, 21);
            this.lblRole.TabIndex = 42;
            this.lblRole.Text = "Role";
            // 
            // PensionCalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1114, 587);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.pnlCalSummary);
            this.Controls.Add(this.pnlPensionCal);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblSearchEmployee);
            this.Controls.Add(this.lblPensionCalculator);
            this.Name = "PensionCalForm";
            this.Text = "PensionCalForm";
            this.Load += new System.EventHandler(this.PensionCalForm_Load);
            this.pnlMonthPension.ResumeLayout(false);
            this.pnlMonthPension.PerformLayout();
            this.pnlLumpSum.ResumeLayout(false);
            this.pnlLumpSum.PerformLayout();
            this.pnlCalSummary.ResumeLayout(false);
            this.pnlCalSummary.PerformLayout();
            this.pnlPensionCal.ResumeLayout(false);
            this.pnlPensionCal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBDTSign;
        private System.Windows.Forms.Label lblMonthPensionNum;
        private System.Windows.Forms.Panel pnlMonthPension;
        private System.Windows.Forms.Label lblMonthPension;
        private System.Windows.Forms.Label lblLumpSum;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalPension;
        private System.Windows.Forms.DateTimePicker dateTimeJoin;
        private System.Windows.Forms.Label lblDateJoin;
        private System.Windows.Forms.DateTimePicker dateTimeBirth;
        private System.Windows.Forms.Label lblDateBirth;
        private System.Windows.Forms.ComboBox cmbEmpRank;
        private System.Windows.Forms.Label lblBDTSign2;
        private System.Windows.Forms.Label lblLumpSumNum;
        private System.Windows.Forms.Panel pnlLumpSum;
        private System.Windows.Forms.Panel pnlCalSummary;
        private System.Windows.Forms.Label lblEmployeeRank;
        private System.Windows.Forms.Label lblBasicSal;
        private System.Windows.Forms.TextBox txtBasicSal;
        private System.Windows.Forms.Panel pnlPensionCal;
        private System.Windows.Forms.Label lblEmpDetail;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblSearchEmployee;
        private System.Windows.Forms.Label lblPensionCalculator;
        private System.Windows.Forms.Label lblRole;
    }
}
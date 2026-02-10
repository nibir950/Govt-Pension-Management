namespace Govt.BDPension.Forms
{
    partial class SettingsForm
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
            this.chbUtility = new System.Windows.Forms.CheckBox();
            this.chbTransport = new System.Windows.Forms.CheckBox();
            this.chbMedical = new System.Windows.Forms.CheckBox();
            this.chbHouseRent = new System.Windows.Forms.CheckBox();
            this.lblDefaultAllowCheck = new System.Windows.Forms.Label();
            this.lblFPPencentage = new System.Windows.Forms.Label();
            this.rtxtFullPension = new System.Windows.Forms.RichTextBox();
            this.lblFullPension = new System.Windows.Forms.Label();
            this.lblMPPercentage = new System.Windows.Forms.Label();
            this.rtxtMaxPercentage = new System.Windows.Forms.RichTextBox();
            this.lblMaxPercentage = new System.Windows.Forms.Label();
            this.lblPensionFormula = new System.Windows.Forms.Label();
            this.pnlPensionFormula = new System.Windows.Forms.Panel();
            this.lblPensionFormulaNote = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.pnlSaveOrReset = new System.Windows.Forms.Panel();
            this.lblMAYear = new System.Windows.Forms.Label();
            this.rtxtMinServeYear = new System.Windows.Forms.RichTextBox();
            this.lblMinServYear = new System.Windows.Forms.Label();
            this.lblMinAgeNote = new System.Windows.Forms.Label();
            this.lblSAYear = new System.Windows.Forms.Label();
            this.rtxtStandardAge = new System.Windows.Forms.RichTextBox();
            this.lblStandardAge = new System.Windows.Forms.Label();
            this.lblSandardAgeNote = new System.Windows.Forms.Label();
            this.lblBasseLineAgeService = new System.Windows.Forms.Label();
            this.lblRetireParameter = new System.Windows.Forms.Label();
            this.pnlRetireparameter = new System.Windows.Forms.Panel();
            this.lblSettingNote = new System.Windows.Forms.Label();
            this.lblSetting = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.cmbEmpRank = new System.Windows.Forms.ComboBox();
            this.lblEmployeeRank = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxtRankBonus = new System.Windows.Forms.RichTextBox();
            this.lblRankBonus = new System.Windows.Forms.Label();
            this.pnlPensionFormula.SuspendLayout();
            this.pnlSaveOrReset.SuspendLayout();
            this.pnlRetireparameter.SuspendLayout();
            this.SuspendLayout();
            // 
            // chbUtility
            // 
            this.chbUtility.AutoSize = true;
            this.chbUtility.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbUtility.Location = new System.Drawing.Point(950, 226);
            this.chbUtility.Name = "chbUtility";
            this.chbUtility.Size = new System.Drawing.Size(78, 24);
            this.chbUtility.TabIndex = 30;
            this.chbUtility.Text = "Utility";
            this.chbUtility.UseVisualStyleBackColor = true;
            // 
            // chbTransport
            // 
            this.chbTransport.AutoSize = true;
            this.chbTransport.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbTransport.Location = new System.Drawing.Point(646, 226);
            this.chbTransport.Name = "chbTransport";
            this.chbTransport.Size = new System.Drawing.Size(110, 24);
            this.chbTransport.TabIndex = 29;
            this.chbTransport.Text = "Transport";
            this.chbTransport.UseVisualStyleBackColor = true;
            // 
            // chbMedical
            // 
            this.chbMedical.AutoSize = true;
            this.chbMedical.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbMedical.Location = new System.Drawing.Point(323, 226);
            this.chbMedical.Name = "chbMedical";
            this.chbMedical.Size = new System.Drawing.Size(91, 24);
            this.chbMedical.TabIndex = 28;
            this.chbMedical.Text = "Medical";
            this.chbMedical.UseVisualStyleBackColor = true;
            // 
            // chbHouseRent
            // 
            this.chbHouseRent.AutoSize = true;
            this.chbHouseRent.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbHouseRent.Location = new System.Drawing.Point(23, 226);
            this.chbHouseRent.Name = "chbHouseRent";
            this.chbHouseRent.Size = new System.Drawing.Size(120, 24);
            this.chbHouseRent.TabIndex = 27;
            this.chbHouseRent.Text = "House Rent";
            this.chbHouseRent.UseVisualStyleBackColor = true;
            // 
            // lblDefaultAllowCheck
            // 
            this.lblDefaultAllowCheck.AutoSize = true;
            this.lblDefaultAllowCheck.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDefaultAllowCheck.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDefaultAllowCheck.Location = new System.Drawing.Point(19, 185);
            this.lblDefaultAllowCheck.Name = "lblDefaultAllowCheck";
            this.lblDefaultAllowCheck.Size = new System.Drawing.Size(370, 21);
            this.lblDefaultAllowCheck.TabIndex = 26;
            this.lblDefaultAllowCheck.Text = "Default Allowances included in Calculation";
            // 
            // lblFPPencentage
            // 
            this.lblFPPencentage.AutoSize = true;
            this.lblFPPencentage.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFPPencentage.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblFPPencentage.Location = new System.Drawing.Point(1015, 65);
            this.lblFPPencentage.Name = "lblFPPencentage";
            this.lblFPPencentage.Size = new System.Drawing.Size(27, 23);
            this.lblFPPencentage.TabIndex = 25;
            this.lblFPPencentage.Text = "%";
            // 
            // rtxtFullPension
            // 
            this.rtxtFullPension.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtFullPension.Location = new System.Drawing.Point(646, 55);
            this.rtxtFullPension.Name = "rtxtFullPension";
            this.rtxtFullPension.Size = new System.Drawing.Size(363, 33);
            this.rtxtFullPension.TabIndex = 24;
            this.rtxtFullPension.Text = "30";
            // 
            // lblFullPension
            // 
            this.lblFullPension.AutoSize = true;
            this.lblFullPension.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFullPension.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFullPension.Location = new System.Drawing.Point(642, 19);
            this.lblFullPension.Name = "lblFullPension";
            this.lblFullPension.Size = new System.Drawing.Size(191, 21);
            this.lblFullPension.TabIndex = 23;
            this.lblFullPension.Text = "Years for Full Pension";
            // 
            // lblMPPercentage
            // 
            this.lblMPPercentage.AutoSize = true;
            this.lblMPPercentage.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMPPercentage.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblMPPercentage.Location = new System.Drawing.Point(392, 136);
            this.lblMPPercentage.Name = "lblMPPercentage";
            this.lblMPPercentage.Size = new System.Drawing.Size(27, 23);
            this.lblMPPercentage.TabIndex = 21;
            this.lblMPPercentage.Text = "%";
            // 
            // rtxtMaxPercentage
            // 
            this.rtxtMaxPercentage.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtMaxPercentage.Location = new System.Drawing.Point(23, 126);
            this.rtxtMaxPercentage.Name = "rtxtMaxPercentage";
            this.rtxtMaxPercentage.Size = new System.Drawing.Size(363, 33);
            this.rtxtMaxPercentage.TabIndex = 17;
            this.rtxtMaxPercentage.Text = "70";
            // 
            // lblMaxPercentage
            // 
            this.lblMaxPercentage.AutoSize = true;
            this.lblMaxPercentage.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxPercentage.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMaxPercentage.Location = new System.Drawing.Point(19, 90);
            this.lblMaxPercentage.Name = "lblMaxPercentage";
            this.lblMaxPercentage.Size = new System.Drawing.Size(213, 21);
            this.lblMaxPercentage.TabIndex = 15;
            this.lblMaxPercentage.Text = "Max Pension Percentage";
            // 
            // lblPensionFormula
            // 
            this.lblPensionFormula.AutoSize = true;
            this.lblPensionFormula.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPensionFormula.Location = new System.Drawing.Point(17, 19);
            this.lblPensionFormula.Name = "lblPensionFormula";
            this.lblPensionFormula.Size = new System.Drawing.Size(279, 27);
            this.lblPensionFormula.TabIndex = 4;
            this.lblPensionFormula.Text = "Pension Formula Settings";
            // 
            // pnlPensionFormula
            // 
            this.pnlPensionFormula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlPensionFormula.Controls.Add(this.label1);
            this.pnlPensionFormula.Controls.Add(this.rtxtRankBonus);
            this.pnlPensionFormula.Controls.Add(this.lblRankBonus);
            this.pnlPensionFormula.Controls.Add(this.cmbEmpRank);
            this.pnlPensionFormula.Controls.Add(this.lblEmployeeRank);
            this.pnlPensionFormula.Controls.Add(this.chbUtility);
            this.pnlPensionFormula.Controls.Add(this.chbTransport);
            this.pnlPensionFormula.Controls.Add(this.chbMedical);
            this.pnlPensionFormula.Controls.Add(this.chbHouseRent);
            this.pnlPensionFormula.Controls.Add(this.lblDefaultAllowCheck);
            this.pnlPensionFormula.Controls.Add(this.lblFPPencentage);
            this.pnlPensionFormula.Controls.Add(this.rtxtFullPension);
            this.pnlPensionFormula.Controls.Add(this.lblFullPension);
            this.pnlPensionFormula.Controls.Add(this.lblMPPercentage);
            this.pnlPensionFormula.Controls.Add(this.rtxtMaxPercentage);
            this.pnlPensionFormula.Controls.Add(this.lblMaxPercentage);
            this.pnlPensionFormula.Controls.Add(this.lblPensionFormulaNote);
            this.pnlPensionFormula.Controls.Add(this.lblPensionFormula);
            this.pnlPensionFormula.Location = new System.Drawing.Point(46, 358);
            this.pnlPensionFormula.Name = "pnlPensionFormula";
            this.pnlPensionFormula.Size = new System.Drawing.Size(1098, 267);
            this.pnlPensionFormula.TabIndex = 33;
            // 
            // lblPensionFormulaNote
            // 
            this.lblPensionFormulaNote.AutoSize = true;
            this.lblPensionFormulaNote.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPensionFormulaNote.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblPensionFormulaNote.Location = new System.Drawing.Point(19, 46);
            this.lblPensionFormulaNote.Name = "lblPensionFormulaNote";
            this.lblPensionFormulaNote.Size = new System.Drawing.Size(298, 20);
            this.lblPensionFormulaNote.TabIndex = 12;
            this.lblPensionFormulaNote.Text = "Configure the calculation logic and caps.";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Yellow;
            this.btnLogout.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Location = new System.Drawing.Point(1026, 719);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(118, 34);
            this.btnLogout.TabIndex = 32;
            this.btnLogout.Text = "Log Out";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Goldenrod;
            this.btnReset.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(715, 13);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(118, 38);
            this.btnReset.TabIndex = 20;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Yellow;
            this.btnBack.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(26, 719);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(118, 34);
            this.btnBack.TabIndex = 31;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Goldenrod;
            this.btnSave.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(915, 13);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(155, 38);
            this.btnSave.TabIndex = 19;
            this.btnSave.Text = "Save Settings";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // pnlSaveOrReset
            // 
            this.pnlSaveOrReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlSaveOrReset.Controls.Add(this.btnReset);
            this.pnlSaveOrReset.Controls.Add(this.btnSave);
            this.pnlSaveOrReset.Location = new System.Drawing.Point(46, 631);
            this.pnlSaveOrReset.Name = "pnlSaveOrReset";
            this.pnlSaveOrReset.Size = new System.Drawing.Size(1098, 61);
            this.pnlSaveOrReset.TabIndex = 30;
            // 
            // lblMAYear
            // 
            this.lblMAYear.AutoSize = true;
            this.lblMAYear.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMAYear.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblMAYear.Location = new System.Drawing.Point(1015, 136);
            this.lblMAYear.Name = "lblMAYear";
            this.lblMAYear.Size = new System.Drawing.Size(55, 23);
            this.lblMAYear.TabIndex = 25;
            this.lblMAYear.Text = "Years";
            // 
            // rtxtMinServeYear
            // 
            this.rtxtMinServeYear.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtMinServeYear.Location = new System.Drawing.Point(646, 126);
            this.rtxtMinServeYear.Name = "rtxtMinServeYear";
            this.rtxtMinServeYear.Size = new System.Drawing.Size(363, 33);
            this.rtxtMinServeYear.TabIndex = 24;
            this.rtxtMinServeYear.Text = "10";
            // 
            // lblMinServYear
            // 
            this.lblMinServYear.AutoSize = true;
            this.lblMinServYear.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinServYear.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMinServYear.Location = new System.Drawing.Point(642, 90);
            this.lblMinServYear.Name = "lblMinServYear";
            this.lblMinServYear.Size = new System.Drawing.Size(205, 21);
            this.lblMinServYear.TabIndex = 23;
            this.lblMinServYear.Text = "Minimum Service Years";
            // 
            // lblMinAgeNote
            // 
            this.lblMinAgeNote.AutoSize = true;
            this.lblMinAgeNote.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMinAgeNote.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblMinAgeNote.Location = new System.Drawing.Point(642, 162);
            this.lblMinAgeNote.Name = "lblMinAgeNote";
            this.lblMinAgeNote.Size = new System.Drawing.Size(418, 20);
            this.lblMinAgeNote.TabIndex = 22;
            this.lblMinAgeNote.Text = "Minimum years requied to be eligible for partial pension.\r\n";
            // 
            // lblSAYear
            // 
            this.lblSAYear.AutoSize = true;
            this.lblSAYear.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSAYear.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblSAYear.Location = new System.Drawing.Point(392, 136);
            this.lblSAYear.Name = "lblSAYear";
            this.lblSAYear.Size = new System.Drawing.Size(55, 23);
            this.lblSAYear.TabIndex = 21;
            this.lblSAYear.Text = "Years";
            // 
            // rtxtStandardAge
            // 
            this.rtxtStandardAge.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtStandardAge.Location = new System.Drawing.Point(23, 126);
            this.rtxtStandardAge.Name = "rtxtStandardAge";
            this.rtxtStandardAge.Size = new System.Drawing.Size(363, 33);
            this.rtxtStandardAge.TabIndex = 17;
            this.rtxtStandardAge.Text = "60";
            // 
            // lblStandardAge
            // 
            this.lblStandardAge.AutoSize = true;
            this.lblStandardAge.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStandardAge.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblStandardAge.Location = new System.Drawing.Point(19, 90);
            this.lblStandardAge.Name = "lblStandardAge";
            this.lblStandardAge.Size = new System.Drawing.Size(223, 21);
            this.lblStandardAge.TabIndex = 15;
            this.lblStandardAge.Text = "Standard Retirement Age\r\n";
            // 
            // lblSandardAgeNote
            // 
            this.lblSandardAgeNote.AutoSize = true;
            this.lblSandardAgeNote.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSandardAgeNote.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSandardAgeNote.Location = new System.Drawing.Point(19, 162);
            this.lblSandardAgeNote.Name = "lblSandardAgeNote";
            this.lblSandardAgeNote.Size = new System.Drawing.Size(424, 20);
            this.lblSandardAgeNote.TabIndex = 13;
            this.lblSandardAgeNote.Text = "The mandatory age for retirement across all departments.\r\n";
            // 
            // lblBasseLineAgeService
            // 
            this.lblBasseLineAgeService.AutoSize = true;
            this.lblBasseLineAgeService.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasseLineAgeService.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblBasseLineAgeService.Location = new System.Drawing.Point(19, 46);
            this.lblBasseLineAgeService.Name = "lblBasseLineAgeService";
            this.lblBasseLineAgeService.Size = new System.Drawing.Size(363, 20);
            this.lblBasseLineAgeService.TabIndex = 12;
            this.lblBasseLineAgeService.Text = "Define the baseline age and service requirements.\r\n";
            // 
            // lblRetireParameter
            // 
            this.lblRetireParameter.AutoSize = true;
            this.lblRetireParameter.Font = new System.Drawing.Font("Cambria", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRetireParameter.Location = new System.Drawing.Point(17, 19);
            this.lblRetireParameter.Name = "lblRetireParameter";
            this.lblRetireParameter.Size = new System.Drawing.Size(258, 27);
            this.lblRetireParameter.TabIndex = 4;
            this.lblRetireParameter.Text = "Retirement Parameters";
            // 
            // pnlRetireparameter
            // 
            this.pnlRetireparameter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnlRetireparameter.Controls.Add(this.lblMAYear);
            this.pnlRetireparameter.Controls.Add(this.rtxtMinServeYear);
            this.pnlRetireparameter.Controls.Add(this.lblMinServYear);
            this.pnlRetireparameter.Controls.Add(this.lblMinAgeNote);
            this.pnlRetireparameter.Controls.Add(this.lblSAYear);
            this.pnlRetireparameter.Controls.Add(this.rtxtStandardAge);
            this.pnlRetireparameter.Controls.Add(this.lblStandardAge);
            this.pnlRetireparameter.Controls.Add(this.lblSandardAgeNote);
            this.pnlRetireparameter.Controls.Add(this.lblBasseLineAgeService);
            this.pnlRetireparameter.Controls.Add(this.lblRetireParameter);
            this.pnlRetireparameter.Location = new System.Drawing.Point(46, 107);
            this.pnlRetireparameter.Name = "pnlRetireparameter";
            this.pnlRetireparameter.Size = new System.Drawing.Size(1098, 236);
            this.pnlRetireparameter.TabIndex = 29;
            // 
            // lblSettingNote
            // 
            this.lblSettingNote.AutoSize = true;
            this.lblSettingNote.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSettingNote.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblSettingNote.Location = new System.Drawing.Point(42, 57);
            this.lblSettingNote.Name = "lblSettingNote";
            this.lblSettingNote.Size = new System.Drawing.Size(547, 20);
            this.lblSettingNote.TabIndex = 28;
            this.lblSettingNote.Text = "Manage global parameters for pension calculations and retirement criteria.";
            // 
            // lblSetting
            // 
            this.lblSetting.AutoSize = true;
            this.lblSetting.Font = new System.Drawing.Font("Cambria", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetting.Location = new System.Drawing.Point(40, 24);
            this.lblSetting.Name = "lblSetting";
            this.lblSetting.Size = new System.Drawing.Size(291, 33);
            this.lblSetting.TabIndex = 27;
            this.lblSetting.Text = "System Configuration";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lblRole.Location = new System.Drawing.Point(483, 725);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(48, 21);
            this.lblRole.TabIndex = 42;
            this.lblRole.Text = "Role";
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
            this.cmbEmpRank.Location = new System.Drawing.Point(656, 154);
            this.cmbEmpRank.Name = "cmbEmpRank";
            this.cmbEmpRank.Size = new System.Drawing.Size(166, 24);
            this.cmbEmpRank.TabIndex = 32;
            // 
            // lblEmployeeRank
            // 
            this.lblEmployeeRank.AutoSize = true;
            this.lblEmployeeRank.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployeeRank.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblEmployeeRank.Location = new System.Drawing.Point(652, 126);
            this.lblEmployeeRank.Name = "lblEmployeeRank";
            this.lblEmployeeRank.Size = new System.Drawing.Size(122, 20);
            this.lblEmployeeRank.TabIndex = 31;
            this.lblEmployeeRank.Text = "Employee Rank";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.label1.Location = new System.Drawing.Point(1015, 151);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 23);
            this.label1.TabIndex = 35;
            this.label1.Text = "%";
            // 
            // rtxtRankBonus
            // 
            this.rtxtRankBonus.Font = new System.Drawing.Font("Cambria", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtRankBonus.Location = new System.Drawing.Point(846, 151);
            this.rtxtRankBonus.Name = "rtxtRankBonus";
            this.rtxtRankBonus.Size = new System.Drawing.Size(163, 33);
            this.rtxtRankBonus.TabIndex = 34;
            this.rtxtRankBonus.Text = "00";
            // 
            // lblRankBonus
            // 
            this.lblRankBonus.AutoSize = true;
            this.lblRankBonus.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRankBonus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRankBonus.Location = new System.Drawing.Point(842, 115);
            this.lblRankBonus.Name = "lblRankBonus";
            this.lblRankBonus.Size = new System.Drawing.Size(110, 21);
            this.lblRankBonus.TabIndex = 33;
            this.lblRankBonus.Text = "Rank Bonus";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1171, 776);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.pnlPensionFormula);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pnlSaveOrReset);
            this.Controls.Add(this.pnlRetireparameter);
            this.Controls.Add(this.lblSettingNote);
            this.Controls.Add(this.lblSetting);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.pnlPensionFormula.ResumeLayout(false);
            this.pnlPensionFormula.PerformLayout();
            this.pnlSaveOrReset.ResumeLayout(false);
            this.pnlRetireparameter.ResumeLayout(false);
            this.pnlRetireparameter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chbUtility;
        private System.Windows.Forms.CheckBox chbTransport;
        private System.Windows.Forms.CheckBox chbMedical;
        private System.Windows.Forms.CheckBox chbHouseRent;
        private System.Windows.Forms.Label lblDefaultAllowCheck;
        private System.Windows.Forms.Label lblFPPencentage;
        private System.Windows.Forms.RichTextBox rtxtFullPension;
        private System.Windows.Forms.Label lblFullPension;
        private System.Windows.Forms.Label lblMPPercentage;
        private System.Windows.Forms.RichTextBox rtxtMaxPercentage;
        private System.Windows.Forms.Label lblMaxPercentage;
        private System.Windows.Forms.Label lblPensionFormula;
        private System.Windows.Forms.Panel pnlPensionFormula;
        private System.Windows.Forms.Label lblPensionFormulaNote;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel pnlSaveOrReset;
        private System.Windows.Forms.Label lblMAYear;
        private System.Windows.Forms.RichTextBox rtxtMinServeYear;
        private System.Windows.Forms.Label lblMinServYear;
        private System.Windows.Forms.Label lblMinAgeNote;
        private System.Windows.Forms.Label lblSAYear;
        private System.Windows.Forms.RichTextBox rtxtStandardAge;
        private System.Windows.Forms.Label lblStandardAge;
        private System.Windows.Forms.Label lblSandardAgeNote;
        private System.Windows.Forms.Label lblBasseLineAgeService;
        private System.Windows.Forms.Label lblRetireParameter;
        private System.Windows.Forms.Panel pnlRetireparameter;
        private System.Windows.Forms.Label lblSettingNote;
        private System.Windows.Forms.Label lblSetting;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbEmpRank;
        private System.Windows.Forms.Label lblEmployeeRank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxtRankBonus;
        private System.Windows.Forms.Label lblRankBonus;
    }
}
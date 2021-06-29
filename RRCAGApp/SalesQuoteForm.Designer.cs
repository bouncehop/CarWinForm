namespace RRCAGApp
{
    partial class SalesQuoteForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTradeInValue = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkNavigation = new System.Windows.Forms.CheckBox();
            this.chkLeather = new System.Windows.Forms.CheckBox();
            this.chkStereo = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radCustom = new System.Windows.Forms.RadioButton();
            this.radPearlized = new System.Windows.Forms.RadioButton();
            this.radStandard = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblAmountDue = new System.Windows.Forms.Label();
            this.lblTradeInAmount = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.lblSalesTaxAmount = new System.Windows.Forms.Label();
            this.lblSubtotalAmount = new System.Windows.Forms.Label();
            this.lblOptionsAmount = new System.Windows.Forms.Label();
            this.lblVehicleSalePrice = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblSalesTaxRate = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblMonthlyPayment = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.nudAnnualInterestRate = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.nudYears = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.btnCalculateQuote = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.msFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.msView = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuVehicleInformation = new System.Windows.Forms.ToolStripMenuItem();
            this.cboVehicle = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnnualInterestRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehicle:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Trade-in Value:";
            // 
            // txtTradeInValue
            // 
            this.txtTradeInValue.Location = new System.Drawing.Point(173, 80);
            this.txtTradeInValue.Name = "txtTradeInValue";
            this.txtTradeInValue.Size = new System.Drawing.Size(150, 22);
            this.txtTradeInValue.TabIndex = 2;
            this.txtTradeInValue.Text = "0";
            this.txtTradeInValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkNavigation);
            this.groupBox1.Controls.Add(this.chkLeather);
            this.groupBox1.Controls.Add(this.chkStereo);
            this.groupBox1.Location = new System.Drawing.Point(34, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 180);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Accessories";
            // 
            // chkNavigation
            // 
            this.chkNavigation.AutoSize = true;
            this.chkNavigation.Location = new System.Drawing.Point(26, 129);
            this.chkNavigation.Name = "chkNavigation";
            this.chkNavigation.Size = new System.Drawing.Size(162, 21);
            this.chkNavigation.TabIndex = 2;
            this.chkNavigation.Text = "Computer Navigation";
            this.chkNavigation.UseVisualStyleBackColor = true;
            // 
            // chkLeather
            // 
            this.chkLeather.AutoSize = true;
            this.chkLeather.Location = new System.Drawing.Point(26, 86);
            this.chkLeather.Name = "chkLeather";
            this.chkLeather.Size = new System.Drawing.Size(127, 21);
            this.chkLeather.TabIndex = 1;
            this.chkLeather.Text = "Leather Interior";
            this.chkLeather.UseVisualStyleBackColor = true;
            // 
            // chkStereo
            // 
            this.chkStereo.AutoSize = true;
            this.chkStereo.Location = new System.Drawing.Point(26, 43);
            this.chkStereo.Name = "chkStereo";
            this.chkStereo.Size = new System.Drawing.Size(122, 21);
            this.chkStereo.TabIndex = 0;
            this.chkStereo.Text = "Stereo System";
            this.chkStereo.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radCustom);
            this.groupBox2.Controls.Add(this.radPearlized);
            this.groupBox2.Controls.Add(this.radStandard);
            this.groupBox2.Location = new System.Drawing.Point(34, 335);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 180);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Exterior Finish";
            // 
            // radCustom
            // 
            this.radCustom.AutoSize = true;
            this.radCustom.Location = new System.Drawing.Point(26, 125);
            this.radCustom.Name = "radCustom";
            this.radCustom.Size = new System.Drawing.Size(161, 21);
            this.radCustom.TabIndex = 2;
            this.radCustom.Text = "Customized Detailing";
            this.radCustom.UseVisualStyleBackColor = true;
            // 
            // radPearlized
            // 
            this.radPearlized.AutoSize = true;
            this.radPearlized.Location = new System.Drawing.Point(26, 83);
            this.radPearlized.Name = "radPearlized";
            this.radPearlized.Size = new System.Drawing.Size(88, 21);
            this.radPearlized.TabIndex = 1;
            this.radPearlized.Text = "Pearlized";
            this.radPearlized.UseVisualStyleBackColor = true;
            // 
            // radStandard
            // 
            this.radStandard.AutoSize = true;
            this.radStandard.Checked = true;
            this.radStandard.Location = new System.Drawing.Point(26, 41);
            this.radStandard.Name = "radStandard";
            this.radStandard.Size = new System.Drawing.Size(87, 21);
            this.radStandard.TabIndex = 0;
            this.radStandard.TabStop = true;
            this.radStandard.Text = "Standard";
            this.radStandard.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblAmountDue);
            this.groupBox3.Controls.Add(this.lblTradeInAmount);
            this.groupBox3.Controls.Add(this.lblTotalAmount);
            this.groupBox3.Controls.Add(this.lblSalesTaxAmount);
            this.groupBox3.Controls.Add(this.lblSubtotalAmount);
            this.groupBox3.Controls.Add(this.lblOptionsAmount);
            this.groupBox3.Controls.Add(this.lblVehicleSalePrice);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.lblSalesTaxRate);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(374, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(390, 343);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Summary";
            // 
            // lblAmountDue
            // 
            this.lblAmountDue.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblAmountDue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAmountDue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblAmountDue.Location = new System.Drawing.Point(190, 282);
            this.lblAmountDue.Name = "lblAmountDue";
            this.lblAmountDue.Size = new System.Drawing.Size(150, 23);
            this.lblAmountDue.TabIndex = 13;
            this.lblAmountDue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTradeInAmount
            // 
            this.lblTradeInAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTradeInAmount.Location = new System.Drawing.Point(190, 242);
            this.lblTradeInAmount.Name = "lblTradeInAmount";
            this.lblTradeInAmount.Size = new System.Drawing.Size(150, 23);
            this.lblTradeInAmount.TabIndex = 12;
            this.lblTradeInAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTotalAmount.Location = new System.Drawing.Point(190, 202);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(150, 23);
            this.lblTotalAmount.TabIndex = 11;
            this.lblTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSalesTaxAmount
            // 
            this.lblSalesTaxAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSalesTaxAmount.Location = new System.Drawing.Point(190, 162);
            this.lblSalesTaxAmount.Name = "lblSalesTaxAmount";
            this.lblSalesTaxAmount.Size = new System.Drawing.Size(150, 23);
            this.lblSalesTaxAmount.TabIndex = 10;
            this.lblSalesTaxAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSubtotalAmount
            // 
            this.lblSubtotalAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSubtotalAmount.Location = new System.Drawing.Point(190, 122);
            this.lblSubtotalAmount.Name = "lblSubtotalAmount";
            this.lblSubtotalAmount.Size = new System.Drawing.Size(150, 23);
            this.lblSubtotalAmount.TabIndex = 9;
            this.lblSubtotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOptionsAmount
            // 
            this.lblOptionsAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOptionsAmount.Location = new System.Drawing.Point(190, 82);
            this.lblOptionsAmount.Name = "lblOptionsAmount";
            this.lblOptionsAmount.Size = new System.Drawing.Size(150, 23);
            this.lblOptionsAmount.TabIndex = 8;
            this.lblOptionsAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblVehicleSalePrice
            // 
            this.lblVehicleSalePrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVehicleSalePrice.Location = new System.Drawing.Point(190, 42);
            this.lblVehicleSalePrice.Name = "lblVehicleSalePrice";
            this.lblVehicleSalePrice.Size = new System.Drawing.Size(150, 23);
            this.lblVehicleSalePrice.TabIndex = 7;
            this.lblVehicleSalePrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(94, 285);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 17);
            this.label9.TabIndex = 6;
            this.label9.Text = "Amount Due:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(118, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 17);
            this.label8.TabIndex = 5;
            this.label8.Text = "Trade-in:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(140, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Total:";
            // 
            // lblSalesTaxRate
            // 
            this.lblSalesTaxRate.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSalesTaxRate.Location = new System.Drawing.Point(68, 165);
            this.lblSalesTaxRate.Name = "lblSalesTaxRate";
            this.lblSalesTaxRate.Size = new System.Drawing.Size(116, 17);
            this.lblSalesTaxRate.TabIndex = 3;
            this.lblSalesTaxRate.Text = "Sales Tax (13%):";
            this.lblSalesTaxRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(120, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Subtotal:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(123, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Options:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Vehicle\'s Sale Price:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblMonthlyPayment);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.nudAnnualInterestRate);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.nudYears);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(374, 390);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(390, 125);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Finance";
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.lblMonthlyPayment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMonthlyPayment.Location = new System.Drawing.Point(249, 72);
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(115, 23);
            this.lblMonthlyPayment.TabIndex = 5;
            this.lblMonthlyPayment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(248, 43);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 17);
            this.label12.TabIndex = 4;
            this.label12.Text = "Monthly Payment";
            // 
            // nudAnnualInterestRate
            // 
            this.nudAnnualInterestRate.DecimalPlaces = 2;
            this.nudAnnualInterestRate.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.nudAnnualInterestRate.Location = new System.Drawing.Point(136, 72);
            this.nudAnnualInterestRate.Maximum = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.nudAnnualInterestRate.Name = "nudAnnualInterestRate";
            this.nudAnnualInterestRate.Size = new System.Drawing.Size(86, 22);
            this.nudAnnualInterestRate.TabIndex = 3;
            this.nudAnnualInterestRate.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(133, 26);
            this.label11.MaximumSize = new System.Drawing.Size(100, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 34);
            this.label11.TabIndex = 2;
            this.label11.Text = "Annual Interest Rate";
            // 
            // nudYears
            // 
            this.nudYears.Location = new System.Drawing.Point(24, 72);
            this.nudYears.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudYears.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudYears.Name = "nudYears";
            this.nudYears.Size = new System.Drawing.Size(86, 22);
            this.nudYears.TabIndex = 1;
            this.nudYears.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "No. of Years";
            // 
            // btnCalculateQuote
            // 
            this.btnCalculateQuote.Location = new System.Drawing.Point(629, 536);
            this.btnCalculateQuote.Name = "btnCalculateQuote";
            this.btnCalculateQuote.Size = new System.Drawing.Size(135, 33);
            this.btnCalculateQuote.TabIndex = 9;
            this.btnCalculateQuote.Text = "Calculate Quote";
            this.btnCalculateQuote.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(34, 536);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(95, 33);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msFile,
            this.msView});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(797, 28);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // msFile
            // 
            this.msFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuClose});
            this.msFile.Name = "msFile";
            this.msFile.Size = new System.Drawing.Size(46, 24);
            this.msFile.Text = "File";
            // 
            // mnuClose
            // 
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.mnuClose.Size = new System.Drawing.Size(184, 26);
            this.mnuClose.Text = "&Close";
            // 
            // msView
            // 
            this.msView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuVehicleInformation});
            this.msView.Name = "msView";
            this.msView.Size = new System.Drawing.Size(55, 24);
            this.msView.Text = "View";
            // 
            // mnuVehicleInformation
            // 
            this.mnuVehicleInformation.Enabled = false;
            this.mnuVehicleInformation.Name = "mnuVehicleInformation";
            this.mnuVehicleInformation.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.I)));
            this.mnuVehicleInformation.Size = new System.Drawing.Size(307, 26);
            this.mnuVehicleInformation.Text = "Vehicle &Information";
            // 
            // cboVehicle
            // 
            this.cboVehicle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVehicle.FormattingEnabled = true;
            this.cboVehicle.Location = new System.Drawing.Point(173, 42);
            this.cboVehicle.Name = "cboVehicle";
            this.cboVehicle.Size = new System.Drawing.Size(150, 24);
            this.cboVehicle.TabIndex = 1;
            // 
            // SalesQuoteForm
            // 
            this.AcceptButton = this.btnCalculateQuote;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 607);
            this.Controls.Add(this.cboVehicle);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCalculateQuote);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtTradeInValue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "SalesQuoteForm";
            this.Text = "Vehicle Sales Quote";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnnualInterestRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTradeInValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkNavigation;
        private System.Windows.Forms.CheckBox chkLeather;
        private System.Windows.Forms.CheckBox chkStereo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radCustom;
        private System.Windows.Forms.RadioButton radPearlized;
        private System.Windows.Forms.RadioButton radStandard;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblAmountDue;
        private System.Windows.Forms.Label lblTradeInAmount;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label lblSalesTaxAmount;
        private System.Windows.Forms.Label lblSubtotalAmount;
        private System.Windows.Forms.Label lblOptionsAmount;
        private System.Windows.Forms.Label lblVehicleSalePrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblSalesTaxRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown nudYears;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblMonthlyPayment;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown nudAnnualInterestRate;
        private System.Windows.Forms.Button btnCalculateQuote;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem msFile;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ToolStripMenuItem msView;
        private System.Windows.Forms.ToolStripMenuItem mnuVehicleInformation;
        private System.Windows.Forms.ComboBox cboVehicle;
    }
}